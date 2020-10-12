
namespace iTin.Core.ComponentModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Exceptions;

    /// <summary>
    /// Class which defines a time period.
    /// </summary>
    public class Period : IEquatable<Period>, IComparable<Period>, ICloneable
    {
        #region private static readonly members
        private static readonly TimeSpan StartTimeOfDay = new TimeSpan(0, 0, 0);
        private static readonly TimeSpan EndTimeOfDay = new TimeSpan(23, 59, 59);
        #endregion

        #region public constructor/s

        #region [public] Period(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Period"/> class.
        /// </summary>
        public Period()
        {
        }
        #endregion

        #region [public] Period(Datetime, DateTime): Initializes a new instance of the class.
        /// <summary>
        /// Initializes a new instance of the <see cref="Period"/> class.
        /// </summary>
        /// <param name="startDateTime">The start date of period.</param>
        /// <param name="endDateTime">The end date of period.</param>
        /// <exception cref="InvalidPeriodException">End datetime must be greater than start datetime.</exception>
        public Period(DateTime startDateTime, DateTime endDateTime)
        {
            if (startDateTime > endDateTime)
            {
                throw new InvalidPeriodException("ENDDATE_MUSTBE_GREATHER_STARTDATE");
            }

            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (TimeSpan) Duration: Gets the duration.
        /// <summary>
        /// Gets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public TimeSpan Duration => EndDateTime - StartDateTime;
        #endregion

        #region [public] (DateTime) EndDateTime: Gets the duration.Gets the end date time.
        /// <summary>
        /// Gets the end date time.
        /// </summary>
        /// <value>
        /// The end date time.
        /// </value>
        public DateTime EndDateTime { get; private set; }
        #endregion

        #region [public] (DateTime) StartDateTime: Gets the start date time.
        /// <summary>
        /// Gets the start date time.
        /// </summary>
        /// <value>
        /// The start date time.
        /// </value>
        public DateTime StartDateTime { get; private set; }
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (EpochPeriod) CreateEpochPeriod(Period): Returns a new epoch period from a period instance
        /// <summary>
        /// Returns a new epoch period from a period instance.
        /// </summary>
        /// <param name="period">Target period.</param>
        /// <returns>
        /// Returns a new <see cref="EpochPeriod"/> from specified <see cref="Period"/>.
        /// </returns>
        public static EpochPeriod CreateEpochPeriod(Period period) => new EpochPeriod(period);
        #endregion

        #region [public] {static} (DateTime) CurrentDate: Gets the current date
        /// <summary>
        /// Gets the current date.
        /// </summary>
        /// <value>
        /// The current date.
        /// </value>
        public static DateTime CurrentDate => DateTime.Now;
        #endregion

        #region [public] {static} (TimeSpan) CurrentTime: Gets the current time
        /// <summary>
        /// Gets the current time.
        /// </summary>
        /// <value>
        /// The current time.
        /// </value>
        public static TimeSpan CurrentTime => CurrentDate.TimeOfDay;
        #endregion

        #region [public] {static} (IEnumerable<Period>) NaturalPeriodsBetweenTwoMoments(DateTime, DateTime): Returns a list of natural periods that represents time line between two moments
        /// <summary>
        /// <para>Returns a list of natural <see cref="Period"/> that represents time line between two moments.</para>
        /// </summary>
        /// <param name="momentStart">The moment start.</param>
        /// <param name="momentEnd">The moment end.</param>
        /// <returns>
        /// A <see cref="IEnumerable{Period}"/> that represents a sequential of natural periods for this two moments.
        /// </returns>
        public static IEnumerable<Period> NaturalPeriodsBetweenTwoMoments(DateTime momentStart, DateTime momentEnd)
        {
            List<Period> periods = new List<Period>();
            Period momentPeriod = new Period(momentStart, momentEnd);
            int days = momentPeriod.Duration.Days;

            Period firstPeriod = days > 0
                                    ? new Period(
                                        momentStart,
                                        new DateTime(
                                        momentStart.Year,
                                        momentStart.Month,
                                        momentStart.Day,
                                        EndTimeOfDay.Hours,
                                        EndTimeOfDay.Minutes,
                                        EndTimeOfDay.Seconds))
                                    : momentPeriod;

            Period lastPeriod = days > 0
                                    ? new Period(
                                        new DateTime(
                                        momentEnd.Year,
                                        momentEnd.Month,
                                        momentEnd.Day,
                                        StartTimeOfDay.Hours,
                                        StartTimeOfDay.Minutes,
                                        StartTimeOfDay.Seconds),
                                        momentEnd)
                                    : momentPeriod;

            if (days > 0)
            {
                periods.Add(firstPeriod);

                for (int i = 1; i <= days - 1; i++)
                {
                    DateTime current = momentStart.AddDays(i);
                    Period period =
                        new Period(
                            new DateTime(
                                current.Year,
                                current.Month,
                                current.Day,
                                StartTimeOfDay.Hours,
                                StartTimeOfDay.Minutes,
                                StartTimeOfDay.Seconds),
                            new DateTime(
                                current.Year,
                                current.Month,
                                current.Day,
                                EndTimeOfDay.Hours,
                                EndTimeOfDay.Minutes,
                                EndTimeOfDay.Seconds));
                    periods.Add(period);
                }

                periods.Add(lastPeriod);
            }
            else
            {
                periods.Add(momentPeriod);
            }

            return periods.ToArray();
        }
        #endregion

        #region [public] {static} (IEnumerable<Period>) SequentialPeriodsFromMoments(IEnumerable<DateTime>): Returns a list of periods that represents time line for specified moment list
        /// <summary>
        /// <para>Returns a list of <see cref="Period"/> that represents time line for specified moment list.</para>
        /// <para>If <paramref name="moments" /> parameter is <b>null</b> always returns an empty list.</para>
        /// </summary>
        /// <param name="moments">Target moments.</param>
        /// <returns>
        /// A <see cref="IEnumerable{Period}"/> that represents a sequential periods for this moments list.
        /// </returns>
        public static IEnumerable<Period> SequentialPeriodsFromMoments(IEnumerable<DateTime> moments)
        {
            List<Period> periods = new List<Period>();

            if (moments == null)
            {
                return periods;
            }

            DateTime[] momentArray = moments.ToArray();
            int momentItems = momentArray.Count();
            for (int i = 0; i < momentItems - 1; i++)
            {
                periods.Add(new Period(momentArray[i], momentArray[i + 1]));
            }

            return periods;
        }
        #endregion

        #region [public] {static} (Period) FromMoment(DateTime): Returns a new period for current datetime for single moment
        /// <summary>
        /// Returns a new <see cref="Period"/> for current date for single moment.
        /// </summary>
        /// <param name="datetime">Target datetime.</param>
        /// <returns>
        /// A <see cref="Period"/> for current date between the specified times.
        /// </returns>
        public static Period FromMoment(DateTime datetime) => FromMoments(datetime, datetime.TimeOfDay, datetime.TimeOfDay);
        #endregion

        #region [public] {static} (Period) FromMoment(TimeSpan): Returns a new period for current date for single moment
        /// <summary>
        /// Returns a new <see cref="Period"/> for current date for single moment.
        /// </summary>
        /// <param name="time">moment time.</param>
        /// <returns>
        /// A <see cref="Period"/> for current date between the specified times.
        /// </returns>
        public static Period FromMoment(TimeSpan time) => FromMoments(CurrentDate, time, time);
        #endregion

        #region [public] {static} (Period) FromMoments(TimeSpan, TimeSpan): Returns a new period for current date between the specified times
        /// <summary>
        /// Returns a new <see cref="Period"/> for current date between the specified times.
        /// </summary>
        /// <param name="fromTime">Start time.</param>
        /// <param name="toTime">End time.</param>
        /// <returns>
        /// A <see cref="Period"/> for current date between the specified times.
        /// </returns>
        public static Period FromMoments(TimeSpan fromTime, TimeSpan toTime) => FromMoments(CurrentDate, fromTime, toTime);
        #endregion

        #region [public] {static} (Period) FromMoments(DateTime, TimeSpan, TimeSpan): Returns a new period for specified date between the specified times
        /// <summary>
        /// Returns a new <see cref="Period"/> for specified date between the specified times.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="fromTime">From time.</param>
        /// <param name="toTime">To time.</param>
        /// <returns>
        /// A <see cref="Period"/> for specified date between the specified times.
        /// </returns>
        public static Period FromMoments(DateTime date, TimeSpan fromTime, TimeSpan toTime)
        {
            DateTime from = new DateTime(
                date.Year,
                date.Month,
                date.Day,
                fromTime.Hours,
                fromTime.Minutes,
                fromTime.Seconds);

            DateTime to = new DateTime(
                date.Year,
                date.Month,
                date.Day,
                toTime.Hours,
                toTime.Minutes,
                toTime.Seconds);

            return new Period(from, to);
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (Period) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        public Period Clone() => (Period)MemberwiseClone();
        #endregion

        #region [public] (int) CompareTo(Period): Compares the current object with another object of the same type
        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.
        /// Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
        /// </returns>
        public int CompareTo(Period other) => Duration.CompareTo(other.Duration);
        #endregion

        #region [public] (bool) Equals(Period): Indicates whether the current object is equal to another object of the same type
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <b>true</b> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(Period other) => other != null && other.Equals((object)this);
        #endregion

        #region [public] (bool) Overlaps(Period): Indicates whether both periods are overlapses
        /// <summary>
        /// Indicates whether both periods are overlapses.
        /// </summary>
        /// <param name="anotherPeriod">Another period.</param>
        /// <returns>
        /// <b>true</b> if is overlap; Otherwise, <b>false</b>.
        /// </returns>
        public bool Overlaps(Period anotherPeriod) => StartDateTime < anotherPeriod.EndDateTime && anotherPeriod.StartDateTime < EndDateTime;
        #endregion

        #region [public] (EpochPeriod) ToEpochPeriod(): Returns a new Period from this epoch period
        /// <summary>
        /// Returns a new <see cref="EpochPeriod"/> from this <see cref="Period"/>.
        /// </summary>
        /// <returns>
        /// Returns a new <see cref="EpochPeriod"/> from current instance.
        /// </returns>
        public EpochPeriod ToEpochPeriod() => CreateEpochPeriod(this);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns a value that represents the hash code for this class
        /// <summary>
        /// Returns a value that represents the hash code for this class.
        /// </summary>
        /// <returns>
        /// Hash code for this class.
        /// </returns>
        public override int GetHashCode() => ToString().GetHashCode();
        #endregion

        #region [public] {override} (bool) Equals(object): Returns a value that indicates whether this class is equal to another
        /// <summary>
        /// Returns a value that indicates whether this class is equal to another
        /// </summary>
        /// <param name="obj">Class with which to compare.</param>
        /// <returns>
        /// Results equality comparison.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Period))
            {
                return false;
            }

            var other = (Period)obj;

            return other.StartDateTime.Equals(StartDateTime) && other.EndDateTime.Equals(EndDateTime);
        }
        #endregion

        #region [public] {override} (string) ToString(): Indicates whether the current object is equal to another object of the same type
        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString() => $"Period = {{{StartDateTime} - {EndDateTime}}}, Duration = {Duration}";
        #endregion

        #endregion

        #region private methods

        #region [private] (object) ICloneable.Clone(): Creates a new object that is a copy of the current instance.
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone() => Clone();
        #endregion

        #endregion
    }
}

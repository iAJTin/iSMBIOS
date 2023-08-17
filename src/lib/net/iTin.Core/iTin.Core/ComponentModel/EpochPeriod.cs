
using System;
using System.Diagnostics;

using iTin.Core.Helpers;

namespace iTin.Core.ComponentModel;

/// <summary>
/// Class that defines a time period expressed in <b>Unix</b> time. The <b>Unix</b> epoch gets the elapsed time from 1970 to today. The time is measured in seconds from January 1, 1970, at zero hours. 
/// </summary>
public class EpochPeriod : IEquatable<EpochPeriod>, IComparable<EpochPeriod>, ICloneable
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="EpochPeriod"/> class.
    /// </summary>
    public EpochPeriod()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> class from a <see cref="T:iTin.Core.ComponentModel.Period"/>
    /// </summary>
    /// <param name="period">Target period.</param>
    public EpochPeriod(Period period) : this(period.StartDateTime, period.EndDateTime)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EpochPeriod"/> class.
    /// </summary>
    /// <param name="startDateTime">The start date of period.</param>
    /// <param name="endDateTime">The end date of period.</param>
    public EpochPeriod(DateTime startDateTime, DateTime endDateTime)
    {
        if (startDateTime > endDateTime)
        {
            SentinelHelper.ArgumentGreaterThan(nameof(endDateTime), startDateTime, endDateTime); //throw new InvalidPeriodException("ENDDATE_MUSTBE_GREATHER_STARTDATE");
        }

        EndDateTime = endDateTime;
        StartDateTime = startDateTime;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EpochPeriod"/> class.
    /// </summary>
    /// <param name="startDateTime">The start date of period.</param>
    /// <param name="offset">Time offset.</param>
    public EpochPeriod(DateTime startDateTime, TimeSpan offset)
    {
        StartDateTime = startDateTime;
        EndDateTime = startDateTime.AddTicks(offset.Ticks);
    }

    #endregion

    #region interfaces

    #region ICloneable

    /// <summary>
    /// Creates a new object that is a copy of the current instance.
    /// </summary>
    /// <returns>
    /// A new object that is a copy of this instance.
    /// </returns>
    object ICloneable.Clone() => Clone();

    #endregion

    #region IComparable

    /// <summary>
    /// Compares the current object with another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other" /> parameter.Zero This object is equal to <paramref name="other" />. Greater than zero This object is greater than <paramref name="other" />.
    /// </returns>
    public int CompareTo(EpochPeriod other) => Duration.CompareTo(other.Duration);

    #endregion

    #region IEquatable

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// <b>true</b> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <b>false</b>.
    /// </returns>
    public bool Equals(EpochPeriod other) => other != null && other.Equals((object)this);

    #endregion

    #endregion

    #region public static methods

    /// <summary>
    /// Gets the current date.
    /// </summary>
    /// <value>
    /// The current date.
    /// </value>
    public static DateTime CurrentDate => DateTime.Now;

    /// <summary>
    /// Gets the current time.
    /// </summary>
    /// <value>
    /// The current time.
    /// </value>
    public static TimeSpan CurrentTime => CurrentDate.TimeOfDay;

    /// <summary>
    /// Returns a new <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> for current date for single moment.
    /// </summary>
    /// <param name="datetime">Target datetime.</param>
    /// <returns>
    /// A <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> for current date between the specified times.
    /// </returns>
    public static EpochPeriod FromMoment(DateTime datetime) => FromMoments(datetime, datetime.TimeOfDay, datetime.TimeOfDay);

    /// <summary>
    /// Returns a new <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> for current date for single moment.
    /// </summary>
    /// <param name="time">moment time.</param>
    /// <returns>
    /// A <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> for current date between the specified times.
    /// </returns>
    public static EpochPeriod FromMoment(TimeSpan time) => FromMoments(CurrentDate, time, time);

    /// <summary>
    /// Returns a new <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> for current date between the specified times.
    /// </summary>
    /// <param name="fromTime">Start time.</param>
    /// <param name="toTime">End time.</param>
    /// <returns>
    /// A <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> for current date between the specified times.
    /// </returns>
    public static EpochPeriod FromMoments(TimeSpan fromTime, TimeSpan toTime) => FromMoments(CurrentDate, fromTime, toTime);

    /// <summary>
    /// Returns a new <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> for specified date between the specified times.
    /// </summary>
    /// <param name="date">Target date.</param>
    /// <param name="fromTime">From time offset.</param>
    /// <param name="toTime">To time offset.</param>
    /// <returns>
    /// A <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> for specified date between the specified times.
    /// </returns>
    public static EpochPeriod FromMoments(DateTime date, TimeSpan fromTime, TimeSpan toTime)
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

        return new EpochPeriod(from, to);
    }

    /// <summary>
    /// Returns a new <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> from specified <see cref="T:iTin.Core.ComponentModel.Period"/>.
    /// </summary>
    /// <param name="period">Target period.</param>
    /// <returns>
    /// A <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/> for specified <see cref="T:iTin.Core.ComponentModel.Period"/>.
    /// </returns>
    public static EpochPeriod FromPeriod(Period period) => new EpochPeriod(period.StartDateTime, period.EndDateTime);

    #endregion

    #region public properties

    /// <summary>
    /// Gets the end epoch date time in milliseconds.
    /// </summary>
    /// <value>
    /// The end epoch date time in milliseconds.
    /// </value>
    public long EndMilliseconds => new DateTimeOffset(EndDateTime.Year, EndDateTime.Month, EndDateTime.Day, EndDateTime.Hour, EndDateTime.Minute, EndDateTime.Second, EndDateTime.Millisecond, TimeSpan.Zero).ToUnixTimeMilliseconds();

    /// <summary>
    /// Gets the start epoch date time in milliseconds.
    /// </summary>
    /// <value>
    /// The start epoch date time in milliseconds.
    /// </value>
    public long StartMilliseconds => new DateTimeOffset(StartDateTime.Year, StartDateTime.Month, StartDateTime.Day, StartDateTime.Hour, StartDateTime.Minute, StartDateTime.Second, StartDateTime.Millisecond, TimeSpan.Zero).ToUnixTimeMilliseconds();

    /// <summary>
    /// Gets the epoch duration.
    /// </summary>
    /// <value>
    /// The epoch duration.
    /// </value>
    public long Duration => EndMilliseconds - StartMilliseconds;

    #endregion

    #region internal properties

    /// <summary>
    /// Gets the end date time.
    /// </summary>
    /// <value>
    /// The end date time.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    internal DateTime EndDateTime { get; }

    /// <summary>
    /// Gets the start date time.
    /// </summary>
    /// <value>
    /// The start date time.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    internal DateTime StartDateTime { get; }

    #endregion

    #region public methods

    /// <summary>
    /// Clones this instance.
    /// </summary>
    /// <returns>
    /// A new object that is a copy of this instance.
    /// </returns>
    public EpochPeriod Clone() => (EpochPeriod)MemberwiseClone();

    /// <summary>
    /// Indicates whether both epoc periods are overlapses.
    /// </summary>
    /// <param name="anotherPeriod">Another epoc period.</param>
    /// <returns>
    /// <b>true</b> if is overlap; Otherwise, <b>false</b>.
    /// </returns>
    public bool Overlaps(EpochPeriod anotherPeriod) => StartMilliseconds < anotherPeriod.EndMilliseconds && anotherPeriod.StartMilliseconds < EndMilliseconds;

    /// <summary>
    /// Returns a new <see cref="T:iTin.Core.ComponentModel.Period"/> from this <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/>.
    /// </summary>
    /// <returns>
    /// Returns a new <see cref="T:iTin.Core.ComponentModel.Period"/> from current instance.
    /// </returns>
    public Period ToPeriod() => ToPeriod(this);

    /// <summary>
    /// Indicates whether both epoc periods are overlapses.
    /// </summary>
    /// <param name="anotherPeriod">Another epoc period.</param>
    /// <returns>
    /// Returns a new <see cref="T:iTin.Core.ComponentModel.Period"/> from current <see cref="T:iTin.Core.ComponentModel.EpochPeriod"/>.
    /// </returns>
    public Period ToPeriod(EpochPeriod anotherPeriod) => new Period(anotherPeriod.StartDateTime, anotherPeriod.EndDateTime);
        
    #endregion

    #region public override methods

    /// <summary>
    /// Returns a value that represents the hash code for this class.
    /// </summary>
    /// <returns>
    /// Hash code for this class.
    /// </returns>
    public override int GetHashCode() => StartDateTime.GetHashCode() ^ EndDateTime.GetHashCode();

    /// <summary>
    /// Returns a value that indicates whether this class is equal to another
    /// </summary>
    /// <param name="obj">Class with which to compare.</param>
    /// <returns>
    /// Results equality comparison.
    /// </returns>
    public override bool Equals(object obj)
    {
        if (obj is not EpochPeriod other)
        {
            return false;
        }

        return other.StartDateTime == StartDateTime && other.EndDateTime == EndDateTime;
    }

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents this instance.
    /// </returns>
    public override string ToString() => $"Duration = {Duration}";

    #endregion
}

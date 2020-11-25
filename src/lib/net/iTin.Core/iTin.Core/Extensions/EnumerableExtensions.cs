
namespace iTin.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;

    using Logging;

    /// <summary>
    /// Static class than contains extension methods for generic enumerable objects.
    /// </summary> 
    public static class EnumerableExtensions
    {
        #region [public] {static} (IEnumerable<string>) AsHexadecimal(This IEnumerable<byte>): Returns the target enumerable of bytes as hexadecimal representation
        /// <summary>
        /// Returns the target enumerable of bytes as hexadecimal representation.
        /// </summary>
        /// <returns>
        /// An new <see cref="IEnumerable{T}" /> where <b>T</b> is a <see cref="string"/> typed from <see cref="IEnumerable"/> of bytes.
        /// </returns>
        public static IEnumerable<string> AsHexadecimal(this IEnumerable<byte> value) => new ReadOnlyCollection<string>(value.Select(item => $"{item:x2}").ToList());
        #endregion

        #region [public] {static} (IEnumerable<double?>) Average>(this IEnumerable<IEnumerable<int>>): Computes the average for all series
        /// <summary>
        /// Computes the average for all series.
        /// </summary>
        /// <param name="series">List of list with values to generate the average</param>
        /// <returns>
        /// Returns the series average.
        /// </returns>
        public static IEnumerable<double?> Average(this IEnumerable<IEnumerable<int>> series)
        {
            var allSeries = series.ToList();
            var averages = new List<double?>();
            for (var i = 0; i != allSeries.First().Count(); ++i)
            {
                averages.Add(allSeries.Average(serie => serie.ElementAt(i)));
            }

            return averages;
        }
        #endregion

        #region [public] {static} (IEnumerable<float?>) Average>(this IEnumerable<IEnumerable<float>>): Computes the average for all series
        /// <summary>
        /// Computes the average for all series.
        /// </summary>
        /// <param name="series">List of list with values to generate the average</param>
        /// <returns>
        /// Returns the series average.
        /// </returns>
        public static IEnumerable<float?> Average(this IEnumerable<IEnumerable<float>> series)
        {
            var allSeries = series.ToList();
            var averages = new List<float?>();
            for (var i = 0; i != allSeries.First().Count(); ++i)
            {
                averages.Add(allSeries.Average(serie => serie.ElementAt(i)));
            }

            return averages;
        }
        #endregion

        #region [public] {static} (IEnumerable<double?>) Average>(this IEnumerable<IEnumerable<long>>): Computes the average for all series
        /// <summary>
        /// Computes the average for all series.
        /// </summary>
        /// <param name="series">List of list with values to generate the average</param>
        /// <returns>
        /// Returns the series average.
        /// </returns>
        public static IEnumerable<double?> Average(this IEnumerable<IEnumerable<long>> series)
        {
            var allSeries = series.ToList();
            var averages = new List<double?>();
            for (var i = 0; i != allSeries.First().Count(); ++i)
            {
                averages.Add(allSeries.Average(serie => serie.ElementAt(i)));
            }

            return averages;
        }
        #endregion

        #region [public] {static} (IEnumerable<T> Clone<T>(this IEnumerable<T>) where T : ICloneable: Clones collection
        /// <summary>
        /// Clones collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">The sequence.</param>
        /// <returns>Clonned IEnumerable&lt;T&gt;.</returns>
        public static IEnumerable<T> Clone<T>(this IEnumerable<T> collection) where T : ICloneable
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Clones collection");
            Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<T>)}) Clone<{typeof(T)}>(this {typeof(IEnumerable<T>)}) where {typeof(T)} : {typeof(ICloneable)}");
            Logger.Instance.Debug($"   > collection: {collection}");

            return collection.Select(item => (T)item.Clone()).ToList();
        }
        #endregion

        #region [public] {static} (List<T>) ExchangeElement<T>(this IEnumerable<T>, T, int): Moves specified item to new position
        /// <summary>
        /// Moves specified item to new position.
        /// </summary>
        /// <param name="items">Target list</param>
        /// <param name="item">Item to move</param>
        /// <param name="newPosition">New position into list</param>
        /// <typeparam name="T">Element type</typeparam>
        /// <returns>
        /// Returns the same list with item in new position
        /// </returns>
        public static List<T> ExchangeElement<T>(this IEnumerable<T> items, T item, int newPosition)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Moves specified item to new position");
            Logger.Instance.Debug($" > Signature: ({typeof(List<T>)}) ExchangeElement<{typeof(T)}>(this {typeof(IEnumerable<T>)})");
            Logger.Instance.Debug($"   > items: {items}");
            Logger.Instance.Debug($"   > item: {item}");
            Logger.Instance.Debug($"   > newPosition: {newPosition}");

            if (items == null)
            {
                return null;
            }

            var list = items.ToList();
            if (item == null)
            {
                return list;
            }

            if (newPosition > list.Count)
            {
                return list;
            }

            if (newPosition < 0)
            {
                return list;
            }

            list.Remove(item);
            list.Insert(newPosition, item);

            return list;
        }
        #endregion

        #region [public] {static} (IEnumerable<T>) Extract<T>(this IEnumerable<T>, byte): Extracts the specified sequence
        /// <summary>
        /// Extracts the specified sequence.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sequence">The sequence.</param>
        /// <param name="start">The start index.</param>
        /// <returns>
        /// IEnumerable&lt;T&gt;.
        /// </returns>
        public static IEnumerable<T> Extract<T>(this IEnumerable<T> sequence, byte start)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Extracts the specified sequence");
            Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<T>)}) Extract<{typeof(T)}>(this {typeof(IEnumerable<T>)}, {typeof(byte)})");
            Logger.Instance.Debug($"   > sequence: {sequence}");
            Logger.Instance.Debug($"   > start: {start}");

            return sequence.Skip(start);
        }
        #endregion

        #region [public] {static} (IEnumerable<T>) Extract<T>(this IEnumerable<T>, byte, byte): Extracts the specified sequence
        /// <summary>
        /// Extracts the specified sequence.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sequence">The sequence.</param>
        /// <param name="start">The start index.</param>
        /// <param name="lenght">The lenght.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public static IEnumerable<T> Extract<T>(this IEnumerable<T> sequence, byte start, byte lenght)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Extracts the specified sequence");
            Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<T>)}) Extract<{typeof(T)}>(this {typeof(IEnumerable<T>)}, {typeof(byte)}, {typeof(byte)})");
            Logger.Instance.Debug($"   > sequence: {sequence}");
            Logger.Instance.Debug($"   > start: {start}");
            Logger.Instance.Debug($"   > lenght: {lenght}");

            return
                 sequence
                    .Skip(start)
                    .TakeWhile((element, index) => index < lenght);
        }
        #endregion

        #region [public] {static} (IEnumerable<T>) Extract<T>(this IEnumerable<T>, byte, int): Extracts the specified sequence
        /// <summary>
        /// Extracts the specified sequence.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sequence">The sequence.</param>
        /// <param name="start">The start index.</param>
        /// <param name="lenght">The lenght.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public static IEnumerable<T> Extract<T>(this IEnumerable<T> sequence, int start, int lenght)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Extracts the specified sequence");
            Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<T>)}) Extract<{typeof(T)}>(this {typeof(IEnumerable<T>)}, {typeof(byte)}, {typeof(int)})");
            Logger.Instance.Debug($"   > sequence: {sequence}");
            Logger.Instance.Debug($"   > start: {start}");
            Logger.Instance.Debug($"   > lenght: {lenght}");

            return
                sequence
                    .Skip(start)
                    .TakeWhile((element, index) => index < lenght);
        }
        #endregion

        #region [public] {static} (List<T>) ForEach<T>(this IEnumerable<T>, Action<T>): Executes an action for every item in the collection
        /// <summary>
        /// Executes an action for every item in the collection.
        /// </summary>
        /// <param name="source">Target source</param>
        /// <param name="action">ction to executes</param>
        /// <typeparam name="T">Type of element</typeparam>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Executes an action for every item in the collection");
            Logger.Instance.Debug($" > Signature: ({typeof(List<T>)}) ForEach<{typeof(T)}>(this {typeof(IEnumerable<T>)}, {typeof(Action<T>)})");
            Logger.Instance.Debug($"   > source: {source}");
            Logger.Instance.Debug($"   > action: {action}");

            foreach (var item in source)
            {
                action(item);
            }
        }
        #endregion

        #region [public] {static} (IEnumerable<T>) GetDuplicates<T>(this IEnumerable<T>): Executes an action for every item in the collection
        /// <summary>
        /// Gets the duplicates.
        /// </summary>
        /// <typeparam name="T">Type of element</typeparam>
        /// <param name="source">The source.</param>
        /// <returns>
        /// Item duplicates list.
        /// </returns>
        public static IEnumerable<T> GetDuplicates<T>(this IEnumerable<T> source)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Gets the duplicates");
            Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<T>)}) GetDuplicates<{typeof(T)}>(this {typeof(IEnumerable<T>)})");
            Logger.Instance.Debug($"   > source: {source}");

            HashSet<T> itemsSeen = new HashSet<T>();
            HashSet<T> itemsYielded = new HashSet<T>();

            foreach (var item in source)
            {
                if (itemsSeen.Add(item))
                {
                    continue;
                }

                if (itemsYielded.Add(item))
                {
                    yield return item;
                }
            }
        }
        #endregion

        #region [public] {static} (IEnumerable<T>) GetDuplicates<T>(this IEnumerable<T>): Executes an action for every item in the collection
        /// <summary>
        /// Determines whether this instance has duplicates.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns>
        /// <b>true</b> if contains duplicates; otherwise <b>false</b>.
        /// </returns>
        public static bool HasDuplicates<T>(this IEnumerable<T> source)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Gets the duplicates");
            Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<T>)}) HasDuplicates<{typeof(T)}>(this {typeof(IEnumerable<T>)})");
            Logger.Instance.Debug($"   > source: {source}");

            IEnumerable<T> duplicates = source.GetDuplicates();
            return duplicates.Any();
        }
        #endregion

        #region [public] {static} (Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>) Pivot<TSource, TFirstKey, TSecondKey, TValue>)(this IEnumerable<TSource>, Func<TSource, TFirstKey>, Func<TSource, TSecondKey>, Func<IEnumerable<TSource>, TValue>): Pivots the specified first key selector
        /// <summary>
        /// Pivots the specified first key selector.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TFirstKey">The type of the first key.</typeparam>
        /// <typeparam name="TSecondKey">The type of the second key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="firstKeySelector">The first key selector.</param>
        /// <param name="secondKeySelector">The second key selector.</param>
        /// <param name="aggregate">The aggregate.</param>
        /// <returns>
        /// A new dictionary with data transformation.
        /// </returns>
        public static Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> Pivot<TSource, TFirstKey, TSecondKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TFirstKey> firstKeySelector, Func<TSource, TSecondKey> secondKeySelector, Func<IEnumerable<TSource>, TValue> aggregate)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Pivots the specified first key selector");
            Logger.Instance.Debug($" > Signature: ({typeof(Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>)}) Pivot(this {typeof(IEnumerable<TSource>)}, {typeof(Func<TSource, TFirstKey>)}, {typeof(Func<TSource, TSecondKey>)}, {typeof(Func<IEnumerable<TSource>, TValue>)})");
            Logger.Instance.Debug($"   > source: {source}");
            Logger.Instance.Debug($"   > firstKeySelector: {firstKeySelector}");
            Logger.Instance.Debug($"   > secondKeySelector: {secondKeySelector}");
            Logger.Instance.Debug($"   > aggregate: {aggregate}");

            var retVal = new Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>();

            var l = source.ToLookup(firstKeySelector);
            foreach (var item in l)
            {
                var dict = new Dictionary<TSecondKey, TValue>();
                retVal.Add(item.Key, dict);
                var subdict = item.ToLookup(secondKeySelector);
                foreach (var subitem in subdict)
                {
                    dict.Add(subitem.Key, aggregate(subitem));
                }
            }

            return retVal;
        }
        #endregion

        #region [public] {static} (DataTable) ToDataTable<T>(This IEnumerable, string): Creates a new datatable from an IEnumerable type
        /// <summary>
        /// Creates a new datatable from an <see cref="T:System.Collections.IEnumerable"/>.
        /// </summary>
        /// <typeparam name="T">Enumerable data type</typeparam>
        /// <param name="items">Target items.</param>
        /// <param name="name">Table name.</param>
        /// <returns>
        /// <see cref="T:System.Data.DataTable"/> which contains the specified rows.
        /// </returns>
        public static DataTable ToDataTable<T>(this IEnumerable items, string name)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Converts an enumeration of groupings into a Dictionary of those groupings");
            Logger.Instance.Debug($" > Signature: ({typeof(DataTable)}) ToDataTable(this {typeof(IEnumerable)}, {typeof(string)})");
            Logger.Instance.Debug($"   > items: {items}");
            Logger.Instance.Debug($"   > name: {name}");

            var table = new DataTable(name);
            var properties = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            var list = items.Cast<T>();
            foreach (var item in list)
            {
                var row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }
        #endregion

        #region [public] {static} (Dictionary<TKey, List<TValue>>) ToDictionary<TKey, TValue>(This IEnumerable<IGrouping<TKey, TValue>>): Performs a test on the method argument, and throws an exception of type ArgumentNullException with specified error message if is null
        /// <summary>
        /// Converts an enumeration of groupings into a Dictionary of those groupings.
        /// </summary>
        /// <typeparam name="TKey">Key type of the grouping and dictionary.</typeparam>
        /// <typeparam name="TValue">Element type of the grouping and dictionary list.</typeparam>
        /// <param name="groupings">The enumeration of groupings from a GroupBy() clause.</param>
        /// <returns>A dictionary of groupings such that the key of the dictionary is TKey type and the value is List of TValue type.</returns>
        public static Dictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(this IEnumerable<IGrouping<TKey, TValue>> groupings)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Converts an enumeration of groupings into a Dictionary of those groupings");
            Logger.Instance.Debug($" > Signature: ({typeof(Dictionary<TKey, List<TValue>>)}) ToDictionary(this {typeof(IEnumerable<IGrouping<TKey, TValue>>)})");
            Logger.Instance.Debug($"   > groupings: {groupings}");

            return groupings.ToDictionary(group => group.Key, group => group.ToList());
        }
        #endregion

        #region [public] {static} (ObservableCollection<T>) ToObservableCollection<T>(This IEnumerable<T>): Creates a new observable collection from an IEnumerable
        /// <summary>
        /// Creates a new observable collection from an <see cref="T:System.Collections.IEnumerable"/>.
        /// </summary>
        /// <typeparam name="T">Type of enumeeration.</typeparam>
        /// <returns>
        /// An new <see cref="T:System.Collections.ObjectModel.ObservableCollection" /> typed from <see cref="T:System.Collections.IEnumerable" />.
        /// </returns>
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: EnumerableExtensions");
            Logger.Instance.Debug($" Creates a new observable collection from an {typeof(IEnumerable<T>)}");
            Logger.Instance.Debug($" > Signature: ({typeof(ObservableCollection<T>)}) ToObservableCollection<{typeof(T)}>(this {typeof(IEnumerable<T>)})");
            Logger.Instance.Debug($"   > source: {source}");

            return new ObservableCollection<T>(source);
        }
        #endregion
    }
}

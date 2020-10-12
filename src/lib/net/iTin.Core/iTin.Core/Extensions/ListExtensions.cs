
namespace iTin.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Logging;

    /// <summary>
    /// Static class than contains extension methods for generic List.
    /// </summary> 
    public static class ListExtensions
    {      
        /// <summary>
        /// Moves specified item to new position
        /// </summary>
        /// <param name="items">Target list</param>
        /// <param name="item">Item to move</param>
        /// <param name="newPosition">New position into list</param>
        /// <typeparam name="T">Element type</typeparam>
        /// <returns>
        /// Returns the same list with item in new position
        /// </returns>
        public static List<T> MoveElementToPosition<T>(this List<T> items, T item, int newPosition)
        {
            if (items == null)
            {
                return null;
            }

            if (item == null)
            {
                return items;
            }

            if (newPosition > items.Count)
            {
                return items;
            }

            if (newPosition < 0)
            {
                return items;
            }

            items.Remove(item);
            items.Insert(newPosition, item);

            return items;
        }

        /// <summary>
        /// Returns the next item on the list from the specified current
        /// <para>Will return null if the current is the last</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        public static T? GetNext<T>(this List<T> items, T current) where T : struct
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Returns the next item on the list from the specified current. Will return null if the current is the last");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: ListExtensions");
            Logger.Instance.Info("  > Method: GetNext<T>(this List<T>, T)");
            Logger.Instance.Info("  > Output: T?");

            if (items == null || !items.Any())
            {
                return null;
            }

            var length = items.Count();
            var index = items.LastIndexOf(current);

            if (index >= length - 1)
            {
                return null;
            }

            return items[index + 1];
        }

        /// <summary>
        /// Returns the previous item on the list from the specified current
        /// <para>Will return null if the current is the first</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        public static T? GetPrev<T>(this List<T> items, T current) where T : struct
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Returns the previous item on the list from the specified current. Will return null if the current is the first");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: ListExtensions");
            Logger.Instance.Info("  > Method: GetPrev<T>(this List<T>, T)");
            Logger.Instance.Info("  > Output: T?");

            if (items == null || !items.Any())
            {
                return null;
            }

            var index = items.IndexOf(current);

            if (index <= 0)
            {
                return null;
            }

            return items[index - 1];
        }

        /// <summary>
        /// Returns the next item on the list from the specified current
        /// <para>Will return null if the current is the last</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        public static T GetNextObject<T>(this List<T> items, T current) where T : class
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Returns the next item on the list from the specified current. Will return null if the current is the last");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: ListExtensions");
            Logger.Instance.Info("  > Method: GetNextObject<T>(this List<T>, T)");
            Logger.Instance.Info("  > Output: T");

            if (items == null || !items.Any())
            {
                return null;
            }

            var length = items.Count();
            var index = items.LastIndexOf(current);

            if (index >= length - 1)
            {
                return null;
            }

            return items[index + 1];
        }

        /// <summary>
        /// Returns the previous item on the list from the specified current
        /// <para>Will return null if the current is the first</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        public static T GetPrevObject<T>(this List<T> items, T current) where T : class
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Returns the previous item on the list from the specified current. Will return null if the current is the first");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: ListExtensions");
            Logger.Instance.Info("  > Method: GetPrevObject<T>(this List<T>, T)");
            Logger.Instance.Info("  > Output: T");

            if (items == null || !items.Any())
            {
                return null;
            }

            var index = items.IndexOf(current);

            if (index <= 0)
            {
                return null;
            }

            return items[index - 1];
        }

        /// <summary>
        /// Returns a valid index to use in this List.
        /// </summary>
        /// <typeparam name="T">Type element</typeparam>
        /// <param name="items">Target list</param>
        /// <param name="index">Reference index</param>
        /// <returns>
        /// A valid index.
        /// </returns>
        public static int GetValidIndex<T>(this List<T> items, int index)
        {
            return Math.Max(0, Math.Min(index, items.Count - 1));
        }

        /// <summary>
        /// Determines if specified value is a valid index in list
        /// </summary>
        /// <typeparam name="T">Type element</typeparam>
        /// <param name="items">Target list</param>
        /// <param name="index">Value to test</param>
        /// <returns>
        /// <b>true</b> if is a valid index; otherwise <b>false</b>.
        /// </returns>
        public static bool IsValidIndex<T>(this IList<T> items, int index)
        {
            return
                items != null && 
                index >= 0 && 
                index < items.Count;
        }

        /// <summary>
        /// Try returns item in specified index. If index is not valid value is <b>null</b> (<b>Nothing</b> in Visual Basic)
        /// </summary>
        /// <typeparam name="T">Type element</typeparam>
        /// <param name="items">Target list</param>
        /// <param name="index">Reference index</param>
        /// <param name="value">Item</param>
        /// <returns></returns>
        public static bool TryGetValue<T>(this List<T> items, int index, ref T value)
        {
            if (!IsValidIndex(items, index))
            {
                return false;
            }

            value = items[index];
            return true;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

using iTin.Logging;

namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for Arrays.
    /// </summary> 
    public static class ArrayExtensions
    {
        #region public static methods

        #region [public] {static} (T[]) Append<T>(this T[], T): Add the element to the end of the array
        /// <summary>
        /// Add the element to the end of the array.
        /// </summary>
        /// <typeparam name="T">Element array type</typeparam>
        /// <param name="array">Elements array</param>
        /// <param name="item">Element to add</param>
        /// <returns>
        /// Returns a new array that contains the new element at the end.
        /// </returns>
        public static T[] Append<T>(this T[] array, T item) => InsertAt(array, array.Length, item);
        #endregion

        #region [public] {static} (T[]) Append<T>(this T[], T[]): Add an array of elements to the end of the array
        /// <summary>
        /// Add an array of elements to the end of the array.
        /// </summary>
        /// <typeparam name="T">Element array type</typeparam>
        /// <param name="array">Elements array</param>
        /// <param name="items">Elements to add</param>
        /// <returns>
        /// Returns a new array that contains the new elements array at the end.
        /// </returns>
        public static T[] Append<T>(this T[] array, T[] items) => InsertAt(array, array.Length, items);
        #endregion

        #region [public] {static} (T[]) Copy<T>(this T[], int, int): Copy a set of elements from an array from the indicated position and length
        /// <summary>
        /// Copy a set of elements from an array from the indicated position and length.
        /// </summary>
        /// <typeparam name="T">Element array type</typeparam>
        /// <param name="array">Elements array</param>
        /// <param name="start">Start element index</param>
        /// <param name="length">Length to copy</param>
        /// <returns>
        /// Returns a new array that contains a set of elements from an array from the indicated position and length.
        /// </returns>
        public static T[] Copy<T>(this T[] array, int start, int length)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(ArrayExtensions).Assembly.GetName().Name}, v{typeof(ArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ArrayExtensions).Namespace}, Class: {nameof(ArrayExtensions)}");
            Logger.Instance.Debug(" Copy a set of elements from an array from the indicated position and length");
            Logger.Instance.Debug($" > Signature: ({typeof(T[])}) Copy<{typeof(T)})>(this {typeof(T[])}, {typeof(int)}, {typeof(int)})");
            Logger.Instance.Debug($"   > array: {array.Length} items");
            Logger.Instance.Debug($"   > start: {start}");
            Logger.Instance.Debug($"   > length: {length}");

            // It's ok for 'start' to equal 'array.Length'.  In that case you'll
            // just get an empty array back.
            //Debug.Assert(start >= 0);
            //Debug.Assert(start <= array.Length);

            if (start + length > array.Length)
            {
                length = array.Length - start;
            }

            T[] newArray = new T[length];
            Array.Copy(array, start, newArray, 0, length);
            return newArray;
        }
        #endregion

        #region [public] {static} (T[]) InsertAt<T>(this T[], int, T): Insert an element in the array at the indicated position
        /// <summary>
        /// Insert an element in the array at the indicated position.
        /// </summary>
        /// <typeparam name="T">Element array type</typeparam>
        /// <param name="array">Elements array</param>
        /// <param name="position">Position in array</param>
        /// <param name="item">Element to insert</param>
        /// <returns>
        /// Returns a new array that contains the new element at the indicated position.
        /// </returns>
        public static T[] InsertAt<T>(this T[] array, int position, T item)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(ArrayExtensions).Assembly.GetName().Name}, v{typeof(ArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ArrayExtensions).Namespace}, Class: {nameof(ArrayExtensions)}");
            Logger.Instance.Debug(" Insert an element in the array at the indicated position");
            Logger.Instance.Debug($" > Signature: ({typeof(T[])}) InsertAt<{typeof(T)})>(this {typeof(T[])}, {typeof(int)}, {typeof(T)})");
            Logger.Instance.Debug($"   > array: {array.Length} items");
            Logger.Instance.Debug($"   > position: {position}");
            Logger.Instance.Debug($"   > item: {item}");

            T[] newArray = new T[array.Length + 1];
            if (position > 0)
            {
                Array.Copy(array, newArray, position);
            }

            if (position < array.Length)
            {
                Array.Copy(array, position, newArray, position + 1, array.Length - position);
            }

            newArray[position] = item;
            return newArray;
        }
        #endregion

        #region [public] {static} (T[]) InsertAt<T>(this T[], int, T[]): Insert an array of elements in the array from the indicated position
        /// <summary>
        /// Insert an array of elements in the array from the indicated position.
        /// </summary>
        /// <typeparam name="T">Element array type</typeparam>
        /// <param name="array">Elements array</param>
        /// <param name="position">Position into array</param>
        /// <param name="items">Elements to insert</param>
        /// <returns>
        /// Returns a new array that contains the new elements array at the indicated position.
        /// </returns>
        public static T[] InsertAt<T>(this T[] array, int position, T[] items)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(ArrayExtensions).Assembly.GetName().Name}, v{typeof(ArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ArrayExtensions).Namespace}, Class: {nameof(ArrayExtensions)}");
            Logger.Instance.Debug(" Insert an array of elements in the array from the indicated position");
            Logger.Instance.Debug($" > Signature: ({typeof(T[])}) InsertAt<{typeof(T)})>(this {typeof(T[])}, {typeof(int)}, {typeof(T[])})");
            Logger.Instance.Debug($"   > array: {array.Length} items");
            Logger.Instance.Debug($"   > position: {position}");
            Logger.Instance.Debug($"   > items: {array.Length} items");

            T[] newArray = new T[array.Length + items.Length];
            if (position > 0)
            {
                Array.Copy(array, newArray, position);
            }

            if (position < array.Length)
            {
                Array.Copy(array, position, newArray, position + items.Length, array.Length - position);
            }

            items.CopyTo(newArray, position);
            return newArray;
        }
        #endregion

        #region [public] {static} (T[]) RemoveAt<T>(this T[], int): Remove an element from an array from the indicated position
        /// <summary>
        /// Remove an element from an array from the indicated position
        /// </summary>
        /// <typeparam name="T">Element array type</typeparam>
        /// <param name="array">>Elements array</param>
        /// <param name="position">Position into array</param>
        /// <returns>
        /// Returns a new array that does not contain the indicated element.
        /// </returns>
        public static T[] RemoveAt<T>(this T[] array, int position) => RemoveAt(array, position, 1);
        #endregion

        #region [public] {static} (T[]) RemoveAt<T>(this T[], int, int): Remove an array of elements from an array from the indicated position and length
        /// <summary>
        /// Remove an array of elements from an array from the indicated position and length.
        /// </summary>
        /// <typeparam name="T">Element array type</typeparam>
        /// <param name="array">>Elements array</param>
        /// <param name="start">Start element index</param>
        /// <param name="length">Length to extract</param>
        /// <returns>
        /// Returns a new array that does not contain the indicated elements.
        /// </returns>
        public static T[] RemoveAt<T>(this T[] array, int start, int length)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(ArrayExtensions).Assembly.GetName().Name}, v{typeof(ArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ArrayExtensions).Namespace}, Class: {nameof(ArrayExtensions)}");
            Logger.Instance.Debug(" Remove an array of elements from an array from the indicated position and length");
            Logger.Instance.Debug($" > Signature: ({typeof(T[])}) RemoveAt<{typeof(T)})>(this {typeof(T[])}, {typeof(int)}, {typeof(int)})");
            Logger.Instance.Debug($"   > array: {array.Length} items");
            Logger.Instance.Debug($"   > start: {start}");
            Logger.Instance.Debug($"   > length: {length}");

            if (start + length > array.Length)
            {
                length = array.Length - start;
            }

            T[] newArray = new T[array.Length - length];
            if (start > 0)
            {
                Array.Copy(array, newArray, start);
            }

            if (start < newArray.Length)
            {
                Array.Copy(array, start + length, newArray, start, newArray.Length - start);
            }

            return newArray;
        }
        #endregion

        #region [public] {static} (T[]) ReplaceAt<T>(this T[], int, T): Replace an element in the array at the indicated position
        /// <summary>
        /// Replace an element in the array at the indicated position.
        /// </summary>
        /// <typeparam name="T">Element array type</typeparam>
        /// <param name="array">>Elements array</param>
        /// <param name="position">Position in array</param>
        /// <param name="item">Elements to replace</param>
        /// <returns>
        /// Returns a new array that contains the new array content.
        /// </returns>
        public static T[] ReplaceAt<T>(this T[] array, int position, T item)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(ArrayExtensions).Assembly.GetName().Name}, v{typeof(ArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ArrayExtensions).Namespace}, Class: {nameof(ArrayExtensions)}");
            Logger.Instance.Debug(" Replace an element in the array at the indicated position");
            Logger.Instance.Debug($" > Signature: ({typeof(T[])}) ReplaceAt<{typeof(T)})>(this {typeof(T[])}, {typeof(int)}, {typeof(T)})");
            Logger.Instance.Debug($"   > array: {array.Length} items");
            Logger.Instance.Debug($"   > position: {position}");
            Logger.Instance.Debug($"   > item: {item}");

            T[] newArray = new T[array.Length];
            Array.Copy(array, newArray, array.Length);
            newArray[position] = item;
            return newArray;
        }
        #endregion

        #region [public] {static} (T[]) ReplaceAt<T>(this T[], int, int, T[]): Replace an element in the array at the indicated position
        /// <summary>
        /// Replace a set of elements in the array at the indicated position.
        /// </summary>
        /// <typeparam name="T">Element array type</typeparam>
        /// <param name="array">>Elements array</param>
        /// <param name="position">Position in array</param>
        /// <param name="length">Length to replace</param>
        /// <param name="items">Elements to replace</param>
        /// <returns>
        /// Returns a new array that contains the new array content.
        /// </returns>
        public static T[] ReplaceAt<T>(this T[] array, int position, int length, T[] items) => InsertAt(RemoveAt(array, position, length), position, items);
        #endregion

        #region [public] {static} (IEnumerable<T[]>) SliceArray<T>(this T[], int): Slice array
        /// <summary>
        /// Slice array
        /// </summary>
        /// <typeparam name="T">Element array type</typeparam>
        /// <param name="source">Target array</param>
        /// <param name="maxResultElements">Max elements for sub-arrays</param>
        /// <returns>
        /// Returns a new array that contains the new array content.
        /// </returns>
        public static IEnumerable<T[]> SliceArray<T>(this T[] source, int maxResultElements)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(ArrayExtensions).Assembly.GetName().Name}, v{typeof(ArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ArrayExtensions).Namespace}, Class: {nameof(ArrayExtensions)}");
            Logger.Instance.Debug(" Slice array");
            Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<T>)}) SliceArray<{typeof(T)})>(this {typeof(T[])}, {typeof(int)})");
            Logger.Instance.Debug($"   > array: {source.Length} items");
            Logger.Instance.Debug($"   > maxResultElements: {maxResultElements}");

            int numberOfArrays = source.Length / maxResultElements;
            if (maxResultElements * numberOfArrays < source.Length)
            {
                numberOfArrays++;
            }

            T[][] target = new T[numberOfArrays][];
            for (int index = 0; index < numberOfArrays; index++)
            {
                int elementsInThisArray = Math.Min(maxResultElements, source.Length - index * maxResultElements);
                target[index] = new T[elementsInThisArray];
                Array.Copy(source, index * maxResultElements, target[index], 0, elementsInThisArray);
            }

            return target.ToList();
        }
        #endregion

        #endregion

        #region internal static methods

        #region [internal] {static} (void) ReverseContents<T>(this T[]);
        internal static void ReverseContents<T>(this T[] array) => ReverseContents(array, 0, array.Length);
        #endregion

        #region [internal] {static} (void) ReverseContents<T>(this T[], int, int): 
        internal static void ReverseContents<T>(this T[] array, int start, int count)
        {
            int end = start + count - 1;
            for (int i = start, j = end; i < j; i++, j--)
            {
                T tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
        }
        #endregion

        #endregion
    }
}

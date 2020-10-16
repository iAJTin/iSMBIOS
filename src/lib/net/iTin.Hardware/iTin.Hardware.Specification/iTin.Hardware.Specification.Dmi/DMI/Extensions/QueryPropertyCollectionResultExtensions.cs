﻿
namespace iTin.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Linq;

    using iTin.Core.Hardware.Common;
    using iTin.Core.Hardware.Common.ComponentModel;

    /// <summary>
    /// Static class than contains extension methods for types <see cref="QueryPropertyCollectionResult"/>.
    /// </summary> 
    public static class QueryPropertyCollectionResultExtensions
    {
        /// <summary>
        /// Converts a <see cref="QueryPropertyCollectionResult"/> instance into a new <see cref="QueryPropertyDictionaryResult"/> instance.
        /// </summary>
        /// <param name="result">Property collection to convert.</param>
        /// <returns>
        /// A new <see cref="QueryPropertyDictionaryResult"/> instance from <see cref="QueryPropertyCollectionResult"/>.
        /// </returns>
        public static QueryPropertyDictionaryResult AsDictionaryResult(this QueryPropertyCollectionResult result)
        {
            var propertyTable = new PropertyItemDictionary();

            if (result == null)
            {
                return QueryPropertyDictionaryResult.CreateErroResult("Can not be null", propertyTable);
            }

            int index = 0;
            IEnumerable<PropertyItem> items = result.Value.ToList();
            foreach (var item in items)
            {
                propertyTable.Add(index, item);
                index++;
            }

            return QueryPropertyDictionaryResult.CreateSuccessResult(propertyTable);
        }
    }
}

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

using System;

namespace iTin.Core.ComponentModel.Enumerators
{

    /// <summary>
    /// Must be a ref struct as it contains a ReadOnlySpan char
    /// </summary>
    public ref struct SplitEnumerator
    {
        private ReadOnlySpan<char> _str;
        private readonly ReadOnlySpan<char> _separators;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="separators"></param>
        public SplitEnumerator(ReadOnlySpan<char> str, ReadOnlySpan<char> separators)
        {
            _str = str;
            _separators = separators;
            Current = default;
        }

        /// <summary>
        /// Needed to be compatible with the foreach operator
        /// </summary>
        /// <returns></returns>
        public SplitEnumerator GetEnumerator() => this;

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// </returns>
        public bool MoveNext()
        {
            var span = _str;
            switch (span.Length)
            {
                case 0:
                    return false;

                case 1:
                    {
                        for (int i = 0; i < _separators.Length; i++)
                        {
                            if (span.GetPinnableReference() != _separators[i])
                            {
                                continue;
                            }

                            Current = ReadOnlySpan<char>.Empty;
                            _str = ReadOnlySpan<char>.Empty;

                            return true;
                        }

                        break;
                    }
            }

            var index = span.IndexOfAny(_separators);
            if (index == -1)
            {
                Current = span;
                _str = ReadOnlySpan<char>.Empty;

                return true;
            }

            if (index < span.Length - 1)
            {
                for (int i = 0; i < _separators.Length; i++)
                {
                    if (span[index] != _separators[i])
                    {
                        continue;
                    }

                    Current = span.Slice(0, index);
                    _str = span[(index + 1)..];

                    return true;
                }
            }

            Current = span.Slice(0, index);

            _str = span.Slice(index);

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReadOnlySpan<char> Current { get; private set; }
    }
}

#endif

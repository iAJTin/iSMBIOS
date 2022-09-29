
using System;

namespace iTin.Core.Criteria
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public abstract class CriteriaOperator : ICloneable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static explicit operator CriteriaOperator(bool val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(byte val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(char val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(decimal val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(double val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(float val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(short val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(int val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(long val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(Guid val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(string val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(DateTime val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(TimeSpan val) => (OperandValue)val;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator CriteriaOperator(byte[] val) => (OperandValue)val;

        //public static CriteriaOperator And(CriteriaOperator left, CriteriaOperator right)
        //{
        //    return GroupOperator.Combine(GroupOperatorType.And, left, right);
        //}

        //public static CriteriaOperator Or(CriteriaOperator left, CriteriaOperator right)
        //{
        //    return GroupOperator.Combine(GroupOperatorType.Or, left, right);
        //}

        //public static CriteriaOperator And(params CriteriaOperator[] operands)
        //{
        //    return GroupOperator.Combine(GroupOperatorType.And, operands);
        //}

        //public static CriteriaOperator And(IEnumerable<CriteriaOperator> operands)
        //{
        //    return GroupOperator.Combine(GroupOperatorType.And, operands);
        //}

        //public static CriteriaOperator Or(params CriteriaOperator[] operands)
        //{
        //    return GroupOperator.Combine(GroupOperatorType.Or, operands);
        //}

        //public static CriteriaOperator Or(IEnumerable<CriteriaOperator> operands)
        //{
        //    return GroupOperator.Combine(GroupOperatorType.Or, operands);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class OperandValue : CriteriaOperator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public OperandValue(object value)
        {
            Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OperandValue() : this(null)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public object Value { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!ReferenceEquals(GetType(), obj.GetType()))
            {
                return false;
            }

            return Equals(Value, ((OperandValue)obj).Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            object value = Value;
            return value != null ? value.GetHashCode() : -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static explicit operator OperandValue(bool val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(byte val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(char val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(decimal val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(double val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(float val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(short val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(int val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(long val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(Guid val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(string val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(DateTime val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(TimeSpan val) => new OperandValue(val);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static implicit operator OperandValue(byte[] val) => new OperandValue(val);
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public sealed class BetweenOperator : CriteriaOperator
    {

        //public BetweenOperator(string propertyName, object beginValue, object endValue)
        //    : this(new OperandProperty(testPropertyName), ObjectToCriteriaSafe(beginValue), ObjectToCriteriaSafe(endValue))
        //{
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="beginExpression"></param>
        /// <param name="endExpression"></param>
        public BetweenOperator(string propertyName, CriteriaOperator beginExpression, CriteriaOperator endExpression)
        {

        }

    }
}

using UnityEngine;

namespace Data
{
    public class IrrationalNumber
    {
        public int number;

        public IrrationalNumber(int number)
        {
            this.number = number;
        }

        public IrrationalNumber(Point point, bool isNegative = false)
        {
            PointToIrrationalNumber(point);
            if (isNegative) number *= -1;
        }


        public void PointToIrrationalNumber(Point point)
        {
            number = point.x * point.x + point.y * point.y;
        }

        public IrrationalNumber SetNegative()
        {
            return number < 0 ? new IrrationalNumber(number) : new IrrationalNumber(-number);
        }


        public override string ToString()
        {
            string sign = number < 0 ? "-" : "";
            float sqrt = Mathf.Sqrt(Mathf.Abs(number));
            bool isInteger = Mathf.Abs(sqrt - Mathf.Round(sqrt)) < Mathf.Epsilon; // Check if the float number is an integer
            string str = isInteger? sqrt.ToString() : "√" + Mathf.Abs(number);
        
            return sign + str;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return ((IrrationalNumber)obj).number == number;
        }
    
        public bool EqualsAbs(object obj)
        {
            if (obj == null) return false;
            return Mathf.Abs(((IrrationalNumber)obj).number) == Mathf.Abs(number);
        }
        
        public static bool operator >(IrrationalNumber num1, IrrationalNumber num2) => num1.number > num2.number;
        public static bool operator <(IrrationalNumber num1, IrrationalNumber num2) => num1.number < num2.number;
        public static bool operator >=(IrrationalNumber num1, IrrationalNumber num2) => num1.number >= num2.number;
        public static bool operator <=(IrrationalNumber num1, IrrationalNumber num2) => num1.number <= num2.number;

    }
}
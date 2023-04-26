
public class IrrationalNumber
{
    public int number;

    public IrrationalNumber(int number, bool isNegative = false)
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


    public override string ToString()
    {
        string sign = number < 0 ? "-" : "";
        return sign + "√" + number;
    }


    public static bool operator ==(IrrationalNumber num1, IrrationalNumber num2) => num2 != null && num1 != null && num1.number == num2.number;

    public static bool operator !=(IrrationalNumber num1, IrrationalNumber num2) => num2 != null && num1 != null && num1.number != num2.number;
    
    public static bool operator >(IrrationalNumber num1, IrrationalNumber num2) => num1.number > num2.number;

    public static bool operator <(IrrationalNumber num1, IrrationalNumber num2) => num1.number < num2.number;
    
    public static bool operator >=(IrrationalNumber num1, IrrationalNumber num2) => num1.number >= num2.number;

    public static bool operator <=(IrrationalNumber num1, IrrationalNumber num2) => num1.number <= num2.number;

}
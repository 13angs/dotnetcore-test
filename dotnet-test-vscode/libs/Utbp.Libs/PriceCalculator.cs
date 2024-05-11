namespace Utbp.Libs;

public interface IDateTimeProvider
{
    DayOfWeek DayOfWeek();
}
public class PriceCalculator
{

    public int GetDiscountedPrice(int price, IDateTimeProvider dateTimeProvider)
    {
        if (dateTimeProvider.DayOfWeek() == DayOfWeek.Tuesday)
        {
            return price / 2;
        }
        else
        {
            return price;
        }
    }
}
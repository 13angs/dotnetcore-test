using Utbp.Libs;

namespace Utbp.Tests;

public class Stub_Static_Reference
{
    public void GetDiscountedPrice_NotTuesday_ReturnsFullPrice()
    {
        var priceCalculator = new PriceCalculator();
        var dateTimeProviderStub = new Mock<IDateTimeProvider>();
        dateTimeProviderStub.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Monday);

        var actual = priceCalculator.GetDiscountedPrice(2, dateTimeProviderStub);

        Assert.Equal(2, actual);
    }

    public void GetDiscountedPrice_OnTuesday_ReturnsHalfPrice()
    {
        var priceCalculator = new PriceCalculator();
        var dateTimeProviderStub = new Mock<IDateTimeProvider>();
        dateTimeProviderStub.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Tuesday);

        var actual = priceCalculator.GetDiscountedPrice(2, dateTimeProviderStub);

        Assert.Equal(1, actual);
    }
}
namespace EShop.Application;

public interface IValidationCard
{
    public bool ValidateCardNumber(string cardNumber);

    public string GetCardType(string cardNumber);
}
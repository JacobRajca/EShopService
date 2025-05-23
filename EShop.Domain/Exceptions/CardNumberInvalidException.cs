namespace EShop.Domain.Exceptions;

public class CardNumberInvalidException : Exception
{
    public CardNumberInvalidException() : base("Card Number is invalid") { }

    public CardNumberInvalidException(Exception innerException) : base("Card Number is invalid", innerException) { }
}
namespace EShopService;

public class CardNumberTooShortException : Exception
{
    public CardNumberTooShortException() {}
    public CardNumberTooShortException(string message) : base(message) { }
    public CardNumberTooShortException(string message, Exception inner) : base(message, inner) { }
}
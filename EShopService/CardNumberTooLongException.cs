namespace EShopService;

public class CardNumberTooLongException : Exception
{
    public CardNumberTooLongException() {}
    public CardNumberTooLongException(string message) : base(message) { }
    public CardNumberTooLongException(string message, Exception inner) : base(message, inner) { }
}
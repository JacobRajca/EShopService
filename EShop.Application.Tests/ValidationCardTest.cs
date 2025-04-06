using EShop.Application;
using EShop.Domain.Exceptions;
namespace EShop.Application.Tests;


public class ValidationCardTest
{
    [Fact]
    public void ValidateCardNumber_CheckCardLength_ReturnTrue()
    {
        // Arange
        var validationCard = new ValidationCard();
        string cardNumber = "374979127978356";
        
        // Act
        var result = validationCard.ValidateCardNumber(cardNumber);
        
        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void ValidateCardNumber_CheckExceptionsTooShort_ReturnTrue()
    {
        // Arange
        var validationCard = new ValidationCard();
        string cardNumber = "3749123";
        
        // Act && Assert
        Assert.Throws<CardNumberTooShortException>(() => validationCard.ValidateCardNumber(cardNumber));
    }
    
    [Fact]
    public void ValidateCard_CheckExceptionsTooLong_ReturnTrue()
    {
        // Arrange
        var validationCard = new ValidationCard();
        string cardNumber = "37497912797835619280341";

        // Act && Assert
        Assert.Throws<CardNumberTooLongException>(() => validationCard.ValidateCardNumber(cardNumber));
    }
}
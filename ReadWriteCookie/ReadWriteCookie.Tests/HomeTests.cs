using ReadWriteCookie.Components.Pages;

namespace ReadWriteCookie.Tests;

public class HomeTests : BunitContext
{
    [Fact]
    public void Test_ConstructInputValue()
    {
        // Arrange
        var component = Render<Home>();
        
        // Act
        var result = component.Instance.ConstructInputValue("1", "2");
        
        // Assert
        Assert.Equal("ClinicID=1&JobID=2", result);
    }

    [Fact]
    public void Test_HomeH1()
    { 
        var component = Render<Home>();

        component.MarkupMatches(@"<h1>Cookie Demo!</h1>");
    }
}
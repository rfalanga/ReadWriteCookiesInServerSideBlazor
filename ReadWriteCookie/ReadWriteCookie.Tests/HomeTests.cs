using Bunit;
using Xunit;
using ReadWriteCookie.Components.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace ReadWriteCookie.Tests;

public class HomeTests : TestContext
{
    [Fact]
    public void Test_ConstructInputValue()
    {
        // Arrange
        var component = RenderComponent<Home>();
        
        // Act
        var result = component.Instance.ConstructInputValue("1", "2");
        
        // Assert
        Assert.Equal("ClinicID=1&JobID=2", result);
    }
}
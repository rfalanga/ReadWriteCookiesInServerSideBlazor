using Microsoft.JSInterop;
using ReadWriteCookie.Models;

namespace ReadWriteCookie.Components.Pages;

public partial class Home
{
    private string inputValue = "";
    private string inputLocationValue = "";
    private string inputPositionValue = "";
    private string selectedLocationValue { get; set; } = "";
    private string selectedPositionValue { get; set; } = "";
    public string myCookieValue { get; set; } = "";

    // This URL will be useful for built-in Blazor components: https://learn.microsoft.com/en-us/aspnet/core/blazor/components/built-in-components?view=aspnetcore-9.0

    // Pseudo-database for demonstration purposes
    private List<Location> locations = new List<Location>
    {
        new Location { ID = 1, PropertyName = "Albuquerque" },
        new Location { ID = 2, PropertyName = "Rio Rancho" },
        new Location { ID = 3, PropertyName = "Los Lunas" },
        new Location { ID = 4, PropertyName = "Bernalillo" }
    };

    private List<Position> positions = new List<Position>
    {
        new Position { ID = 1, PropertyName = "Doctor" },
        new Position { ID = 2, PropertyName = "Nurse" },
        new Position { ID = 3, PropertyName = "Receptionist" },
        new Position { ID = 4, PropertyName = "Technician" }
    };

    private string ConstructInputValue(string locationValue, string positionValue)
    {
        // Combine location and position values into a single string for the cookie  
        return $"ClinicID={locationValue}&JobID={positionValue}";
    }

    protected async Task WriteCookies()
    {
        // Add sanity checks here to ensure inputLocationValue is not empty or null  
        // if (string.IsNullOrWhiteSpace(inputLocationValue))  
        // {  
        //     Console.WriteLine("Location value is empty or null. Please enter a valid value.");  
        //     return;  
        // }  

        // Add sanity checks here to ensure inputPositionValue is not empty or null  
        // if (string.IsNullOrWhiteSpace(inputPositionValue))  
        // {  
        //     Console.WriteLine("Position value is empty or null. Please enter a valid value.");  
        //     return;  
        // }  

        inputValue = ConstructInputValue(selectedLocationValue, selectedPositionValue);

        await JsRuntime.InvokeAsync<object>("WriteCookie", "StaffInfoCookie", this.inputValue, 366);    // Set cookie to expire 366 days  
    }

    protected async Task ReadCookies()
    {
        myCookieValue = await JsRuntime.InvokeAsync<string>("ReadCookie", "StaffInfoCookie");

        if (myCookieValue != null && myCookieValue.Length > 0)
        {
            var parts = myCookieValue.Split('&');
            foreach (var part in parts)
            {
                var keyValue = part.Split('=');
                if (keyValue.Length == 2)
                {
                    Console.WriteLine($"Key: {keyValue[0]}, Value: {keyValue[1]}");
                }
                else
                {
                    Console.WriteLine($"keyValue.Length != 2");
                }
            }
        }
        else
        {
            Console.WriteLine("Cookie is empty or not set the way it needs to be for parsing the cookie.");
        }
    }
}

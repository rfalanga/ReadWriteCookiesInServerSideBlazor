/*
 * This is for the location or site dropdown.
 */
namespace ReadWriteCookie.Models;

public class Location : IInMemory
{
    public int ID { get; set; }
    public string PropertyName { get; set; } = string.Empty;
}

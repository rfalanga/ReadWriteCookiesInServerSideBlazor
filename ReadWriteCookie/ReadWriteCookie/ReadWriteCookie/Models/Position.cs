/*
 * This is for the position or job title dropdown.
 */
namespace ReadWriteCookie.Models;

public class Position : IInMemory
{
    public int ID { get; set; }
    public string PropertyName { get; set; } = string.Empty;
}

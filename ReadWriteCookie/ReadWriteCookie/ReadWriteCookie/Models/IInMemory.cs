/*
 * This app is not going to use a database, so we will use an in-memory store.
 */
namespace ReadWriteCookie.Models;

public interface IInMemory
{
    public int ID { get; set; }
    public string PropertyName { get; set; }
}

namespace Filters.Api.Interfaces
{
    /// <summary>
    /// IHelloServiceServiceFilter
    /// </summary>
    public interface IHelloServiceServiceFilter
    {
        /// <summary>
        /// Greets the users.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>string</returns>
        string GreetUsers(string message);
    }
}

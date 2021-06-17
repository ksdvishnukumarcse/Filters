namespace Filters.Api.Interfaces
{
    /// <summary>
    /// IHelloServiceTypeFilter
    /// </summary>
    public interface IHelloServiceTypeFilter
    {
        /// <summary>
        /// Greets the users.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>string</returns>
        string GreetUsers(string message);
    }
}

using Filters.Api.Interfaces;

namespace Filters.Api.Implementatiosn
{
    /// <summary>
    /// HelloServiceTypeFilter
    /// </summary>
    /// <seealso cref="Filters.Api.Interfaces.IHelloServiceTypeFilter" />
    public class HelloServiceTypeFilter : IHelloServiceTypeFilter
    {
        /// <summary>
        /// Greets the users.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>string</returns>
        public string GreetUsers(string message)
        {
            return $"{message} User from Type Filter!!!";
        }
    }
}

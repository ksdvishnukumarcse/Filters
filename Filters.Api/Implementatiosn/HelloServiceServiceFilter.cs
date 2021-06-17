using Filters.Api.Interfaces;

namespace Filters.Api.Implementatiosn
{
    /// <summary>
    /// HelloServiceServiceFilter
    /// </summary>
    /// <seealso cref="Filters.Api.Interfaces.IHelloServiceServiceFilter" />
    public class HelloServiceServiceFilter : IHelloServiceServiceFilter
    {
        /// <summary>
        /// Greets the users.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>string</returns>
        public string GreetUsers(string message)
        {
            return $"{message} User from Service Filter!!!";
        }
    }
}

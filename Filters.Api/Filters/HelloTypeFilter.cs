using Filters.Api.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Filters.Api.Filters
{
    /// <summary>
    /// HelloTypeFilter
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Filters.IActionFilter" />
    public class HelloTypeFilter : IActionFilter
    {
        private readonly IHelloServiceTypeFilter _helloServiceTypeFilter;
        private string _welcomeMessage;

        /// <summary>
        /// Initializes a new instance of the <see cref="HelloTypeFilter"/> class.
        /// </summary>
        /// <param name="helloServiceTypeFilter">The hello service type filter.</param>
        /// <param name="welcomeMessage">The welcome message.</param>
        public HelloTypeFilter(IHelloServiceTypeFilter helloServiceTypeFilter, string welcomeMessage)
        {
            _helloServiceTypeFilter = helloServiceTypeFilter;
            _welcomeMessage = welcomeMessage;
        }

        /// <summary>
        /// Called after the action executes, before the action result.
        /// </summary>
        /// <param name="context">The <see cref="T:Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext" />.</param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"{_helloServiceTypeFilter.GreetUsers("Bye")}");
        }

        /// <summary>
        /// Called before the action executes, after model binding is complete.
        /// </summary>
        /// <param name="context">The <see cref="T:Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext" />.</param>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"{_helloServiceTypeFilter.GreetUsers("Hello")} {_welcomeMessage}");
        }
    }
}

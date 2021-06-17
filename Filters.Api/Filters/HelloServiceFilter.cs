using Filters.Api.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Filters.Api.Filters
{
    /// <summary>
    /// HelloServiceFilter
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Filters.IActionFilter" />
    public class HelloServiceFilter : IActionFilter
    {
        private readonly IHelloServiceServiceFilter _helloServiceServiceFilter;

        /// <summary>
        /// Initializes a new instance of the <see cref="HelloServiceFilter"/> class.
        /// </summary>
        /// <param name="helloServiceServiceFilter">The hello service service filter.</param>
        public HelloServiceFilter(IHelloServiceServiceFilter helloServiceServiceFilter)
        {
            _helloServiceServiceFilter = helloServiceServiceFilter;
        }

        /// <summary>
        /// Called after the action executes, before the action result.
        /// </summary>
        /// <param name="context">The <see cref="T:Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext" />.</param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(_helloServiceServiceFilter.GreetUsers("Bye"));
        }

        /// <summary>
        /// Called before the action executes, after model binding is complete.
        /// </summary>
        /// <param name="context">The <see cref="T:Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext" />.</param>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine(_helloServiceServiceFilter.GreetUsers("Hello"));
        }
    }
}

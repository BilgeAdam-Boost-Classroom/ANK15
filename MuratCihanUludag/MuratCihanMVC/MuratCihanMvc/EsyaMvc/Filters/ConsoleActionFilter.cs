using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EsyaMvc.Filters
{

    public class ConsoleActionFilter : ActionFilterAttribute, IActionFilter, IOrderedFilter
    {
        private readonly string _mesaj;
        public int Order { get; set; }
        public ConsoleActionFilter(string Mesaj, int order)
        {
            _mesaj = Mesaj;
            Order = order;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"{_mesaj}-Once Calisti");
            base.OnActionExecuting(context);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"{_mesaj}-Sonra Calisti");

            base.OnActionExecuted(context);
        }
    }
}

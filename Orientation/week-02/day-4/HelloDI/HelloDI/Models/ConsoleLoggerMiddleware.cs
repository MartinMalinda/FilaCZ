using HelloDI.Interfaces;
using HelloDI.Views;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HelloDI.Models
{
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        private Printer Printer { get; set; } 
        private IColor Color { get; set; }

        public ConsoleLoggerMiddleware(Printer printer, IColor color) //injeciting printer to middleware
        {
            this.Printer = printer;
            this.Color = color;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            Printer.Log("Ahoj");
            Color.PrintColor();
            return next(context);
        }
    }
}

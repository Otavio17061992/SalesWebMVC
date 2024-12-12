using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class NotFoundExcepetion : ApplicationException
    {
        public NotFoundExcepetion(string message) :base(message) 
        {

        }
    }
}

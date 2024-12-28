using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class IntegretyException : ApplicationException
    {
        public IntegretyException(string message) : base(message) { }
    }
}

using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class DbConcurrencyExcpetion : ApplicationException
    {
        public DbConcurrencyExcpetion(string message) :base(message)
        {

        }
    }
}

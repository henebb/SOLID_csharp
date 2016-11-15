using System;

namespace SOLID_csharp.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
            
        }
    }
}
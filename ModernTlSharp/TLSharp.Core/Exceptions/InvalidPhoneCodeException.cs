using System;

namespace ModernTlSharp.TLSharp.Core.Exceptions
{
    public class InvalidPhoneCodeException : Exception
    {
        internal InvalidPhoneCodeException(string msg) : base(msg) { }
    }
}
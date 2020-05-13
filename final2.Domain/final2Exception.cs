namespace final2.Domain
{
    using System;

    public class final2Exception : Exception
    {
        internal final2Exception()
        { }

        internal final2Exception(string message)
            : base(message)
        { }

        internal final2Exception(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}

using System;

namespace Signing
{

    public class InvalidFileSignatureException : Exception
    {
        public InvalidFileSignatureException() :
            base("Invalid file signature")
        {

        }
    }

}

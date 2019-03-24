using System;

namespace CheckSumPlugin
{
    public class InvalidFileCheckSumException : Exception
    {
        public InvalidFileCheckSumException(string message):
            base(message)
        {

        }
    }
}

using System;

namespace Signing
{

    public class FileNotSignedException : Exception
    {
        public FileNotSignedException() :
            base("File is not signed")
        {

        }
    }

}

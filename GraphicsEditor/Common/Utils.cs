using System.IO;
using System.Collections;

namespace GraphicsEditor
{
    public class Utils
    {

        public static byte[] ReadStream(Stream input)
        {
            if(input.CanSeek)
            {
                input.Position = 0;
            }

            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        public static bool ByteArraysEquals(byte[] a1, byte[] a2)
        {
            return StructuralComparisons.StructuralEqualityComparer.Equals(a1, a2);
        }

    }
}

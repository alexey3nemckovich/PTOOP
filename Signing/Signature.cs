using System;
using System.Collections;

namespace Signing
{
    public class Signature
    {

        public byte[] Hash { get; set; }
        public DateTime Date { get; set; }

        public Signature()
        {
            Hash = new byte[0];
            Date = DateTime.Now;
        }

        public Signature(byte[] hash, DateTime date)
        {
            Hash = hash;
            Date = date;
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Signature other = (Signature)obj;
                return (Date == other.Date) && ByteArraysEquals(Hash, other.Hash);
            }
        }

        private static bool ByteArraysEquals(byte[] a1, byte[] a2)
        {
            return StructuralComparisons.StructuralEqualityComparer.Equals(a1, a2);
        }

    }
}

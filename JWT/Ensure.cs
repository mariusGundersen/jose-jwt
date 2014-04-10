using System;

namespace Jose
{
    public class Ensure
    {
        public static void IsEmpty(byte[] arr, string msg, params object[] args)
        {
            if(arr.Length!=0)
                throw new ArgumentException(msg);
        }

        public static T Type<T>(object obj, string msg, params object[] args)
        {
            if (!(obj is T))
                throw new ArgumentException(msg);

            return (T) obj;
        }

        public static void IsNull(object key, string msg, params object[] args)
        {
            if (key != null)
                throw new ArgumentException(msg);
        }

        public static void BitSize(byte[] array, int expectedSize, string msg, params object[] args)
        {
            if(expectedSize!=array.Length * 8)
                throw new ArgumentException(string.Format(msg,args));
        }

        public static void BitSize(int actualSize, int expectedSize, string msg)
        {
            if(expectedSize!=actualSize)
                throw new ArgumentException(msg);
        }

        public static void IsNotEmpty(string arg, string msg, params object[] args)
        {
            if(string.IsNullOrWhiteSpace(arg))   
                throw new ArgumentException(msg);
        }

        public static void Divisible(int arg, int divisor, string msg, params object[] args)
        {
            if(arg % divisor !=0)
                throw new ArgumentException(string.Format(msg,args));
        }

        public static void MinValue(int arg, int min, string msg, params object[] args)
        {
            if(arg < min)
                throw new ArgumentException(string.Format(msg,args));
        }

        public static void MinBitSize(byte[] arr, int minBitSize, string msg, params object[] args)
        {
            MinValue(arr.Length * 8, minBitSize, msg, args);
        }
    }
}
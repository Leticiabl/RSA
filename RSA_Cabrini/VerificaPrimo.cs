using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;

namespace RSA_Cabrini
{
    public static class RSAHelper
    {

        public static T[] CopySlice<T>(this T[] source, int index, int length, bool padToLength = false)
        {
            int n = length;
            T[] slice = null;

            if (source.Length < index + length)
            {
                n = source.Length - index;
                if (padToLength)
                {
                    slice = new T[length];
                }
            }

            if (slice == null) slice = new T[n];
            Array.Copy(source, index, slice, 0, n);
            return slice;
        }

        public static IEnumerable<T[]> Slices<T>(this T[] source, int count, bool padToLength = false)
        {
            for (var i = 0; i < source.Length; i += count)
                yield return source.CopySlice(i, count, padToLength);
        }

        public static UInt16 GetBitsize(this BigInteger num)
        {
            UInt16 bitSize = 0;
            while (num != 0)
            {
                num /= 2;
                bitSize++;
            }
            return bitSize;
        }

        
        public static BigInteger modInverse(this BigInteger e, ref BigInteger phi)
        {
            BigInteger i = phi, v = 0, d = 1;
            while (e > 0)
            {
                BigInteger t = i / e, x = e;
                e = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= phi;
            if (v < 0) v = (v + phi) % phi;
            return v;
        }


        public static String ToBinString(this byte val)
        {
            return Convert.ToString(val, 2).PadLeft(8, '0');
        }

        public static String ToHexString(this byte[] bArr)
        {
            String result = "";
            foreach (char letter in bArr)
            {
                int value = Convert.ToInt32(letter);
                result += String.Format("{0:X2} ", value);
            }

            return result.TrimEnd();
        }

        public static BigInteger getPrime(int bitsize)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();

            int wlen = (bitsize / 8) + 1;

            byte[] bytes = new byte[wlen];
            BigInteger testPrime;
            rng.GetBytes(bytes);
            bytes[wlen - 1] = 0x00;
            bytes[0] |= (Byte)0x01;
            testPrime = new BigInteger(bytes);

            double count = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            bool IsProbablePrime = false;
            while (!IsProbablePrime && count <= 2e3)
            {
                IsProbablePrime = false;
                count++;

                testPrime += 2;
                IsProbablePrime = testPrime.IsProbablePrime(5);
            }


            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            if (IsProbablePrime)
            {
                bytes = testPrime.ToByteArray();
                 return testPrime;
            }
            else
            {
                return BigInteger.Zero;
            }
        }

        public static bool IsProbablePrime(this BigInteger w, int iterations)
        {
            if (w == 2 || w == 3)
                return true;
            if (w < 2 || w % 2 == 0)
                return false;


            BigInteger m = w - 1;
            ushort a = 0;
            while (m % 2 == 0)
            {
                m /= 2;
                a += 1;
            }


            ushort bitsize = w.GetBitsize();
            int wlen = bitsize / 8;
            if (bitsize % 8 == 0)
                wlen++;
            if (wlen == 0)
                wlen++;

            RandomNumberGenerator rbg = RandomNumberGenerator.Create();
            byte[] bytes = new byte[wlen];
            BigInteger b;

            
            for (int i = 1; i <= iterations; i++)
            {
                ushort cycles = 0;
                do
                {
                    cycles++;
                    if (cycles == 2e6)
                        return false;

                    rbg.GetBytes(bytes);

                    bytes[wlen - 1] = unchecked((byte)((0xFF >> 1 + (7 - (bitsize % 8))) & bytes[wlen - 1]));
                    b = new BigInteger(bytes);
                } while (b <= 1 || b >= w - 1);
                BigInteger z = BigInteger.ModPow(b, m, w);
                if (z == 1 || z == w - 1)
                    continue;



                for (int j = 1; j < a; j++)
                {
                    z = BigInteger.ModPow(z, 2, w);
                    if (z == w - 1)
                        break;
                    if (z == 1)
                        return false;
                }

                if (z != w - 1)
                    return false;
            }


            return true;
        }
    }
}

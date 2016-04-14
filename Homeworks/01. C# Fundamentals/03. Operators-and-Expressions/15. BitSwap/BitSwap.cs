using System;

class BitSwap
{
    static void Main()
    {
        uint n;
        byte p, q, k;

        bool isnInt = uint.TryParse(Console.ReadLine(), out n);

        bool ispByte = byte.TryParse(Console.ReadLine(), out p);

        bool isqByte = byte.TryParse(Console.ReadLine(), out q);

        bool iskByte = byte.TryParse(Console.ReadLine(), out k);

        if (isnInt & ispByte & isqByte & iskByte)
        {
            if ((p + k) < 31 && (q + k) < 31 && (Math.Abs(p - q) >= k))
            {
                if (p > q)
                {
                    byte temp = q;
                    q = p;
                    p = temp;
                }


                n = ((~(((uint)Math.Pow(2, k) - 1) << q | ((uint)Math.Pow(2, k) - 1) << p)) & n) | (((n & (((uint)Math.Pow(2, k) - 1) << p)) << (Math.Abs(p - q))) | ((n & (((uint)Math.Pow(2, k) - 1) << q)) >> (Math.Abs(p - q))));
                Console.WriteLine(Convert.ToInt32(n));

            }
            else
            {

            }
        }
        else
        {

        }

    }
}
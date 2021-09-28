using System;

namespace trougao_odredjen_pravom_i_kordinatnim_pocetkom
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x1, y1, x2, y2, x3, y3, A, B, C, O, P;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            x1 = 0;
            y1 = 0;

            y2 = 0;
            x2 = (b * (-1)) / a;

            x3 = 0;
            y3 = b;

            A = Math.Sqrt(((y3 - y2) * (y3 - y2)) + ((x3 - x2) * (x3 - x2)));
            B = Math.Sqrt(((y3 - y1) * (y3 - y1)) + ((x3 - x1) * (x3 - x1)));
            C = Math.Sqrt(((y2 - y1) * (y2 - y1)) + ((x2 - x1) * (x2 - x1)));

            O = A + B + C;
            P = (C * B) / 2;

            Console.WriteLine(Math.Round(P, 2));
            Console.WriteLine(Math.Round(O, 2));
        }
    }
}

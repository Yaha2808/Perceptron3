using System;

namespace Perceptron3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = -1, b1 = -1, c1 = -1, dx1 = -1,
                a2 = -1, b2 = -1, c2 = +1, dx2 = -1,
                a3 = -1, b3 = +1, c3 = -1, dx3 = -1,
                a4 = -1, b4 = +1, c4 = +1, dx4 = -1,
                a5 = +1, b5 = -1, c5 = -1, dx5 = -1,
                a6 = +1, b6 = -1, c6 = +1, dx6 = -1,
                a7 = +1, b7 = +1, c7 = -1, dx7 = -1,
                a8 = +1, b8 = +1, c8 = +1, dx8 = +1;

            double w1, w2, w3, u;
            double nw1, nw2, nw3, nu;
            double r1, r2, r3, r4, r5, r6, r7, r8;
            double nr1, nr2, nr3, nr4, nr5, nr6, nr7, nr8;


            Console.WriteLine("Ingresa el valor de W1");
            w1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de W2");
            w2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de W3");
            w3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de U");
            u = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            r1 = ((a1 * w1) + (b1 * w2) + (c1 * w3) + u);
            r2 = ((a2 * w1) + (b2 * w2) + (c2 * w3) + u);
            r3 = ((a3 * w1) + (b3 * w2) + (c3 * w3) + u);
            r4 = ((a4 * w1) + (b4 * w2) + (c4 * w3) + u);
            r5 = ((a5 * w1) + (b5 * w2) + (c5 * w3) + u);
            r6 = ((a6 * w1) + (b6 * w2) + (c6 * w3) + u);
            r7 = ((a7 * w1) + (b7 * w2) + (c7 * w3) + u);
            r8 = ((a8 * w1) + (b8 * w2) + (c8 * w3) + u);

            
            if (r1 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx=" + dx1);
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = (dx1 * a1);
                nw2 = (dx1 * b1);
                nw3 = (dx1 * c1);
                nu = (dx1) + u;


                nr1 = ((a1 * nw1) + (b1 * nw2) + (c1 * nw3) + nu);



                Console.WriteLine("Las variables W1, W2 y U se tuvieron que recalcular para cumplir la tabla de verdad");
                Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
                Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
                Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
                Console.WriteLine("El nuevo resultado de U es: " + nu);
                Console.WriteLine("El nuevo resultado es: " + nr1);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx1 =" + dx1);

                r2 = ((a2 * nw1) + (b2 * nw2) + (c2 * nw3) + nu);


            }
            if (r2 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx2=" + dx2);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = (dx2 * a2);
                nw2 = (dx2 * b2);
                nw3 = (dx2 * c2);
                nu = (dx2) + u;


                nr2 = ((a2 * nw1) + (b2 * nw2) + (c2 * nw3) + nu);



                Console.WriteLine("Las variables W1, W2 y U se tuvieron que recalcular para cumplir la tabla de verdad");
                Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
                Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
                Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
                Console.WriteLine("El nuevo resultado de U es: " + nu);
                Console.WriteLine("El nuevo resultado es: " + nr2);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx2 =" + dx2);
                
                r3 = ((a3 * nw1) + (b3 * nw2) + (c3 * nw3) + nu);


            }


            if (r3 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx3=" + dx3);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = (dx3 * a3);
                nw2 = (dx3 * b3);
                nw3 = (dx3 * c3);
                nu = (dx3) + u;


                nr3 = ((a3 * nw1) + (b3 * nw2) + (c3 * nw3) + nu);



                Console.WriteLine("Las variables W1, W2 y U se tuvieron que recalcular para cumplir la tabla de verdad");
                Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
                Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
                Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
                Console.WriteLine("El nuevo resultado de U es: " + nu);
                Console.WriteLine("El nuevo resultado es: " + nr3);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx3 =" + dx3);

                r4 = ((a4 * nw1) + (b4 * nw2) + (c4 * nw3) + nu);


            }
            if (r4 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx4=" + dx4);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = (dx4 * a4);
                nw2 = (dx4 * b4);
                nw3 = (dx4 * c4);
                nu = (dx4) + u;


                nr4 = ((a4 * nw1) + (b4 * nw2) + (c4 * nw3) + nu);



                Console.WriteLine("Las variables W1, W2 y U se tuvieron que recalcular para cumplir la tabla de verdad");
                Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
                Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
                Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
                Console.WriteLine("El nuevo resultado de U es: " + nu);
                Console.WriteLine("El nuevo resultado es: " + nr4);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx4 =" + dx4);

                r5 = ((a5 * nw1) + (b5 * nw2) + (c5 * nw3) + nu);


            }
            if (r5 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx5=" + dx5);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = (dx5 * a5);
                nw2 = (dx5 * b5);
                nw3 = (dx5 * c5);
                nu = (dx5) + u;


                nr5 = ((a5 * nw1) + (b5 * nw2) + (c5 * nw3) + nu);



                Console.WriteLine("Las variables W1, W2 y U se tuvieron que recalcular para cumplir la tabla de verdad");
                Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
                Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
                Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
                Console.WriteLine("El nuevo resultado de U es: " + nu);
                Console.WriteLine("El nuevo resultado es: " + nr5);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx5 =" + dx5);

                r6 = ((a6 * nw1) + (b6 * nw2) + (c6 * nw3) + nu);


            }
            if (r6 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx6=" + dx6);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = (dx6 * a6);
                nw2 = (dx6 * b6);
                nw3 = (dx6 * c6);
                nu = (dx6) + u;


                nr6 = ((a6 * nw1) + (b6 * nw2) + (c6 * nw3) + nu);



                Console.WriteLine("Las variables W1, W2 y U se tuvieron que recalcular para cumplir la tabla de verdad");
                Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
                Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
                Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
                Console.WriteLine("El nuevo resultado de U es: " + nu);
                Console.WriteLine("El nuevo resultado es: " + nr6);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx6 =" + dx6);

                r7 = ((a7 * nw1) + (b7 * nw2) + (c7 * nw3) + nu);


            }
            if (r7 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx7=" + dx7);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = (dx7 * a7);
                nw2 = (dx7 * b7);
                nw3 = (dx7 * c7);
                nu = (dx7) + u;


                nr7 = ((a7 * nw1) + (b7 * nw2) + (c7 * nw3) + nu);



                Console.WriteLine("Las variables W1, W2 y U se tuvieron que recalcular para cumplir la tabla de verdad");
                Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
                Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
                Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
                Console.WriteLine("El nuevo resultado de U es: " + nu);
                Console.WriteLine("El nuevo resultado es: " + nr7);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx7 =" + dx7);

                r8 = ((a8 * nw1) + (b8 * nw2) + (c8 * nw3) + nu);


            }
            if (r8 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx8=" + dx8);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = (dx8 * a8);
                nw2 = (dx8 * b8);
                nw3 = (dx8 * c8);
                nu = (dx8) + u;


                nr8 = ((a8 * nw1) + (b8 * nw2) + (c8 * nw3) + nu);



                Console.WriteLine("Las variables W1, W2 y U se tuvieron que recalcular para cumplir la tabla de verdad");
                Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
                Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
                Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
                Console.WriteLine("El nuevo resultado de U es: " + nu);
                Console.WriteLine("El nuevo resultado es: " + nr8);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("El valor de dx8 =" + dx8);


            }
            Console.ForegroundColor = ConsoleColor.Black;






        }
    }
}

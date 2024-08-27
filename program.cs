using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A2Q1 a2Q1 = new A2Q1();
            a2Q1.discont();
            A2Q2 a2Q2 = new A2Q2();
            a2Q2.convert();

            Console.ReadLine();


        }

    }
    class A2Q1
    {

        int shoes = 500;
        int bag = 200;
        int clothes = 1500;
        int grocery = 100;
        int watch = 2000;
        int discount = 10;
        int price = 0;
        public void discont()
        {
            price = shoes + bag + clothes + grocery + watch;
            if (price > 3000)
            {
                price = price - (price * discount) / 100;
                Console.WriteLine(price);
            }
            else
            {
                Console.WriteLine(price / 500);
            }


        }



    }
    class A2Q2
    {
        float temp = float.Parse(Console.ReadLine());
        public void convert()
        {
            if (temp <= 0)
            {
                Console.WriteLine("Below freezing ");
            }
            else
            {
                float t = (temp * 9 / 5) + 32;

                Console.WriteLine(t);

            }
        }
    }
}

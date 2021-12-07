/* This code is not ment to be used, this is just to show off lists. Although each Main does work if alone. Try it! */

using System;
using System.Collections.Generic;

namespace Default_name {
    class Program {
        static void Main(string[] args) { // Temprature example with arrays
            double[] tempraturer = new double[7];
            for (int i = 0; i < tempraturer.Length; i++) {
                Console.WriteLine("What tis the temp today: " +(i+1));
                tempraturer[i] = double.Parse(Console.ReadLine());
            }
           
            double summ = 0;
            foreach (double t in tempraturer) {
                summ += t;
                Console.WriteLine("The meen temparture is: " + summ / tempraturer.Length);
            }

            Console.ReadKey();
        }

        static void Main(string[] args) { // Temprature example with Lists
            double[] tempraturer = new double[7];
            List<double> templist = new List<double>();

            for (int i = 0; i < 5; i++) {
                Console.Write("What tis the temp today: " +(i+1) + " : ");
                double temp = double.Parse(Console.ReadLine());
                templist.Add(temp);
            }
           
            double summ = 0;
            foreach (double t in templist) {
                summ += t;
                Console.WriteLine("The meen temparture is: " + summ / tempraturer.Length);
            }

            Console.ReadKey();
        }
    }
}

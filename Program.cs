using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //console.writeline("enter the base number: ");
            //a = int.parse(console.readline());
            //console.writeline("enter number 1");
            //a += int.parse(console.readline());
            //console.writeline("enter number 2");
            //a -= int.parse(console.readline());
            //console.writeline("enter number 3");
            //a *= int.parse(console.readline());
            //console.writeline("enter number 4");
            //a /= int.parse(console.readline());

            //console.writeline("results: {0}", a);

            //*****************************to practice break and continue in for loop***********//

            //for (int i = 0; i < 100; i++)
            //{

            //    if (i == 5)
            //        continue;
            //    Console.WriteLine(i);


            //}

            //To write the ASCII value of each character

            //for (int i=0; i<=256; i++)
            //{
            //    Console.WriteLine("{0} : {1}", (char)i, i);
            //}

            // sum up all numbers a user Enters 
            //int sum = 0;
            //Console.WriteLine("Enter all numbers to sum, then input '0' to get Result");
            //while(true)
            //{
            //    int Num = int.Parse(Console.ReadLine());
                
            //    if (Num == 0)
            //        break;
            //    sum += Num;
                
            //}
            //Console.WriteLine("Sum = {0}", sum);

            //****.......counting number of words on a sentence.
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine(words.Length);

            Console.ReadLine();

        }
    }
}

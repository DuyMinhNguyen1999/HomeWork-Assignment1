using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a array and array size
            Console.WriteLine("Please input your size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            decimal[] array = new decimal[size];
            //A loop to input a number,check if it a number or not and add that into array
            for (int i = 0; i < size; i++)
            {
                decimal n;
                Console.WriteLine("please! Input a number");// Input Number
                string newInput = Console.ReadLine();
                //Check if it a number or not 
                bool isNumeric = decimal.TryParse(newInput, out n);
                if (isNumeric)
                {
                    //if true add that number into array
                    decimal number = Convert.ToDecimal(newInput);
                    array[i] = number;
                 }
               else
                {
                    //if false add 0 into array
                    array[i] = 0;
                }
                                
            }
            //output a array
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ,");
                
               
            }
            Console.Read();
        }
    }
}

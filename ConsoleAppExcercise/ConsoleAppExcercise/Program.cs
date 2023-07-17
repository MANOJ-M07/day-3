using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert string to integer using TryParse
            string intStr = "10";
            int convertedInt;
            if (int.TryParse(intStr, out convertedInt))
            {
                int multipliedValue = convertedInt * 5;
                Console.WriteLine("Final value: " + multipliedValue);
            }
            else
            {
                Console.WriteLine("Error: Invalid integer format");
            }

            // Convert string to DateTime using Convert
            string dateTimeStr = "2021-06-01";
            try
            {
                DateTime convertedDateTime = Convert.ToDateTime(dateTimeStr);
                DateTime subtractedDateTime = convertedDateTime.AddMonths(-1);
                Console.WriteLine("Subtracted DateTime: " + subtractedDateTime);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid DateTime format");
            }

            // Convert string to TimeSpan using Parse
            string timeSpanStr = "02:30:00";
            try
            {
                TimeSpan convertedTimeSpan = TimeSpan.Parse(timeSpanStr);
                TimeSpan addedTimeSpan = convertedTimeSpan.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine("Added TimeSpan: " + addedTimeSpan);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid TimeSpan format");
            }
            Console.ReadKey();  

            //string mystring = "1333";
            //int myint;
            //if(int.TryParse(mystring, out myint))
            //{
            //    Console.WriteLine("converted integer: \t"+myint);
            //}
            //else { Console.WriteLine("failed"); }

            //string doublestring="13333";
            //try
            //{
            //    double val = Convert.ToDouble(doublestring);

            //    Console.WriteLine("converted successfully: " +doublestring);
            //}
            //catch (FormatException){
            //    Console.WriteLine("format exception");
            //}
            //catch (OverFlowException)
            //{
            //    Console.WriteLine("OverFlow Exception");
            //}

            //string decimalstring = "10.19";
            //try
            //{
            //    decimal decimalvalue = decimal.Parse(decimalstring);
            //    Console.WriteLine("successfully parsed string to decimal: " + decimalvalue);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("format exception" + ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("overflow exception" + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("error!!!" + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("end of program!!!");

            //    Console.ReadKey();
            //}

        }
    }
}

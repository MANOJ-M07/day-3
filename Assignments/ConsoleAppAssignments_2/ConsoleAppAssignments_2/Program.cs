using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignments_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert string to integer using TryParse
            string tparse = "10";
            int resultInt;
            if (int.TryParse(tparse, out resultInt))
            {
                int finalValue = resultInt * 5;
                Console.WriteLine("Final value: " + finalValue);
            }
            else
            {
                Console.WriteLine("Error!!!");
            }

            // Convert string to DateTime using Convert
            string Dtobj = "01/06/2022";
            try
            {
                DateTime convertedDateTime = Convert.ToDateTime(Dtobj);
                DateTime subtractedDateTime = convertedDateTime.AddMonths(-1);
                Console.WriteLine("Subtracted DateTime: " + subtractedDateTime);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }

            // Convert string to TimeSpan using Parse
            string timespan1 = "05:45:33";
            try
            {
                TimeSpan convertedTimeSpan = TimeSpan.Parse(timespan1);
                TimeSpan addedTimeSpan = convertedTimeSpan.Add(new TimeSpan(5, 1, 0));
                Console.WriteLine("Added TimeSpan: " + addedTimeSpan);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Console.WriteLine("end");
                Console.ReadKey();
            }
        }
    }
}

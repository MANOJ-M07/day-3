using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignments_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string mystring = "1333";
            int myint;
            if(int.TryParse(mystring, out myint))
            {
                Console.WriteLine("converted integer: \t"+myint);
            }
            else { Console.WriteLine("failed"); }
            string doublestring="13333";
            try
            {
                double val = Convert.ToDouble(doublestring)
                Console.WriteLine("converted successfully: " +doublestring);
            }
            catch (FormatException){
                Console.WriteLine("format exception");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverFlow Exception");
            }

            string decimalstring = "10.19";
            try
            {
                decimal decimalvalue = decimal.Parse(decimalstring);
                Console.WriteLine("successfully parsed string to decimal: " + decimalvalue);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("format exception" + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("overflow exception" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error!!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("end of program!!!");

                Console.ReadKey();
            }
        }
    }
}

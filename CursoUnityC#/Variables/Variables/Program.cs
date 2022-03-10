using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "True";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("The Number could not be converted to a Byte");
            }
        
        }
    }
}

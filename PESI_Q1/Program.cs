using System;
using System.Linq;
using System.Threading;

namespace PESI_Q1
{
    public class Program
    {
        //Implementation 1
        public static string StringRandomizer_Impl1(string input)
        {
            if (input == null)
                throw new ArgumentNullException("Received null input");

            if (input.Length <= 1)
                return input;

            Random rnd = new Random();
            char[] array = input.ToCharArray();
            int n = array.Length;
            while (n > 1)
            {
                int k = rnd.Next(0, n--);
                char temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
            return new string(array);
        }


        //Implementation 2
        private static int randomNumberGenerator(int max)
        {
            var currentTime = DateTime.Now;
            int numerator = currentTime.Hour + currentTime.Minute + currentTime.Second + currentTime.Millisecond;
            return numerator % max;
        }
        public static string StringRandomizer_Impl2(string input)
        {
            if (input == null)
                throw new ArgumentNullException("Received null input");

            if (input.Length <= 1)
                return input;

            char[] array = input.ToCharArray();
            int n = array.Length;
            while (n > 1)
            {
                int k = randomNumberGenerator(n--);
                char temp = array[n];
                array[n] = array[k];
                array[k] = temp;
                Thread.Sleep(1);
            }
            return new string(array);
        }
        static void Main(string[] args)
        {

            //Implementation 1
            Console.WriteLine("Implementation 1");
            try
            {
                Console.WriteLine(StringRandomizer_Impl1(null));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var initialStr = "";
            Console.WriteLine(string.Format("Initial String:|{0}|, Randomized Version:|{1}|", initialStr, StringRandomizer_Impl1(initialStr)));
            initialStr = "t";
            Console.WriteLine(string.Format("Initial String:|{0}|, Randomized Version:|{1}|", initialStr, StringRandomizer_Impl1(initialStr)));
            initialStr = "tarunkapoor";
            var randomzedStr = StringRandomizer_Impl1(initialStr);
            Console.WriteLine(string.Format("Initial String:|{0}|, Randomized Version:|{1}|", initialStr, StringRandomizer_Impl1(initialStr)));

            //Implementation 2
            Console.WriteLine("Implementation 2");
            try
            {
                Console.WriteLine(StringRandomizer_Impl2(null));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            initialStr = "";
            Console.WriteLine(string.Format("Initial String:|{0}|, Randomized Version:|{1}|", initialStr, StringRandomizer_Impl2(initialStr)));
            initialStr = "t";
            Console.WriteLine(string.Format("Initial String:|{0}|, Randomized Version:|{1}|", initialStr, StringRandomizer_Impl2(initialStr)));
            initialStr = "tarunkapoor";
            Console.WriteLine(string.Format("Initial String:|{0}|, Randomized Version:|{1}|", initialStr, StringRandomizer_Impl2(initialStr)));

        }
    }
}




using System;

namespace sensitive_info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your information"); // prompts user to enter a ~secret~
            var value = Console.ReadLine(); // read that input
            var removeValue = value.Length - 4; // declaring that all but the last four chars will be affected
            var lastFour = value.Remove(0, removeValue); // declaring the separated chars. Beginning with the first indexed char (0), we remove all chars until we get to the last 4
            var remainingValue = value.Remove(removeValue); // removing all that stuff from line 12; now we have two separate strings!
            var hiddenValues = new System.Text.StringBuilder(); // building new string function
            for (var i = 0; i < remainingValue.Length; i++)
            {
                hiddenValues.Append('*'); // replacing everything except last 4 with *
            }
            Console.WriteLine(hiddenValues + lastFour); // print new string that combines all the above.
        }
    }
}

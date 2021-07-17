using System;

namespace sensitive_info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your information");
            var value = Console.ReadLine();
            var removeValue = value.Length - 4;
            var lastFour = value.Remove(0, removeValue);
            var remainingValue = value.Remove(removeValue);
            var hiddenValues = new System.Text.StringBuilder();
            for (var i = 0; i < remainingValue.Length; i++)
            {
                hiddenValues.Append('*');
            }
            Console.WriteLine(hiddenValues + lastFour);
        }
    }
}

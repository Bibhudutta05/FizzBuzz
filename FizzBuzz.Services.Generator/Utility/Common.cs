using Microsoft.AspNetCore.Components.Forms;

namespace FizzBuzz.Services.Generator.Utility
{
    public static class Common
    {
        public static void CheckDivisibilty(int dividend, out List<string> result)
        {
            List<string> tempresult = new List<string>();

            // Check if i is divisible by both 3 and 5 
            if (dividend % 3 == 0 && dividend % 5 == 0)
            {
                // Add "FizzBuzz" to the result list 
                tempresult.Add(Constants.FizzBuzz);
            }
            // Check if i is divisible by 3 
            else if (dividend % 3 == 0)
            {
                // Add "Fizz" to the result list 
                tempresult.Add(Constants.Fizz);
            }
            // Check if i is divisible by 5 
            else if (dividend % 5 == 0)
            {
                // Add "Buzz" to the result list 
                tempresult.Add(Constants.Buzz);
            }
            else
            {
                // Add "Buzz" to the result list
                string temp = $"Divided {dividend} by 3, Divided {dividend} by 5";
                tempresult.Add(temp);
            }
            result = tempresult; 
        }
    }
}

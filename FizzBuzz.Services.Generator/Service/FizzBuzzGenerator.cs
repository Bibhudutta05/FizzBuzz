using FizzBuzz.Services.Generator.Utility;

namespace FizzBuzz.Services.Generator.Service
{
    public class FizzBuzzGenerator : IFizzBuzz
    {
        public FizzBuzzGenerator() { }

        public List<string> Generator(List<string> inputString)
        {
            List<string> result = new List<string>();

            try
            {
                foreach (string input in inputString)
                {
                    int inputNumber;
                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out inputNumber))
                    {
                        // Check if i is divisible by both 3 and 5 
                        if (inputNumber % 3 == 0 && inputNumber % 5 == 0)
                        {
                            // Add "FizzBuzz" to the result list 
                            result.Add(Constants.FizzBuzz);
                        }
                        // Check if i is divisible by 3 
                        else if (inputNumber % 3 == 0)
                        {
                            // Add "Fizz" to the result list 
                            result.Add(Constants.Fizz);
                        }
                        // Check if i is divisible by 5 
                        else if (inputNumber % 5 == 0)
                        {
                            // Add "Buzz" to the result list 
                            result.Add(Constants.Buzz);
                        }
                        else
                        {
                            // Add "Buzz" to the result list
                            string temp = $"Divided {input} by 3, Divided {input} by 5";
                            result.Add(temp);
                        }
                    }
                    else
                    {
                        // not a number
                        result.Add(Constants.Invalid);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return new List<string>();
            }
        }
    }
}

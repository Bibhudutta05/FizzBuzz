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
                        Utility.Common.CheckDivisibilty(inputNumber, out result);
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

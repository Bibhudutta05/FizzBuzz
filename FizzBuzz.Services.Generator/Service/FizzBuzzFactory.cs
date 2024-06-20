namespace FizzBuzz.Services.Generator.Service
{
    public class FizzBuzzFactory
    {
        public static IFizzBuzz GetGeneratorInstance(string generator)
        {
            IFizzBuzz objectType = null;
            try
            {                
                if (generator.ToLower().Equals("fizzbuzz"))
                {
                    objectType = new FizzBuzzGenerator();
                }
                return objectType;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

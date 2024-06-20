using FizzBuzz.Services.Generator.Service;
using FizzBuzz.Services.Generator.Utility;
using Newtonsoft.Json;
using System.Reflection;

namespace FizzBuzz.UnitTest
{
    public class UnitTest1
    {
        List<string> SingleInvalidDataSet = new List<string>
        {
            "Invalid item"
        };
        List<string> MultileInvalidDataSet = new List<string>
        {
            "Invalid item", "Invalid item"
        };

        List<string> MultileDataSet = new List<string>            
        {
              "Divided 1 by 3, Divided 1 by 5",
              "Fizz",
              "Buzz",
              "Invalid item",
              "FizzBuzz",
              "Invalid item",
              "Divided 23 by 3, Divided 23 by 5"
        };

        [Fact]
        public void TestGenerate_SingleInvalidEntry()
        {
            List<string> input = new List<string>()
            {
                "A"
            };
            //Act
            List<string> output = FizzBuzzFactory.GetGeneratorInstance(Constants.FizzBuzz).Generator(input);
            //Assert
            Assert.NotNull(output);
            Assert.Equal(SingleInvalidDataSet.Count(), output.Count());
            Assert.Equal(SingleInvalidDataSet.ToString(), output.ToString());
            var obj1Str = JsonConvert.SerializeObject(SingleInvalidDataSet);
            var obj2Str = JsonConvert.SerializeObject(output);
            Assert.True(obj1Str.Equals(obj2Str));
        }

        [Fact]
        public void TestGenerate_MultileInvalidEntry()
        {
            List<string> input = new List<string>()
            {
                "A", ""
            };
            //Act
            List<string> output = FizzBuzzFactory.GetGeneratorInstance(Constants.FizzBuzz).Generator(input);
            //Assert
            Assert.NotNull(output);
            Assert.Equal(MultileInvalidDataSet.Count(), output.Count());
            Assert.Equal(MultileInvalidDataSet.ToString(), output.ToString());
            var obj1Str = JsonConvert.SerializeObject(MultileInvalidDataSet);
            var obj2Str = JsonConvert.SerializeObject(output);
            Assert.True(obj1Str.Equals(obj2Str));
        }

        [Fact]
        public void TestGenerate_MultileEntry()
        {
            List<string> input = new List<string>()
            {
                "1", "3", "5", "", "15", "A", "23"
            };
            //Act
            List<string> output = FizzBuzzFactory.GetGeneratorInstance(Constants.FizzBuzz).Generator(input);
            //Assert
            Assert.NotNull(output);
            Assert.Equal(MultileDataSet.Count(), output.Count());
            Assert.Equal(MultileDataSet.ToString(), output.ToString());
            var obj1Str = JsonConvert.SerializeObject(MultileDataSet);
            var obj2Str = JsonConvert.SerializeObject(output);
            Assert.True(obj1Str.Equals(obj2Str));
        }
    }
}
using FizzBuzz.Services.Generator.Controllers;
using FizzBuzz.Services.Generator.Model;
using FizzBuzz.Services.Generator.Service;
using Moq;

namespace UnitTest.TestProject
{
    public class UnitTest1
    {
        private readonly Mock<IFizzBuzz> fizzbuzzService;
        public UnitTest1()
        {
            fizzbuzzService = new Mock<IFizzBuzz>();
        }

        [Fact]
        public void GenerateOuputList()
        {
            //arrange
            var productList = GetData();
            fizzbuzzService.Setup(x => x.Generator(productList))
                .Returns(productList);
            var productController = new FizzBuzzController(fizzbuzzService.Object);

            //act
            var productResult = productController.ProductList();

            //assert
            Assert.NotNull(productResult);
            Assert.Equal(GetProductsData().Count(), productResult.Count());
            Assert.Equal(GetProductsData().ToString(), productResult.ToString());
            Assert.True(productList.Equals(productResult));
        }

        private List<string> GetData()
        {
            List<string> InpurArray = new List<string>() {
            "1", "3", "5", "", "15", "A", "23"          
            };
            
            return InpurArray;
        }
    }
}
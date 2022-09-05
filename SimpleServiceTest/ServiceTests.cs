using NUnit.Framework;
using SimpleService;

namespace SimpleServiceTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetExistingProduct()
        {
            ProductService productService = new ProductService();
            ProductResponse response = productService.GetProductInformation(1);

            Assert.IsTrue(response.sucess);
            Assert.IsNotNull(response.product);
            Assert.IsNotNull(response.product.CodeName);
            Assert.IsNotNull(response.product.Description);
        }

        [Test]
        public void ProductNotFound()
        {
            ProductService productService = new ProductService();
            ProductResponse response = productService.GetProductInformation(9999999);

            Assert.IsFalse(response.sucess);
            Assert.IsNull(response.product);            
        }
    }
}
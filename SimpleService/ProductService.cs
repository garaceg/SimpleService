namespace SimpleService
{
    public class ProductService
    {
        private List<Product> Products = new List<Product>();
        public ProductService()
        {            
            // Read Text File, populates Products List
            string[] lines = System.IO.File.ReadAllLines(@"Products.txt");
            lines = lines.Skip(1).ToArray();            

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                Products.Add(new Product { ProductId = int.Parse(values[0]), CodeName = values[1], Description = values[2], Category = int.Parse(values[3]), Color = values[4], ProductionDate = DateTime.Parse(values[5])});
            }
        }

        public ProductResponse GetProductInformation(int productId)
        {
            ProductResponse productResponse = new ProductResponse();
            productResponse.errorMessage = string.Empty;
            productResponse.sucess = true;

            try
            {
                productResponse.product = Products.Find(x => x.ProductId == productId);

                if (productResponse.product == null)
                {
                    productResponse.errorMessage = "Product not found";
                    productResponse.sucess = false;
                }
            }
            catch (Exception ex)
            {
                productResponse.errorMessage = String.Format("Exception calling GetProductInformation : {0} - Inner Exception {1}", ex.Message, ex.InnerException);
                productResponse.sucess = false;
            }
                      
            return productResponse;
        }
    }
}
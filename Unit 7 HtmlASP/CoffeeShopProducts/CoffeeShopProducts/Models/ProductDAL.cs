namespace CoffeeShopProducts.Models
{
    public class ProductDAL
    {
        public List<Product> GetAllProducts()
        {
            List<Product> result = null;

            using (CoffeeShopProductsContext context = new CoffeeShopProductsContext())
            {
                result = context.Products.ToList();
            }

            return result;
        }

        public Product GetProductById(int ID)
        {
            Product result = null;

            using (CoffeeShopProductsContext context = new CoffeeShopProductsContext())
            {
                result = context.Products.First(p => p.Id == ID);
            }

            return result;
        }

        public List<Product> GetProductsByCategory(string Category)
        {
            List<Product> result = null;

            using (CoffeeShopProductsContext context = new CoffeeShopProductsContext())
            {
                result = context.Products.Where(p => p.Category == Category).ToList();
            }

            return result;
        }
    }
}

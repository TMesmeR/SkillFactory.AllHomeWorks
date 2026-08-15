namespace SkillFactory.AllHomeWorks.Server.Products
{
    /// <summary>
    /// Для упрощения цены будут устанавливаться рандомно на товар от 20 у.е. до 150 y.e.
    /// </summary>
    internal  class CostOfProducts
    {
        
       private static  string[] allProducts = ProductCollection.ArrayAllProducts();
        
       private static List<string> quantityAllProducts = new List<string>();

        private static Dictionary<string, int> idProduct = new Dictionary<string, int>();


        static CostOfProducts()
        {
            for (int i = 0; i < allProducts.Length; i++)
            {
                quantityAllProducts.Add(allProducts[i]);
            }

            for (int i = 0; i < quantityAllProducts.Count; i++) 
            {
                idProduct.Add(quantityAllProducts[i], Random.Shared.Next(20, 151));
            }
            
        }
        /// <summary>
        /// //Возвращает словарь с  id и ценой товара
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string,int> AllProducts() => idProduct;

        


     
        
    }
}

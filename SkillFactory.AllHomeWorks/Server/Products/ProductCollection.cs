namespace SkillFactory.AllHomeWorks.Server.Products
{

   //Да простит меня мое чувство вкуса...но надо же было куда- то впихнуть перегрузку оператора
    public class ProductCollection
    {
        static ProductCollection fruits = new ProductCollection(ArraysOfProducts.arraysOfProducts["fruits"]);
        static ProductCollection vegetables = new ProductCollection(ArraysOfProducts.arraysOfProducts["vegetable"]);
        static ProductCollection cereals = new ProductCollection(ArraysOfProducts.arraysOfProducts["cereals"]);
        static ProductCollection meatPoutry = new ProductCollection(ArraysOfProducts.arraysOfProducts["meatPoutry"]);
        static ProductCollection fishSeafood = new ProductCollection(ArraysOfProducts.arraysOfProducts["fishSeafood"]);
        static ProductCollection dairy = new ProductCollection(ArraysOfProducts.arraysOfProducts["dairy"]);
        static ProductCollection fatsOils = new ProductCollection(ArraysOfProducts.arraysOfProducts["fatsOils"]);
        static ProductCollection sweetsDesserts = new ProductCollection(ArraysOfProducts.arraysOfProducts["sweetsDesserts"]);
        static ProductCollection drinks = new ProductCollection(ArraysOfProducts.arraysOfProducts["drinks"]);
        static ProductCollection seasoningsSauce = new ProductCollection(ArraysOfProducts.arraysOfProducts["seasoningsSauce"]);
        static ProductCollection nutsSeens = new ProductCollection(ArraysOfProducts.arraysOfProducts["nutsSeens"]);
        



        private string[] _products;

        public ProductCollection(string[] initialProducts)
        {
            _products = initialProducts;
        }

        public static ProductCollection operator +(ProductCollection a, ProductCollection b)
        {
            string[] combined = new string[a._products.Length + b._products.Length];
            a._products.CopyTo(combined, 0);
            b._products.CopyTo(combined, a._products.Length);
            return new ProductCollection(combined);
        }

        public string[] GetAllProducts()
        {
            return _products;
        }



        public static string[] ArrayAllProducts()
        {
            ProductCollection allCollection = fruits + vegetables + cereals + meatPoutry + fishSeafood + dairy + fatsOils + sweetsDesserts + drinks + seasoningsSauce + nutsSeens;
            return allCollection.GetAllProducts();
        }
    }
}

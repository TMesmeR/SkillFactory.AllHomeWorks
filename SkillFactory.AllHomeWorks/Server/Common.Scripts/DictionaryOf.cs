using SkillFactory.AllHomeWorks.Server.Products;

namespace SkillFactory.AllHomeWorks.Server.Common.Scripts
{
    /// <summary>
    /// Создание словарей из стрингового массива и Listа
    /// </summary>
    internal static class DictionaryOf
    {
        /// <summary>
        /// Создает словарь для  продуктов определенной группы, а так же словарь групп продуктов
        /// </summary>
        /// <param name="arrOfProducts">Принимает стринговый массив линейки продуктов</param>
        /// <returns></returns>
        public static Dictionary<int, string> CreateADictionary(string[] arrOfProducts)
        {
            Dictionary<int, string> DictionaryOfProducts = new Dictionary<int, string>();

            for (int i = 0; i < arrOfProducts.Length; i++)
            {
                DictionaryOfProducts.Add(i + 1, arrOfProducts[i]);
            }
            return DictionaryOfProducts;
        }
        /// <summary>
        /// Создает словарь: id (наименование товара, цена товара) для корзины.
        /// </summary>
        /// <param name="arrOfProducts"></param>
        /// <returns></returns>
        public static Dictionary<int, (string,int)> CreateADictionaryBasket(Dictionary<int, (string, int)> arrOfProducts)
        {
            Dictionary<int, (string,int)> DictionaryOfProducts = new Dictionary<int, (string,int)>();

            for (int i = 0; i-1 < arrOfProducts.Count-1; i++)
            {
                
                DictionaryOfProducts.Add(i+1, (arrOfProducts[i+1].Item1, arrOfProducts[i+1].Item2));
            }
            return DictionaryOfProducts;
        }

        /// <summary>
        /// Словарь для показа группы продуктов
        /// </summary>
        /// <param name="products">Названия групп продуктов</param>
        /// <returns></returns>
        public static Dictionary<int, string> ViewGroups(string[] products)
        {
            Dictionary<int, string> keyValuePairs = DictionaryOf.CreateADictionary(products);

            foreach (var pairs in keyValuePairs)
            {
                Console.Write(pairs.Key + " - ");
                Console.WriteLine(pairs.Value);
            }

            return keyValuePairs;
        }
        /// <summary>
        /// Создает словарь продуктов, так же добавляет в него рандомные цены 
        /// </summary>
        /// <param name="products">ID(наименование товара, цена товара)</param>
        /// <returns></returns>
        public static Dictionary<int, (string, int)> ViewProducts(string[] products)
        {
            Dictionary<int, string> DictProducts = DictionaryOf.CreateADictionary(products); 
   
            Dictionary<int, (string, int)> DictIdProdCost = new Dictionary<int, (string, int)>(); 

            foreach (var DictProduct in DictProducts)
            {
                foreach (var DictCost in CostOfProducts.AllProducts())
                {
                    if (DictProduct.Value == DictCost.Key)
                    {
                        DictIdProdCost.Add(DictProduct.Key, (DictProduct.Value, DictCost.Value));
                    }
                }
            }

            foreach (var pairs in DictIdProdCost)
            {
                Console.WriteLine(pairs.Key + " - " + pairs.Value.Item1 + "-" + pairs.Value.Item2);
                
            }

            return DictIdProdCost;
        }
    }
}

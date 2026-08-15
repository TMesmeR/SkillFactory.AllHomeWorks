namespace SkillFactory.AllHomeWorks.Server.User
{
    /// <summary>
    /// Логика корзины
    /// </summary>
    public static class BasketUser
    {
        internal static Dictionary<int, (string, int)>  _basketUser =new Dictionary<int, (string, int)>();
        static int  id =1;
        static int sum =0;
        internal static void AddInBasketUser(sbyte pick, Dictionary<int, (string,int)> categories)
        {
            
            _basketUser.Add(id ,(categories[pick].Item1, categories[pick].Item2));
            id++;
            Console.WriteLine($"Товар {categories[pick].Item1} добавлен в корзину");
            sum += categories[pick].Item2;
            
        }

        internal static void RemoveInBasketUser(sbyte pick, Dictionary<int, (string, int)> categories)
        {
            if (_basketUser != null)
            {
                _basketUser.Remove(pick);
                RebuildBasket();
                Console.WriteLine($"Товар {categories[pick].Item1} - {categories[pick].Item2} удален из корзины");
                sum -= categories[pick].Item2;
              
            }
            else
                Console.WriteLine("Товара нет");
        }

        private static void RebuildBasket()
        {
            Dictionary<int, (string, int)> newBasket = new Dictionary<int, (string, int)>();
            int newId = 1;

            foreach (var item in _basketUser)
            {
                newBasket.Add(newId, (item.Value.Item1, item.Value.Item2));
                newId++;
            }

            _basketUser = newBasket;
            id = newId;
            
        }

        internal static void PrintBasket(Dictionary<int, (string, int)> basketUser)
        {
            foreach (var keyValue in basketUser)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value.Item1} - {keyValue.Value.Item2}");
            }
        }

        internal static int GetSummOrder() => sum;
    }
}

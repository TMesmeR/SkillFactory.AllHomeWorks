using SkillFactory.AllHomeWorks.Server.Common.Scripts;
using SkillFactory.AllHomeWorks.Server.User;

namespace SkillFactory.AllHomeWorks.Client.Scripts.Visual
{
    /// <summary>
    /// Визуальная часть корзины
    /// </summary>
    internal static class Basket
    {
        static Dictionary<int, (string,int)> BasketDictionary;

        /// <summary>
        /// выводит количество товаров в корзине в меню
        /// </summary>
        /// <returns></returns>
        internal static int PrintCount() => BasketUser._basketUser.Count; 
        
        internal static void PrintBasket()
        {
            while (true)
            {

                if (BasketUser._basketUser.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Корзина пуста");
                    return;
                }
                else
                {
                    Console.Clear();

                    BasketDictionary = DictionaryOf.CreateADictionaryBasket(BasketUser._basketUser);
                    
                    Console.WriteLine("В корзине:");
                    BasketUser.PrintBasket(BasketDictionary);
                    Console.WriteLine ($"Общая сумма покупки {BasketUser.GetSummOrder()}");

                    Console.WriteLine("Введите номер продукта, если хотите его удалить.");
                    Console.WriteLine("Введите 0 для возврата в меню");
                    sbyte pick = Checks.CheckPick(BasketDictionary);
                    if (pick == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                        BasketUser.RemoveInBasketUser(pick, BasketDictionary);
                }
            }
        }

    }
}

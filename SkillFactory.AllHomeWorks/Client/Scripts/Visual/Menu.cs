using SkillFactory.AllHomeWorks.Server.Common.Scripts;

namespace SkillFactory.AllHomeWorks.Client.Scripts.Visual
{
    /// <summary>
    /// Меню - оно и в Африке меню
    /// </summary>
    internal class Menu
    {
        static sbyte pickButton;
        internal static void PrintMenu()
        {
            while (true)
            {
                
                
                Console.WriteLine("Пожалуйста, выберите дальнейшее действие:");
                Console.WriteLine();
                Console.WriteLine("1 - Посмотреть группы товаров");
                Console.WriteLine($"2 - Просмотр корзины. В корзине товаров: {Basket.PrintCount()}");
                Console.WriteLine("3 - Выбор способа получения товара");
                Console.WriteLine("4 - Просмотр состояния заказа");
                Console.WriteLine("0 - Выход из программы");

                pickButton = Checks.CheckPickMenu();
                

                if (pickButton == 0)
                    return;
                

                SwitchPick(pickButton);

            }
        }

        static void SwitchPick( sbyte pickButton)
        {
            switch (pickButton)
            {
                case 1:
                    ViewGroupProducts.PrintCategories();
                    break;
                case 2:
                    Basket.PrintBasket();
                    break;
                case 3:
                    Delivers.PickDeliver.PrintDelivers();
                    break;
                case 4:
                    Order.Print();
                    break;
            }
        }
    }
}

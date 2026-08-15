using SkillFactory.AllHomeWorks.Client.Scripts.Visual.Delivers.PickPointDelivery;
using SkillFactory.AllHomeWorks.Client.Scripts.Visual.Delivers.ShopDeliverys;
using SkillFactory.AllHomeWorks.Server.Common.Scripts;
using SkillFactory.AllHomeWorks.Server.Delivers;

namespace SkillFactory.AllHomeWorks.Client.Scripts.Visual.Delivers
{
    internal class PickDeliver

    {
        static sbyte pickButton;
        internal static void PrintDelivers()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите 0 для возврата в меню");
                Console.WriteLine("Выберите способ доставки:");
                Console.WriteLine();

                Console.WriteLine("1 - доставка на дом");
                Console.WriteLine("2 - доставка в магазин - партнеры ");
                Console.WriteLine("3 - доставка в наши магазины");
                pickButton = Checks.CheckPickWayDelivers();
                SwitchPick(ref pickButton);
                if (pickButton == 0)
                {
                    Console.Clear();
                    return;
                }

            }

        }


        static void SwitchPick(ref sbyte num)
        {
            switch (num)
            {
                case 1:
                   
                    Console.Clear();
                    Server.Order.Order.enumType = EnumTypeDelivers.HomeDelivery;
                    Console.WriteLine("Выбрана доставка на дом. В заказе проверьте свои данные");
                    Console.ReadLine();
                    break;
                case 2:
                    Server.Order.Order.enumType = EnumTypeDelivers.PickPointDelivery;
                    Console.Clear();
                    SwitchPickPoint.Print();

                    break;
                case 3:
                    Server.Order.Order.enumType = EnumTypeDelivers.ShopDelivery;
                    Console.Clear();
                    SwitchShopDelivery.Print();
                    break;
            }
        }
    }
}

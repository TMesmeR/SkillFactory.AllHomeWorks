using SkillFactory.AllHomeWorks.Server.Common.Scripts;
using SkillFactory.AllHomeWorks.Server.Delivers;

namespace SkillFactory.AllHomeWorks.Client.Scripts.Visual.Delivers.ShopDeliverys
{
    internal class SwitchShopDelivery
    {
        static sbyte num;
        internal static void Print()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Для возврата в предыдущее меню введите 0");
                Console.WriteLine("Выберите наш магазин для доставки:");
                Console.WriteLine("1 - \"Магазин на Таганке\". ул. Таганка д.123б");
                Console.WriteLine("2 - Магазин в \"Сити Хелл\". ТЦ \"Сити Хелл\" 2 этаж");
                Console.WriteLine("3 - Магазин в галерее \"Абракадабра\". ул. СмутыФпсовной 15/30 ");

                num = Checks.CheckPickWayDelivers();

                if (num == 0)
                {
                    Console.Clear();
                    return;
                }

                SwitchPick(num);


            }
        }


        static void SwitchPick(sbyte num)
        {
            switch (num)
            {
                case 1:
                    ShopDelivers.pointDeliveres = ShopDelivery.DeliveryShopTaganka;
                    Console.Clear();
                    Console.WriteLine("Выбран \"Магазин на Таганке\"");
                    Console.ReadLine();
                    break;
                case 2:
                    ShopDelivers.pointDeliveres = ShopDelivery.DeliveryShopCityHell;
                    Console.Clear();
                    Console.WriteLine("Выбран магазин в \"Сити Хелл\"");
                    Console.ReadLine();
                    break;
                case 3:
                    ShopDelivers.pointDeliveres = ShopDelivery.DeliveryShopGalleryAbrakadabra;
                    Console.Clear();
                    Console.WriteLine("Выбран магазин в галерее \"Абракадабра\"");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

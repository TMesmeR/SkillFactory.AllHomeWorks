using SkillFactory.AllHomeWorks.Server.Common.Scripts;
using SkillFactory.AllHomeWorks.Server.Delivers;

namespace SkillFactory.AllHomeWorks.Client.Scripts.Visual.Delivers.PickPointDelivery
{
    internal class SwitchPickPoint
    {
        static sbyte num;
        internal static void Print()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Для возврата в предыдущее меню введите 0");
                Console.WriteLine("Выберите удобный адрес доставки:");
                Console.WriteLine("1 - Магазин \"Пяторочка\". Здание музея \"Изнакурнож\"");
                Console.WriteLine("2 - Магазин \"Перекресток\". Бывшее здание \"ИИЧАВО\"");
                Console.WriteLine("3 - Магазин  \"Лента\". ул. Рога и Копыта. д.13/13 ");

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
                    PickPointDeliveres.pointDeliveres = PickPointDelivers.Pyatoroshka;
                    Console.Clear();    
                    Console.WriteLine("Выбран магазин Пяторочка");
                    Console.ReadLine();
                    break;
                case 2:
                    PickPointDeliveres.pointDeliveres = PickPointDelivers.Perekrestok;
                    Console.Clear();
                    Console.WriteLine("Выбран магазин Перекресток");
                    Console.ReadLine();
                    break;
                case 3:
                    PickPointDeliveres.pointDeliveres = PickPointDelivers.Lenta;
                    Console.Clear();
                    Console.WriteLine("Выбран магазин Лента");
                    Console.ReadLine();
                    break;
            }
        }
        
    }
}

using SkillFactory.AllHomeWorks.Server.Common.Scripts;
using SkillFactory.AllHomeWorks.Server.Order;

namespace SkillFactory.AllHomeWorks.Client.Scripts.Visual
{ /// <summary>
/// Console.WriteLine("Hell World");
/// </summary>
    internal static class Welcome
    {
        internal static void Print()
        {
            Console.WriteLine($"Добро пожаловать {ServerUser.clientUser.GetUserName()}");

            if (ServerUser.clientUser.GetBirthDay().Month == ServerTime.GetServerTime().Month
                && ServerUser.clientUser.GetBirthDay().Day == ServerTime.GetServerTime().Day)
            {
                Console.WriteLine($"{ServerUser.clientUser.GetUserName()} видим что вам исполнилось {ServerUser.clientUser.GetAge()}");
                Console.WriteLine($"Сегодня вы получите скидку в {ServerOrders.extensionOrder.GetDiscount()} процентов");
            }

        }
    }
}

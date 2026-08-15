using SkillFactory.AllHomeWorks.Server.Order;
using SkillFactory.AllHomeWorks.Server.User;

// Использовано глобальное имя ServerOrders
namespace SkillFactory.AllHomeWorks.Client.Scripts.Visual.Delivers
{
    internal  class HomeDelivers
    {
        private static int discount = ServerOrders.extensionOrder.GetDiscount();
        private static int sumDiscount = ServerOrders.extensionOrder.GetSummDiscount();
        internal static void HomeDeliver()
        {
            Console.Clear();
            Console.WriteLine("Подробности заказа:");
            Console.Write($"{ServerUser.clientUser.GetUserName()}, ");
            Console.WriteLine("Ваш заказ будет доставлен на дом");
            Console.WriteLine($"Адрес доставки: {ServerUser.clientUser.GetUserAdress()}");
            Console.WriteLine($"Доставка будет осуществлена в течении часа");
            Console.WriteLine($"Чек вы получите на вашу почту: {ServerUser.clientUser.GetEmail()}");
            Console.WriteLine();
            Console.WriteLine("//--------------------------------------------------//");
            Console.WriteLine($"Имя курьера: {ServerOrders.GetCourierName()}");
            Console.WriteLine($"Курьер приедет на машине : {ServerOrders.GetCarCourier().GetCarName()}");
            Console.WriteLine($"Цвет машины: {ServerOrders.GetCarCourier().CourierCar()}");
            Console.WriteLine($"Номер машины: {ServerOrders.GetCarCourier().GetNumberCar()}");
            Console.WriteLine($"Id машины: {ServerOrders.GetCarCourier().GetId()}");
            Console.WriteLine("В случае непредвиденных конфликтных ситуаций пожалуйста сообщите нам всю данную информацию") ;
            Console.WriteLine();
            Console.WriteLine("//--------------------------------------------------//");
            Console.WriteLine("Ваш заказ:");
            BasketUser.PrintBasket(ServerOrders.GetBasketUser());
            Console.WriteLine();
            Console.WriteLine($"Сумма заказа:{ServerOrders.GetSumm()}");

            if (discount != 0)
            {
                Console.Write("Ваша скидка: ");
                Console.WriteLine(discount);
                Console.WriteLine($"Сумма покупки с учетом скидки равна : {sumDiscount}");
            }
            Console.WriteLine();
            Console.WriteLine("Для возврата в меню введите Enter...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
using SkillFactory.AllHomeWorks.Server.Abstract.Classes;
using SkillFactory.AllHomeWorks.Server.Common.Scripts;
using SkillFactory.AllHomeWorks.Server.Delivers;
using SkillFactory.AllHomeWorks.Server.Delivers.Couriers;
using SkillFactory.AllHomeWorks.Server.User;

namespace SkillFactory.AllHomeWorks.Server.Order
{
    internal  class Order
    {
        internal static Order extensionOrder = new Order();
        internal static EnumTypeDelivers enumType = EnumTypeDelivers.HomeDelivery;
      

        internal static string GetCourierName() => CourierManager.RandomCurier().GetName(); //Возвращает рандомное имя из класса курьеров
        internal static CarCourier GetCarCourier () => CourierManager.RandomCurier().GetCar();// Возвращает автомобиль рандомного курьера

        internal static Dictionary <int,(string,int)> GetBasketUser()
        {
            if (BasketUser._basketUser != null)
                return BasketUser._basketUser;              
            return null;

        }

        internal static int GetSumm() => BasketUser.GetSummOrder();

        internal static string GetNameDeliveres<T>(T nameDeliveres) where T :abstractDeliver
        {
            
            return nameDeliveres.GetDeliveryPointName();

        }

        internal static string GetAddressDeliveres<T>(T addressDeliveres) where T: abstractDeliver
        {
            return addressDeliveres.GetAddressDelivery();
        }
       
    }

   internal  static class ExtensionOrder
    {

        internal static int GetDiscount(this Order order)
        {
            int discount = 0;
            if (User.User.clientUser.GetBirthDay().Month == ServerTime.GetServerTime().Month
               && User.User.clientUser.GetBirthDay().Day == ServerTime.GetServerTime().Day)
            {
                discount += 5;
            }
            if (Order.enumType == EnumTypeDelivers.HomeDelivery)
                discount+=0;
            else if (Order.enumType == EnumTypeDelivers.PickPointDelivery)
                discount+=3;
            else if (Order.enumType == EnumTypeDelivers.ShopDelivery) 
                discount += 5;

            return discount;
        }

        internal static int GetSummDiscount(this Order order)
        {
            int summ = Order.GetSumm();
            int discountSum = summ* ServerOrders.extensionOrder.GetDiscount()/100;
            return summ-discountSum;
            

        }
    }
}

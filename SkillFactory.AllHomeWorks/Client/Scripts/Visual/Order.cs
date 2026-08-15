using SkillFactory.AllHomeWorks.Client.Scripts.Visual.Delivers;
using SkillFactory.AllHomeWorks.Client.Scripts.Visual.Delivers.PickPointDelivery;
using SkillFactory.AllHomeWorks.Client.Scripts.Visual.Delivers.ShopDeliverys;
using SkillFactory.AllHomeWorks.Server.Delivers;

namespace SkillFactory.AllHomeWorks.Client.Scripts.Visual
{
    internal static class Order
    {
        
       internal static void Print()
        {
            if (ServerOrders.enumType == EnumTypeDelivers.HomeDelivery)
                HomeDelivers.HomeDeliver();
            else if (ServerOrders.enumType == EnumTypeDelivers.PickPointDelivery)
                PickPointDeliverys.PickPointDelivery();
            else
                ShopDeliverys.ShopDelivery();
        }

    

      

        

    }
}

using SkillFactory.AllHomeWorks.Server.Abstract.Classes;

namespace SkillFactory.AllHomeWorks.Server.Delivers
{
    internal class ShopDelivers:abstractDeliver
    {
        internal static Delivers.ShopDelivery pointDeliveres;
        internal static ShopDelivers PointDeliveres = new ShopDelivers();
        private string DeliveryPointName { get; set; }
        public ShopDelivers()
        {

            if (pointDeliveres == ShopDelivery.DeliveryShopTaganka)
            {
                DeliveryPointName = "\"Магазин на Таганке\"";
                base.AddressDelivery = "ул. Таганка д.123б";
            }
            if (pointDeliveres == ShopDelivery.DeliveryShopCityHell)
            {
                DeliveryPointName = "Магазин в \"Сити Хелл\"";
                base.AddressDelivery = "ТЦ \"Сити Хелл\" 2 этаж";

            }
            if (pointDeliveres == ShopDelivery.DeliveryShopGalleryAbrakadabra)
            {
                DeliveryPointName = "Магазин в галерее \"Абракадабра\"";
                base.AddressDelivery = "ул. СмутыФпсовной 15/30";

            }

        }

        internal override string GetDeliveryPointName() => DeliveryPointName;
    }
}

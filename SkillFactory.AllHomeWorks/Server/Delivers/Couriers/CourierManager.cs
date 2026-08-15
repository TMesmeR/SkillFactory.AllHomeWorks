namespace SkillFactory.AllHomeWorks.Server.Delivers.Couriers
{
    internal static class CourierManager
    {
        private static List<Courier> couriers = new List<Courier>();

        static CourierManager()
        {
            CarCourier car1 = new CarCourier("Вольво", "N321FS", 100);
            Courier courier1 = new Couriers.Courier("Tomas", car1);
            couriers.Add(courier1);

            CarCourier car2 = new CarCourier("Митсубиси", "N322FS", 101);
            Courier courier2 = new Courier("Alex", car2);
            couriers.Add(courier2);

            CarCourier car3 = new CarCourier("Субару", "N323FS", 102);
            Courier courier3 = new Courier("Alisa", car3);
            couriers.Add(courier3);
        }

        internal static Courier RandomCurier()
        {
            int z = Random.Shared.Next(0, 3);
            return couriers[z];
        }
        

    }
}

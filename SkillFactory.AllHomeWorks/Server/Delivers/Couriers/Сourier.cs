namespace SkillFactory.AllHomeWorks.Server.Delivers.Couriers
{
   

        internal class Courier
        {
            private string Name { get; set; }
            private CarCourier car;

            internal Courier(string name, CarCourier car)
            {
                Name = name;
                this.car = car;
            }

            internal string GetName() => Name;
            internal CarCourier GetCar() => car;
        }

    
}

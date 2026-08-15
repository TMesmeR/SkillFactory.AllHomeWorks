using SkillFactory.AllHomeWorks.Server.Delivers.Couriers;

namespace SkillFactory.AllHomeWorks.Server.Abstract.Classes
{
    internal abstract class abstractCarCurier<T>
    {
        private protected string _carName;
        private protected string _numberCar;
        private protected T _id;
        private protected CarCourier.ColorCar colorCar;
        internal string GetCarName() => _carName;
        internal string GetNumberCar() => _numberCar;

        internal T GetId() => _id;

        internal string CourierCar() => colorCar.GetColorCar();

    }
}

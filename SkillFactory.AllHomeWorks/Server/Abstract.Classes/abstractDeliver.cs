namespace SkillFactory.AllHomeWorks.Server.Abstract.Classes
{
    internal abstract class abstractDeliver
    {
        
       
        private protected  string AddressDelivery { get; set; }
        

        internal string GetAddressDelivery() => AddressDelivery;
        internal abstract string GetDeliveryPointName();
    }
}


using SkillFactory.AllHomeWorks.Server.Common.Scripts;

namespace SkillFactory.AllHomeWorks.Server.Abstract.Classes
{
    public abstract class abstractUser
    {
        private TimeSpan difference;//отрабатывает через Age - блок get
        private protected string UserName { get; set; }
        private protected string Email { get; set; }

        private protected DateTime Birthday { get; set; }

        private int _age;
        private protected int Age
        {
            get
            {
                difference = (ServerTime.GetServerTime().Subtract(Birthday));
                _age = (int)(difference.TotalDays / 365.25);
                return _age;
            }
            set
            {
                if (value < 14)
                    Console.WriteLine("Возраст пользователя должен быть больше 14 лет");
                else 
                    _age = value;
            }
        }
        private protected string UserAddress { get; set; }
 

        internal string GetUserName() => UserName;
        internal string GetEmail() => Email;
        internal string GetUserAdress() => UserAddress;
        internal int GetAge() => Age;
        
        internal DateTime GetBirthDay() => Birthday;

    }
}

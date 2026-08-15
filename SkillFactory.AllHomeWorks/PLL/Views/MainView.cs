namespace SkillFactory.AllHomeWorks.PLL.Views
{
    public class MainView
    {
        public void Show()
        {
            Console.WriteLine("Войти в профиль (нажмите 1)");
            Console.WriteLine("Зарегистрироваться (нажмите 2)");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        StartPoint.authenticationView.Show();
                        break;
                    }
                case "2":
                    {
                        StartPoint.registrationView.Show();
                        break;
                    }
            }
        }
    }
}

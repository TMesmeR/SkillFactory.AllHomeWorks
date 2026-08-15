using SkillFactory.AllHomeWorks.BLL.Exceptions;
using SkillFactory.AllHomeWorks.BLL.Models;
using SkillFactory.AllHomeWorks.BLL.Services;
using SkillFactory.AllHomeWorks.PLL.Helpers;

namespace SkillFactory.AllHomeWorks.PLL.Views
{
    public class AuthenticationView
    {
        UserService userService;

        public AuthenticationView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show()
        {
            var authenticationData = new UserAuthenticationData();

            Console.WriteLine("Введите почтовый адрес:");
            authenticationData.Email = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            authenticationData.Password = Console.ReadLine();

            try
            {
                User user = userService.Authenticate(authenticationData);

                SuccessMessage.Show("Вы успешно вошли в социальную сеть!");
                SuccessMessage.Show("Добро пожаловать" + user.FirstName);

                StartPoint.userMenuView.Show(user);

            }
            catch (WrongPasswordException)
            {
                AlertMessage.Show("Пароль не корректный");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден");
            }

        }
    }
}

using SkillFactory.AllHomeWorks.BLL.Services;
using SkillFactory.AllHomeWorks.DAL.Repositories;

namespace SkillFactory.AllHomeWorks.PLL.Views
{
    public class StartPoint
    {
        static MessageService messageService;
        static UserService userService;
        static FriendService friendService;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static FriendshipView friendshipView;


        public StartPoint()
        {
            messageService = new MessageService();
            userService = new UserService();
            friendService = new FriendService(new FriendRepository());

            mainView = new MainView();
            registrationView = new RegistrationView(userService);
            authenticationView = new AuthenticationView(userService);
            userMenuView = new UserMenuView(userService, friendService);
            userInfoView = new UserInfoView();
            userDataUpdateView = new UserDataUpdateView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();
            friendshipView = new FriendshipView(userService, friendService);
        }


        public void Start()
        {
            while (true)
            {
                mainView.Show();
            }
        }
    }
}

using SkillFactory.AllHomeWorks.DAL.Entities;
using SkillFactory.AllHomeWorks.DAL.Repositories;

namespace SkillFactory.AllHomeWorks.BLL.Services
{
    public class FriendService
    {
        private readonly IFriendRepository _friendRepository;

        public FriendService(IFriendRepository friendRepository)
        {
            _friendRepository = friendRepository;
        }

        public void AddFriend(int userId, int friendId)
        {
            FriendEntity friendEntity = new FriendEntity
            {
                user_id = userId,
                friend_id = friendId
            };

            _friendRepository.Create(friendEntity);
        }
    }
}

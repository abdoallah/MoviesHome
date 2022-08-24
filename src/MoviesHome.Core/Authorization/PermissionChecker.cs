using Abp.Authorization;
using MoviesHome.Authorization.Roles;
using MoviesHome.Authorization.Users;

namespace MoviesHome.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

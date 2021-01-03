using Microsoft.AspNetCore.Http;

namespace loosely_coupled.UILayer
{
    public class AspNetUserContextAdapter : IUserContext
    {
        private static HttpContextAccessor Accessor = new HttpContextAccessor();

        public bool IsInRole(Role role)
        {
            return Accessor.HttpContext.User.IsInRole(role.ToString());
        }
    }
}
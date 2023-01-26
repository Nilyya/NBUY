using DiariesFood.Entity.Concrete.Identity;

namespace DiariesFood.Web.Admin.Models.Dtos
{
    public class RoleDetailsDto
    {
        public Role Role { get; set; }
        public List<User> Members { get; set; }
        public List<User> NonMembers { get; set; }
    }
}

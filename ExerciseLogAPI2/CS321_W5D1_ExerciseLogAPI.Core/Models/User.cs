
namespace CS321_W5D1_ExerciseLogAPI.Core.Models
{
    // TODO: inherit from IdentityUser
    public class User 
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}

using System;

namespace TrangHoSoCaNhan.Models
{
    public class UserProfile
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ProfileImageBase64 { get; set; }
        public string Bio { get; set; }
        public string PhoneNumber { get; set; }
        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public string WorkExperience { get; set; }
        public string Education { get; set; }
        public string Skills { get; set; }
        public string Projects { get; set; }
        public string Certificates { get; set; }
        public string Hobbies { get; set; }
    }
}

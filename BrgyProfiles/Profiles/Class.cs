using System.ComponentModel.DataAnnotations;


namespace BrgyProfiles.Profiles
{
    public class Class
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Gender { get; set; } = string.Empty;
       
    }
}

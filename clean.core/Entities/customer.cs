using System.ComponentModel.DataAnnotations;

namespace clean.core.Entities
{
    public class customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string HMO { get; set; }

    }
}
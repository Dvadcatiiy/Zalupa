namespace Zalupa2.Models
{
    public class Personal
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }

        //public ICollection<Coffe> Coffes { get; set; }
    }
}

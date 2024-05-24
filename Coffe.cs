namespace Zalupa2.Models
{
    public class Coffe
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string Demand { get; set; } = string.Empty;

        public int Score { get; set; }

        //public Provider? Prov { get; set; }
        public virtual Provider Provider { get; set; }
    }
}

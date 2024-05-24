using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zalupa2.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string NameOrg { get; set; }
        public string Product { get; set; }

        //public ICollection<Coffe> Coffe{ get; set; }
        [InverseProperty("Provider")]
        public virtual ICollection<Coffe> Coffe { get; set; }
    }
}


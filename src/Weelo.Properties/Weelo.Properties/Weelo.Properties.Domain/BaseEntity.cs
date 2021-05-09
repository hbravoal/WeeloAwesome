using System.ComponentModel.DataAnnotations;

namespace Weelo.Properties.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}

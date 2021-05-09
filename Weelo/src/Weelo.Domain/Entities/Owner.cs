using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Weelo.Domain.Common;
using Weelo.Domain.Settings;

namespace Weelo.Domain.Entities
{
    [Table(nameof(SchemasConfiguration.Owner), Schema = nameof(SchemasConfiguration.Weelo))]
    public class Owner : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday{ get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}

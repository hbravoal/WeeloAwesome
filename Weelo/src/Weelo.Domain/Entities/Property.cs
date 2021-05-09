using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Weelo.Domain.Common;
using Weelo.Domain.Settings;

namespace Weelo.Domain.Entities
{
    [Table(nameof(SchemasConfiguration.Property), Schema = nameof(SchemasConfiguration.Weelo))]
    public class Property : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Address{ get; set; }
        public decimal Price { get; set; }
        public decimal CodeInternal{ get; set; }
        public string Year{ get; set; }


        #region Owner
        public int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
        #endregion
        public virtual ICollection<PropertyTrace> PropertyTraces { get; set; }
        public virtual ICollection<PropertyImage> PropertyImages { get; set; }
    }
}

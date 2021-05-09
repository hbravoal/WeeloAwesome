using System;
using System.ComponentModel.DataAnnotations.Schema;
using Weelo.Domain.Common;
using Weelo.Domain.Settings;

namespace Weelo.Domain.Entities
{
    [Table(nameof(SchemasConfiguration.PropertyTrace), Schema = nameof(SchemasConfiguration.Weelo))]
    public class PropertyTrace : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public decimal Tax{ get; set; }
        public DateTime DateSale { get; set; }
        public bool Enabled { get; set; }
        #region Property
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        #endregion
    }
}

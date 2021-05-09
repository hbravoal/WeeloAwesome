using System.ComponentModel.DataAnnotations.Schema;
using Weelo.Domain.Common;
using Weelo.Domain.Settings;

namespace Weelo.Domain.Entities
{
    [Table(nameof(SchemasConfiguration.PropertyImage), Schema = nameof(SchemasConfiguration.Weelo))]
    public class PropertyImage : AuditableBaseEntity
    {
        public string File { get; set; }
        public bool Enabled{ get; set; }

        #region Property
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        #endregion
    }
}

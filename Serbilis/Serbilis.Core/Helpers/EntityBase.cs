using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Serbilis.Core.Helpers
{
    public class EntityBase
    {
        [Key]
        [Column("Id")]
        public virtual Int32 Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }

}

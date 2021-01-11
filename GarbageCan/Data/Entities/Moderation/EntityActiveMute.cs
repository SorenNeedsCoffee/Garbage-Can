using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarbageCan.Data.Entities.Moderation
{
    [Table("moderationActiveMutes")]
    public class EntityActiveMute
    {
        [Key] public int id { get; set; }
        public ulong uId { get; set; }
        [Column(TypeName = "datetime")] public DateTime expirationDate { get; set; }
    }
}
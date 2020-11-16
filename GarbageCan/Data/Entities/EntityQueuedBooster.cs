﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarbageCan.Data.Entities
{
	[Table("xp_queued_boosters")]
	public class EntityQueuedBooster
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int position { get; set; }

		public float multiplier { get; set; }
		public long duration_in_seconds { get; set; }
	}
}
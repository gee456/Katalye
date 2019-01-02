﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Katalye.Data.Interfaces;
using Newtonsoft.Json.Linq;

namespace Katalye.Data.Entities
{
    public class JobMinionReturnEvent : IEntity, IAuditable
    {
        public Guid Id { get; set; }

        [Required]
        public Guid? JobMinionId { get; set; }

        [ForeignKey(nameof(JobMinionId))]
        public JobMinion JobMinion { get; set; }
        
        [NotMapped]
        public JObject ReturnData { get; set; }

        public bool Success { get; set; }

        public long ReturnCode { get; set; }

        public DateTimeOffset Timestamp { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset ModifiedOn { get; set; }
    }
}
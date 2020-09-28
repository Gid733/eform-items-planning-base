﻿using Microting.eForm.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Microting.ItemsPlanningBase.Infrastructure.Data.Entities
{
    public class PlanningsTagsVersion : BaseEntity
    {
        public int PlanningTagId { get; set; }
        public int PlanningId { get; set; }

        [ForeignKey("PlanningsTagsId")]
        public int PlanningsTagsId { get; set; }
    }
}

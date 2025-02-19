﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PCRApi.Models.Db
{
    public partial class ItemDatum
    {
        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public long PromotionLevel { get; set; }
        public long ItemType { get; set; }
        public long Value { get; set; }
        public long Price { get; set; }
        public long LimitNum { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}

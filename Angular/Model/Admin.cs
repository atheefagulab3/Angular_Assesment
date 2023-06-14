﻿using System.ComponentModel.DataAnnotations;

namespace Angular.Model
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string? AdminName { get; set; }
        public string? AdminPassword { get; set; }
    }
}

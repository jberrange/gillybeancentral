﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GillyBeanCentral.Entities
{
    [Table("ActivityOption")]
    public class ActivityOption
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string  ActivityName { get; set; }

        [MaxLength(255)]
        public string Byline { get; set; }

        [MaxLength(1024)]
        [Required]
        public string Description { get; set; }



    }
}
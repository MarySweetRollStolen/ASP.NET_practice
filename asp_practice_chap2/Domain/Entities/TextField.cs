﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp_practice_chap2.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Назва сторінки (заголовок)")]
        public override string Title { get; set; } = "Інформаційна сторінка";

        [Display(Name = "Зміст сторінки")]
        public override string Text { get; set; } = "Зміст сторінки запомнюється адміністратором";
    }
}
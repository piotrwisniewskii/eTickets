﻿using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name= "Logo")]
        [Required(ErrorMessage = "Cinema logo is required")]

        public string Logo { get; set; }

        [Display(Name= "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is required")]

        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema Description is required")]
        public string Description { get; set; }

        public List<NewMovieVM> Movies { get; set; }

    }
}

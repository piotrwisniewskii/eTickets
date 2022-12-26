using eTickets.Data.Base;
using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        [Required(ErrorMessage ="Name is required")]
        [Display(Description ="Movie name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Display(Description = "Movie Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Description = "Movie Price")]
        public double Price { get; set; }

        [Required(ErrorMessage = "ImageURL is required")]
        [Display(Description = "Movie ImageURL")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "StartDate is required")]
        [Display(Description = "Movie StartDate")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "EndDate is required")]
        [Display(Description = "Movie EndDate")]
        public DateTime EndDate {get; set; }

        [Required(ErrorMessage = "MovieCategory is required")]
        [Display(Description = "Movie MovieCategory")]
        public MovieCategory MovieCategory { get; set; }


        // Relationships
        [Required(ErrorMessage = "actors is required")]
        [Display(Description = "Select actors")]
        public List<int> ActorsIds { get; set; }

        //Cinema
        [Required(ErrorMessage = "Cinema is required")]
        [Display(Description = "Select Cinema")]
        public int CinemaId { get; set; }

        //Producer
        [Required(ErrorMessage = "Producer is required")]
        [Display(Description = "Select Producer")]
        public int ProducerId { get; set; }

}

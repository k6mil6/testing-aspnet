﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile picture URL")]
        public string ProfilePictureURL { get; set; }

		[Display(Name = "Full Name")]
		public string FullName { get; set;}

		[Display(Name = "Biography")]
		public string Bio { get; set; }


        //Relationship

        public List<ActorAndMovie> ActorsAndMovies { get; set;}
    }
}

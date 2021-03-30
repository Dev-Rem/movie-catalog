using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    /// <summary>Class <c> Movie </c> ORM Movie class defines fields to be create in the datababse </summary>
    public class Movie
    {
        /// <summary> attribute <c> Id </c> Id of Movie also database primary key </summary>
        public int Id { get; set; }

        /// <summary> attribute <c> Title </c> Title of Movie </summary>
        public string Title { get; set; }
        
       

        /// <summary> attribute <c> ReleaseDate </c> Release Date  of Movie. Time not needed </summary>
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        /// <summary> attribute <c> Genre </c> Genre of Movie </summary>
        public string Genre { get; set; }

        /// <summary> attribute <c> Price </c> Price of Movie </summary>
        public decimal Price { get; set; }

        // /// <summary> attribute <c> Rating </c> Rating of Movie </summary>
        // public string Rating { get; set; }
    }
}
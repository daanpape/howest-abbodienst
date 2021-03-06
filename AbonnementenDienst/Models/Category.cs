﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbonnementenDienst.Models
{
    /// <summary>
    /// This class represents the category of a magazine.
    /// </summary>
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public ICollection<Magazine> magazines { get; set; }
    }

    /// <summary>
    /// Metadata of the category
    /// </summary>
    public class CategoryMetaData
    {
        [Display(Name = "Categorie")]
        public int ID { get; set; }
        
        [Required(ErrorMessage = "De categorie moet een naam hebben")]
        [Display(Name = "Naam*")]
        public string name { get; set; }

        [Display(Name = "Omschrijving")]
        public string description { get; set; }

        public ICollection<Magazine> magazines { get; set; }
    }
}
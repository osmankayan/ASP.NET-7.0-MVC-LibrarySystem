﻿

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;



namespace Library.MODEL.Models
{
    public class Author:BaseEntity
    {
        //[ModelMetadataType(typeof(AuthorMetaData))]


        [Required(ErrorMessage ="giriş")]
        public string FirstName { get; set; }
      
        
        public string LastName { get; set; }

        //relational
        public List<Book>  Books { get; set; }
    }
}

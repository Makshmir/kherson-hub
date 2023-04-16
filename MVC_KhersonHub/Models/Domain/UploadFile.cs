using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace MVC_KhersonHub

{
    public class UploadFile

    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string RegisteredResidence { get; set; }
        [Required]
        public string ActualResidence { get; set; }
        [Required]
        public string IDP_number { get; set; }
        public int? Number_of_children { get; set; }
        public IFormFile MyImage { get; set; }







    }
}

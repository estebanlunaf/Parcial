using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectApi.Models
{
    public enum TypeList
    {
        Leo,
        Laura,
        Lisa,
        Leandro,
        Luis
    }
    public class Proyect
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        public string List { get; set; }
        [Required]
        public TypeList Type { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
        [Display(Description = "Proyect")]
        public string ProyectValue { get; set; }

    }
}

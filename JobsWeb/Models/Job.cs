using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobsWeb.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        [Required(ErrorMessage = "This Field is Required.")]

        [DisplayName("Job Title")]
        public String JobTitle { get; set; }
        [Column(TypeName = "nvarchar(200)")]



        [DisplayName("Publish Date")]
        public String PDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]


        [DisplayName("Last Date")]
        public String LDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]


        [DisplayName("NewsPaper")]
        public String NewsPaper { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        [DisplayName("Location")]
        public String Location { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebProgFinal.Models
{
    public class Person
    {
        private int ageCalculate(DateTime BirthDate)
        {
            DateTime now = DateTime.Today;

            int age = now.Year - BirthDate.Year - 1;

            if (BirthDate.Month < now.Month)
            {
                age++;
            }
            else if (BirthDate.Month == now.Month && BirthDate.Day < now.Day)
            {
                age++;
            }
            return age;
        }
        public int ID { get; set; }
        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [Column("LastName")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;
        [Column("BirthDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime Birthdate { get; set; }
        [Column("Gender")]
        public Genders Gender { get; set; }
        [Required]
        [Column("City")]
        public string City { get; set; } = string.Empty;
        [Column("Age")]
        public int Age
        {
            get { return ageCalculate(this.Birthdate); }

            set { }
        }
    }

    public enum Genders
    {
        Erkek = 0,
        Kadın = 1
    }
}

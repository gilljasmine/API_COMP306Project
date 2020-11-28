using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jasmine_Akshil_GroupProject_COMP306.Models
{
    public class Review
    {
        [Key]
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public string FacultyEmail { get; set; }
        public string CourseName { get; set; }
        public string FacultyReview {get;set;}
        public string StudentName { get; set; }

    }
}

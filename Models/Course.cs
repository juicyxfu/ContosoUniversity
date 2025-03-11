// CHANGE HISTORY
///////////////////////////////////////////////////////////////////////////////////////////////////
// DATE         DEVELOPER           DESCRIPTION
// 03-05-2025   adorog12@uw.edu     Created new Course class and initialize getter and setter
//                                  methods.
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
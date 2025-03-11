// CHANGE HISTORY
///////////////////////////////////////////////////////////////////////////////////////////////////
// DATE         DEVELOPER           DESCRIPTION
// 03-05-2025   adorog12@uw.edu     Created new Student class and initialize getter and setter
//                                  methods.
using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }

        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

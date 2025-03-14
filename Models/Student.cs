// Alexandria D'Oro-Gilbert
// T INFO 200 B
///////////////////////////////////////////////////////////////////////////////////////////////////
// CHANGE HISTORY
// DATE         DEVELOPER           DESCRIPTION
// 03-05-2025   adorog12@uw.edu     Created new Student class and initialize getter and setter
//                                  methods.
// 03-11-2025   adorog12@uw.edu     Add in EmailAddress getter-setter method for future
//                                  implimentation.
using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }

        public string FirstMidName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

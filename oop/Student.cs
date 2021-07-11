using System;

namespace oop {
    /// <summary>
    /// A Book Class
    /// @params name: Name of the student
    /// @params major: Major of the student
    /// @params gpa: GPA of the student.
    /// <code>Student student = new Student("Student", "author author", 3.6)</code>
    /// </summary>
    class Student {
        public string name;
        public string major;
        public double gpa;

        public Student(string name_, string major_, double gpa_) {
            Console.WriteLine("Creating Student");
            name = name_;
            major = major_;
            gpa = gpa_;
        }

        public string HasHonours() {
            if (gpa >= 3.5) return name+ " has honours";
            return name + " does not have honours";
        }
    }
}

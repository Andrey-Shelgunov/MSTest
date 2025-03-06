using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    // Класс для представления студента
    public class Student
    {
        public int StudentId { get; set; } // Уникальный идентификатор студента
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }

        public Student(int studentId, string firstName, string lastName, DateTime dateOfBirth, string email)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
        }

        public override string ToString() // Переопределение для более удобного вывода информации о студенте
        {
            return $"Student ID: {StudentId}, Name: {FirstName} {LastName}, Email: {Email}";
        }
    }
}

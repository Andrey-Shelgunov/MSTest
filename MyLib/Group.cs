using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    // Класс для представления учебной группы
    public class Group
    {
        public string GroupName { get; set; } // Название группы (например, "П-30")
        public List<Student> Students { get; set; } // Список студентов в группе

        public Group(string groupName)
        {
            GroupName = groupName;
            Students = new List<Student>(); // Инициализация списка студентов при создании группы
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Студент не может быть null."); // Обработка исключения, если студент null
            }
            if (!Students.Contains(student))
            {
                Students.Add(student);
                Console.WriteLine($"Студент {student.FirstName} {student.LastName} добавлен в группу {GroupName}.");
            }
            else
            {
                Console.WriteLine($"Студент {student.FirstName} {student.LastName} уже состоит в группе {GroupName}.");
            }
        }

        public void RemoveStudent(int studentId)
        {
            Student studentToRemove = Students.FirstOrDefault(s => s.StudentId == studentId); // LINQ - поиск студента по ID
            if (studentToRemove != null)
            {
                Students.Remove(studentToRemove);
                Console.WriteLine($"Студент с ID {studentId} удален из группы {GroupName}.");
            }
            else
            {
                Console.WriteLine($"Студент с ID {studentId} не найден в группе {GroupName}.");
            }
        }


        public override string ToString() // Переопределение для более удобного вывода информации о группе
        {
            return $"Group: {GroupName}, Students: {Students.Count}";
        }

        public void PrintStudents()  // Метод для вывода списка студентов в группе
        {
            Console.WriteLine($"Students in group {GroupName}:");
            if (Students.Count == 0)
            {
                Console.WriteLine("  (No students in this group)");
                return;
            }
            foreach (var student in Students)
            {
                Console.WriteLine($"  - {student}"); // Используем переопределение ToString() для студента
            }
        }
    }
}

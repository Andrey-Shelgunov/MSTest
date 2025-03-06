using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyLib
{
    // Класс для представления колледжа
    public class College
    {
        public string CollegeName { get; set; }
        public List<Group> Groups { get; set; }

        public College(string collegeName)
        {
            CollegeName = collegeName;
            Groups = new List<Group>(); // Инициализация списка групп при создании колледжа
        }

        public void AddGroup(Group group)
        {
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group), "Группа не может быть null."); // Обработка исключения, если группа null
            }

            if (!Groups.Contains(group))
            {
                Groups.Add(group);
                Console.WriteLine($"Группа {group.GroupName} добавлена в колледж {CollegeName}.");
            }
            else
            {
                Console.WriteLine($"Группа {group.GroupName} уже существует в колледже {CollegeName}.");
            }

        }

        public void RemoveGroup(string groupName)
        {
            Group groupToRemove = Groups.FirstOrDefault(g => g.GroupName == groupName); // LINQ - поиск группы по имени
            if (groupToRemove != null)
            {
                Groups.Remove(groupToRemove);
                Console.WriteLine($"Группа {groupName} удалена из колледжа {CollegeName}.");
            }
            else
            {
                Console.WriteLine($"Группа {groupName} не найдена в колледже {CollegeName}.");
            }
        }

        public void PrintGroups()  // Метод для вывода списка групп в колледже
        {
            Console.WriteLine($"Groups in {CollegeName}:");
            if (Groups.Count == 0)
            {
                Console.WriteLine("  (No groups in this college)");
                return;
            }
            foreach (var group in Groups)
            {
                Console.WriteLine($"  - {group}"); // Используем переопределение ToString() для группы
            }
        }

        // Метод для поиска студента во всех группах
        public Student FindStudent(int studentId)
        {
            foreach (var group in Groups)
            {
                Student foundStudent = group.Students.FirstOrDefault(s => s.StudentId == studentId);
                if (foundStudent != null)
                {
                    return foundStudent;
                }
            }
            return null; // Если студент не найден
        }
    }
}


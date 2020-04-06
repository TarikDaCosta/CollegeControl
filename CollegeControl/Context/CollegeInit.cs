using CollegeControl.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CollegeControl.Context
{
    public class CollegeInit : CreateDatabaseIfNotExists<CollegeContext>
    {
        protected override void Seed(CollegeContext context)
        {
            List<Courses> courses = new List<Courses>()
            {
                new Courses() {Name = "Ciências da Computação"},
                new Courses() {Name = "Engenharia de Software"},
                new Courses() {Name = "Analise de Sistemas"}
            };
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            List<Student> student = new List<Student>()
            {
                new Student() {
                    Name = "José da Silva", 
                    Birth = DateTime.Parse("01/12/1992"),
                    Registration = 1
                },
                new Student() {
                    Name = "Miguel Frantz",
                    Birth = DateTime.Parse("05/05/1993"),
                    Registration = 2
                },
                new Student() {
                    Name = "Leonardo Bratti",
                    Birth = DateTime.Parse("14/03/1991"),
                    Registration = 3
                },
                new Student() {
                    Name = "Gustavo Baptista",
                    Birth = DateTime.Parse("22/06/1996"),
                    Registration = 4
                },
                new Student() {
                    Name = "Cintia Salles",
                    Birth = DateTime.Parse("25/09/1995"),
                    Registration = 5
                },
                new Student() {
                    Name = "Camila Pereira",
                    Birth = DateTime.Parse("26/06/1992"),
                    Registration = 6
                },
                new Student() {
                    Name = "Luiz Testoni",
                    Birth = DateTime.Parse("01/10/1988"),
                    Registration = 7
                },
                new Student() {
                    Name = "Jane da Costa",
                    Birth = DateTime.Parse("04/07/1993"),
                    Registration = 8
                },
                new Student() {
                    Name = "Maria Madalena",
                    Birth = DateTime.Parse("05/06/1992"),
                    Registration = 9
                },
                new Student() {
                    Name = "Carlos Bridi",
                    Birth = DateTime.Parse("26/04/1991"),
                    Registration = 10
                },
                new Student() {
                    Name = "Marta Schimit",
                    Birth = DateTime.Parse("12/02/1992"),
                    Registration = 11
                },
                new Student() {
                    Name = "Marcelo Rodrigues",
                    Birth = DateTime.Parse("22/08/1991"),
                    Registration = 12
                },
                new Student() {
                    Name = "Bruna Roque",
                    Birth = DateTime.Parse("02/10/1992"),
                    Registration = 13
                },
                new Student() {
                    Name = "Otavio Felipe",
                    Birth = DateTime.Parse("04/12/1992"),
                    Registration = 14
                }

            };
            student.ForEach(s => context.Student.Add(s));
            context.SaveChanges();

            List<Teachers> teachers = new List<Teachers>()
            {
                new Teachers()
                {
                    Name = "Fabiene Brasil",
                    Birth = DateTime.Parse("01/10/1987"),
                    Salary = 1300.00m
                },
                new Teachers()
                {
                    Name = "Vanessa Gomes",
                    Birth = DateTime.Parse("01/10/1987"),
                    Salary = 986.00m
                },
                new Teachers()
                {
                    Name = "Félix Saloio Salgueiro",
                    Birth = DateTime.Parse("18/06/1981"),
                    Salary = 2450.00m
                },
                new Teachers()
                {
                    Name = "Rahyssa Jobim Albuquerque",
                    Birth = DateTime.Parse("05/09/1981"),
                    Salary = 1857.00m
                },
                new Teachers()
                {
                    Name = "Catalin Poças Guterres",
                    Birth = DateTime.Parse("07/11/1989"),
                    Salary = 1234.00m
                },
                new Teachers()
                {
                    Name = "Kimi Jordão Escobar",
                    Birth = DateTime.Parse("13/02/1985"),
                    Salary = 1812.00m
                },
                new Teachers()
                {
                    Name = "Amir Faustino Valadão",
                    Birth = DateTime.Parse("06/02/2001"),
                    Salary = 986.00m
                }
            };
            teachers.ForEach(t => context.Teachers.Add(t));
            context.SaveChanges();

            List<Subjects> subjects = new List<Subjects>()
            {
                new Subjects()
                {
                    Name = "Fundamentals of Programming",
                    CoursesId = 1,
                    TeachersId = 15
                },
                new Subjects()
                {
                    Name = "Data Structures",
                    CoursesId = 1,
                    TeachersId = 16
                },
                new Subjects()
                {
                    Name = "Introduction to Algorithms",
                    CoursesId = 2,
                    TeachersId = 17
                },
                new Subjects()
                {
                    Name = "Operating Systems",
                    CoursesId = 2,
                    TeachersId = 18
                },
                new Subjects()
                {
                    Name = "Computer Architecture",
                    CoursesId = 3,
                    TeachersId = 19
                },
                new Subjects()
                {
                    Name = "Programming Languages",
                    CoursesId = 3,
                    TeachersId = 20
                },
                new Subjects()
                {
                    Name = "Discrete Mathematics",
                    CoursesId = 2,
                    TeachersId = 21
                },
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();

            List<Grades> grades = new List<Grades>()
            {
                
                new Grades()
                {
                StudentId= 2,
                SubjectsId= 3,
                Grade = 7.9m
                },
                new Grades()
                {
                StudentId= 13,
                SubjectsId= 2,
                Grade= 2.2m
                },
                new Grades()
                {
                StudentId = 8,
                SubjectsId = 1,
                Grade = 6.1m
                },
                new Grades()
                {
                StudentId = 10,
                SubjectsId = 3,
                Grade = 4.8m
                },
                new Grades()
                {
                StudentId = 4,
                SubjectsId = 7,
                Grade = 6.9m
                },
                new Grades()
                {
                StudentId = 9,
                SubjectsId = 6,
                Grade = 2.3m
                },
                new Grades()
                {
                StudentId = 2,
                SubjectsId = 7,
                Grade = 5.5m
                },
                new Grades()
                {
                StudentId = 8,
                SubjectsId = 3,
                Grade = 8.9m
                },
                new Grades()
                {
                StudentId = 13,
                SubjectsId = 3,
                Grade = 7.7m
                },
                new Grades()
                {
                StudentId = 11,
                SubjectsId = 7,
                Grade = 7.7m
                },
                new Grades()
                {
                StudentId = 11,
                SubjectsId = 7,
                Grade = 7m
                },
                new Grades()
                {
                StudentId = 10,
                SubjectsId = 7,
                Grade = 0.9m
                },
                new Grades()
                {
                StudentId = 14,
                SubjectsId = 6,
                Grade = 6.1m
                },
                new Grades()
                {
                StudentId = 2,
                SubjectsId = 5,
                Grade = 5.8m
                },
                new Grades()
                {
                StudentId = 11,
                SubjectsId = 4,
                Grade = 9.3m
                },
                new Grades()
                {
                StudentId = 1,
                SubjectsId = 5,
                Grade = 7.5m
                },
                new Grades()
                {
                StudentId = 13,
                SubjectsId = 7,
                Grade = 0.9m
                },
                new Grades()
                {
                StudentId = 14,
                SubjectsId = 2,
                Grade = 6.3m
                },
                new Grades()
                {
                StudentId = 14,
                SubjectsId = 4,
                Grade = 1.5m
                },
                new Grades()
                {
                StudentId = 12,
                SubjectsId = 3,
                Grade = 3.6m
                },
                new Grades()
                {
                StudentId = 10,
                SubjectsId = 6,
                Grade = 8.2m
                }

            };
            grades.ForEach(g => context.Grades.Add(g));
            context.SaveChanges();
        }
    }
}
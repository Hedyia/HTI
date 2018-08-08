using System.Collections.ObjectModel;
using HTI.Models;

namespace HTI.Services
{
    public class CourseService : ICoursesService
    {
        private ObservableCollection<Course> _courses;
        public ObservableCollection<Course> GetCourses()
        {
            if (_courses == null)
            {
                _courses = new ObservableCollection<Course>
                {
                    new Course
                    {
                        CourseId = "CSC 414",
                        CourseName = "Software Engineering (2)",
                        CourseDescription = "The aim of the module is to provide an understanding of the methodologies, considerations and issues particular to software projects management. The module provides knowledge and hands-on experience of the techniques practiced and tools used to plan and manage software projects in its different stages. The module further aims to build basic project management skills by highlighting the concepts of team building, organizational behaviour, motivational theories, and of the role of good management in the successful and timely delivery of software projects. ",
                        ProfName = "Eid Abelhakeem",
                        Units = 4,
                        PdfFileName = "softwareengineering",
                        PlayListUrl = "https://www.youtube.com/playlist?list=PLDDGPdw7e6Ag1EIznZ-m-qXu4XX3A0cIz",
                        Image = "software_engineering",
                        Specialist = Specialist.IS,
                        IsFavoirate = false
                    },
                    new Course
                    {
                        CourseId = "BSC 220",
                        CourseName = "Operations Research",
                        CourseDescription ="The aim of this module is to introduce various aspects of Operations Research to ICS students, with special emphasis on modelling. ",
                        ProfName = "Rania Ragab",
                        Units = 3,
                        PlayListUrl = "https://www.youtube.com/playlist?list=PLgA4wLGrqI-ll9OSJmR5nU4lV4_aNTgKx",
                        Image = "or",
                        IsFavoirate = false

                    },
                    new Course
                    {
                        CourseId = "CSC 110",
                        CourseName = "Introduction to Computer Programming",
                        CourseDescription = "This course is a first step into the world of computer science," +
                        " and whether you want to become a software engineer, or collaborate with software engineers, " +
                        "this course is for you. You'll be prepared for intermediate-level computer science classes when you've mastered the concepts covered in this course.",
                        ProfName = "Rania Ragab",
                        Units = 4,
                        PlayListUrl = "https://www.youtube.com/playlist?list=PLvJoKWRPIu8G6Si7LlvmBPA5rOJ9BA29R",
                        Image = "ics",
                        Specialist = Specialist.CS,
                        IsFavoirate = false

                    },
                    new Course
                    {
                        CourseId = "INF 311",
                        CourseName = "Database Management Systems 1",
                        CourseDescription = "A relational database management system is a database management system based on the relational model invented by Edgar F. Codd at IBM's San Jose Research Laboratory. ",
                        ProfName = "Muhammed Aboelfadl",
                        Units = 4,
                        PlayListUrl = "https://www.youtube.com/playlist?list=PL5H3smBFNEEg5uGMYKiuzJiqxxTg2ulzb",
                        Image = "dbms",
                        Specialist = Specialist.IS,
                        IsFavoirate = false

                    }
                };
            }
            return _courses;
        }
    }
}

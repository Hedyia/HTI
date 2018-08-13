using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using HTI.Helpers;
using HTI.Models;

namespace HTI.Services
{
    public class CourseService 
    {
        private ObservableCollection<Course> _courses;
        private ObservableCollection<CourseSpecialist> _specialist;
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
                        //Image = "software_engineering",
                        Specialist = Specialist.IS,
                        IsFavoirate = true
                    },
                    new Course
                    {
                        CourseId = "BSC 220",
                        CourseName = "Operations Research",
                        CourseDescription ="The aim of this module is tqo introduce various aspects of Operations Research to ICS students, with special emphasis on modelling. ",
                        ProfName = "Rania Ragab",
                        Units = 3,
                        PlayListUrl = "https://www.youtube.com/playlist?list=PLgA4wLGrqI-ll9OSJmR5nU4lV4_aNTgKx",
                       // Image = "or",
                        IsFavoirate = false,
                        Specialist = Specialist.BSC

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
                        //Image = "ics",
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
                        //Image = "dbms",
                        Specialist = Specialist.IS,
                        IsFavoirate = false
                    },
                    new Course
                    {
                        CourseId = "BSC 122",
                        CourseName = "Electronics 2",
                        CourseDescription = "Electronics is the discipline dealing with the development and application of devices and systems involving the flow of electrons in a vacuum, in gaseous media, and in semiconductors.",
                        ProfName = "Muhammed Aboelfadl",
                        PdfFileName="electronics2",
                        Units = 4,
                        PlayListUrl = "https://www.youtube.com/playlist?list=PLBajgtqPAZzBIMM0q7zRdC3vFWjvuCqac",
                        //Image = "dbms",
                        Specialist = Specialist.BSC,
                        IsFavoirate = true
                    },
                    new Course
                    {
                        CourseId = "INF 211",
                        CourseName = "Introduction to Information systems",
                        CourseDescription = "is a man-made system that facilitates an organization's operational functions and supports management decision-making by providing information that managers can use to plan and control the activities of the firm.",
                        ProfName = "Muhammed Aboelfadl",
                        PdfFileName="inf",
                        Units = 4,
                        PlayListUrl = "https://www.youtube.com/playlist?list=PLzr5fRV1AGV9EBDnqI73HiI39KggzWX3y",
                        //Image = "dbms",
                        Specialist = Specialist.IS,
                        IsFavoirate = true
                    }


                };

            }
            return _courses;
        }
        public ObservableCollection<CourseSpecialist> GetCourseSpecialists()
        {
            if (_specialist == null)
            {
                _specialist = new ObservableCollection<CourseSpecialist>()
                {
                    new CourseSpecialist
                    {
                        Name = "BSC",
                        Specialist = Specialist.BSC
                    },
                    new CourseSpecialist
                    {
                        Name = "CS",
                        Specialist = Specialist.CS
                    },
                    new CourseSpecialist
                    {
                        Name = "IT",
                        Specialist = Specialist.IT
                    },
                    new CourseSpecialist
                    {
                        Name = "IS",
                        Specialist = Specialist.IS
                    },
                     new CourseSpecialist
                    {
                        Name = "ALL",
                        Specialist = Specialist.ALL
                    },

                };

            }
            return _specialist;
        }
    }
}

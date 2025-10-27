using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class StudyProgram
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private List<Course> courses = new List<Course>();
        public List<Course> Courses
        {
            get
            {
                return courses;
            }
            set
            {
                courses = value;
            }
        }
        public StudyProgram(string name)
        {
            this.name = name;
        }

        public void ShowOverview()
        {
            Console.WriteLine($"Programma: {Name}\n");
            foreach (Course course in Courses)
            {
                course.ShowOverview();
            }
        }
        public static void DemoStudyProgram()
        {
            //bug 1 en oplossing
            //Course communicatie = new Course("Communicatie");
            //Course programmeren = new Course("Programmeren");
            //Course databanken = new Course("Databanken");
            //List<Course> coursesProgrammeren = new List<Course>() { communicatie, programmeren, databanken };
            ////aanpassing na eerste bug: nieuwe courses
            //List<Course> coursesSNB = new List<Course>() { communicatie, programmeren, databanken };
            //StudyProgram programmerenProgram = new StudyProgram("Programmeren");
            //StudyProgram snbProgram = new StudyProgram("Systeem- en netwerkbeheer");
            //programmerenProgram.Courses = coursesProgrammeren;
            //snbProgram.Courses = coursesSNB;
            ////we willen hieronder Databanken schrappen uit het programma SNB
            //snbProgram.Courses.Remove(databanken);
            //programmerenProgram.ShowOverview();
            //snbProgram.ShowOverview();

            //bug 2
            //Course communicatie = new Course("Communicatie");
            //Course programmeren = new Course("Programmeren");
            //Course databanken = new Course("Databanken");
            //List<Course> coursesProgrammeren = new List<Course>() { communicatie, programmeren, databanken };
            //List<Course> coursesSNB = new List<Course>() { communicatie, programmeren, databanken };
            //StudyProgram programmerenProgram = new StudyProgram("Programmeren");
            //StudyProgram snbProgram = new StudyProgram("Systeem- en netwerkbeheer");
            //programmerenProgram.Courses = coursesProgrammeren;
            //snbProgram.Courses = coursesSNB;
            ////we willen hieronder Databanken schrappen uit het programma SNB
            //snbProgram.Courses.Remove(databanken);
            ////voor SNB wordt de titel van de cursus Programmeren veranderd naar "Scripting"
            //snbProgram.Courses[1].Title = "Scripting";
            //programmerenProgram.ShowOverview();
            //snbProgram.ShowOverview();

            //bug 2  oplossing
            Course communicatie = new Course("Communicatie");
            Course programmeren = new Course("Programmeren");
            Course databanken = new Course("Databanken");
            //nieuwe cursus
            Course scripting = new Course("programmeren");
            List<Course> coursesProgrammeren = new List<Course>() { communicatie, programmeren, databanken };
            //aanpassing met scripting
            List<Course> coursesSNB = new List<Course>() { communicatie, scripting, databanken };
            StudyProgram programmerenProgram = new StudyProgram("Programmeren");
            StudyProgram snbProgram = new StudyProgram("Systeem- en netwerkbeheer");
            programmerenProgram.Courses = coursesProgrammeren;
            snbProgram.Courses = coursesSNB;
            //we willen hieronder Databanken schrappen uit het programma SNB
            snbProgram.Courses.Remove(databanken);
            //voor SNB wordt de titel van de cursus Programmeren veranderd naar "Scripting"
            snbProgram.Courses[1].Title = "Scripting";
            programmerenProgram.ShowOverview();
            snbProgram.ShowOverview();
        }

        public void SetCourses(List<Course> courses)
        {
            this.courses = courses;
        }
    }
}

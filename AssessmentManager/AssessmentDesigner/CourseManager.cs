using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssessmentManager.CONSTANTS;

namespace AssessmentManager
{
    public class CourseManager
    {

        private List<Course> courses = new List<Course>();
        private TreeView tree;

        public CourseManager()
        {

        }

        #region Properties

        public List<Course> Courses => courses;

        #endregion

        #region Methods

        public void Initialise(TreeView tv)
        {
            //Record the tree view to be used
            tree = tv;
            string p = Application.StartupPath + "\\" + COURSES_FOLDER_NAME;
            //Create 'Courses' folder if doesn't already exist
            if (!Directory.Exists(p))
            {
                Directory.CreateDirectory(p);
            }

            //Read all courses and load them into the list. Method returns any errors.
            List<string> errors = LoadAllCourses(p);

            //Report any errors
            if (errors.Count > 0)
            {
                string erroredCourses = "";
                foreach (var e in errors)
                    erroredCourses += e + "\n";
                MessageBox.Show($"Unable to load course information from the following folder(s): \n\n {erroredCourses}", "Error loading some courses");
            }

            //Fill the tree view.
            RebuildTreeView();
        }

        private List<string> LoadAllCourses(string coursesPath)
        {
            List<string> errors = new List<string>();
            string[] dirs = Directory.GetDirectories(coursesPath);
            if (dirs.Count() > 0)
            {
                for (int i = 0; i < dirs.Count(); i++)
                {
                    string[] files = Directory.GetFiles(dirs[i]);
                    string path = null;
                    try
                    {
                        path = (from t in files
                                where Path.GetExtension(t) == COURSE_EXT
                                select t).First();
                    }
                    catch { }
                    if (!path.NullOrEmpty())
                    {

                        Course c = LoadCourse(path);
                        if (c != null)
                            courses.Add(c);
                        else
                            errors.Add(path);
                    }
                }
            }
            return errors;
        }

        public void RegisterNewCourse(Course course)
        {
            course.SetIdDirect(RandomCourseID());
            SerialiseCourse(course);
            courses.Add(course);
            RebuildTreeView();
        }

        public void SerialiseCourse(Course course)
        {
            string path = course.GetCoursePath();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            try
            {
                string filePath = course.GetFilePath();
                using (FileStream s = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(s, course);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save course information: \n\n" + ex.Message);
            }
        }

        public Course LoadCourse(string path)
        {
            Course c = null;
            try
            {
                using (FileStream s = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    c = (Course)bf.Deserialize(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load course information: \n\n" + ex.Message);
            }
            return c;
        }

        public void RebuildTreeView()
        {
            tree.Nodes.Clear();
            if (courses.Count > 0)
            {
                foreach (var c in courses)
                {
                    CourseNode cn = BuildCourseNodeFor(c);
                    tree.Nodes.Add(cn);
                }
            }
        }

        public void RebuildTreeView(string criteria)
        {
            tree.Nodes.Clear();
            if (courses.Count > 0)
            {
                foreach(var c in courses.Where(co => co.CourseTitle.Contains(criteria)))
                {
                    CourseNode cn = BuildCourseNodeFor(c);
                    tree.Nodes.Add(cn);
                }
            }
        }

        public CourseNode BuildCourseNodeFor(Course course)
        {
            CourseNode node = new CourseNode(course);
            //TODO:: Fill the children nodes with any assessments deployed under this course.
            return node;
        }

        public string RandomCourseID()
        {
            //Check to make sure that no other course has this same id
            string id = "";
            do
            {
                id = Util.RandomString(6);
            } while (id.NullOrEmpty() && courses.Where(c => c.ID == id).Any());
            return id;
        }

        #endregion
    }
}

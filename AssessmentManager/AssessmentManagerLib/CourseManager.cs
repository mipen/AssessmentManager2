using Microsoft.VisualBasic.FileIO;
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
        private static CourseManager instance;
        private static string coursesDir = "";

        public CourseManager()
        {
        }

        #region Properties

        public List<Course> Courses => courses;
        public static CourseManager Instance => instance;

        #endregion

        #region Methods

        public void Initialise(TreeView tv, CourseManager instance)
        {
            //Record the instance of itself for access elsewhere
            CourseManager.instance = instance;
            //Record the tree view to be used
            tree = tv;
            string p = Application.StartupPath + "\\" + COURSES_FOLDER_NAME;
            //Create 'Courses' folder if doesn't already exist
            if (!Directory.Exists(p))
            {
                Directory.CreateDirectory(p);
            }
            coursesDir = p;

            //Read all courses and load them into the list. Method returns any errors.
            List<string> errors = LoadAllCourses(p);

            //Report any errors
            if (errors.Count > 0)
            {
                string erroredCourses = "";
                foreach (var e in errors)
                    erroredCourses += e + "\n";
                string end = errors.Count == 1 ? "a course" : "some courses";
                MessageBox.Show($"Unable to load course information from the following folder(s): \n\n {erroredCourses}", $"Error loading {end}");
            }

            //Fill the tree view.
            RebuildTreeView();
        }

        private List<string> LoadAllCourses(string coursesPath)
        {
            //TODO:: Load all assessments from course dir
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

        public bool SerialiseSession(AssessmentSession session, string filePath)
        {
            try
            {
                using (FileStream s = File.Open(@filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(s, session);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save assessment session: \n\n" + ex.Message);
                return false;
            }

            return true;
        }

        public string CreateAssessmentDir(AssessmentSession session, string coursePath)
        {
            try
            {
                string dirName = Path.Combine(@coursePath, RandomAssessmentID(session, @coursePath));
                if (!Directory.Exists(dirName))
                    Directory.CreateDirectory(dirName);
                return dirName;
            }
            catch (Exception e)
            {
                throw e;
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
                tree.Sort();
            }
        }

        public void RebuildTreeView(string criteria)
        {
            tree.Nodes.Clear();
            if (courses.Count > 0)
            {
                foreach (var c in courses.Where(co => co.CourseTitle.Contains(criteria)))
                {
                    CourseNode cn = BuildCourseNodeFor(c);
                    tree.Nodes.Add(cn);
                }
                tree.Sort();
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
            } while (id.NullOrEmpty() || courses.Where(c => c.ID == id).Any());
            return id;
        }

        public string RandomAssessmentID(AssessmentSession session, string coursePath)
        {
            if (Directory.Exists(@coursePath))
            {
                string[] dirs = Directory.GetDirectories(@coursePath);
                if (dirs.Count() > 0)
                {
                    string id = "";
                    do
                    {
                        id = Util.RandomString(6);
                    } while (id == "" || dirs.Where(c => c.EndsWith(id)).Any());

                    return session.AssessmentName + " - " + id;
                }
                else
                {
                    string id = Util.RandomString(6);
                    return session.AssessmentName + " - " + id;
                }
            }
            else
                throw new ArgumentException("Cannot find specified path: \n\n" + coursePath, "coursePath");
        }

        public DialogResult DeleteCourse(Course course)
        {
            //Delete the course's folder
            try
            {
                FileSystem.DeleteDirectory(course.GetCoursePath(), UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
            }
            catch (OperationCanceledException)
            {
                return DialogResult.No;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error removing course with ID: " + course.ID + "\n\n" + e.Message, "Error");
            }
            //Remove the course from the list
            courses.Remove(course);
            return DialogResult.Yes;
        }

        public string PathForCourse(string ID)
        {
            if (!Courses.Where(c => c.ID == ID).Any())
                throw new ArgumentException($"No course with ID: {ID} registered", "ID");

            string path = Path.Combine(coursesDir, ID);
            if (Directory.Exists(path))
                return path;
            else
                throw new ArgumentException($"Cannot find directory for course with ID: {ID}", "ID");
        }

        #endregion
    }
}

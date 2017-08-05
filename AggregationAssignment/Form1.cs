using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AggregationAssignment
{
    public partial class frmCourseInfo : Form
    {
        public frmCourseInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Show course list in list box
            List<Course> courseList = CourseDB.GetCourseList();
            PopulateCourseListBox(courseList);
        }

        private void btnViewInstructor_Click(object sender, EventArgs e)
        {
            // Show instructor info for the selected course
            if (lstCourses.SelectedIndex >= 0)
            {
                Course c = lstCourses.SelectedItem as Course;
                Instructor i = c.getInstructor();
                MessageBox.Show($"Name: {i}\nEmail: {i.Email}\nOffice: {i.OfficeLocation}"
                    , "Course Instructor");
            }
        }

        private void btnViewRoster_Click(object sender, EventArgs e)
        {
            // Show student roster info for the selected course
            if (lstCourses.SelectedIndex >= 0)
            {
                Course c = lstCourses.SelectedItem as Course;
                List<Student> roster = c.LoadRoster();

                string stuRoster = "";
                foreach (Student s in roster)
                {
                    stuRoster += s.ToString() + "\n";
                }
                MessageBox.Show(stuRoster,"Student Roster");
            }
        }

        private void PopulateCourseListBox(List<Course> courseList)
        {
            foreach (Course c in courseList)
            {
                lstCourses.Items.Add(c);
            }
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex < 0)
                return;

            var selectedCourse = lstCourses.SelectedItem as Course;
            txtCourseNumber.Text = selectedCourse.Number;
            txtCourseTitle.Text = selectedCourse.Title;
            txtCourseDescription.Text = selectedCourse.Description;
            txtCourseCredits.Text = selectedCourse.NumberOfCredits.ToString();

        }
    }
}

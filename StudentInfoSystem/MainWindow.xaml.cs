using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;

        public MainWindow()
        {
            InitializeComponent();
            DisableTextBoxes();
        }

        void ClearAllText()
        {
            textFirstName.Text = string.Empty;
            textMidName.Text = string.Empty;
            textLastName.Text = string.Empty;
            textFaculty.Text = string.Empty;
            textSpecialty.Text = string.Empty;
            textDegree.Text = string.Empty;
            textStatus.Text = string.Empty;
            textFacNum.Text = string.Empty;
            textCourse.Text = string.Empty;
            textStream.Text = string.Empty;
            textGroup.Text = string.Empty;
        }

        void DisableTextBoxes()
        {
            textFirstName.IsEnabled = false;
            textMidName.IsEnabled = false;
            textLastName.IsEnabled = false;
            textFaculty.IsEnabled = false;
            textSpecialty.IsEnabled = false;
            textDegree.IsEnabled = false;
            textStatus.IsEnabled = false;
            textFacNum.IsEnabled = false;
            textCourse.IsEnabled = false;
            textStream.IsEnabled = false;
            textGroup.IsEnabled = false;
        }

        public void EnableTextBoxes()
        {
            textFirstName.IsEnabled = true;
            textMidName.IsEnabled = true;
            textLastName.IsEnabled = true;
            textFaculty.IsEnabled = true;
            textSpecialty.IsEnabled = true;
            textDegree.IsEnabled = true;
            textStatus.IsEnabled = true;
            textFacNum.IsEnabled = true;
            textCourse.IsEnabled = true;
            textStream.IsEnabled = true;
            textGroup.IsEnabled = true;
        }

        //void ClearAllText(Control con)
        //{
        //    foreach (Control c in con.Controls)
        //    {
        //        if (c is TextBox)
        //            ((TextBox)c).Clear();
        //        else
        //            ClearAllText(c);
        //    }
        //}

        //void DisableTextBoxes(Control con)
        //{
        //    foreach (Control c in con.Controls)
        //    {
        //        if (c is TextBox)
        //            ((TextBox)c).Enabled = false;
        //        else
        //            DisableTextBoxes(c);
        //    }
        //}

        //void EnableTextBoxes(Control con)
        //{
        //    foreach (Control c in con.Controls)
        //    {
        //        if (c is TextBox)
        //            ((TextBox)c).Enabled = true;
        //        else
        //            EnableTextBoxes(c);
        //    }
        //}

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            EnableTextBoxes();

            List<Student> students = StudentData.getStudents();

            if (count < students.Count)
            {
                ClearAllText();
                textFirstName.Text = students[count].firstName;
                textMidName.Text = students[count].middleName;
                textLastName.Text = students[count].lastName;
                textFaculty.Text = students[count].faculty;
                textSpecialty.Text = students[count].specialty;
                textDegree.Text = students[count].educationDegree;
                textStatus.Text = students[count].status;
                textFacNum.Text = students[count].facNumber;
                textCourse.Text = students[count].course.ToString();
                textStream.Text = students[count].stream.ToString();
                textGroup.Text = students[count].group.ToString();
                count++;
            }
            else
            {
                count = 0;
                ClearAllText();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow()
            {
                Height = this.Height,
                Width = this.Width
            };
            loginWindow.Show();
            this.Close();
        }
    }
}

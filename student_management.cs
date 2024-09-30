using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class student_management : Form
    {
        public student_management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard loginForm = new dashboard();
            loginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student_management_createStudent loginForm = new student_management_createStudent();
            loginForm.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            student_management_assignCourse loginForm = new student_management_assignCourse();
            loginForm.Show();
            //this.Hide();
        }
    }
}

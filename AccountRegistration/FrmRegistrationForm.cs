using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass student = new StudentInfoClass();

            StudentInfoClass.StudentNo = Convert.ToInt64(txtStudentNo.Text.ToString());
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.FirstName = txtFirstName.Text.ToString();
            StudentInfoClass.MiddleName = txtMiddleName.Text.ToString();
            StudentInfoClass.LastName = txtLastName.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt32(txtAge.Text.ToString());
            StudentInfoClass.Address = txtAddress.Text.ToString();
            StudentInfoClass.ContactNo = Convert.ToInt64(txtContactNo.Text.ToString());

            using (FrmConfirm Form2 = new FrmConfirm())
            {
                if (Form2.ShowDialog() == DialogResult.OK)
                {
                    {
                        txtStudentNo.Clear();
                        cbProgram.SelectedIndex = 1;
                        txtFirstName.Clear();
                        txtMiddleName.Clear();
                        txtLastName.Clear();
                        txtAge.Clear();
                        txtAddress.Clear();
                        txtContactNo.Clear();

                    }

                }
            }
        }
    }
}

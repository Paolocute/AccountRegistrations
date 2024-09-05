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
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  
        }

        private DelegateNumber DelNumAge, DelContactNo, DelStudNo;

        private DelegateNumber DelNumContactNo { get; }

        public FrmConfirm()
        {
            InitializeComponent();
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContactNo = new DelegateNumber(StudentInfoClass.GetContact);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
        }

            private void FrmConfirm_Load(object sender, EventArgs e)
        {

            lblStudentNo.Text = Convert.ToString(DelStudNo(StudentInfoClass.StudentNo));
            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblLastName.Text = DelLastName(StudentInfoClass.LastName);
            lblFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);  
            lblAge.Text = Convert.ToString(DelNumAge(StudentInfoClass.Age));
            lblContactNo.Text = Convert.ToString(DelContactNo(StudentInfoClass.ContactNo));
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
        }



       }

    }

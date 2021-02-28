using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordGradeSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentDetail frmStudentDetail = new FrmStudentDetail();
            frmStudentDetail.number = maskedTextBox1.Text;
            frmStudentDetail.Show();
            
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text=="1111")
            {
                FrmTeacherDetail frmTeacherDetail = new FrmTeacherDetail();
                frmTeacherDetail.Show();
            }
        }
    }
}

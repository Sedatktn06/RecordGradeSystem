using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RecordGradeSystem
{
    public partial class FrmStudentDetail : Form
    {
        public FrmStudentDetail()
        {
            InitializeComponent();
        }
        public string number;
        
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RJ6K3QC\SQLEXPRESS;
        Initial Catalog=DbRecordGrade;Integrated Security=True");
        
        private void FrmStudentDetail_Load(object sender, EventArgs e)
        {
            lblNumber.Text = number;
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From TBLLESSON where NUMBER=@p1",connection);
            sqlCommand.Parameters.AddWithValue("@p1",number);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                lblNameSurname.Text = dataReader[2].ToString()+" "+dataReader[3].ToString();
                lblExam1.Text = dataReader[4].ToString();
                lblExam2.Text = dataReader[5].ToString();
                lblExam3.Text = dataReader[6].ToString();
                lblAverage.Text = dataReader[7].ToString();
                lblCondition.Text = dataReader[8].ToString();
            }
            connection.Close();
        }

        
    }
}

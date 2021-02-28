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
    public partial class FrmTeacherDetail : Form
    {

        public FrmTeacherDetail()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RJ6K3QC\SQLEXPRESS;
        Initial Catalog=DbRecordGrade;Integrated Security=True");
        private void FrmTeacherDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbRecordGradeDataSet.TBLLESSON' table. You can move, or remove it, as needed.
            this.tBLLESSONTableAdapter.Fill(this.dbRecordGradeDataSet.TBLLESSON);

        }

        private void BtnSaveStudent_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TBLLESSON (NUMBER,NAME,SURNAME) values (@p1,@p2,@p3)",connection);
            command.Parameters.AddWithValue("@p1", MskNumber.Text);
            command.Parameters.AddWithValue("@p2", TxtName.Text);
            command.Parameters.AddWithValue("@p3", TxtSurname.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("The Student Added In System.");
            this.tBLLESSONTableAdapter.Fill(this.dbRecordGradeDataSet.TBLLESSON);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            MskNumber.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtName.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            TxtExam1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            TxtExam2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            TxtExam3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
        }

        private void BtnSaveGrade_Click(object sender, EventArgs e)
        {


            string result;
            double average, note1, note2, note3;
            note1 = Convert.ToDouble(TxtExam1.Text);
            note2 = Convert.ToDouble(TxtExam2.Text);
            note3 = Convert.ToDouble(TxtExam3.Text);
            average = (note1 + note2 + note3) / 3;
            LblAvarage.Text = average.ToString();
            if (average >= 50)
            {
                result = "True";
            }
            else
            {
                result = "False";
            }
            connection.Open();
            SqlCommand command = new SqlCommand("update TBLLESSON set EXAM1=@p1,EXAM2=@p2,EXAM3=@p3,AVERAGE=@p4,CONDITION=@p5 WHERE NUMBER=@p6", connection);
            command.Parameters.AddWithValue("@p1", TxtExam1.Text);
            command.Parameters.AddWithValue("@p2", TxtExam2.Text);
            command.Parameters.AddWithValue("@p3", TxtExam3.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(LblAvarage.Text));
            command.Parameters.AddWithValue("@p5", result);
            command.Parameters.AddWithValue("@p6", MskNumber.Text);
            command.ExecuteNonQuery();
            AddPassingOrFailing();

            connection.Close();
            MessageBox.Show("Notes saved.");
            this.tBLLESSONTableAdapter.Fill(this.dbRecordGradeDataSet.TBLLESSON);
        }

        private void AddPassingOrFailing()
        {
            SqlCommand command1 = new SqlCommand("Select COUNT(*) From TBLLESSON where CONDITION='1'", connection);
            SqlDataReader dataReader = command1.ExecuteReader();
            while (dataReader.Read())
            {
                LblPassing.Text = dataReader[0].ToString();
            }
            dataReader.Close();
            //------------------------------------------------------
            SqlCommand command2 = new SqlCommand("Select COUNT(*) From TBLLESSON where CONDITION='0'", connection);
            SqlDataReader dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                LblFailing.Text = dataReader2[0].ToString();
            }
            dataReader2.Close();
            //-------------------------------------------------------
        }
    }
}


namespace RecordGradeSystem
{
    partial class FrmTeacherDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSaveStudent = new System.Windows.Forms.Button();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.MskNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSaveGrade = new System.Windows.Forms.Button();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblFailing = new System.Windows.Forms.Label();
            this.LblPassing = new System.Windows.Forms.Label();
            this.LblAvarage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAM1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAM2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAM3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDITIONDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLLESSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbRecordGradeDataSet = new RecordGradeSystem.DbRecordGradeDataSet();
            this.tBLLESSONTableAdapter = new RecordGradeSystem.DbRecordGradeDataSetTableAdapters.TBLLESSONTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLESSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRecordGradeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSaveStudent);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.MskNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Student";
            // 
            // BtnSaveStudent
            // 
            this.BtnSaveStudent.Location = new System.Drawing.Point(92, 139);
            this.BtnSaveStudent.Name = "BtnSaveStudent";
            this.BtnSaveStudent.Size = new System.Drawing.Size(195, 34);
            this.BtnSaveStudent.TabIndex = 6;
            this.BtnSaveStudent.Text = "Save Student";
            this.BtnSaveStudent.UseVisualStyleBackColor = true;
            this.BtnSaveStudent.Click += new System.EventHandler(this.BtnSaveStudent_Click);
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(92, 107);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(195, 26);
            this.TxtSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name : ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(92, 75);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(195, 26);
            this.TxtName.TabIndex = 2;
            // 
            // MskNumber
            // 
            this.MskNumber.Location = new System.Drawing.Point(92, 43);
            this.MskNumber.Mask = "0000";
            this.MskNumber.Name = "MskNumber";
            this.MskNumber.Size = new System.Drawing.Size(195, 26);
            this.MskNumber.TabIndex = 1;
            this.MskNumber.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtExam3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnSaveGrade);
            this.groupBox2.Controls.Add(this.TxtExam2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtExam1);
            this.groupBox2.Location = new System.Drawing.Point(412, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grades Of Exams";
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(92, 104);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(195, 26);
            this.TxtExam3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Exam 3 : ";
            // 
            // BtnSaveGrade
            // 
            this.BtnSaveGrade.Location = new System.Drawing.Point(92, 139);
            this.BtnSaveGrade.Name = "BtnSaveGrade";
            this.BtnSaveGrade.Size = new System.Drawing.Size(195, 34);
            this.BtnSaveGrade.TabIndex = 6;
            this.BtnSaveGrade.Text = "Save Grades";
            this.BtnSaveGrade.UseVisualStyleBackColor = true;
            this.BtnSaveGrade.Click += new System.EventHandler(this.BtnSaveGrade_Click);
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(92, 72);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(195, 26);
            this.TxtExam2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exam 2 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exam 1 :";
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(92, 40);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(195, 26);
            this.TxtExam1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblFailing);
            this.groupBox3.Controls.Add(this.LblPassing);
            this.groupBox3.Controls.Add(this.LblAvarage);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(812, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 356);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grades Of Exams";
            // 
            // LblFailing
            // 
            this.LblFailing.AutoSize = true;
            this.LblFailing.Location = new System.Drawing.Point(164, 115);
            this.LblFailing.Name = "LblFailing";
            this.LblFailing.Size = new System.Drawing.Size(28, 18);
            this.LblFailing.TabIndex = 10;
            this.LblFailing.Text = "00";
            // 
            // LblPassing
            // 
            this.LblPassing.AutoSize = true;
            this.LblPassing.Location = new System.Drawing.Point(164, 83);
            this.LblPassing.Name = "LblPassing";
            this.LblPassing.Size = new System.Drawing.Size(28, 18);
            this.LblPassing.TabIndex = 9;
            this.LblPassing.Text = "00";
            // 
            // LblAvarage
            // 
            this.LblAvarage.AutoSize = true;
            this.LblAvarage.Location = new System.Drawing.Point(164, 51);
            this.LblAvarage.Name = "LblAvarage";
            this.LblAvarage.Size = new System.Drawing.Size(28, 18);
            this.LblAvarage.TabIndex = 8;
            this.LblAvarage.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Failing Students : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Passing Students : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Average : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 387);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1194, 255);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Notes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.nUMBERDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.eXAM1DataGridViewTextBoxColumn,
            this.eXAM2DataGridViewTextBoxColumn,
            this.eXAM3DataGridViewTextBoxColumn,
            this.aVERAGEDataGridViewTextBoxColumn,
            this.cONDITIONDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLLESSONBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1188, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMBERDataGridViewTextBoxColumn
            // 
            this.nUMBERDataGridViewTextBoxColumn.DataPropertyName = "NUMBER";
            this.nUMBERDataGridViewTextBoxColumn.HeaderText = "NUMBER";
            this.nUMBERDataGridViewTextBoxColumn.Name = "nUMBERDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            // 
            // eXAM1DataGridViewTextBoxColumn
            // 
            this.eXAM1DataGridViewTextBoxColumn.DataPropertyName = "EXAM1";
            this.eXAM1DataGridViewTextBoxColumn.HeaderText = "EXAM1";
            this.eXAM1DataGridViewTextBoxColumn.Name = "eXAM1DataGridViewTextBoxColumn";
            // 
            // eXAM2DataGridViewTextBoxColumn
            // 
            this.eXAM2DataGridViewTextBoxColumn.DataPropertyName = "EXAM2";
            this.eXAM2DataGridViewTextBoxColumn.HeaderText = "EXAM2";
            this.eXAM2DataGridViewTextBoxColumn.Name = "eXAM2DataGridViewTextBoxColumn";
            // 
            // eXAM3DataGridViewTextBoxColumn
            // 
            this.eXAM3DataGridViewTextBoxColumn.DataPropertyName = "EXAM3";
            this.eXAM3DataGridViewTextBoxColumn.HeaderText = "EXAM3";
            this.eXAM3DataGridViewTextBoxColumn.Name = "eXAM3DataGridViewTextBoxColumn";
            // 
            // aVERAGEDataGridViewTextBoxColumn
            // 
            this.aVERAGEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.HeaderText = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.Name = "aVERAGEDataGridViewTextBoxColumn";
            // 
            // cONDITIONDataGridViewCheckBoxColumn
            // 
            this.cONDITIONDataGridViewCheckBoxColumn.DataPropertyName = "CONDITION";
            this.cONDITIONDataGridViewCheckBoxColumn.HeaderText = "CONDITION";
            this.cONDITIONDataGridViewCheckBoxColumn.Name = "cONDITIONDataGridViewCheckBoxColumn";
            // 
            // tBLLESSONBindingSource
            // 
            this.tBLLESSONBindingSource.DataMember = "TBLLESSON";
            this.tBLLESSONBindingSource.DataSource = this.dbRecordGradeDataSet;
            // 
            // dbRecordGradeDataSet
            // 
            this.dbRecordGradeDataSet.DataSetName = "DbRecordGradeDataSet";
            this.dbRecordGradeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLLESSONTableAdapter
            // 
            this.tBLLESSONTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1228, 654);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTeacherDetail";
            this.Text = "FrmTeacherDetail";
            this.Load += new System.EventHandler(this.FrmTeacherDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLESSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRecordGradeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.MaskedTextBox MskNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSaveStudent;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSaveGrade;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblFailing;
        private System.Windows.Forms.Label LblPassing;
        private System.Windows.Forms.Label LblAvarage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbRecordGradeDataSet dbRecordGradeDataSet;
        private System.Windows.Forms.BindingSource tBLLESSONBindingSource;
        private DbRecordGradeDataSetTableAdapters.TBLLESSONTableAdapter tBLLESSONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAM1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAM2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAM3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cONDITIONDataGridViewCheckBoxColumn;
    }
}
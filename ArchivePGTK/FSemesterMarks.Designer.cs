namespace ArchivePGTK
{
    partial class FSemesterMarks
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
            this.dataSetMainForm = new ArchivePGTK.DataSetMainForm();
            this.subjectnamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectnamesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.subjectnamesTableAdapter();
            this.tableAdapterManager = new ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager();
            this.dgSubject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Find = new System.Windows.Forms.TextBox();
            this.tb_semester = new System.Windows.Forms.TextBox();
            this.tb_mark = new System.Windows.Forms.TextBox();
            this.tb_ahours = new System.Windows.Forms.TextBox();
            this.tb_shours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.semestermarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semestermarksTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.semestermarksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectnamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubject)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semestermarksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetMainForm
            // 
            this.dataSetMainForm.DataSetName = "DataSetMainForm";
            this.dataSetMainForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectnamesBindingSource
            // 
            this.subjectnamesBindingSource.DataMember = "subjectnames";
            this.subjectnamesBindingSource.DataSource = this.dataSetMainForm;
            // 
            // subjectnamesTableAdapter
            // 
            this.subjectnamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cardsTableAdapter = null;
            this.tableAdapterManager.cworkmarksTableAdapter = null;
            this.tableAdapterManager.finalmarksTableAdapter = null;
            this.tableAdapterManager.groupsTableAdapter = null;
            this.tableAdapterManager.personsTableAdapter = null;
            this.tableAdapterManager.practicmarksTableAdapter = null;
            this.tableAdapterManager.practicnamesTableAdapter = null;
            this.tableAdapterManager.remandstatusTableAdapter = null;
            this.tableAdapterManager.schoolsTableAdapter = null;
            this.tableAdapterManager.semestermarksTableAdapter = this.semestermarksTableAdapter;
            this.tableAdapterManager.semestermissingsTableAdapter = null;
            this.tableAdapterManager.specialitiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgSubject
            // 
            this.dgSubject.AllowUserToAddRows = false;
            this.dgSubject.AllowUserToDeleteRows = false;
            this.dgSubject.AllowUserToResizeRows = false;
            this.dgSubject.AutoGenerateColumns = false;
            this.dgSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgSubject.DataSource = this.subjectnamesBindingSource;
            this.dgSubject.Location = new System.Drawing.Point(6, 45);
            this.dgSubject.Name = "dgSubject";
            this.dgSubject.RowHeadersVisible = false;
            this.dgSubject.Size = new System.Drawing.Size(277, 191);
            this.dgSubject.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "snm_pcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "snm_pcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "snm_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Find);
            this.groupBox1.Controls.Add(this.dgSubject);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tb_Find
            // 
            this.tb_Find.Location = new System.Drawing.Point(6, 19);
            this.tb_Find.Name = "tb_Find";
            this.tb_Find.Size = new System.Drawing.Size(277, 20);
            this.tb_Find.TabIndex = 2;
            this.tb_Find.TextChanged += new System.EventHandler(this.tb_Find_TextChanged);
            // 
            // tb_semester
            // 
            this.tb_semester.Location = new System.Drawing.Point(307, 47);
            this.tb_semester.Name = "tb_semester";
            this.tb_semester.Size = new System.Drawing.Size(151, 20);
            this.tb_semester.TabIndex = 3;
            // 
            // tb_mark
            // 
            this.tb_mark.Location = new System.Drawing.Point(307, 86);
            this.tb_mark.Name = "tb_mark";
            this.tb_mark.Size = new System.Drawing.Size(151, 20);
            this.tb_mark.TabIndex = 4;
            // 
            // tb_ahours
            // 
            this.tb_ahours.Location = new System.Drawing.Point(307, 125);
            this.tb_ahours.Name = "tb_ahours";
            this.tb_ahours.Size = new System.Drawing.Size(151, 20);
            this.tb_ahours.TabIndex = 5;
            // 
            // tb_shours
            // 
            this.tb_shours.Location = new System.Drawing.Point(307, 164);
            this.tb_shours.Name = "tb_shours";
            this.tb_shours.Size = new System.Drawing.Size(151, 20);
            this.tb_shours.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Семестр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оценка (2 - 5)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Академ. часы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сумм. часов";
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(302, 261);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 11;
            this.btOk.Text = "Сохранить";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(383, 261);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отменить";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // semestermarksBindingSource
            // 
            this.semestermarksBindingSource.DataMember = "semestermarks";
            this.semestermarksBindingSource.DataSource = this.dataSetMainForm;
            // 
            // semestermarksTableAdapter
            // 
            this.semestermarksTableAdapter.ClearBeforeFill = true;
            // 
            // FSemesterMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 297);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_shours);
            this.Controls.Add(this.tb_ahours);
            this.Controls.Add(this.tb_mark);
            this.Controls.Add(this.tb_semester);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FSemesterMarks";
            this.Text = "Семестровые оценки";
            this.Load += new System.EventHandler(this.FSemesterMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectnamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubject)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semestermarksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetMainForm dataSetMainForm;
        private System.Windows.Forms.BindingSource subjectnamesBindingSource;
        private DataSetMainFormTableAdapters.subjectnamesTableAdapter subjectnamesTableAdapter;
        private DataSetMainFormTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Find;
        private System.Windows.Forms.TextBox tb_semester;
        private System.Windows.Forms.TextBox tb_mark;
        private System.Windows.Forms.TextBox tb_ahours;
        private System.Windows.Forms.TextBox tb_shours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private DataSetMainFormTableAdapters.semestermarksTableAdapter semestermarksTableAdapter;
        private System.Windows.Forms.BindingSource semestermarksBindingSource;
    }
}
namespace ArchivePGTK
{
    partial class FFinalmarksAdd
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
            this.tbFind = new System.Windows.Forms.TextBox();
            this.tb_ahours = new System.Windows.Forms.TextBox();
            this.tb_mhours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mark = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.finalmarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalmarksTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.finalmarksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectnamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubject)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalmarksBindingSource)).BeginInit();
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
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.cworkmarksTableAdapter = null;
            this.tableAdapterManager.finalmarksTableAdapter = null;
            this.tableAdapterManager.groupsTableAdapter = null;
            this.tableAdapterManager.personsTableAdapter = null;
            this.tableAdapterManager.practicmarksTableAdapter = null;
            this.tableAdapterManager.practicnamesTableAdapter = null;
            this.tableAdapterManager.remandstatusTableAdapter = null;
            this.tableAdapterManager.schoolsTableAdapter = null;
            this.tableAdapterManager.semestermarksTableAdapter = null;
            this.tableAdapterManager.semestermissingsTableAdapter = null;
            this.tableAdapterManager.specialitiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgSubject
            // 
            this.dgSubject.AllowUserToAddRows = false;
            this.dgSubject.AllowUserToDeleteRows = false;
            this.dgSubject.AllowUserToResizeColumns = false;
            this.dgSubject.AllowUserToResizeRows = false;
            this.dgSubject.AutoGenerateColumns = false;
            this.dgSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgSubject.DataSource = this.subjectnamesBindingSource;
            this.dgSubject.Location = new System.Drawing.Point(6, 45);
            this.dgSubject.MultiSelect = false;
            this.dgSubject.Name = "dgSubject";
            this.dgSubject.ReadOnly = true;
            this.dgSubject.RowHeadersVisible = false;
            this.dgSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubject.Size = new System.Drawing.Size(285, 109);
            this.dgSubject.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "snm_pcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "snm_pcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "snm_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(6, 19);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(285, 20);
            this.tbFind.TabIndex = 1;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // tb_ahours
            // 
            this.tb_ahours.Location = new System.Drawing.Point(314, 31);
            this.tb_ahours.Name = "tb_ahours";
            this.tb_ahours.Size = new System.Drawing.Size(100, 20);
            this.tb_ahours.TabIndex = 2;
            // 
            // tb_mhours
            // 
            this.tb_mhours.Location = new System.Drawing.Point(314, 71);
            this.tb_mhours.Name = "tb_mhours";
            this.tb_mhours.Size = new System.Drawing.Size(100, 20);
            this.tb_mhours.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Академ. часов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Макс. часов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Оценка (2 - 5)";
            // 
            // tb_mark
            // 
            this.tb_mark.Location = new System.Drawing.Point(314, 112);
            this.tb_mark.Name = "tb_mark";
            this.tb_mark.Size = new System.Drawing.Size(100, 20);
            this.tb_mark.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgSubject);
            this.groupBox1.Controls.Add(this.tbFind);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 158);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(258, 187);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 10;
            this.btOK.Text = "Сохранить";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(339, 187);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // finalmarksBindingSource
            // 
            this.finalmarksBindingSource.DataMember = "finalmarks";
            this.finalmarksBindingSource.DataSource = this.dataSetMainForm;
            // 
            // finalmarksTableAdapter
            // 
            this.finalmarksTableAdapter.ClearBeforeFill = true;
            // 
            // FFinalmarksAdd
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(429, 223);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_mark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_mhours);
            this.Controls.Add(this.tb_ahours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FFinalmarksAdd";
            this.Text = "Итоговые оценки";
            this.Load += new System.EventHandler(this.FFinalmarksAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectnamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubject)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalmarksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetMainForm dataSetMainForm;
        private System.Windows.Forms.BindingSource subjectnamesBindingSource;
        private DataSetMainFormTableAdapters.subjectnamesTableAdapter subjectnamesTableAdapter;
        private DataSetMainFormTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgSubject;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.TextBox tb_ahours;
        private System.Windows.Forms.TextBox tb_mhours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource finalmarksBindingSource;
        private DataSetMainFormTableAdapters.finalmarksTableAdapter finalmarksTableAdapter;
    }
}
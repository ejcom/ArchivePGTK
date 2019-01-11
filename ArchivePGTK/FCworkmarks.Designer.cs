namespace ArchivePGTK
{
    partial class FCworkmarks
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
            this.dgSubject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectnamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMainForm = new ArchivePGTK.DataSetMainForm();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.subjectnamesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.subjectnamesTableAdapter();
            this.tableAdapterManager = new ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager();
            this.cworkmarksTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.cworkmarksTableAdapter();
            this.cworkmarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTheme = new System.Windows.Forms.TextBox();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectnamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cworkmarksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgSubject);
            this.groupBox1.Controls.Add(this.tbFind);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.dgSubject.Location = new System.Drawing.Point(6, 36);
            this.dgSubject.MultiSelect = false;
            this.dgSubject.Name = "dgSubject";
            this.dgSubject.ReadOnly = true;
            this.dgSubject.RowHeadersVisible = false;
            this.dgSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubject.Size = new System.Drawing.Size(305, 166);
            this.dgSubject.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "snm_pcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "snm_pcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "snm_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // subjectnamesBindingSource
            // 
            this.subjectnamesBindingSource.DataMember = "subjectnames";
            this.subjectnamesBindingSource.DataSource = this.dataSetMainForm;
            // 
            // dataSetMainForm
            // 
            this.dataSetMainForm.DataSetName = "DataSetMainForm";
            this.dataSetMainForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(6, 10);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(305, 20);
            this.tbFind.TabIndex = 0;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
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
            this.tableAdapterManager.cworkmarksTableAdapter = this.cworkmarksTableAdapter;
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
            // cworkmarksTableAdapter
            // 
            this.cworkmarksTableAdapter.ClearBeforeFill = true;
            // 
            // cworkmarksBindingSource
            // 
            this.cworkmarksBindingSource.DataMember = "cworkmarks";
            this.cworkmarksBindingSource.DataSource = this.dataSetMainForm;
            // 
            // tbTheme
            // 
            this.tbTheme.Location = new System.Drawing.Point(18, 244);
            this.tbTheme.Multiline = true;
            this.tbTheme.Name = "tbTheme";
            this.tbTheme.Size = new System.Drawing.Size(305, 61);
            this.tbTheme.TabIndex = 1;
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(18, 324);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(72, 20);
            this.tbMark.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тема:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Оценка (2-5):";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(173, 321);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "Сохранить";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(254, 321);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // FCworkmarks
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(347, 362);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMark);
            this.Controls.Add(this.tbTheme);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FCworkmarks";
            this.Text = "Курсовые работы";
            this.Load += new System.EventHandler(this.CWorkmarks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectnamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cworkmarksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFind;
        private DataSetMainForm dataSetMainForm;
        private System.Windows.Forms.BindingSource subjectnamesBindingSource;
        private DataSetMainFormTableAdapters.subjectnamesTableAdapter subjectnamesTableAdapter;
        private DataSetMainFormTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataSetMainFormTableAdapters.cworkmarksTableAdapter cworkmarksTableAdapter;
        private System.Windows.Forms.BindingSource cworkmarksBindingSource;
        private System.Windows.Forms.TextBox tbTheme;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}
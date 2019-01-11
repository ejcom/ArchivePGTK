namespace ArchivePGTK
{
    partial class FPractic
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
            this.dgName = new System.Windows.Forms.DataGridView();
            this.pnmpcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnmnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practicnamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMainForm = new ArchivePGTK.DataSetMainForm();
            this.practicmarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicmarksTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.practicmarksTableAdapter();
            this.tableAdapterManager = new ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager();
            this.practicnamesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.practicnamesTableAdapter();
            this.practictypesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.practictypesTableAdapter();
            this.practictypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbSem = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicnamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicmarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practictypesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgName
            // 
            this.dgName.AllowUserToAddRows = false;
            this.dgName.AllowUserToDeleteRows = false;
            this.dgName.AllowUserToResizeRows = false;
            this.dgName.AutoGenerateColumns = false;
            this.dgName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pnmpcodeDataGridViewTextBoxColumn,
            this.pnmnameDataGridViewTextBoxColumn});
            this.dgName.DataSource = this.practicnamesBindingSource;
            this.dgName.Location = new System.Drawing.Point(8, 36);
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            this.dgName.RowHeadersVisible = false;
            this.dgName.Size = new System.Drawing.Size(454, 150);
            this.dgName.TabIndex = 0;
            // 
            // pnmpcodeDataGridViewTextBoxColumn
            // 
            this.pnmpcodeDataGridViewTextBoxColumn.DataPropertyName = "pnm_pcode";
            this.pnmpcodeDataGridViewTextBoxColumn.HeaderText = "pnm_pcode";
            this.pnmpcodeDataGridViewTextBoxColumn.Name = "pnmpcodeDataGridViewTextBoxColumn";
            this.pnmpcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pnmpcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // pnmnameDataGridViewTextBoxColumn
            // 
            this.pnmnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pnmnameDataGridViewTextBoxColumn.DataPropertyName = "pnm_name";
            this.pnmnameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.pnmnameDataGridViewTextBoxColumn.Name = "pnmnameDataGridViewTextBoxColumn";
            this.pnmnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // practicnamesBindingSource
            // 
            this.practicnamesBindingSource.DataMember = "practicnames";
            this.practicnamesBindingSource.DataSource = this.dataSetMainForm;
            // 
            // dataSetMainForm
            // 
            this.dataSetMainForm.DataSetName = "DataSetMainForm";
            this.dataSetMainForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // practicmarksBindingSource
            // 
            this.practicmarksBindingSource.DataMember = "practicmarks";
            this.practicmarksBindingSource.DataSource = this.dataSetMainForm;
            // 
            // practicmarksTableAdapter
            // 
            this.practicmarksTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.practicmarksTableAdapter = this.practicmarksTableAdapter;
            this.tableAdapterManager.practicnamesTableAdapter = this.practicnamesTableAdapter;
            this.tableAdapterManager.practictypesTableAdapter = this.practictypesTableAdapter;
            this.tableAdapterManager.remandstatusTableAdapter = null;
            this.tableAdapterManager.schoolsTableAdapter = null;
            this.tableAdapterManager.semestermarksTableAdapter = null;
            this.tableAdapterManager.semestermissingsTableAdapter = null;
            this.tableAdapterManager.specialitiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // practicnamesTableAdapter
            // 
            this.practicnamesTableAdapter.ClearBeforeFill = true;
            // 
            // practictypesTableAdapter
            // 
            this.practictypesTableAdapter.ClearBeforeFill = true;
            // 
            // practictypesBindingSource
            // 
            this.practictypesBindingSource.DataMember = "practictypes";
            this.practictypesBindingSource.DataSource = this.dataSetMainForm;
            // 
            // cbType
            // 
            this.cbType.DataSource = this.practictypesBindingSource;
            this.cbType.DisplayMember = "ptp_type";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(12, 256);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(168, 21);
            this.cbType.TabIndex = 1;
            this.cbType.ValueMember = "ptp_pcode";
            // 
            // tbSem
            // 
            this.tbSem.Location = new System.Drawing.Point(12, 296);
            this.tbSem.Name = "tbSem";
            this.tbSem.Size = new System.Drawing.Size(168, 20);
            this.tbSem.TabIndex = 2;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(186, 254);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(121, 20);
            this.tbLength.TabIndex = 3;
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(186, 296);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(121, 20);
            this.tbMark.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип практики:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Семестр (1-8):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Продолжительность (нед.):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Оценка (1-5):";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(323, 325);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 9;
            this.btOk.Text = "Сохранить";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(404, 325);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Редактировать список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFind);
            this.groupBox1.Controls.Add(this.dgName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 220);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(8, 10);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(454, 20);
            this.tbFind.TabIndex = 12;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // FPractic
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(487, 355);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMark);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.tbSem);
            this.Controls.Add(this.cbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FPractic";
            this.Text = "Практика";
            this.Load += new System.EventHandler(this.FPractic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicnamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicmarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practictypesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgName;
        private DataSetMainForm dataSetMainForm;
        private System.Windows.Forms.BindingSource practicmarksBindingSource;
        private DataSetMainFormTableAdapters.practicmarksTableAdapter practicmarksTableAdapter;
        private DataSetMainFormTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetMainFormTableAdapters.practicnamesTableAdapter practicnamesTableAdapter;
        private System.Windows.Forms.BindingSource practicnamesBindingSource;
        private DataSetMainFormTableAdapters.practictypesTableAdapter practictypesTableAdapter;
        private System.Windows.Forms.BindingSource practictypesBindingSource;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbSem;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnmpcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnmnameDataGridViewTextBoxColumn;
    }
}
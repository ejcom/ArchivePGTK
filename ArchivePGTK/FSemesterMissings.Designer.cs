namespace ArchivePGTK
{
    partial class FSemesterMissings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Sem = new System.Windows.Forms.TextBox();
            this.tb_lmiss = new System.Windows.Forms.TextBox();
            this.tb_imiss = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.dataSetMainForm = new ArchivePGTK.DataSetMainForm();
            this.semestermissingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semestermissingsTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.semestermissingsTableAdapter();
            this.tableAdapterManager = new ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestermissingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ Семестра";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "По уважительной причине";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "По НЕ уважительной причине";
            // 
            // tb_Sem
            // 
            this.tb_Sem.Location = new System.Drawing.Point(21, 25);
            this.tb_Sem.Name = "tb_Sem";
            this.tb_Sem.Size = new System.Drawing.Size(100, 20);
            this.tb_Sem.TabIndex = 3;
            // 
            // tb_lmiss
            // 
            this.tb_lmiss.Location = new System.Drawing.Point(6, 40);
            this.tb_lmiss.Name = "tb_lmiss";
            this.tb_lmiss.Size = new System.Drawing.Size(100, 20);
            this.tb_lmiss.TabIndex = 4;
            // 
            // tb_imiss
            // 
            this.tb_imiss.Location = new System.Drawing.Point(6, 80);
            this.tb_imiss.Name = "tb_imiss";
            this.tb_imiss.Size = new System.Drawing.Size(100, 20);
            this.tb_imiss.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_imiss);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_lmiss);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Количество пропусков:";
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(56, 174);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "Сохранить";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(137, 174);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // dataSetMainForm
            // 
            this.dataSetMainForm.DataSetName = "DataSetMainForm";
            this.dataSetMainForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // semestermissingsBindingSource
            // 
            this.semestermissingsBindingSource.DataMember = "semestermissings";
            this.semestermissingsBindingSource.DataSource = this.dataSetMainForm;
            // 
            // semestermissingsTableAdapter
            // 
            this.semestermissingsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.semestermarksTableAdapter = null;
            this.tableAdapterManager.semestermissingsTableAdapter = this.semestermissingsTableAdapter;
            this.tableAdapterManager.specialitiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FSemesterMissings
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(220, 204);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_Sem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FSemesterMissings";
            this.Text = "Пропуски";
            this.Load += new System.EventHandler(this.FSemesterMissings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestermissingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Sem;
        private System.Windows.Forms.TextBox tb_lmiss;
        private System.Windows.Forms.TextBox tb_imiss;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private DataSetMainForm dataSetMainForm;
        private System.Windows.Forms.BindingSource semestermissingsBindingSource;
        private DataSetMainFormTableAdapters.semestermissingsTableAdapter semestermissingsTableAdapter;
        private DataSetMainFormTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
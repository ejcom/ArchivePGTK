namespace ArchivePGTK
{
    partial class FPrint
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
            this.btPrint = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpGosEkCom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbChair = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.dataSetMainForm = new ArchivePGTK.DataSetMainForm();
            this.cardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardsTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.cardsTableAdapter();
            this.tableAdapterManager = new ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager();
            this.cworkmarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cworkmarksTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.cworkmarksTableAdapter();
            this.finalmarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalmarksTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.finalmarksTableAdapter();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.personsTableAdapter();
            this.practicmarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicmarksTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.practicmarksTableAdapter();
            this.practicnamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicnamesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.practicnamesTableAdapter();
            this.practictypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practictypesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.practictypesTableAdapter();
            this.remandstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remandstatusTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.remandstatusTableAdapter();
            this.schoolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolsTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.schoolsTableAdapter();
            this.semestermarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semestermarksTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.semestermarksTableAdapter();
            this.semestermissingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semestermissingsTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.semestermissingsTableAdapter();
            this.specialitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialitiesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.specialitiesTableAdapter();
            this.subjectnamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectnamesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.subjectnamesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cworkmarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalmarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicmarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicnamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practictypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remandstatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestermarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestermissingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectnamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(185, 157);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(75, 23);
            this.btPrint.TabIndex = 0;
            this.btPrint.Text = "Создать";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(266, 157);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата решения";
            // 
            // dtpGosEkCom
            // 
            this.dtpGosEkCom.Location = new System.Drawing.Point(9, 32);
            this.dtpGosEkCom.Name = "dtpGosEkCom";
            this.dtpGosEkCom.Size = new System.Drawing.Size(200, 20);
            this.dtpGosEkCom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Председатель";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbChair);
            this.groupBox1.Controls.Add(this.dtpGosEkCom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Государственная экзаменационная комиссия";
            // 
            // tbChair
            // 
            this.tbChair.Location = new System.Drawing.Point(9, 71);
            this.tbChair.Name = "tbChair";
            this.tbChair.Size = new System.Drawing.Size(310, 20);
            this.tbChair.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Руководитель образовательного учреждения";
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(21, 131);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(310, 20);
            this.tbDirector.TabIndex = 7;
            // 
            // dataSetMainForm
            // 
            this.dataSetMainForm.DataSetName = "DataSetMainForm";
            this.dataSetMainForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardsBindingSource
            // 
            this.cardsBindingSource.DataMember = "cards";
            this.cardsBindingSource.DataSource = this.dataSetMainForm;
            // 
            // cardsTableAdapter
            // 
            this.cardsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cardsTableAdapter = this.cardsTableAdapter;
            this.tableAdapterManager.cworkmarksTableAdapter = this.cworkmarksTableAdapter;
            this.tableAdapterManager.finalmarksTableAdapter = this.finalmarksTableAdapter;
            this.tableAdapterManager.groupsTableAdapter = null;
            this.tableAdapterManager.personsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager.practicmarksTableAdapter = this.practicmarksTableAdapter;
            this.tableAdapterManager.practicnamesTableAdapter = this.practicnamesTableAdapter;
            this.tableAdapterManager.practictypesTableAdapter = this.practictypesTableAdapter;
            this.tableAdapterManager.remandstatusTableAdapter = this.remandstatusTableAdapter;
            this.tableAdapterManager.schoolsTableAdapter = this.schoolsTableAdapter;
            this.tableAdapterManager.semestermarksTableAdapter = this.semestermarksTableAdapter;
            this.tableAdapterManager.semestermissingsTableAdapter = this.semestermissingsTableAdapter;
            this.tableAdapterManager.specialitiesTableAdapter = this.specialitiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cworkmarksBindingSource
            // 
            this.cworkmarksBindingSource.DataMember = "cworkmarks";
            this.cworkmarksBindingSource.DataSource = this.dataSetMainForm;
            // 
            // cworkmarksTableAdapter
            // 
            this.cworkmarksTableAdapter.ClearBeforeFill = true;
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
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "persons";
            this.personsBindingSource.DataSource = this.dataSetMainForm;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
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
            // practicnamesBindingSource
            // 
            this.practicnamesBindingSource.DataMember = "practicnames";
            this.practicnamesBindingSource.DataSource = this.dataSetMainForm;
            // 
            // practicnamesTableAdapter
            // 
            this.practicnamesTableAdapter.ClearBeforeFill = true;
            // 
            // practictypesBindingSource
            // 
            this.practictypesBindingSource.DataMember = "practictypes";
            this.practictypesBindingSource.DataSource = this.dataSetMainForm;
            // 
            // practictypesTableAdapter
            // 
            this.practictypesTableAdapter.ClearBeforeFill = true;
            // 
            // remandstatusBindingSource
            // 
            this.remandstatusBindingSource.DataMember = "remandstatus";
            this.remandstatusBindingSource.DataSource = this.dataSetMainForm;
            // 
            // remandstatusTableAdapter
            // 
            this.remandstatusTableAdapter.ClearBeforeFill = true;
            // 
            // schoolsBindingSource
            // 
            this.schoolsBindingSource.DataMember = "schools";
            this.schoolsBindingSource.DataSource = this.dataSetMainForm;
            // 
            // schoolsTableAdapter
            // 
            this.schoolsTableAdapter.ClearBeforeFill = true;
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
            // semestermissingsBindingSource
            // 
            this.semestermissingsBindingSource.DataMember = "semestermissings";
            this.semestermissingsBindingSource.DataSource = this.dataSetMainForm;
            // 
            // semestermissingsTableAdapter
            // 
            this.semestermissingsTableAdapter.ClearBeforeFill = true;
            // 
            // specialitiesBindingSource
            // 
            this.specialitiesBindingSource.DataMember = "specialities";
            this.specialitiesBindingSource.DataSource = this.dataSetMainForm;
            // 
            // specialitiesTableAdapter
            // 
            this.specialitiesTableAdapter.ClearBeforeFill = true;
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
            // FPrint
            // 
            this.AcceptButton = this.btPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(353, 189);
            this.ControlBox = false;
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FPrint";
            this.Text = "Подготовка шаблона";
            this.Load += new System.EventHandler(this.FPrint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cworkmarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalmarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicmarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicnamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practictypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remandstatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestermarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestermissingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectnamesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpGosEkCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbChair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDirector;
        private DataSetMainForm dataSetMainForm;
        private System.Windows.Forms.BindingSource cardsBindingSource;
        private DataSetMainFormTableAdapters.cardsTableAdapter cardsTableAdapter;
        private DataSetMainFormTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetMainFormTableAdapters.cworkmarksTableAdapter cworkmarksTableAdapter;
        private System.Windows.Forms.BindingSource cworkmarksBindingSource;
        private DataSetMainFormTableAdapters.finalmarksTableAdapter finalmarksTableAdapter;
        private System.Windows.Forms.BindingSource finalmarksBindingSource;
        private DataSetMainFormTableAdapters.personsTableAdapter personsTableAdapter;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private DataSetMainFormTableAdapters.practicmarksTableAdapter practicmarksTableAdapter;
        private System.Windows.Forms.BindingSource practicmarksBindingSource;
        private DataSetMainFormTableAdapters.practicnamesTableAdapter practicnamesTableAdapter;
        private System.Windows.Forms.BindingSource practicnamesBindingSource;
        private DataSetMainFormTableAdapters.practictypesTableAdapter practictypesTableAdapter;
        private System.Windows.Forms.BindingSource practictypesBindingSource;
        private DataSetMainFormTableAdapters.remandstatusTableAdapter remandstatusTableAdapter;
        private System.Windows.Forms.BindingSource remandstatusBindingSource;
        private DataSetMainFormTableAdapters.schoolsTableAdapter schoolsTableAdapter;
        private System.Windows.Forms.BindingSource schoolsBindingSource;
        private DataSetMainFormTableAdapters.semestermarksTableAdapter semestermarksTableAdapter;
        private System.Windows.Forms.BindingSource semestermarksBindingSource;
        private DataSetMainFormTableAdapters.semestermissingsTableAdapter semestermissingsTableAdapter;
        private System.Windows.Forms.BindingSource semestermissingsBindingSource;
        private DataSetMainFormTableAdapters.specialitiesTableAdapter specialitiesTableAdapter;
        private System.Windows.Forms.BindingSource specialitiesBindingSource;
        private System.Windows.Forms.BindingSource subjectnamesBindingSource;
        private DataSetMainFormTableAdapters.subjectnamesTableAdapter subjectnamesTableAdapter;
    }
}
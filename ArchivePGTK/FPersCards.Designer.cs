namespace ArchivePGTK
{
    partial class FPersCards
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
            System.Windows.Forms.Label crd_inschoolLabel;
            System.Windows.Forms.Label crd_spccodeLabel;
            System.Windows.Forms.Label crd_bdateLabel;
            System.Windows.Forms.Label crd_edateLabel;
            System.Windows.Forms.Label crd_docdateLabel;
            System.Windows.Forms.Label crd_docnameLabel;
            System.Windows.Forms.Label crd_docorgLabel;
            System.Windows.Forms.Label crd_workplaceLabel;
            System.Windows.Forms.Label crd_workpostLabel;
            System.Windows.Forms.Label crd_outschoolLabel;
            System.Windows.Forms.Label crd_remandedLabel;
            System.Windows.Forms.Label crd_remandreasonLabel;
            this.cardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMainForm = new ArchivePGTK.DataSetMainForm();
            this.bindingSourceInScools = new System.Windows.Forms.BindingSource(this.components);
            this.schoolsTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.schoolsTableAdapter();
            this.cardsTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.cardsTableAdapter();
            this.tableAdapterManager = new ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager();
            this.bindingSourceSpec = new System.Windows.Forms.BindingSource(this.components);
            this.crd_bdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.crd_edateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.crd_docdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.crd_docnameTextBox = new System.Windows.Forms.TextBox();
            this.crd_docorgTextBox = new System.Windows.Forms.TextBox();
            this.crd_workplaceTextBox = new System.Windows.Forms.TextBox();
            this.crd_workpostTextBox = new System.Windows.Forms.TextBox();
            this.bindingSourceOutScools = new System.Windows.Forms.BindingSource(this.components);
            this.crd_remandreasonTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.specialitiesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.specialitiesTableAdapter();
            this.crd_OutScoolListBox = new System.Windows.Forms.ListBox();
            this.crd_InScoolListBox = new System.Windows.Forms.ListBox();
            this.crd_spccodeListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crd_remadnstatuscomboBox = new System.Windows.Forms.ComboBox();
            this.remandstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.remandstatusTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.remandstatusTableAdapter();
            this.cbEditMode = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbDipserial = new System.Windows.Forms.TextBox();
            this.tbDipregnum = new System.Windows.Forms.TextBox();
            this.dtpDipdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            crd_inschoolLabel = new System.Windows.Forms.Label();
            crd_spccodeLabel = new System.Windows.Forms.Label();
            crd_bdateLabel = new System.Windows.Forms.Label();
            crd_edateLabel = new System.Windows.Forms.Label();
            crd_docdateLabel = new System.Windows.Forms.Label();
            crd_docnameLabel = new System.Windows.Forms.Label();
            crd_docorgLabel = new System.Windows.Forms.Label();
            crd_workplaceLabel = new System.Windows.Forms.Label();
            crd_workpostLabel = new System.Windows.Forms.Label();
            crd_outschoolLabel = new System.Windows.Forms.Label();
            crd_remandedLabel = new System.Windows.Forms.Label();
            crd_remandreasonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInScools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOutScools)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remandstatusBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // crd_inschoolLabel
            // 
            crd_inschoolLabel.AutoSize = true;
            crd_inschoolLabel.Location = new System.Drawing.Point(4, 14);
            crd_inschoolLabel.Name = "crd_inschoolLabel";
            crd_inschoolLabel.Size = new System.Drawing.Size(288, 13);
            crd_inschoolLabel.TabIndex = 2;
            crd_inschoolLabel.Text = "Образовательное учреждение на момент поступления:";
            // 
            // crd_spccodeLabel
            // 
            crd_spccodeLabel.AutoSize = true;
            crd_spccodeLabel.Location = new System.Drawing.Point(8, 63);
            crd_spccodeLabel.Name = "crd_spccodeLabel";
            crd_spccodeLabel.Size = new System.Drawing.Size(88, 13);
            crd_spccodeLabel.TabIndex = 4;
            crd_spccodeLabel.Text = "Специальность:";
            // 
            // crd_bdateLabel
            // 
            crd_bdateLabel.AutoSize = true;
            crd_bdateLabel.Location = new System.Drawing.Point(8, 24);
            crd_bdateLabel.Name = "crd_bdateLabel";
            crd_bdateLabel.Size = new System.Drawing.Size(123, 13);
            crd_bdateLabel.TabIndex = 6;
            crd_bdateLabel.Text = "Дата начала обучения:";
            // 
            // crd_edateLabel
            // 
            crd_edateLabel.AutoSize = true;
            crd_edateLabel.Location = new System.Drawing.Point(203, 24);
            crd_edateLabel.Name = "crd_edateLabel";
            crd_edateLabel.Size = new System.Drawing.Size(141, 13);
            crd_edateLabel.TabIndex = 8;
            crd_edateLabel.Text = "Дата окончания обучения:";
            // 
            // crd_docdateLabel
            // 
            crd_docdateLabel.AutoSize = true;
            crd_docdateLabel.Location = new System.Drawing.Point(8, 108);
            crd_docdateLabel.Name = "crd_docdateLabel";
            crd_docdateLabel.Size = new System.Drawing.Size(76, 13);
            crd_docdateLabel.TabIndex = 10;
            crd_docdateLabel.Text = "Дата выдачи:";
            // 
            // crd_docnameLabel
            // 
            crd_docnameLabel.AutoSize = true;
            crd_docnameLabel.Location = new System.Drawing.Point(6, 24);
            crd_docnameLabel.Name = "crd_docnameLabel";
            crd_docnameLabel.Size = new System.Drawing.Size(61, 13);
            crd_docnameLabel.TabIndex = 12;
            crd_docnameLabel.Text = "Документ:";
            // 
            // crd_docorgLabel
            // 
            crd_docorgLabel.AutoSize = true;
            crd_docorgLabel.Location = new System.Drawing.Point(6, 63);
            crd_docorgLabel.Name = "crd_docorgLabel";
            crd_docorgLabel.Size = new System.Drawing.Size(186, 13);
            crd_docorgLabel.TabIndex = 14;
            crd_docorgLabel.Text = "Организация, выдавшая документ:";
            // 
            // crd_workplaceLabel
            // 
            crd_workplaceLabel.AutoSize = true;
            crd_workplaceLabel.Location = new System.Drawing.Point(41, 23);
            crd_workplaceLabel.Name = "crd_workplaceLabel";
            crd_workplaceLabel.Size = new System.Drawing.Size(82, 13);
            crd_workplaceLabel.TabIndex = 16;
            crd_workplaceLabel.Text = "Место работы:";
            // 
            // crd_workpostLabel
            // 
            crd_workpostLabel.AutoSize = true;
            crd_workpostLabel.Location = new System.Drawing.Point(55, 49);
            crd_workpostLabel.Name = "crd_workpostLabel";
            crd_workpostLabel.Size = new System.Drawing.Size(68, 13);
            crd_workpostLabel.TabIndex = 18;
            crd_workpostLabel.Text = "Должность:";
            // 
            // crd_outschoolLabel
            // 
            crd_outschoolLabel.AutoSize = true;
            crd_outschoolLabel.Location = new System.Drawing.Point(411, 14);
            crd_outschoolLabel.Name = "crd_outschoolLabel";
            crd_outschoolLabel.Size = new System.Drawing.Size(326, 13);
            crd_outschoolLabel.TabIndex = 20;
            crd_outschoolLabel.Text = "Образовательное учреждение на момент окончания обучения:";
            // 
            // crd_remandedLabel
            // 
            crd_remandedLabel.AutoSize = true;
            crd_remandedLabel.Location = new System.Drawing.Point(79, 16);
            crd_remandedLabel.Name = "crd_remandedLabel";
            crd_remandedLabel.Size = new System.Drawing.Size(44, 13);
            crd_remandedLabel.TabIndex = 22;
            crd_remandedLabel.Text = "Статус:";
            // 
            // crd_remandreasonLabel
            // 
            crd_remandreasonLabel.AutoSize = true;
            crd_remandreasonLabel.Location = new System.Drawing.Point(9, 39);
            crd_remandreasonLabel.Name = "crd_remandreasonLabel";
            crd_remandreasonLabel.Size = new System.Drawing.Size(114, 13);
            crd_remandreasonLabel.TabIndex = 24;
            crd_remandreasonLabel.Text = "Причина отчисления:";
            // 
            // cardsBindingSource
            // 
            this.cardsBindingSource.DataMember = "cards";
            this.cardsBindingSource.DataSource = this.dataSetMainForm;
            // 
            // dataSetMainForm
            // 
            this.dataSetMainForm.DataSetName = "DataSetMainForm";
            this.dataSetMainForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceInScools
            // 
            this.bindingSourceInScools.DataMember = "schools";
            this.bindingSourceInScools.DataSource = this.dataSetMainForm;
            // 
            // schoolsTableAdapter
            // 
            this.schoolsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.cworkmarksTableAdapter = null;
            this.tableAdapterManager.finalmarksTableAdapter = null;
            this.tableAdapterManager.groupsTableAdapter = null;
            this.tableAdapterManager.personsTableAdapter = null;
            this.tableAdapterManager.practicmarksTableAdapter = null;
            this.tableAdapterManager.practicnamesTableAdapter = null;
            this.tableAdapterManager.practictypesTableAdapter = null;
            this.tableAdapterManager.remandstatusTableAdapter = null;
            this.tableAdapterManager.schoolsTableAdapter = this.schoolsTableAdapter;
            this.tableAdapterManager.semestermarksTableAdapter = null;
            this.tableAdapterManager.semestermissingsTableAdapter = null;
            this.tableAdapterManager.specialitiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingSourceSpec
            // 
            this.bindingSourceSpec.DataMember = "specialities";
            this.bindingSourceSpec.DataSource = this.dataSetMainForm;
            // 
            // crd_bdateDateTimePicker
            // 
            this.crd_bdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.crd_bdateDateTimePicker.Location = new System.Drawing.Point(11, 40);
            this.crd_bdateDateTimePicker.Name = "crd_bdateDateTimePicker";
            this.crd_bdateDateTimePicker.Size = new System.Drawing.Size(189, 20);
            this.crd_bdateDateTimePicker.TabIndex = 7;
            this.crd_bdateDateTimePicker.Value = new System.DateTime(2014, 3, 11, 0, 0, 0, 0);
            // 
            // crd_edateDateTimePicker
            // 
            this.crd_edateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.crd_edateDateTimePicker.Location = new System.Drawing.Point(206, 40);
            this.crd_edateDateTimePicker.Name = "crd_edateDateTimePicker";
            this.crd_edateDateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.crd_edateDateTimePicker.TabIndex = 9;
            this.crd_edateDateTimePicker.Value = new System.DateTime(2014, 3, 11, 0, 0, 0, 0);
            // 
            // crd_docdateDateTimePicker
            // 
            this.crd_docdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.crd_docdateDateTimePicker.Location = new System.Drawing.Point(134, 105);
            this.crd_docdateDateTimePicker.Name = "crd_docdateDateTimePicker";
            this.crd_docdateDateTimePicker.Size = new System.Drawing.Size(274, 20);
            this.crd_docdateDateTimePicker.TabIndex = 11;
            this.crd_docdateDateTimePicker.Value = new System.DateTime(2014, 3, 11, 0, 0, 0, 0);
            // 
            // crd_docnameTextBox
            // 
            this.crd_docnameTextBox.Location = new System.Drawing.Point(11, 40);
            this.crd_docnameTextBox.Name = "crd_docnameTextBox";
            this.crd_docnameTextBox.Size = new System.Drawing.Size(397, 20);
            this.crd_docnameTextBox.TabIndex = 13;
            // 
            // crd_docorgTextBox
            // 
            this.crd_docorgTextBox.Location = new System.Drawing.Point(11, 79);
            this.crd_docorgTextBox.Name = "crd_docorgTextBox";
            this.crd_docorgTextBox.Size = new System.Drawing.Size(397, 20);
            this.crd_docorgTextBox.TabIndex = 15;
            // 
            // crd_workplaceTextBox
            // 
            this.crd_workplaceTextBox.Location = new System.Drawing.Point(129, 20);
            this.crd_workplaceTextBox.Name = "crd_workplaceTextBox";
            this.crd_workplaceTextBox.Size = new System.Drawing.Size(261, 20);
            this.crd_workplaceTextBox.TabIndex = 17;
            // 
            // crd_workpostTextBox
            // 
            this.crd_workpostTextBox.Location = new System.Drawing.Point(129, 46);
            this.crd_workpostTextBox.Name = "crd_workpostTextBox";
            this.crd_workpostTextBox.Size = new System.Drawing.Size(261, 20);
            this.crd_workpostTextBox.TabIndex = 19;
            // 
            // bindingSourceOutScools
            // 
            this.bindingSourceOutScools.DataMember = "schools";
            this.bindingSourceOutScools.DataSource = this.dataSetMainForm;
            // 
            // crd_remandreasonTextBox
            // 
            this.crd_remandreasonTextBox.Location = new System.Drawing.Point(129, 36);
            this.crd_remandreasonTextBox.Name = "crd_remandreasonTextBox";
            this.crd_remandreasonTextBox.Size = new System.Drawing.Size(261, 20);
            this.crd_remandreasonTextBox.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(676, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // specialitiesTableAdapter
            // 
            this.specialitiesTableAdapter.ClearBeforeFill = true;
            // 
            // crd_OutScoolListBox
            // 
            this.crd_OutScoolListBox.DataSource = this.bindingSourceOutScools;
            this.crd_OutScoolListBox.DisplayMember = "scl_name";
            this.crd_OutScoolListBox.FormattingEnabled = true;
            this.crd_OutScoolListBox.HorizontalScrollbar = true;
            this.crd_OutScoolListBox.Location = new System.Drawing.Point(415, 30);
            this.crd_OutScoolListBox.Name = "crd_OutScoolListBox";
            this.crd_OutScoolListBox.Size = new System.Drawing.Size(401, 160);
            this.crd_OutScoolListBox.TabIndex = 28;
            this.crd_OutScoolListBox.ValueMember = "scl_pcode";
            // 
            // crd_InScoolListBox
            // 
            this.crd_InScoolListBox.DataSource = this.bindingSourceInScools;
            this.crd_InScoolListBox.DisplayMember = "scl_name";
            this.crd_InScoolListBox.FormattingEnabled = true;
            this.crd_InScoolListBox.HorizontalScrollbar = true;
            this.crd_InScoolListBox.Location = new System.Drawing.Point(6, 30);
            this.crd_InScoolListBox.Name = "crd_InScoolListBox";
            this.crd_InScoolListBox.Size = new System.Drawing.Size(402, 160);
            this.crd_InScoolListBox.TabIndex = 29;
            this.crd_InScoolListBox.ValueMember = "scl_pcode";
            // 
            // crd_spccodeListBox
            // 
            this.crd_spccodeListBox.DataSource = this.bindingSourceSpec;
            this.crd_spccodeListBox.DisplayMember = "spc_shortname";
            this.crd_spccodeListBox.FormattingEnabled = true;
            this.crd_spccodeListBox.HorizontalScrollbar = true;
            this.crd_spccodeListBox.Location = new System.Drawing.Point(11, 79);
            this.crd_spccodeListBox.Name = "crd_spccodeListBox";
            this.crd_spccodeListBox.Size = new System.Drawing.Size(189, 95);
            this.crd_spccodeListBox.TabIndex = 30;
            this.crd_spccodeListBox.ValueMember = "spc_pcode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crd_remadnstatuscomboBox);
            this.groupBox1.Controls.Add(crd_remandreasonLabel);
            this.groupBox1.Controls.Add(this.crd_remandreasonTextBox);
            this.groupBox1.Controls.Add(crd_remandedLabel);
            this.groupBox1.Location = new System.Drawing.Point(437, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 76);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // crd_remadnstatuscomboBox
            // 
            this.crd_remadnstatuscomboBox.DataSource = this.remandstatusBindingSource;
            this.crd_remadnstatuscomboBox.DisplayMember = "rems_name";
            this.crd_remadnstatuscomboBox.FormattingEnabled = true;
            this.crd_remadnstatuscomboBox.Location = new System.Drawing.Point(129, 13);
            this.crd_remadnstatuscomboBox.Name = "crd_remadnstatuscomboBox";
            this.crd_remadnstatuscomboBox.Size = new System.Drawing.Size(261, 21);
            this.crd_remadnstatuscomboBox.TabIndex = 26;
            this.crd_remadnstatuscomboBox.ValueMember = "rems_pcode";
            // 
            // remandstatusBindingSource
            // 
            this.remandstatusBindingSource.DataMember = "remandstatus";
            this.remandstatusBindingSource.DataSource = this.dataSetMainForm;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.crd_workpostTextBox);
            this.groupBox2.Controls.Add(this.crd_workplaceTextBox);
            this.groupBox2.Controls.Add(crd_workplaceLabel);
            this.groupBox2.Controls.Add(crd_workpostLabel);
            this.groupBox2.Location = new System.Drawing.Point(437, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 74);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Направлен на работу:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.crd_spccodeListBox);
            this.groupBox3.Controls.Add(this.crd_edateDateTimePicker);
            this.groupBox3.Controls.Add(crd_edateLabel);
            this.groupBox3.Controls.Add(crd_bdateLabel);
            this.groupBox3.Controls.Add(crd_spccodeLabel);
            this.groupBox3.Controls.Add(this.crd_bdateDateTimePicker);
            this.groupBox3.Location = new System.Drawing.Point(12, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 189);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о зачислении:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(757, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // remandstatusTableAdapter
            // 
            this.remandstatusTableAdapter.ClearBeforeFill = true;
            // 
            // cbEditMode
            // 
            this.cbEditMode.AutoSize = true;
            this.cbEditMode.Location = new System.Drawing.Point(12, 8);
            this.cbEditMode.Name = "cbEditMode";
            this.cbEditMode.Size = new System.Drawing.Size(103, 17);
            this.cbEditMode.TabIndex = 35;
            this.cbEditMode.Text = "Редактировать";
            this.cbEditMode.UseVisualStyleBackColor = true;
            this.cbEditMode.CheckedChanged += new System.EventHandler(this.cbEditMode_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.crd_InScoolListBox);
            this.groupBox4.Controls.Add(crd_outschoolLabel);
            this.groupBox4.Controls.Add(crd_inschoolLabel);
            this.groupBox4.Controls.Add(this.crd_OutScoolListBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 359);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(822, 196);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.crd_docorgTextBox);
            this.groupBox5.Controls.Add(crd_docnameLabel);
            this.groupBox5.Controls.Add(this.crd_docnameTextBox);
            this.groupBox5.Controls.Add(this.crd_docdateDateTimePicker);
            this.groupBox5.Controls.Add(crd_docdateLabel);
            this.groupBox5.Controls.Add(crd_docorgLabel);
            this.groupBox5.Location = new System.Drawing.Point(12, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(419, 131);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Информация о предыдущем образовании";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.dtpDipdate);
            this.groupBox6.Controls.Add(this.tbDipregnum);
            this.groupBox6.Controls.Add(this.tbDipserial);
            this.groupBox6.Location = new System.Drawing.Point(437, 125);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(397, 152);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Диплом";
            // 
            // tbDipserial
            // 
            this.tbDipserial.Location = new System.Drawing.Point(12, 38);
            this.tbDipserial.Name = "tbDipserial";
            this.tbDipserial.Size = new System.Drawing.Size(378, 20);
            this.tbDipserial.TabIndex = 0;
            // 
            // tbDipregnum
            // 
            this.tbDipregnum.Location = new System.Drawing.Point(12, 79);
            this.tbDipregnum.Name = "tbDipregnum";
            this.tbDipregnum.Size = new System.Drawing.Size(378, 20);
            this.tbDipregnum.TabIndex = 1;
            // 
            // dtpDipdate
            // 
            this.dtpDipdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDipdate.Location = new System.Drawing.Point(12, 118);
            this.dtpDipdate.Name = "dtpDipdate";
            this.dtpDipdate.Size = new System.Drawing.Size(171, 20);
            this.dtpDipdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Серия и номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Регистрационный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата выдачи";
            // 
            // FPersCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 593);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cbEditMode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FPersCards";
            this.Text = "Добавить Личную карточку";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPersCards_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInScools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOutScools)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remandstatusBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceInScools;
        private DataSetMainForm dataSetMainForm;
        private DataSetMainFormTableAdapters.schoolsTableAdapter schoolsTableAdapter;
        private System.Windows.Forms.BindingSource cardsBindingSource;
        private DataSetMainFormTableAdapters.cardsTableAdapter cardsTableAdapter;
        private DataSetMainFormTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker crd_bdateDateTimePicker;
        private System.Windows.Forms.DateTimePicker crd_edateDateTimePicker;
        private System.Windows.Forms.DateTimePicker crd_docdateDateTimePicker;
        private System.Windows.Forms.TextBox crd_docnameTextBox;
        private System.Windows.Forms.TextBox crd_docorgTextBox;
        private System.Windows.Forms.TextBox crd_workplaceTextBox;
        private System.Windows.Forms.TextBox crd_workpostTextBox;
        private System.Windows.Forms.TextBox crd_remandreasonTextBox;
        private System.Windows.Forms.BindingSource bindingSourceOutScools;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSourceSpec;
        private DataSetMainFormTableAdapters.specialitiesTableAdapter specialitiesTableAdapter;
        private System.Windows.Forms.ListBox crd_OutScoolListBox;
        private System.Windows.Forms.ListBox crd_InScoolListBox;
        private System.Windows.Forms.ListBox crd_spccodeListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox crd_remadnstatuscomboBox;
        private System.Windows.Forms.BindingSource remandstatusBindingSource;
        private DataSetMainFormTableAdapters.remandstatusTableAdapter remandstatusTableAdapter;
        private System.Windows.Forms.CheckBox cbEditMode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDipdate;
        private System.Windows.Forms.TextBox tbDipregnum;
        private System.Windows.Forms.TextBox tbDipserial;
    }
}
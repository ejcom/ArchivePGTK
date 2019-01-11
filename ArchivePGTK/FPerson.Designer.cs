namespace ArchivePGTK
{
    partial class FPersonAdd
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
            System.Windows.Forms.Label psn_fnameLabel;
            System.Windows.Forms.Label psn_lnameLabel;
            System.Windows.Forms.Label psn_mnameLabel;
            System.Windows.Forms.Label psn_birthdateLabel;
            System.Windows.Forms.Label psn_birthplaceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPersonAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMainForm = new ArchivePGTK.DataSetMainForm();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.psn_birthplaceTextBox = new System.Windows.Forms.TextBox();
            this.psn_birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.psn_mnameTextBox = new System.Windows.Forms.TextBox();
            this.psn_lnameTextBox = new System.Windows.Forms.TextBox();
            this.psn_fnameTextBox = new System.Windows.Forms.TextBox();
            this.personsTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.personsTableAdapter();
            this.tableAdapterManager = new ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.personsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.cbEditMode = new System.Windows.Forms.CheckBox();
            psn_fnameLabel = new System.Windows.Forms.Label();
            psn_lnameLabel = new System.Windows.Forms.Label();
            psn_mnameLabel = new System.Windows.Forms.Label();
            psn_birthdateLabel = new System.Windows.Forms.Label();
            psn_birthplaceLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingNavigator)).BeginInit();
            this.personsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // psn_fnameLabel
            // 
            psn_fnameLabel.AutoSize = true;
            psn_fnameLabel.Location = new System.Drawing.Point(49, 23);
            psn_fnameLabel.Name = "psn_fnameLabel";
            psn_fnameLabel.Size = new System.Drawing.Size(59, 13);
            psn_fnameLabel.TabIndex = 0;
            psn_fnameLabel.Text = "Фамилия:";
            // 
            // psn_lnameLabel
            // 
            psn_lnameLabel.AutoSize = true;
            psn_lnameLabel.Location = new System.Drawing.Point(74, 49);
            psn_lnameLabel.Name = "psn_lnameLabel";
            psn_lnameLabel.Size = new System.Drawing.Size(32, 13);
            psn_lnameLabel.TabIndex = 2;
            psn_lnameLabel.Text = "Имя:";
            // 
            // psn_mnameLabel
            // 
            psn_mnameLabel.AutoSize = true;
            psn_mnameLabel.Location = new System.Drawing.Point(49, 75);
            psn_mnameLabel.Name = "psn_mnameLabel";
            psn_mnameLabel.Size = new System.Drawing.Size(57, 13);
            psn_mnameLabel.TabIndex = 4;
            psn_mnameLabel.Text = "Отчество:";
            // 
            // psn_birthdateLabel
            // 
            psn_birthdateLabel.AutoSize = true;
            psn_birthdateLabel.Location = new System.Drawing.Point(15, 167);
            psn_birthdateLabel.Name = "psn_birthdateLabel";
            psn_birthdateLabel.Size = new System.Drawing.Size(89, 13);
            psn_birthdateLabel.TabIndex = 8;
            psn_birthdateLabel.Text = "Дата рождения:";
            // 
            // psn_birthplaceLabel
            // 
            psn_birthplaceLabel.AutoSize = true;
            psn_birthplaceLabel.Location = new System.Drawing.Point(9, 193);
            psn_birthplaceLabel.Name = "psn_birthplaceLabel";
            psn_birthplaceLabel.Size = new System.Drawing.Size(95, 13);
            psn_birthplaceLabel.TabIndex = 10;
            psn_birthplaceLabel.Text = "Место рождения:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(psn_birthplaceLabel);
            this.groupBox1.Controls.Add(this.psn_birthplaceTextBox);
            this.groupBox1.Controls.Add(psn_birthdateLabel);
            this.groupBox1.Controls.Add(this.psn_birthdateDateTimePicker);
            this.groupBox1.Controls.Add(psn_mnameLabel);
            this.groupBox1.Controls.Add(this.psn_mnameTextBox);
            this.groupBox1.Controls.Add(psn_lnameLabel);
            this.groupBox1.Controls.Add(this.psn_lnameTextBox);
            this.groupBox1.Controls.Add(psn_fnameLabel);
            this.groupBox1.Controls.Add(this.psn_fnameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Персональная информация";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(18, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 58);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Гражданство:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.personsBindingSource, "psn_foreign", true));
            this.radioButton4.Location = new System.Drawing.Point(92, 35);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 17);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Другое";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "persons";
            this.personsBindingSource.DataSource = this.dataSetMainForm;
            // 
            // dataSetMainForm
            // 
            this.dataSetMainForm.DataSetName = "DataSetMainForm";
            this.dataSetMainForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(92, 11);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 17);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "РФ";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(70, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 60);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пол:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(40, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Женский";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.personsBindingSource, "psn_male", true));
            this.radioButton1.Location = new System.Drawing.Point(40, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Мужской";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // psn_birthplaceTextBox
            // 
            this.psn_birthplaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "psn_birthplace", true));
            this.psn_birthplaceTextBox.Location = new System.Drawing.Point(110, 190);
            this.psn_birthplaceTextBox.Multiline = true;
            this.psn_birthplaceTextBox.Name = "psn_birthplaceTextBox";
            this.psn_birthplaceTextBox.Size = new System.Drawing.Size(229, 88);
            this.psn_birthplaceTextBox.TabIndex = 11;
            this.psn_birthplaceTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // psn_birthdateDateTimePicker
            // 
            this.psn_birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personsBindingSource, "psn_birthdate", true));
            this.psn_birthdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.psn_birthdateDateTimePicker.Location = new System.Drawing.Point(110, 164);
            this.psn_birthdateDateTimePicker.Name = "psn_birthdateDateTimePicker";
            this.psn_birthdateDateTimePicker.Size = new System.Drawing.Size(229, 20);
            this.psn_birthdateDateTimePicker.TabIndex = 9;
            this.psn_birthdateDateTimePicker.ValueChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // psn_mnameTextBox
            // 
            this.psn_mnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "psn_mname", true));
            this.psn_mnameTextBox.Location = new System.Drawing.Point(110, 72);
            this.psn_mnameTextBox.Name = "psn_mnameTextBox";
            this.psn_mnameTextBox.Size = new System.Drawing.Size(229, 20);
            this.psn_mnameTextBox.TabIndex = 5;
            this.psn_mnameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // psn_lnameTextBox
            // 
            this.psn_lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "psn_lname", true));
            this.psn_lnameTextBox.Location = new System.Drawing.Point(110, 46);
            this.psn_lnameTextBox.Name = "psn_lnameTextBox";
            this.psn_lnameTextBox.Size = new System.Drawing.Size(229, 20);
            this.psn_lnameTextBox.TabIndex = 3;
            this.psn_lnameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // psn_fnameTextBox
            // 
            this.psn_fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "psn_fname", true));
            this.psn_fnameTextBox.Location = new System.Drawing.Point(110, 20);
            this.psn_fnameTextBox.Name = "psn_fnameTextBox";
            this.psn_fnameTextBox.Size = new System.Drawing.Size(229, 20);
            this.psn_fnameTextBox.TabIndex = 1;
            this.psn_fnameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cardsTableAdapter = null;
            this.tableAdapterManager.cworkmarksTableAdapter = null;
            this.tableAdapterManager.groupsTableAdapter = null;
            this.tableAdapterManager.personsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager.practicmarksTableAdapter = null;
            this.tableAdapterManager.practicnamesTableAdapter = null;
            this.tableAdapterManager.schoolsTableAdapter = null;
            this.tableAdapterManager.semestermarksTableAdapter = null;
            this.tableAdapterManager.semestermissingsTableAdapter = null;
            this.tableAdapterManager.specialitiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.personsBindingNavigatorSaveItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // personsBindingNavigatorSaveItem
            // 
            this.personsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personsBindingNavigatorSaveItem.Image")));
            this.personsBindingNavigatorSaveItem.Name = "personsBindingNavigatorSaveItem";
            this.personsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.personsBindingNavigatorSaveItem.Click += new System.EventHandler(this.personsBindingNavigatorSaveItem_Click);
            // 
            // personsBindingNavigator
            // 
            this.personsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personsBindingNavigator.BindingSource = this.personsBindingSource;
            this.personsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personsBindingNavigatorSaveItem});
            this.personsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personsBindingNavigator.Name = "personsBindingNavigator";
            this.personsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personsBindingNavigator.Size = new System.Drawing.Size(371, 25);
            this.personsBindingNavigator.TabIndex = 1;
            this.personsBindingNavigator.Text = "bindingNavigator1";
            this.personsBindingNavigator.Visible = false;
            // 
            // cbEditMode
            // 
            this.cbEditMode.AutoSize = true;
            this.cbEditMode.Location = new System.Drawing.Point(12, 12);
            this.cbEditMode.Name = "cbEditMode";
            this.cbEditMode.Size = new System.Drawing.Size(103, 17);
            this.cbEditMode.TabIndex = 4;
            this.cbEditMode.Text = "Редактировать";
            this.cbEditMode.UseVisualStyleBackColor = true;
            this.cbEditMode.CheckStateChanged += new System.EventHandler(this.cbEditMode_CheckedChanged);
            // 
            // FPersonAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 445);
            this.ControlBox = false;
            this.Controls.Add(this.cbEditMode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personsBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FPersonAdd";
            this.Text = "Добавление Студента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPersonAdd_FormClosed);
            this.Load += new System.EventHandler(this.FPCardAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingNavigator)).EndInit();
            this.personsBindingNavigator.ResumeLayout(false);
            this.personsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSetMainForm dataSetMainForm;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private DataSetMainFormTableAdapters.personsTableAdapter personsTableAdapter;
        private DataSetMainFormTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox psn_fnameTextBox;
        private System.Windows.Forms.TextBox psn_birthplaceTextBox;
        private System.Windows.Forms.DateTimePicker psn_birthdateDateTimePicker;
        private System.Windows.Forms.TextBox psn_mnameTextBox;
        private System.Windows.Forms.TextBox psn_lnameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton personsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator personsBindingNavigator;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbEditMode;
    }
}
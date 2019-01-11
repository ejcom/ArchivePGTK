namespace ArchivePGTK
{
    partial class FPractNames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPractNames));
            this.dataSetMainForm = new ArchivePGTK.DataSetMainForm();
            this.practicnamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicnamesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.practicnamesTableAdapter();
            this.tableAdapterManager = new ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager();
            this.practicnamesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.practicnamesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.practicnamesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbFind = new System.Windows.Forms.ToolStripTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicnamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicnamesBindingNavigator)).BeginInit();
            this.practicnamesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practicnamesDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetMainForm
            // 
            this.dataSetMainForm.DataSetName = "DataSetMainForm";
            this.dataSetMainForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.practicnamesTableAdapter = this.practicnamesTableAdapter;
            this.tableAdapterManager.practictypesTableAdapter = null;
            this.tableAdapterManager.remandstatusTableAdapter = null;
            this.tableAdapterManager.schoolsTableAdapter = null;
            this.tableAdapterManager.semestermarksTableAdapter = null;
            this.tableAdapterManager.semestermissingsTableAdapter = null;
            this.tableAdapterManager.specialitiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // practicnamesBindingNavigator
            // 
            this.practicnamesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.practicnamesBindingNavigator.BindingSource = this.practicnamesBindingSource;
            this.practicnamesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.practicnamesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.practicnamesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.practicnamesBindingNavigatorSaveItem,
            this.toolStripLabel1,
            this.tbFind});
            this.practicnamesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.practicnamesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.practicnamesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.practicnamesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.practicnamesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.practicnamesBindingNavigator.Name = "practicnamesBindingNavigator";
            this.practicnamesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.practicnamesBindingNavigator.Size = new System.Drawing.Size(527, 25);
            this.practicnamesBindingNavigator.TabIndex = 0;
            this.practicnamesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
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
            // practicnamesBindingNavigatorSaveItem
            // 
            this.practicnamesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.practicnamesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("practicnamesBindingNavigatorSaveItem.Image")));
            this.practicnamesBindingNavigatorSaveItem.Name = "practicnamesBindingNavigatorSaveItem";
            this.practicnamesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.practicnamesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.practicnamesBindingNavigatorSaveItem.Click += new System.EventHandler(this.practicnamesBindingNavigatorSaveItem_Click);
            // 
            // practicnamesDataGridView
            // 
            this.practicnamesDataGridView.AutoGenerateColumns = false;
            this.practicnamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.practicnamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tableLayoutPanel1.SetColumnSpan(this.practicnamesDataGridView, 4);
            this.practicnamesDataGridView.DataSource = this.practicnamesBindingSource;
            this.practicnamesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.practicnamesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.practicnamesDataGridView.Name = "practicnamesDataGridView";
            this.practicnamesDataGridView.RowHeadersVisible = false;
            this.practicnamesDataGridView.Size = new System.Drawing.Size(521, 290);
            this.practicnamesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pnm_pcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "pnm_pcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pnm_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(366, 299);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "Сохранить";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.practicnamesBindingNavigatorSaveItem_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(448, 299);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Поиск:";
            // 
            // tbFind
            // 
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(100, 25);
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Controls.Add(this.btCancel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btOk, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.practicnamesDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 326);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // FPractNames
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(527, 351);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.practicnamesBindingNavigator);
            this.KeyPreview = true;
            this.Name = "FPractNames";
            this.Text = "Названия практик";
            this.Load += new System.EventHandler(this.FPractNames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicnamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicnamesBindingNavigator)).EndInit();
            this.practicnamesBindingNavigator.ResumeLayout(false);
            this.practicnamesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practicnamesDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetMainForm dataSetMainForm;
        private System.Windows.Forms.BindingSource practicnamesBindingSource;
        private DataSetMainFormTableAdapters.practicnamesTableAdapter practicnamesTableAdapter;
        private DataSetMainFormTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator practicnamesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton practicnamesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView practicnamesDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}
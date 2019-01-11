namespace ArchivePGTK
{
    partial class FSpec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSpec));
            this.dataSetMainForm = new ArchivePGTK.DataSetMainForm();
            this.specialitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialitiesTableAdapter = new ArchivePGTK.DataSetMainFormTableAdapters.specialitiesTableAdapter();
            this.tableAdapterManager = new ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager();
            this.specialitiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.specialitiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.specialitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingNavigator)).BeginInit();
            this.specialitiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetMainForm
            // 
            this.dataSetMainForm.DataSetName = "DataSetMainForm";
            this.dataSetMainForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cardsTableAdapter = null;
            this.tableAdapterManager.cworkmarksTableAdapter = null;
            this.tableAdapterManager.personsTableAdapter = null;
            this.tableAdapterManager.practicmarksTableAdapter = null;
            this.tableAdapterManager.practicnamesTableAdapter = null;
            this.tableAdapterManager.schoolsTableAdapter = null;
            this.tableAdapterManager.semestermarksTableAdapter = null;
            this.tableAdapterManager.semestermissingsTableAdapter = null;
            this.tableAdapterManager.specialitiesTableAdapter = this.specialitiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ArchivePGTK.DataSetMainFormTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specialitiesBindingNavigator
            // 
            this.specialitiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.specialitiesBindingNavigator.BindingSource = this.specialitiesBindingSource;
            this.specialitiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.specialitiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.specialitiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.specialitiesBindingNavigatorSaveItem});
            this.specialitiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.specialitiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.specialitiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.specialitiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.specialitiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.specialitiesBindingNavigator.Name = "specialitiesBindingNavigator";
            this.specialitiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.specialitiesBindingNavigator.Size = new System.Drawing.Size(844, 25);
            this.specialitiesBindingNavigator.TabIndex = 0;
            this.specialitiesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // specialitiesBindingNavigatorSaveItem
            // 
            this.specialitiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.specialitiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("specialitiesBindingNavigatorSaveItem.Image")));
            this.specialitiesBindingNavigatorSaveItem.Name = "specialitiesBindingNavigatorSaveItem";
            this.specialitiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.specialitiesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.specialitiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.specialitiesBindingNavigatorSaveItem_Click);
            // 
            // specialitiesDataGridView
            // 
            this.specialitiesDataGridView.AutoGenerateColumns = false;
            this.specialitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.specialitiesDataGridView.DataSource = this.specialitiesBindingSource;
            this.specialitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specialitiesDataGridView.Location = new System.Drawing.Point(0, 25);
            this.specialitiesDataGridView.Name = "specialitiesDataGridView";
            this.specialitiesDataGridView.RowHeadersWidth = 20;
            this.specialitiesDataGridView.Size = new System.Drawing.Size(844, 477);
            this.specialitiesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "spc_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "spc_specialization";
            this.dataGridViewTextBoxColumn3.HeaderText = "Специализация";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "spc_kvalification";
            this.dataGridViewTextBoxColumn4.HeaderText = "Квалификация";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "spc_key";
            this.dataGridViewTextBoxColumn5.HeaderText = "spc_key";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "spc_length";
            this.dataGridViewTextBoxColumn6.HeaderText = "spc_length";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "spc_shortname";
            this.dataGridViewTextBoxColumn7.HeaderText = "Сокращение";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 502);
            this.Controls.Add(this.specialitiesDataGridView);
            this.Controls.Add(this.specialitiesBindingNavigator);
            this.Name = "FSpec";
            this.Text = "Специальности";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FSpec_FormClosed);
            this.Load += new System.EventHandler(this.FSpec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingNavigator)).EndInit();
            this.specialitiesBindingNavigator.ResumeLayout(false);
            this.specialitiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetMainForm dataSetMainForm;
        private System.Windows.Forms.BindingSource specialitiesBindingSource;
        private DataSetMainFormTableAdapters.specialitiesTableAdapter specialitiesTableAdapter;
        private DataSetMainFormTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator specialitiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton specialitiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView specialitiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
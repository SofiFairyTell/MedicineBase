namespace Больница
{
    partial class Form4
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
            System.Windows.Forms.Label отделениеLabel;
            System.Windows.Forms.Label палатаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dBDataSet = new Больница.DBDataSet();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new Больница.DBDataSetTableAdapters.DepartmentTableAdapter();
            this.tableAdapterManager = new Больница.DBDataSetTableAdapters.TableAdapterManager();
            this.departmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.departmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.отделениеTextBox = new System.Windows.Forms.TextBox();
            this.палатаTextBox = new System.Windows.Forms.TextBox();
            отделениеLabel = new System.Windows.Forms.Label();
            палатаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingNavigator)).BeginInit();
            this.departmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // отделениеLabel
            // 
            отделениеLabel.AutoSize = true;
            отделениеLabel.Location = new System.Drawing.Point(4, 318);
            отделениеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            отделениеLabel.Name = "отделениеLabel";
            отделениеLabel.Size = new System.Drawing.Size(84, 16);
            отделениеLabel.TabIndex = 6;
            отделениеLabel.Text = "Отделение:";
            // 
            // палатаLabel
            // 
            палатаLabel.AutoSize = true;
            палатаLabel.Location = new System.Drawing.Point(306, 318);
            палатаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            палатаLabel.Name = "палатаLabel";
            палатаLabel.Size = new System.Drawing.Size(60, 16);
            палатаLabel.TabIndex = 7;
            палатаLabel.Text = "Палата:";
            палатаLabel.Click += new System.EventHandler(this.палатаLabel_Click);
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dBDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Больница.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departmentBindingNavigator
            // 
            this.departmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.departmentBindingNavigator.BindingSource = this.departmentBindingSource;
            this.departmentBindingNavigator.CountItem = null;
            this.departmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.departmentBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.departmentBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.departmentBindingNavigatorSaveItem});
            this.departmentBindingNavigator.Location = new System.Drawing.Point(0, 385);
            this.departmentBindingNavigator.MoveFirstItem = null;
            this.departmentBindingNavigator.MoveLastItem = null;
            this.departmentBindingNavigator.MoveNextItem = null;
            this.departmentBindingNavigator.MovePreviousItem = null;
            this.departmentBindingNavigator.Name = "departmentBindingNavigator";
            this.departmentBindingNavigator.PositionItem = null;
            this.departmentBindingNavigator.Size = new System.Drawing.Size(410, 25);
            this.departmentBindingNavigator.TabIndex = 0;
            this.departmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(63, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "Отмена";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // departmentBindingNavigatorSaveItem
            // 
            this.departmentBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.departmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.departmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("departmentBindingNavigatorSaveItem.Image")));
            this.departmentBindingNavigatorSaveItem.Name = "departmentBindingNavigatorSaveItem";
            this.departmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(79, 22);
            this.departmentBindingNavigatorSaveItem.Text = "Сохранить";
            this.departmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.departmentBindingNavigatorSaveItem_Click_5);
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.AllowUserToAddRows = false;
            this.departmentDataGridView.AutoGenerateColumns = false;
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.departmentDataGridView.DataSource = this.departmentBindingSource;
            this.departmentDataGridView.Location = new System.Drawing.Point(7, 6);
            this.departmentDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.Size = new System.Drawing.Size(395, 271);
            this.departmentDataGridView.TabIndex = 5;
            this.departmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 250F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Отделение";
            this.dataGridViewTextBoxColumn2.FillWeight = 250F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Отделение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Палата";
            this.dataGridViewTextBoxColumn3.HeaderText = "Палата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Новое";
            // 
            // отделениеTextBox
            // 
            this.отделениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Отделение", true));
            this.отделениеTextBox.Location = new System.Drawing.Point(96, 315);
            this.отделениеTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.отделениеTextBox.Name = "отделениеTextBox";
            this.отделениеTextBox.Size = new System.Drawing.Size(189, 22);
            this.отделениеTextBox.TabIndex = 7;
            // 
            // палатаTextBox
            // 
            this.палатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Палата", true));
            this.палатаTextBox.Location = new System.Drawing.Point(374, 315);
            this.палатаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.палатаTextBox.Name = "палатаTextBox";
            this.палатаTextBox.Size = new System.Drawing.Size(28, 22);
            this.палатаTextBox.TabIndex = 8;
            this.палатаTextBox.TextChanged += new System.EventHandler(this.палатаTextBox_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 410);
            this.Controls.Add(палатаLabel);
            this.Controls.Add(this.палатаTextBox);
            this.Controls.Add(отделениеLabel);
            this.Controls.Add(this.отделениеTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentDataGridView);
            this.Controls.Add(this.departmentBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingNavigator)).EndInit();
            this.departmentBindingNavigator.ResumeLayout(false);
            this.departmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DBDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator departmentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton departmentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView departmentDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox отделениеTextBox;
        private System.Windows.Forms.TextBox палатаTextBox;
    }
}
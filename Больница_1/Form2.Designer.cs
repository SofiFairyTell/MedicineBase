namespace Больница
{
    partial class Form2
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label адрес_пропискиLabel;
            System.Windows.Forms.Label диагнозLabel;
            System.Windows.Forms.Label дата_поступленияLabel;
            System.Windows.Forms.Label отделениеLabel;
            System.Windows.Forms.Label палатаLabel;
            System.Windows.Forms.Label фамилияLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dBDataSet = new Больница.DBDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Больница.DBDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new Больница.DBDataSetTableAdapters.TableAdapterManager();
            this.departmentTableAdapter = new Больница.DBDataSetTableAdapters.DepartmentTableAdapter();
            this.doctorTableAdapter = new Больница.DBDataSetTableAdapters.DoctorTableAdapter();
            this.patientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.patientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адрес_пропискиTextBox = new System.Windows.Forms.TextBox();
            this.диагнозTextBox = new System.Windows.Forms.TextBox();
            this.дата_поступленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.отделениеComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.палатаComboBox = new System.Windows.Forms.ComboBox();
            this.фамилияComboBox = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            адрес_пропискиLabel = new System.Windows.Forms.Label();
            диагнозLabel = new System.Windows.Forms.Label();
            дата_поступленияLabel = new System.Windows.Forms.Label();
            отделениеLabel = new System.Windows.Forms.Label();
            палатаLabel = new System.Windows.Forms.Label();
            фамилияLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).BeginInit();
            this.patientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(12, 25);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 1;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(12, 52);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 3;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(12, 78);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 5;
            отчествоLabel.Text = "Отчество:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(12, 105);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 7;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // адрес_пропискиLabel
            // 
            адрес_пропискиLabel.AutoSize = true;
            адрес_пропискиLabel.Location = new System.Drawing.Point(9, 130);
            адрес_пропискиLabel.Name = "адрес_пропискиLabel";
            адрес_пропискиLabel.Size = new System.Drawing.Size(92, 13);
            адрес_пропискиLabel.TabIndex = 9;
            адрес_пропискиLabel.Text = "Адрес прописки:";
            // 
            // диагнозLabel
            // 
            диагнозLabel.AutoSize = true;
            диагнозLabel.Location = new System.Drawing.Point(11, 188);
            диагнозLabel.Name = "диагнозLabel";
            диагнозLabel.Size = new System.Drawing.Size(54, 13);
            диагнозLabel.TabIndex = 11;
            диагнозLabel.Text = "Диагноз:";
            // 
            // дата_поступленияLabel
            // 
            дата_поступленияLabel.AutoSize = true;
            дата_поступленияLabel.Location = new System.Drawing.Point(12, 159);
            дата_поступленияLabel.Name = "дата_поступленияLabel";
            дата_поступленияLabel.Size = new System.Drawing.Size(58, 13);
            дата_поступленияLabel.TabIndex = 13;
            дата_поступленияLabel.Text = "Поступил:";
            // 
            // отделениеLabel
            // 
            отделениеLabel.AutoSize = true;
            отделениеLabel.Location = new System.Drawing.Point(12, 219);
            отделениеLabel.Name = "отделениеLabel";
            отделениеLabel.Size = new System.Drawing.Size(65, 13);
            отделениеLabel.TabIndex = 15;
            отделениеLabel.Text = "Отделение:";
            // 
            // палатаLabel
            // 
            палатаLabel.AutoSize = true;
            палатаLabel.Location = new System.Drawing.Point(192, 219);
            палатаLabel.Name = "палатаLabel";
            палатаLabel.Size = new System.Drawing.Size(47, 13);
            палатаLabel.TabIndex = 17;
            палатаLabel.Text = "Палата:";
            // 
            // фамилияLabel1
            // 
            фамилияLabel1.AutoSize = true;
            фамилияLabel1.Location = new System.Drawing.Point(12, 250);
            фамилияLabel1.Name = "фамилияLabel1";
            фамилияLabel1.Size = new System.Drawing.Size(73, 13);
            фамилияLabel1.TabIndex = 19;
            фамилияLabel1.Text = "Лечаий врач:";
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dBDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.DoctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.UpdateOrder = Больница.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // patientBindingNavigator
            // 
            this.patientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientBindingNavigator.BindingSource = this.patientBindingSource;
            this.patientBindingNavigator.CountItem = null;
            this.patientBindingNavigator.DeleteItem = null;
            this.patientBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.patientBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.patientBindingNavigator.Location = new System.Drawing.Point(0, 302);
            this.patientBindingNavigator.MoveFirstItem = null;
            this.patientBindingNavigator.MoveLastItem = null;
            this.patientBindingNavigator.MoveNextItem = null;
            this.patientBindingNavigator.MovePreviousItem = null;
            this.patientBindingNavigator.Name = "patientBindingNavigator";
            this.patientBindingNavigator.PositionItem = null;
            this.patientBindingNavigator.Size = new System.Drawing.Size(328, 25);
            this.patientBindingNavigator.TabIndex = 0;
            this.patientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(113, 22);
            this.bindingNavigatorAddNewItem.Text = "Новый пациент";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // patientBindingNavigatorSaveItem
            // 
            this.patientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.patientBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientBindingNavigatorSaveItem.Image")));
            this.patientBindingNavigatorSaveItem.Name = "patientBindingNavigatorSaveItem";
            this.patientBindingNavigatorSaveItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.patientBindingNavigatorSaveItem.Size = new System.Drawing.Size(92, 22);
            this.patientBindingNavigatorSaveItem.Text = "Сохранить";
            this.patientBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButton1.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton1.Text = "Отмена";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(77, 22);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(226, 20);
            this.фамилияTextBox.TabIndex = 2;
            this.фамилияTextBox.TextChanged += new System.EventHandler(this.фамилияTextBox_TextChanged);
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(77, 49);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(226, 20);
            this.имяTextBox.TabIndex = 4;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(77, 75);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(226, 20);
            this.отчествоTextBox.TabIndex = 6;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(107, 101);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 8;
            // 
            // адрес_пропискиTextBox
            // 
            this.адрес_пропискиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Адрес прописки", true));
            this.адрес_пропискиTextBox.Location = new System.Drawing.Point(107, 127);
            this.адрес_пропискиTextBox.Name = "адрес_пропискиTextBox";
            this.адрес_пропискиTextBox.Size = new System.Drawing.Size(196, 20);
            this.адрес_пропискиTextBox.TabIndex = 10;
            // 
            // диагнозTextBox
            // 
            this.диагнозTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Диагноз", true));
            this.диагнозTextBox.Location = new System.Drawing.Point(87, 185);
            this.диагнозTextBox.Name = "диагнозTextBox";
            this.диагнозTextBox.Size = new System.Drawing.Size(216, 20);
            this.диагнозTextBox.TabIndex = 12;
            // 
            // дата_поступленияDateTimePicker
            // 
            this.дата_поступленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Дата поступления", true));
            this.дата_поступленияDateTimePicker.Location = new System.Drawing.Point(87, 153);
            this.дата_поступленияDateTimePicker.Name = "дата_поступленияDateTimePicker";
            this.дата_поступленияDateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.дата_поступленияDateTimePicker.TabIndex = 14;
            // 
            // отделениеComboBox
            // 
            this.отделениеComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Отделение", true));
            this.отделениеComboBox.FormattingEnabled = true;
            this.отделениеComboBox.Location = new System.Drawing.Point(87, 216);
            this.отделениеComboBox.Name = "отделениеComboBox";
            this.отделениеComboBox.Size = new System.Drawing.Size(102, 21);
            this.отделениеComboBox.TabIndex = 16;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "FK__Patient__idDepar__2739D489";
            this.departmentBindingSource.DataSource = this.patientBindingSource;
            // 
            // палатаComboBox
            // 
            this.палатаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Палата", true));
            this.палатаComboBox.FormattingEnabled = true;
            this.палатаComboBox.Location = new System.Drawing.Point(245, 216);
            this.палатаComboBox.Name = "палатаComboBox";
            this.палатаComboBox.Size = new System.Drawing.Size(58, 21);
            this.палатаComboBox.TabIndex = 18;
            // 
            // фамилияComboBox
            // 
            this.фамилияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Фамилия", true));
            this.фамилияComboBox.FormattingEnabled = true;
            this.фамилияComboBox.Location = new System.Drawing.Point(87, 246);
            this.фамилияComboBox.Name = "фамилияComboBox";
            this.фамилияComboBox.Size = new System.Drawing.Size(216, 21);
            this.фамилияComboBox.TabIndex = 20;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "FK__Doctor__idDepart__4D5F7D71";
            this.doctorBindingSource.DataSource = this.departmentBindingSource;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 327);
            this.Controls.Add(фамилияLabel1);
            this.Controls.Add(this.фамилияComboBox);
            this.Controls.Add(палатаLabel);
            this.Controls.Add(this.палатаComboBox);
            this.Controls.Add(отделениеLabel);
            this.Controls.Add(this.отделениеComboBox);
            this.Controls.Add(дата_поступленияLabel);
            this.Controls.Add(this.дата_поступленияDateTimePicker);
            this.Controls.Add(диагнозLabel);
            this.Controls.Add(this.диагнозTextBox);
            this.Controls.Add(адрес_пропискиLabel);
            this.Controls.Add(this.адрес_пропискиTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(this.patientBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).EndInit();
            this.patientBindingNavigator.ResumeLayout(false);
            this.patientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DBDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton patientBindingNavigatorSaveItem;
        private DBDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox адрес_пропискиTextBox;
        private System.Windows.Forms.TextBox диагнозTextBox;
        private System.Windows.Forms.DateTimePicker дата_поступленияDateTimePicker;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DBDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.ComboBox отделениеComboBox;
        private System.Windows.Forms.ComboBox палатаComboBox;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.ComboBox фамилияComboBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
namespace Больница
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label специальнстьLabel;
            System.Windows.Forms.Label отделениеLabel1;
            System.Windows.Forms.Label палатаLabel;
            System.Windows.Forms.Label фамилияLabel;
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Больница.DBDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.фамилияLabel1 = new System.Windows.Forms.Label();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.палатаLabel1 = new System.Windows.Forms.Label();
            this.отделениеLabel2 = new System.Windows.Forms.Label();
            this.специальнстьLabel1 = new System.Windows.Forms.Label();
            this.отчествоLabel1 = new System.Windows.Forms.Label();
            this.имяLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.patientTableAdapter = new Больница.DBDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new Больница.DBDataSetTableAdapters.TableAdapterManager();
            this.departmentTableAdapter = new Больница.DBDataSetTableAdapters.DepartmentTableAdapter();
            this.doctorTableAdapter = new Больница.DBDataSetTableAdapters.DoctorTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            специальнстьLabel = new System.Windows.Forms.Label();
            отделениеLabel1 = new System.Windows.Forms.Label();
            палатаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(325, 123);
            имяLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(53, 24);
            имяLabel.TabIndex = 6;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(517, 123);
            отчествоLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(95, 24);
            отчествоLabel.TabIndex = 8;
            отчествоLabel.Text = "Отчество:";
            // 
            // специальнстьLabel
            // 
            специальнстьLabel.AutoSize = true;
            специальнстьLabel.Location = new System.Drawing.Point(8, 76);
            специальнстьLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            специальнстьLabel.Name = "специальнстьLabel";
            специальнстьLabel.Size = new System.Drawing.Size(143, 24);
            специальнстьLabel.TabIndex = 10;
            специальнстьLabel.Text = "Лечащий врач:";
            // 
            // отделениеLabel1
            // 
            отделениеLabel1.AutoSize = true;
            отделениеLabel1.Location = new System.Drawing.Point(8, 33);
            отделениеLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            отделениеLabel1.Name = "отделениеLabel1";
            отделениеLabel1.Size = new System.Drawing.Size(112, 24);
            отделениеLabel1.TabIndex = 11;
            отделениеLabel1.Text = "Отделение:";
            // 
            // палатаLabel
            // 
            палатаLabel.AutoSize = true;
            палатаLabel.Location = new System.Drawing.Point(231, 33);
            палатаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            палатаLabel.Name = "палатаLabel";
            палатаLabel.Size = new System.Drawing.Size(104, 24);
            палатаLabel.TabIndex = 12;
            палатаLabel.Text = "Палата №:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(8, 123);
            фамилияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(97, 24);
            фамилияLabel.TabIndex = 13;
            фамилияLabel.Text = "Фамилия:";
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.patientDataGridView.DataSource = this.patientBindingSource;
            this.patientDataGridView.Location = new System.Drawing.Point(7, 5);
            this.patientDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.Size = new System.Drawing.Size(1289, 289);
            this.patientDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Адрес прописки";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адрес прописки";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Диагноз";
            this.dataGridViewTextBoxColumn7.HeaderText = "Диагноз";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Дата поступления";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата поступления";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Дата выписки";
            this.dataGridViewTextBoxColumn9.HeaderText = "Дата выписки";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "idDepartment";
            this.dataGridViewTextBoxColumn10.HeaderText = "idDepartment";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(фамилияLabel);
            this.groupBox1.Controls.Add(this.фамилияLabel1);
            this.groupBox1.Controls.Add(палатаLabel);
            this.groupBox1.Controls.Add(this.палатаLabel1);
            this.groupBox1.Controls.Add(отделениеLabel1);
            this.groupBox1.Controls.Add(this.отделениеLabel2);
            this.groupBox1.Controls.Add(специальнстьLabel);
            this.groupBox1.Controls.Add(this.специальнстьLabel1);
            this.groupBox1.Controls.Add(отчествоLabel);
            this.groupBox1.Controls.Add(this.отчествоLabel1);
            this.groupBox1.Controls.Add(имяLabel);
            this.groupBox1.Controls.Add(this.имяLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(11, 297);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(819, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация:";
            // 
            // фамилияLabel1
            // 
            this.фамилияLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Фамилия", true));
            this.фамилияLabel1.Location = new System.Drawing.Point(120, 123);
            this.фамилияLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.фамилияLabel1.Name = "фамилияLabel1";
            this.фамилияLabel1.Size = new System.Drawing.Size(133, 28);
            this.фамилияLabel1.TabIndex = 14;
            this.фамилияLabel1.Text = "-";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "FK__Doctor__idDepart__4D5F7D71";
            this.doctorBindingSource.DataSource = this.departmentBindingSource;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "FK__Patient__idDepar__2739D489";
            this.departmentBindingSource.DataSource = this.patientBindingSource;
            // 
            // палатаLabel1
            // 
            this.палатаLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Палата", true));
            this.палатаLabel1.Location = new System.Drawing.Point(339, 33);
            this.палатаLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.палатаLabel1.Name = "палатаLabel1";
            this.палатаLabel1.Size = new System.Drawing.Size(133, 28);
            this.палатаLabel1.TabIndex = 13;
            this.палатаLabel1.Text = "-";
            this.палатаLabel1.Click += new System.EventHandler(this.палатаLabel1_Click);
            // 
            // отделениеLabel2
            // 
            this.отделениеLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Палата", true));
            this.отделениеLabel2.Location = new System.Drawing.Point(133, 33);
            this.отделениеLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.отделениеLabel2.Name = "отделениеLabel2";
            this.отделениеLabel2.Size = new System.Drawing.Size(133, 28);
            this.отделениеLabel2.TabIndex = 12;
            this.отделениеLabel2.Text = "-";
            // 
            // специальнстьLabel1
            // 
            this.специальнстьLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Специальнсть", true));
            this.специальнстьLabel1.Location = new System.Drawing.Point(164, 78);
            this.специальнстьLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.специальнстьLabel1.Name = "специальнстьLabel1";
            this.специальнстьLabel1.Size = new System.Drawing.Size(133, 28);
            this.специальнстьLabel1.TabIndex = 11;
            this.специальнстьLabel1.Text = "-";
            // 
            // отчествоLabel1
            // 
            this.отчествоLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Отчество", true));
            this.отчествоLabel1.Location = new System.Drawing.Point(623, 123);
            this.отчествоLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.отчествоLabel1.Name = "отчествоLabel1";
            this.отчествоLabel1.Size = new System.Drawing.Size(133, 28);
            this.отчествоLabel1.TabIndex = 9;
            this.отчествоLabel1.Text = "-";
            // 
            // имяLabel1
            // 
            this.имяLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Имя", true));
            this.имяLabel1.Location = new System.Drawing.Point(376, 123);
            this.имяLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.имяLabel1.Name = "имяLabel1";
            this.имяLabel1.Size = new System.Drawing.Size(133, 28);
            this.имяLabel1.TabIndex = 7;
            this.имяLabel1.Text = "-";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1023, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "ДОБАВИТЬ | ИЗМЕНИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1023, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "ДОБАВИТЬ СОТРУДНИКА";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(1023, 377);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "ДОБАВИТЬ ОТДЕЛЕНИЕ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1023, 414);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 28);
            this.button4.TabIndex = 6;
            this.button4.Text = "СОЗДАТЬ ОЧЕТ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(1303, 466);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.patientDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DBDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private DBDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DBDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Label специальнстьLabel1;
        private System.Windows.Forms.Label отчествоLabel1;
        private System.Windows.Forms.Label имяLabel1;
        private System.Windows.Forms.Label палатаLabel1;
        private System.Windows.Forms.Label отделениеLabel2;
        private System.Windows.Forms.Label фамилияLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


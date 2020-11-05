namespace Result
{
    partial class SecureForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecureForm));
            this.UserChooseComboBox = new System.Windows.Forms.ComboBox();
            this.пользовательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ПользовательНадпись = new System.Windows.Forms.Label();
            this.ПарольНадпись = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.СообщениеПароль = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserChooseComboBox
            // 
            this.UserChooseComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserChooseComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UserChooseComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserChooseComboBox.FormattingEnabled = true;
            this.UserChooseComboBox.Items.AddRange(new object[] {
            "Администратор",
            "Аналитик",
            "Секретарь"});
            this.UserChooseComboBox.Location = new System.Drawing.Point(200, 69);
            this.UserChooseComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserChooseComboBox.Name = "UserChooseComboBox";
            this.UserChooseComboBox.Size = new System.Drawing.Size(378, 31);
            this.UserChooseComboBox.TabIndex = 1;
            this.UserChooseComboBox.UseWaitCursor = true;
            this.UserChooseComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // пользовательBindingSource
            // 
            this.пользовательBindingSource.DataMember = "Пользователь";
            this.пользовательBindingSource.CurrentChanged += new System.EventHandler(this.пользовательBindingSource_CurrentChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(200, 118);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(378, 30);
            this.PasswordTextBox.TabIndex = 2;
            this.СообщениеПароль.SetToolTip(this.PasswordTextBox, "Введите Ваш пароль здесь");
            this.PasswordTextBox.UseWaitCursor = true;
            // 
            // ПользовательНадпись
            // 
            this.ПользовательНадпись.AutoSize = true;
            this.ПользовательНадпись.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ПользовательНадпись.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ПользовательНадпись.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПользовательНадпись.Location = new System.Drawing.Point(46, 72);
            this.ПользовательНадпись.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ПользовательНадпись.Name = "ПользовательНадпись";
            this.ПользовательНадпись.Size = new System.Drawing.Size(136, 25);
            this.ПользовательНадпись.TabIndex = 0;
            this.ПользовательНадпись.Text = "Пользователь";
            this.ПользовательНадпись.UseWaitCursor = true;
            // 
            // ПарольНадпись
            // 
            this.ПарольНадпись.AutoSize = true;
            this.ПарольНадпись.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ПарольНадпись.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПарольНадпись.Location = new System.Drawing.Point(106, 125);
            this.ПарольНадпись.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ПарольНадпись.Name = "ПарольНадпись";
            this.ПарольНадпись.Size = new System.Drawing.Size(76, 23);
            this.ПарольНадпись.TabIndex = 0;
            this.ПарольНадпись.Text = "Пароль";
            this.ПарольНадпись.UseWaitCursor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(276, 171);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(124, 46);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.UseWaitCursor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OkButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(434, 171);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(127, 46);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.UseWaitCursor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SecureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(591, 297);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserChooseComboBox);
            this.Controls.Add(this.ПарольНадпись);
            this.Controls.Add(this.ПользовательНадпись);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты медицинского освидетельствования";
            this.Load += new System.EventHandler(this.SecureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox UserChooseComboBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label ПользовательНадпись;
        private System.Windows.Forms.Label ПарольНадпись;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.BindingSource пользовательBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolTip СообщениеПароль;
    }
}


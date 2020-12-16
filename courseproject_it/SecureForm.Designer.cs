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
            this.ПользовательНадпись = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.СообщениеПароль = new System.Windows.Forms.ToolTip(this.components);
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.buttonNew1 = new Result.ButtonNew();
            this.ExitButton = new Result.ButtonNew();
            this.label1 = new System.Windows.Forms.Label();
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
            this.UserChooseComboBox.Location = new System.Drawing.Point(200, 66);
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
            // ПользовательНадпись
            // 
            this.ПользовательНадпись.AutoSize = true;
            this.ПользовательНадпись.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ПользовательНадпись.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ПользовательНадпись.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПользовательНадпись.Location = new System.Drawing.Point(56, 72);
            this.ПользовательНадпись.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ПользовательНадпись.Name = "ПользовательНадпись";
            this.ПользовательНадпись.Size = new System.Drawing.Size(136, 25);
            this.ПользовательНадпись.TabIndex = 0;
            this.ПользовательНадпись.Text = "Пользователь";
            this.ПользовательНадпись.UseWaitCursor = true;
            // 
            // СообщениеПароль
            // 
            this.СообщениеПароль.Popup += new System.Windows.Forms.PopupEventHandler(this.СообщениеПароль_Popup);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(199, 116);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(379, 30);
            this.PasswordTextBox.TabIndex = 7;
            this.СообщениеПароль.SetToolTip(this.PasswordTextBox, "Введите пароль");
            // 
            // buttonNew1
            // 
            this.buttonNew1.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonNew1.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonNew1.BackColorGradientEnabled = false;
            this.buttonNew1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonNew1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonNew1.BorderColorEnabled = false;
            this.buttonNew1.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonNew1.BorderColorOnHoverEnabled = false;
            this.buttonNew1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNew1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonNew1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.buttonNew1.ForeColor = System.Drawing.Color.White;
            this.buttonNew1.Location = new System.Drawing.Point(407, 225);
            this.buttonNew1.Name = "buttonNew1";
            this.buttonNew1.RippleColor = System.Drawing.Color.Black;
            this.buttonNew1.RoundingEnable = false;
            this.buttonNew1.Size = new System.Drawing.Size(171, 44);
            this.buttonNew1.TabIndex = 5;
            this.buttonNew1.Text = "ОK";
            this.buttonNew1.TextHover = null;
            this.buttonNew1.UseDownPressEffectOnClick = false;
            this.buttonNew1.UseRippleEffect = true;
            this.buttonNew1.UseZoomEffectOnHover = false;
            this.buttonNew1.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.ExitButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.ExitButton.BackColorGradientEnabled = false;
            this.ExitButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ExitButton.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ExitButton.BorderColorEnabled = false;
            this.ExitButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.ExitButton.BorderColorOnHoverEnabled = false;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(200, 224);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.RippleColor = System.Drawing.Color.Black;
            this.ExitButton.RoundingEnable = false;
            this.ExitButton.Size = new System.Drawing.Size(200, 45);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.TextHover = null;
            this.ExitButton.UseDownPressEffectOnClick = false;
            this.ExitButton.UseRippleEffect = true;
            this.ExitButton.UseZoomEffectOnHover = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пароль";
            this.label1.UseWaitCursor = true;
            // 
            // SecureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(591, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.buttonNew1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UserChooseComboBox);
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
        private System.Windows.Forms.Label ПользовательНадпись;
        private System.Windows.Forms.BindingSource пользовательBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolTip СообщениеПароль;
        private ButtonNew ExitButton;
        private ButtonNew buttonNew1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
    }
}


namespace Result
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.OpenAllPersonForm = new System.Windows.Forms.Button();
            this.OpenAnalizForm = new System.Windows.Forms.Button();
            this.OpenAddForm = new System.Windows.Forms.Button();
            this.OpenInstructionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenAllPersonForm
            // 
            this.OpenAllPersonForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAllPersonForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAllPersonForm.Location = new System.Drawing.Point(55, 184);
            this.OpenAllPersonForm.Name = "OpenAllPersonForm";
            this.OpenAllPersonForm.Size = new System.Drawing.Size(200, 35);
            this.OpenAllPersonForm.TabIndex = 0;
            this.OpenAllPersonForm.Text = "Открыть базу данных";
            this.OpenAllPersonForm.UseVisualStyleBackColor = true;
            this.OpenAllPersonForm.Click += new System.EventHandler(this.OpenAllPersonForm_Click);
            // 
            // OpenAnalizForm
            // 
            this.OpenAnalizForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAnalizForm.Location = new System.Drawing.Point(340, 184);
            this.OpenAnalizForm.Name = "OpenAnalizForm";
            this.OpenAnalizForm.Size = new System.Drawing.Size(200, 35);
            this.OpenAnalizForm.TabIndex = 1;
            this.OpenAnalizForm.Text = "Аналитика";
            this.OpenAnalizForm.UseVisualStyleBackColor = true;
            this.OpenAnalizForm.Click += new System.EventHandler(this.OpenAnalizForm_Click);
            // 
            // OpenAddForm
            // 
            this.OpenAddForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAddForm.Location = new System.Drawing.Point(331, 403);
            this.OpenAddForm.Name = "OpenAddForm";
            this.OpenAddForm.Size = new System.Drawing.Size(200, 35);
            this.OpenAddForm.TabIndex = 2;
            this.OpenAddForm.Text = "Добавить данные";
            this.OpenAddForm.UseVisualStyleBackColor = true;
            this.OpenAddForm.Click += new System.EventHandler(this.OpenAddForm_Click);
            // 
            // OpenInstructionButton
            // 
            this.OpenInstructionButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenInstructionButton.Location = new System.Drawing.Point(55, 403);
            this.OpenInstructionButton.Name = "OpenInstructionButton";
            this.OpenInstructionButton.Size = new System.Drawing.Size(200, 35);
            this.OpenInstructionButton.TabIndex = 3;
            this.OpenInstructionButton.Text = "Инструкция";
            this.OpenInstructionButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.OpenInstructionButton);
            this.Controls.Add(this.OpenAddForm);
            this.Controls.Add(this.OpenAnalizForm);
            this.Controls.Add(this.OpenAllPersonForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочее пространство";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenAllPersonForm;
        private System.Windows.Forms.Button OpenAnalizForm;
        private System.Windows.Forms.Button OpenAddForm;
        private System.Windows.Forms.Button OpenInstructionButton;
    }
}
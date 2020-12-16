namespace Result
{
    partial class PersonsTreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Список по категориям");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Список по воинскому званию");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Список освидетельствуемых", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.PersonsTreView = new System.Windows.Forms.TreeView();
            this.DataDescriptionGrid = new System.Windows.Forms.DataGridView();
            this.ExportExcellButton = new Result.ButtonNew();
            ((System.ComponentModel.ISupportInitialize)(this.DataDescriptionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonsTreView
            // 
            this.PersonsTreView.Dock = System.Windows.Forms.DockStyle.Left;
            this.PersonsTreView.Location = new System.Drawing.Point(0, 0);
            this.PersonsTreView.Name = "PersonsTreView";
            treeNode1.Name = "CategoryList";
            treeNode1.Text = "Список по категориям";
            treeNode2.Name = "ArmStatusList";
            treeNode2.Text = "Список по воинскому званию";
            treeNode3.Name = "PersonList";
            treeNode3.Text = "Список освидетельствуемых";
            this.PersonsTreView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.PersonsTreView.Size = new System.Drawing.Size(342, 572);
            this.PersonsTreView.TabIndex = 0;
            this.PersonsTreView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.PersonsTreView_NodeMouseDoubleClick);
            // 
            // DataDescriptionGrid
            // 
            this.DataDescriptionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDescriptionGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataDescriptionGrid.Location = new System.Drawing.Point(342, 0);
            this.DataDescriptionGrid.Name = "DataDescriptionGrid";
            this.DataDescriptionGrid.RowTemplate.Height = 24;
            this.DataDescriptionGrid.Size = new System.Drawing.Size(1073, 572);
            this.DataDescriptionGrid.TabIndex = 1;
            // 
            // ExportExcellButton
            // 
            this.ExportExcellButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.ExportExcellButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.ExportExcellButton.BackColorGradientEnabled = false;
            this.ExportExcellButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ExportExcellButton.BorderColor = System.Drawing.Color.MidnightBlue;
            this.ExportExcellButton.BorderColorEnabled = false;
            this.ExportExcellButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.ExportExcellButton.BorderColorOnHoverEnabled = false;
            this.ExportExcellButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportExcellButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExportExcellButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExportExcellButton.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ExportExcellButton.ForeColor = System.Drawing.Color.White;
            this.ExportExcellButton.Location = new System.Drawing.Point(342, 500);
            this.ExportExcellButton.Name = "ExportExcellButton";
            this.ExportExcellButton.RippleColor = System.Drawing.Color.Black;
            this.ExportExcellButton.RoundingEnable = false;
            this.ExportExcellButton.Size = new System.Drawing.Size(1073, 72);
            this.ExportExcellButton.TabIndex = 2;
            this.ExportExcellButton.Text = "Сохранить в Excell";
            this.ExportExcellButton.TextHover = null;
            this.ExportExcellButton.UseDownPressEffectOnClick = false;
            this.ExportExcellButton.UseRippleEffect = true;
            this.ExportExcellButton.UseZoomEffectOnHover = false;
            this.ExportExcellButton.DoubleClick += new System.EventHandler(this.ExportExcellButton_DoubleClick);
            // 
            // PersonsTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 572);
            this.Controls.Add(this.ExportExcellButton);
            this.Controls.Add(this.DataDescriptionGrid);
            this.Controls.Add(this.PersonsTreView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonsTreeView";
            this.Text = "PersonsTreeView";
            ((System.ComponentModel.ISupportInitialize)(this.DataDescriptionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView PersonsTreView;
        private System.Windows.Forms.DataGridView DataDescriptionGrid;
        private ButtonNew ExportExcellButton;
    }
}
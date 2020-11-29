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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Список по должности");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Иванов");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Фамилии", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Список освидетельствуемых", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode4});
            this.PersonsTreView = new System.Windows.Forms.TreeView();
            this.DataDescriptionGrid = new System.Windows.Forms.DataGridView();
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
            treeNode2.Text = "Список по должности";
            treeNode3.Name = "Ivanov";
            treeNode3.Text = "Иванов";
            treeNode4.Name = "SurnameList";
            treeNode4.Text = "Фамилии";
            treeNode5.Name = "PersonList";
            treeNode5.Text = "Список освидетельствуемых";
            this.PersonsTreView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.PersonsTreView.Size = new System.Drawing.Size(374, 572);
            this.PersonsTreView.TabIndex = 0;
            this.PersonsTreView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.PersonsTreView_AfterSelect);
            this.PersonsTreView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.PersonsTreView_NodeMouseDoubleClick);
            this.PersonsTreView.Click += new System.EventHandler(this.PersonsTreView_Click);
            this.PersonsTreView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PersonsTreView_MouseDoubleClick);
            // 
            // DataDescriptionGrid
            // 
            this.DataDescriptionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDescriptionGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.DataDescriptionGrid.Location = new System.Drawing.Point(380, 0);
            this.DataDescriptionGrid.Name = "DataDescriptionGrid";
            this.DataDescriptionGrid.RowTemplate.Height = 24;
            this.DataDescriptionGrid.Size = new System.Drawing.Size(809, 572);
            this.DataDescriptionGrid.TabIndex = 1;
            this.DataDescriptionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataList_CellContentClick);
            // 
            // PersonsTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 572);
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
    }
}
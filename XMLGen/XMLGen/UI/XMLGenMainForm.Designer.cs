namespace XMLGen.UI
{
    partial class XMLGen
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Messages");
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMenu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSubMenu_FieldPrperties = new System.Windows.Forms.ToolStripMenuItem();
            this.messagePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Messages_TreeView = new System.Windows.Forms.TreeView();
            this.cntxtMstrip_TreeNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgview_properties = new System.Windows.Forms.DataGridView();
            this.dgview_FieldEdit = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.cntxtMstrip_TreeNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_FieldEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenu_Add});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMenu_Add
            // 
            this.TSMenu_Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSubMenu_FieldPrperties,
            this.messagePropertiesToolStripMenuItem});
            this.TSMenu_Add.Name = "TSMenu_Add";
            this.TSMenu_Add.Size = new System.Drawing.Size(43, 20);
            this.TSMenu_Add.Text = "ADD";
            // 
            // TSSubMenu_FieldPrperties
            // 
            this.TSSubMenu_FieldPrperties.Name = "TSSubMenu_FieldPrperties";
            this.TSSubMenu_FieldPrperties.Size = new System.Drawing.Size(176, 22);
            this.TSSubMenu_FieldPrperties.Text = "Field properties";
            this.TSSubMenu_FieldPrperties.Click += new System.EventHandler(this.TSSubMenu_FieldPrperties_Click);
            // 
            // messagePropertiesToolStripMenuItem
            // 
            this.messagePropertiesToolStripMenuItem.Name = "messagePropertiesToolStripMenuItem";
            this.messagePropertiesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.messagePropertiesToolStripMenuItem.Text = "Message Properties";
            this.messagePropertiesToolStripMenuItem.Click += new System.EventHandler(this.messagePropertiesToolStripMenuItem_Click);
            // 
            // Messages_TreeView
            // 
            this.Messages_TreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Messages_TreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.Messages_TreeView.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messages_TreeView.Location = new System.Drawing.Point(0, 24);
            this.Messages_TreeView.Name = "Messages_TreeView";
            treeNode2.Name = "Messages";
            treeNode2.Text = "Messages";
            this.Messages_TreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.Messages_TreeView.Size = new System.Drawing.Size(230, 533);
            this.Messages_TreeView.TabIndex = 2;
            this.Messages_TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Messages_TreeView_NodeMouseClick);
            this.Messages_TreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Messages_TreeView_MouseDoubleClick);
            // 
            // cntxtMstrip_TreeNode
            // 
            this.cntxtMstrip_TreeNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMessageToolStripMenuItem,
            this.addFieldToolStripMenuItem,
            this.deleteMessageToolStripMenuItem,
            this.editToolStripMenuItem});
            this.cntxtMstrip_TreeNode.Name = "contextMenuStrip1";
            this.cntxtMstrip_TreeNode.Size = new System.Drawing.Size(146, 92);
            // 
            // addMessageToolStripMenuItem
            // 
            this.addMessageToolStripMenuItem.Name = "addMessageToolStripMenuItem";
            this.addMessageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addMessageToolStripMenuItem.Text = "Add Message";
            this.addMessageToolStripMenuItem.Click += new System.EventHandler(this.addMessageToolStripMenuItem_Click);
            // 
            // addFieldToolStripMenuItem
            // 
            this.addFieldToolStripMenuItem.Name = "addFieldToolStripMenuItem";
            this.addFieldToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addFieldToolStripMenuItem.Text = "Add Field";
            this.addFieldToolStripMenuItem.Click += new System.EventHandler(this.addFieldToolStripMenuItem_Click);
            // 
            // deleteMessageToolStripMenuItem
            // 
            this.deleteMessageToolStripMenuItem.Name = "deleteMessageToolStripMenuItem";
            this.deleteMessageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteMessageToolStripMenuItem.Text = "Delete";
            this.deleteMessageToolStripMenuItem.Click += new System.EventHandler(this.deleteMessageToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // dgview_properties
            // 
            this.dgview_properties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_properties.Location = new System.Drawing.Point(236, 27);
            this.dgview_properties.Name = "dgview_properties";
            this.dgview_properties.Size = new System.Drawing.Size(716, 527);
            this.dgview_properties.TabIndex = 3;
            // 
            // dgview_FieldEdit
            // 
            this.dgview_FieldEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_FieldEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgview_FieldEdit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgview_FieldEdit.GridColor = System.Drawing.SystemColors.Control;
            this.dgview_FieldEdit.Location = new System.Drawing.Point(230, 24);
            this.dgview_FieldEdit.Name = "dgview_FieldEdit";
            this.dgview_FieldEdit.Size = new System.Drawing.Size(722, 533);
            this.dgview_FieldEdit.TabIndex = 4;
            // 
            // XMLGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 579);
            this.Controls.Add(this.dgview_FieldEdit);
            this.Controls.Add(this.dgview_properties);
            this.Controls.Add(this.Messages_TreeView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "XMLGen";
            this.Text = "XMLGen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cntxtMstrip_TreeNode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_FieldEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMenu_Add;
        private System.Windows.Forms.ToolStripMenuItem TSSubMenu_FieldPrperties;
        private System.Windows.Forms.TreeView Messages_TreeView;
        private System.Windows.Forms.DataGridView dgview_properties;
        private System.Windows.Forms.ContextMenuStrip cntxtMstrip_TreeNode;
        private System.Windows.Forms.ToolStripMenuItem addMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagePropertiesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgview_FieldEdit;
    }
}


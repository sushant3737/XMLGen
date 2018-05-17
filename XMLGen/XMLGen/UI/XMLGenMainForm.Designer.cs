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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Messages");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_AppStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMenu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSubMenu_FieldPrperties = new System.Windows.Forms.ToolStripMenuItem();
            this.messagePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exportbinary = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Importbinary = new System.Windows.Forms.ToolStripMenuItem();
            this.Messages_TreeView = new System.Windows.Forms.TreeView();
            this.cntxtMstrip_TreeNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMessageBelowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addFieldToolStripBelowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgview_properties = new System.Windows.Forms.DataGridView();
            this.dgview_FieldEdit = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cntxtMstrip_TreeNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_FieldEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_AppStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_AppStatus
            // 
            this.toolStripStatusLabel_AppStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel_AppStatus.Name = "toolStripStatusLabel_AppStatus";
            this.toolStripStatusLabel_AppStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenu_Add,
            this.fileToolStripMenuItem});
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
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Exportbinary,
            this.xMLToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // ToolStripMenuItem_Exportbinary
            // 
            this.ToolStripMenuItem_Exportbinary.Name = "ToolStripMenuItem_Exportbinary";
            this.ToolStripMenuItem_Exportbinary.Size = new System.Drawing.Size(107, 22);
            this.ToolStripMenuItem_Exportbinary.Text = "Binary";
            this.ToolStripMenuItem_Exportbinary.Click += new System.EventHandler(this.ToolStripMenuItem_Exportbinary_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Importbinary});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // ToolStripMenuItem_Importbinary
            // 
            this.ToolStripMenuItem_Importbinary.Name = "ToolStripMenuItem_Importbinary";
            this.ToolStripMenuItem_Importbinary.Size = new System.Drawing.Size(107, 22);
            this.ToolStripMenuItem_Importbinary.Text = "Binary";
            this.ToolStripMenuItem_Importbinary.Click += new System.EventHandler(this.ToolStripMenuItem_Importbinary_Click);
            // 
            // Messages_TreeView
            // 
            this.Messages_TreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Messages_TreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.Messages_TreeView.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messages_TreeView.Location = new System.Drawing.Point(0, 24);
            this.Messages_TreeView.Name = "Messages_TreeView";
            treeNode1.Name = "Messages";
            treeNode1.Text = "Messages";
            this.Messages_TreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.Messages_TreeView.Size = new System.Drawing.Size(230, 533);
            this.Messages_TreeView.TabIndex = 2;
            this.Messages_TreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.Messages_TreeView_AfterLabelEdit);
            this.Messages_TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Messages_TreeView_NodeMouseClick);
            this.Messages_TreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Messages_TreeView_MouseDoubleClick);
            // 
            // cntxtMstrip_TreeNode
            // 
            this.cntxtMstrip_TreeNode.DropShadowEnabled = false;
            this.cntxtMstrip_TreeNode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntxtMstrip_TreeNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMessageBelowToolStripMenuItem,
            this.toolStripSeparator1,
            this.addFieldToolStripBelowMenuItem,
            this.toolStripSeparator2,
            this.deleteMessageToolStripMenuItem,
            this.editToolStripMenuItem});
            this.cntxtMstrip_TreeNode.Name = "contextMenuStrip1";
            this.cntxtMstrip_TreeNode.Size = new System.Drawing.Size(181, 104);
            // 
            // addMessageBelowToolStripMenuItem
            // 
            this.addMessageBelowToolStripMenuItem.Name = "addMessageBelowToolStripMenuItem";
            this.addMessageBelowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addMessageBelowToolStripMenuItem.Text = "Add Message Below";
            this.addMessageBelowToolStripMenuItem.Click += new System.EventHandler(this.addMessageBelowToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // addFieldToolStripBelowMenuItem
            // 
            this.addFieldToolStripBelowMenuItem.Name = "addFieldToolStripBelowMenuItem";
            this.addFieldToolStripBelowMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFieldToolStripBelowMenuItem.Text = "Add Field Below";
            this.addFieldToolStripBelowMenuItem.Click += new System.EventHandler(this.addFieldToolStripBelowMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // deleteMessageToolStripMenuItem
            // 
            this.deleteMessageToolStripMenuItem.Name = "deleteMessageToolStripMenuItem";
            this.deleteMessageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteMessageToolStripMenuItem.Text = "Delete";
            this.deleteMessageToolStripMenuItem.Click += new System.EventHandler(this.deleteMessageToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgview_FieldEdit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgview_FieldEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgview_FieldEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_FieldEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgview_FieldEdit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgview_FieldEdit.GridColor = System.Drawing.SystemColors.Control;
            this.dgview_FieldEdit.Location = new System.Drawing.Point(230, 24);
            this.dgview_FieldEdit.Name = "dgview_FieldEdit";
            this.dgview_FieldEdit.Size = new System.Drawing.Size(722, 533);
            this.dgview_FieldEdit.TabIndex = 4;
            this.dgview_FieldEdit.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_FieldEdit_CellValueChanged);
            // 
            // XMLGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem deleteMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagePropertiesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgview_FieldEdit;
        private System.Windows.Forms.ToolStripMenuItem addMessageBelowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addFieldToolStripBelowMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exportbinary;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Importbinary;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_AppStatus;
    }
}


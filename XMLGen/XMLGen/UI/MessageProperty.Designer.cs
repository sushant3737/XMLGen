namespace XMLGen.UI
{
    partial class MessageProperty
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
            this.dgview_MessageProperties = new System.Windows.Forms.DataGridView();
            this.btn_AddDefaultMessageAtrrib = new System.Windows.Forms.Button();
            this.cmbbx_DefaultMsgAttribs = new System.Windows.Forms.ComboBox();
            this.btn_addMessageAttrib = new System.Windows.Forms.Button();
            this.txtbx_key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gB1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbx_value = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_MessageProperties)).BeginInit();
            this.gB1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgview_MessageProperties
            // 
            this.dgview_MessageProperties.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgview_MessageProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgview_MessageProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_MessageProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgview_MessageProperties.Location = new System.Drawing.Point(265, 0);
            this.dgview_MessageProperties.Name = "dgview_MessageProperties";
            this.dgview_MessageProperties.Size = new System.Drawing.Size(240, 257);
            this.dgview_MessageProperties.TabIndex = 1;
            // 
            // btn_AddDefaultMessageAtrrib
            // 
            this.btn_AddDefaultMessageAtrrib.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AddDefaultMessageAtrrib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDefaultMessageAtrrib.Location = new System.Drawing.Point(102, 192);
            this.btn_AddDefaultMessageAtrrib.Name = "btn_AddDefaultMessageAtrrib";
            this.btn_AddDefaultMessageAtrrib.Size = new System.Drawing.Size(100, 23);
            this.btn_AddDefaultMessageAtrrib.TabIndex = 10;
            this.btn_AddDefaultMessageAtrrib.Text = "Add";
            this.btn_AddDefaultMessageAtrrib.UseVisualStyleBackColor = false;
            this.btn_AddDefaultMessageAtrrib.Click += new System.EventHandler(this.btn_AddDefaultMessageAtrrib_Click);
            // 
            // cmbbx_DefaultMsgAttribs
            // 
            this.cmbbx_DefaultMsgAttribs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_DefaultMsgAttribs.FormattingEnabled = true;
            this.cmbbx_DefaultMsgAttribs.Location = new System.Drawing.Point(102, 165);
            this.cmbbx_DefaultMsgAttribs.Name = "cmbbx_DefaultMsgAttribs";
            this.cmbbx_DefaultMsgAttribs.Size = new System.Drawing.Size(100, 21);
            this.cmbbx_DefaultMsgAttribs.TabIndex = 9;
            // 
            // btn_addMessageAttrib
            // 
            this.btn_addMessageAttrib.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_addMessageAttrib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMessageAttrib.Location = new System.Drawing.Point(90, 69);
            this.btn_addMessageAttrib.Name = "btn_addMessageAttrib";
            this.btn_addMessageAttrib.Size = new System.Drawing.Size(100, 23);
            this.btn_addMessageAttrib.TabIndex = 8;
            this.btn_addMessageAttrib.Text = "Add";
            this.btn_addMessageAttrib.UseVisualStyleBackColor = false;
            this.btn_addMessageAttrib.Click += new System.EventHandler(this.btn_addMessageAttrib_Click);
            // 
            // txtbx_key
            // 
            this.txtbx_key.Location = new System.Drawing.Point(90, 17);
            this.txtbx_key.Name = "txtbx_key";
            this.txtbx_key.Size = new System.Drawing.Size(100, 20);
            this.txtbx_key.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attribute:";
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.txtbx_value);
            this.gB1.Controls.Add(this.label2);
            this.gB1.Controls.Add(this.label1);
            this.gB1.Controls.Add(this.btn_addMessageAttrib);
            this.gB1.Controls.Add(this.txtbx_key);
            this.gB1.Location = new System.Drawing.Point(12, 12);
            this.gB1.Name = "gB1";
            this.gB1.Size = new System.Drawing.Size(210, 105);
            this.gB1.TabIndex = 11;
            this.gB1.TabStop = false;
            this.gB1.Text = "CustomField";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Attribute:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 86);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PredefinedFields";
            // 
            // txtbx_value
            // 
            this.txtbx_value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbx_value.FormattingEnabled = true;
            this.txtbx_value.Items.AddRange(new object[] {
            "bool",
            "byte",
            "sbyte",
            "short",
            "ushort",
            "int",
            "uint",
            "long",
            "ulong",
            "string"});
            this.txtbx_value.Location = new System.Drawing.Point(90, 43);
            this.txtbx_value.Name = "txtbx_value";
            this.txtbx_value.Size = new System.Drawing.Size(100, 21);
            this.txtbx_value.TabIndex = 9;
            // 
            // MessageProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 257);
            this.Controls.Add(this.gB1);
            this.Controls.Add(this.btn_AddDefaultMessageAtrrib);
            this.Controls.Add(this.cmbbx_DefaultMsgAttribs);
            this.Controls.Add(this.dgview_MessageProperties);
            this.Controls.Add(this.groupBox1);
            this.Name = "MessageProperty";
            this.Text = "MessageProperty";
            this.VisibleChanged += new System.EventHandler(this.MessageProperty_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_MessageProperties)).EndInit();
            this.gB1.ResumeLayout(false);
            this.gB1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgview_MessageProperties;
        private System.Windows.Forms.Button btn_AddDefaultMessageAtrrib;
        private System.Windows.Forms.ComboBox cmbbx_DefaultMsgAttribs;
        private System.Windows.Forms.Button btn_addMessageAttrib;
        private System.Windows.Forms.TextBox txtbx_key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtbx_value;
    }
}
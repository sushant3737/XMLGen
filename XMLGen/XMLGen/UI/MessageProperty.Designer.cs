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
            this.txtbx_value = new System.Windows.Forms.TextBox();
            this.txtbx_key = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_MessageProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgview_MessageProperties
            // 
            this.dgview_MessageProperties.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgview_MessageProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgview_MessageProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_MessageProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgview_MessageProperties.Location = new System.Drawing.Point(132, 0);
            this.dgview_MessageProperties.Name = "dgview_MessageProperties";
            this.dgview_MessageProperties.Size = new System.Drawing.Size(240, 257);
            this.dgview_MessageProperties.TabIndex = 1;
            // 
            // btn_AddDefaultMessageAtrrib
            // 
            this.btn_AddDefaultMessageAtrrib.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AddDefaultMessageAtrrib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDefaultMessageAtrrib.Location = new System.Drawing.Point(12, 139);
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
            this.cmbbx_DefaultMsgAttribs.Location = new System.Drawing.Point(12, 112);
            this.cmbbx_DefaultMsgAttribs.Name = "cmbbx_DefaultMsgAttribs";
            this.cmbbx_DefaultMsgAttribs.Size = new System.Drawing.Size(100, 21);
            this.cmbbx_DefaultMsgAttribs.TabIndex = 9;
            // 
            // btn_addMessageAttrib
            // 
            this.btn_addMessageAttrib.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_addMessageAttrib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMessageAttrib.Location = new System.Drawing.Point(12, 68);
            this.btn_addMessageAttrib.Name = "btn_addMessageAttrib";
            this.btn_addMessageAttrib.Size = new System.Drawing.Size(100, 23);
            this.btn_addMessageAttrib.TabIndex = 8;
            this.btn_addMessageAttrib.Text = "Add";
            this.btn_addMessageAttrib.UseVisualStyleBackColor = false;
            this.btn_addMessageAttrib.Click += new System.EventHandler(this.btn_addMessageAttrib_Click);
            // 
            // txtbx_value
            // 
            this.txtbx_value.Location = new System.Drawing.Point(12, 42);
            this.txtbx_value.Name = "txtbx_value";
            this.txtbx_value.Size = new System.Drawing.Size(100, 20);
            this.txtbx_value.TabIndex = 7;
            // 
            // txtbx_key
            // 
            this.txtbx_key.Location = new System.Drawing.Point(12, 16);
            this.txtbx_key.Name = "txtbx_key";
            this.txtbx_key.Size = new System.Drawing.Size(100, 20);
            this.txtbx_key.TabIndex = 6;
            // 
            // MessageProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 257);
            this.Controls.Add(this.btn_AddDefaultMessageAtrrib);
            this.Controls.Add(this.cmbbx_DefaultMsgAttribs);
            this.Controls.Add(this.btn_addMessageAttrib);
            this.Controls.Add(this.txtbx_value);
            this.Controls.Add(this.txtbx_key);
            this.Controls.Add(this.dgview_MessageProperties);
            this.Name = "MessageProperty";
            this.Text = "MessageProperty";
            this.VisibleChanged += new System.EventHandler(this.MessageProperty_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_MessageProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgview_MessageProperties;
        private System.Windows.Forms.Button btn_AddDefaultMessageAtrrib;
        private System.Windows.Forms.ComboBox cmbbx_DefaultMsgAttribs;
        private System.Windows.Forms.Button btn_addMessageAttrib;
        private System.Windows.Forms.TextBox txtbx_value;
        private System.Windows.Forms.TextBox txtbx_key;
    }
}
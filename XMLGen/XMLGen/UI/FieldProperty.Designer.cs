namespace XMLGen.UI
{
    partial class FieldProperty
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
            this.dgview_FieldProperties = new System.Windows.Forms.DataGridView();
            this.txtbx_key = new System.Windows.Forms.TextBox();
            this.btn_addField = new System.Windows.Forms.Button();
            this.cmbbx_Defaultfields = new System.Windows.Forms.ComboBox();
            this.btn_AddDefaultfield = new System.Windows.Forms.Button();
            this.gB1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_value = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_FieldProperties)).BeginInit();
            this.gB1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgview_FieldProperties
            // 
            this.dgview_FieldProperties.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgview_FieldProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgview_FieldProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_FieldProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgview_FieldProperties.Location = new System.Drawing.Point(252, 0);
            this.dgview_FieldProperties.Name = "dgview_FieldProperties";
            this.dgview_FieldProperties.Size = new System.Drawing.Size(240, 262);
            this.dgview_FieldProperties.TabIndex = 0;
            // 
            // txtbx_key
            // 
            this.txtbx_key.Location = new System.Drawing.Point(94, 17);
            this.txtbx_key.Name = "txtbx_key";
            this.txtbx_key.Size = new System.Drawing.Size(100, 20);
            this.txtbx_key.TabIndex = 1;
            // 
            // btn_addField
            // 
            this.btn_addField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_addField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addField.Location = new System.Drawing.Point(94, 69);
            this.btn_addField.Name = "btn_addField";
            this.btn_addField.Size = new System.Drawing.Size(100, 23);
            this.btn_addField.TabIndex = 3;
            this.btn_addField.Text = "Add";
            this.btn_addField.UseVisualStyleBackColor = false;
            this.btn_addField.Click += new System.EventHandler(this.btn_addField_Click);
            // 
            // cmbbx_Defaultfields
            // 
            this.cmbbx_Defaultfields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Defaultfields.FormattingEnabled = true;
            this.cmbbx_Defaultfields.Location = new System.Drawing.Point(94, 19);
            this.cmbbx_Defaultfields.Name = "cmbbx_Defaultfields";
            this.cmbbx_Defaultfields.Size = new System.Drawing.Size(100, 21);
            this.cmbbx_Defaultfields.TabIndex = 4;
            // 
            // btn_AddDefaultfield
            // 
            this.btn_AddDefaultfield.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AddDefaultfield.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDefaultfield.Location = new System.Drawing.Point(94, 46);
            this.btn_AddDefaultfield.Name = "btn_AddDefaultfield";
            this.btn_AddDefaultfield.Size = new System.Drawing.Size(100, 23);
            this.btn_AddDefaultfield.TabIndex = 5;
            this.btn_AddDefaultfield.Text = "Add";
            this.btn_AddDefaultfield.UseVisualStyleBackColor = false;
            this.btn_AddDefaultfield.Click += new System.EventHandler(this.btn_AddDefaultfield_Click);
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.txtbx_value);
            this.gB1.Controls.Add(this.label2);
            this.gB1.Controls.Add(this.label1);
            this.gB1.Controls.Add(this.txtbx_key);
            this.gB1.Controls.Add(this.btn_addField);
            this.gB1.Location = new System.Drawing.Point(12, 12);
            this.gB1.Name = "gB1";
            this.gB1.Size = new System.Drawing.Size(210, 105);
            this.gB1.TabIndex = 6;
            this.gB1.TabStop = false;
            this.gB1.Text = "CustomField";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbbx_Defaultfields);
            this.groupBox1.Controls.Add(this.btn_AddDefaultfield);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PredefinedFields";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value Type:";
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
            this.txtbx_value.Location = new System.Drawing.Point(94, 42);
            this.txtbx_value.Name = "txtbx_value";
            this.txtbx_value.Size = new System.Drawing.Size(100, 21);
            this.txtbx_value.TabIndex = 10;
            // 
            // FieldProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 262);
            this.Controls.Add(this.gB1);
            this.Controls.Add(this.dgview_FieldProperties);
            this.Controls.Add(this.groupBox1);
            this.Name = "FieldProperty";
            this.Text = "FieldProperty";
            this.VisibleChanged += new System.EventHandler(this.FieldProperty_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_FieldProperties)).EndInit();
            this.gB1.ResumeLayout(false);
            this.gB1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgview_FieldProperties;
        private System.Windows.Forms.TextBox txtbx_key;
        private System.Windows.Forms.Button btn_addField;
        private System.Windows.Forms.ComboBox cmbbx_Defaultfields;
        private System.Windows.Forms.Button btn_AddDefaultfield;
        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtbx_value;
    }
}
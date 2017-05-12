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
            this.txtbx_value = new System.Windows.Forms.TextBox();
            this.btn_addField = new System.Windows.Forms.Button();
            this.cmbbx_Defaultfields = new System.Windows.Forms.ComboBox();
            this.btn_AddDefaultfield = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_FieldProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgview_FieldProperties
            // 
            this.dgview_FieldProperties.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgview_FieldProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgview_FieldProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_FieldProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgview_FieldProperties.Location = new System.Drawing.Point(131, 0);
            this.dgview_FieldProperties.Name = "dgview_FieldProperties";
            this.dgview_FieldProperties.Size = new System.Drawing.Size(240, 262);
            this.dgview_FieldProperties.TabIndex = 0;
            // 
            // txtbx_key
            // 
            this.txtbx_key.Location = new System.Drawing.Point(12, 10);
            this.txtbx_key.Name = "txtbx_key";
            this.txtbx_key.Size = new System.Drawing.Size(100, 20);
            this.txtbx_key.TabIndex = 1;
            // 
            // txtbx_value
            // 
            this.txtbx_value.Location = new System.Drawing.Point(12, 36);
            this.txtbx_value.Name = "txtbx_value";
            this.txtbx_value.Size = new System.Drawing.Size(100, 20);
            this.txtbx_value.TabIndex = 2;
            // 
            // btn_addField
            // 
            this.btn_addField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_addField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addField.Location = new System.Drawing.Point(12, 62);
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
            this.cmbbx_Defaultfields.Location = new System.Drawing.Point(12, 106);
            this.cmbbx_Defaultfields.Name = "cmbbx_Defaultfields";
            this.cmbbx_Defaultfields.Size = new System.Drawing.Size(100, 21);
            this.cmbbx_Defaultfields.TabIndex = 4;
            // 
            // btn_AddDefaultfield
            // 
            this.btn_AddDefaultfield.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AddDefaultfield.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDefaultfield.Location = new System.Drawing.Point(12, 133);
            this.btn_AddDefaultfield.Name = "btn_AddDefaultfield";
            this.btn_AddDefaultfield.Size = new System.Drawing.Size(100, 23);
            this.btn_AddDefaultfield.TabIndex = 5;
            this.btn_AddDefaultfield.Text = "Add";
            this.btn_AddDefaultfield.UseVisualStyleBackColor = false;
            this.btn_AddDefaultfield.Click += new System.EventHandler(this.btn_AddDefaultfield_Click);
            // 
            // FieldProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 262);
            this.Controls.Add(this.btn_AddDefaultfield);
            this.Controls.Add(this.cmbbx_Defaultfields);
            this.Controls.Add(this.btn_addField);
            this.Controls.Add(this.txtbx_value);
            this.Controls.Add(this.txtbx_key);
            this.Controls.Add(this.dgview_FieldProperties);
            this.Name = "FieldProperty";
            this.Text = "FieldProperty";
            ((System.ComponentModel.ISupportInitialize)(this.dgview_FieldProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgview_FieldProperties;
        private System.Windows.Forms.TextBox txtbx_key;
        private System.Windows.Forms.TextBox txtbx_value;
        private System.Windows.Forms.Button btn_addField;
        private System.Windows.Forms.ComboBox cmbbx_Defaultfields;
        private System.Windows.Forms.Button btn_AddDefaultfield;

    }
}
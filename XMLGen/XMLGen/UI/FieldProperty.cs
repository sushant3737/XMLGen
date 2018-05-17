// <copyright file="MessageProperty.cs" >
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Sushant hiremath</author>
// <date>17/05/2018 11:39:58 AM </date>
// <summary>Form to add Field property</summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLGen.UI
{
    public partial class FieldProperty : Form
    {
        public static List<KeyValue> DefaultFieldlist = new List<KeyValue>();
        public static List<KeyValue> Fieldlist = new List<KeyValue>();
        public FieldProperty()
        {
            InitializeComponent();
            ADDDefaultFields();
            dgview_FieldProperties.DataSource = null;
            dgview_FieldProperties.DataSource = Fieldlist;
            dgview_FieldProperties.Refresh();
        }

        private void btn_addField_Click(object sender, EventArgs e)
        {
            string key = txtbx_key.Text;
            string value = txtbx_value.Text;

            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                //if (value != "byte" && value != "sbyte" && value != "short" && value != "ushort" && value != "bool" && value != "string" && value != "int" && value != "uint" && value != "long" && value != "ulong")
                //{
                //    return;
                //}
                if (!Fieldlist.Exists(x => x.Key == key))
                { 
                    Fieldlist.Add(new KeyValue { Key = key, ValueType = value });
                    dgview_FieldProperties.DataSource = null;
                    dgview_FieldProperties.DataSource = Fieldlist;
                }
            }

        }

        private bool ADDDefaultFields()
        {

            bool returntype = false;

            cmbbx_Defaultfields.Items.Clear();
            DefaultFieldlist.Add(new KeyValue { Key = "Name", ValueType = "string" });
            DefaultFieldlist.Add(new KeyValue { Key = "FieldType", ValueType = "string" });
            DefaultFieldlist.Add(new KeyValue { Key = "BitSize", ValueType = "ulong" });
            DefaultFieldlist.Add(new KeyValue { Key = "MinValue", ValueType = "ulong" });
            DefaultFieldlist.Add(new KeyValue { Key = "MaxValue", ValueType = "ulong" });
            DefaultFieldlist.Add(new KeyValue { Key = "Value", ValueType = "ulong" });
            DefaultFieldlist.Add(new KeyValue { Key = "Visibilty", ValueType = "bool" });

            cmbbx_Defaultfields.Items.AddRange(DefaultFieldlist.Select(n => n.Key).ToArray());
            cmbbx_Defaultfields.Refresh();
            return returntype;
        }

        private void btn_AddDefaultfield_Click(object sender, EventArgs e)
        {
            if (!Fieldlist.Exists(x => x.Key == cmbbx_Defaultfields.Text))
            {
                Fieldlist.Add(DefaultFieldlist.FindLast(x => x.Key == cmbbx_Defaultfields.Text));
                dgview_FieldProperties.DataSource = null;
                dgview_FieldProperties.DataSource = Fieldlist;
            }
        }

        private void FieldProperty_VisibleChanged(object sender, EventArgs e)
        {
            //dgview_FieldProperties.DataSource = null;
            //dgview_FieldProperties.DataSource = Fieldlist;
        }
    }
}

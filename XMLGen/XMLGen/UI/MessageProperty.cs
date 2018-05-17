// <copyright file="MessageProperty.cs" >
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Sushant hiremath</author>
// <date>17/05/2018 11:39:58 AM </date>
// <summary>Form to add Message property</summary>

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
    public partial class MessageProperty : Form
    {
        public static List<KeyValue> DefaultMsgAttriblist = new List<KeyValue>();
        public static List<KeyValue> MsgAttriblist = new List<KeyValue>();
        public MessageProperty()
        {
            InitializeComponent();
            ADDDefaultMsgAttribs();
        }

        private void btn_addMessageAttrib_Click(object sender, EventArgs e)
        {
            string key = txtbx_key.Text;
            string value = txtbx_value.Text;


            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                //if (value != "byte" || value != "sbyte" || value != "short" || value != "ushort" || value != "bool" || value != "string" || value != "int" || value != "uint" || value != "long" || value != "ulong")
                //{
                //    return;
                //}
                if (!MsgAttriblist.Exists(x => x.Key == key))
                {
                    MsgAttriblist.Add(new KeyValue { Key = key, ValueType = value });
                    dgview_MessageProperties.DataSource = null;
                    dgview_MessageProperties.DataSource = MsgAttriblist;
                }
            }

        }

        private void btn_AddDefaultMessageAtrrib_Click(object sender, EventArgs e)
        {
            if (!MsgAttriblist.Exists(x => x.Key == cmbbx_DefaultMsgAttribs.Text))
            {
                MsgAttriblist.Add(DefaultMsgAttriblist.FindLast(x => x.Key == cmbbx_DefaultMsgAttribs.Text));
                dgview_MessageProperties.DataSource = null;
                dgview_MessageProperties.DataSource = MsgAttriblist;
                dgview_MessageProperties.Refresh();
            }
        }
        private bool ADDDefaultMsgAttribs()
        {

            bool returntype = false;

            cmbbx_DefaultMsgAttribs.Items.Clear();
            DefaultMsgAttriblist.Add(new KeyValue { Key = "Name", ValueType = "string" });
            DefaultMsgAttriblist.Add(new KeyValue { Key = "MessageID", ValueType = "int" });

            cmbbx_DefaultMsgAttribs.Items.AddRange(DefaultMsgAttriblist.Select(n => n.Key).ToArray());
            return returntype;
        }

        private void MessageProperty_VisibleChanged(object sender, EventArgs e)
        {
            dgview_MessageProperties.DataSource = null;
            dgview_MessageProperties.DataSource = MsgAttriblist;
            dgview_MessageProperties.Refresh();
        }
    }
}

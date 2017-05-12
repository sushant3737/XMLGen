// <copyright file="MessageProperty.cs" >
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Sushant hiremath</author>
// <date>12/05/2017 11:39:58 AM </date>
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
                MsgAttriblist.Add(new KeyValue { Key = key, Value = value });
            }
            dgview_MessageProperties.DataSource = null;
            dgview_MessageProperties.DataSource = MsgAttriblist;
        }

        private void btn_AddDefaultMessageAtrrib_Click(object sender, EventArgs e)
        {
            if (!MsgAttriblist.Exists(x => x.Key == cmbbx_DefaultMsgAttribs.Text))
            {
                MsgAttriblist.Add(DefaultMsgAttriblist.FindLast(x => x.Key == cmbbx_DefaultMsgAttribs.Text));
                dgview_MessageProperties.DataSource = null;
                dgview_MessageProperties.DataSource = MsgAttriblist;
            }
        }
        private bool ADDDefaultMsgAttribs()
        {

            bool returntype = false;

            cmbbx_DefaultMsgAttribs.Items.Clear();
            DefaultMsgAttriblist.Add(new KeyValue { Key = "Name", ValueType = "string" });
            DefaultMsgAttriblist.Add(new KeyValue { Key = "MessageID", ValueType = "string" });

            cmbbx_DefaultMsgAttribs.Items.AddRange(DefaultMsgAttriblist.Select(n => n.Key).ToArray());
            return returntype;
        }
    }
}

// <copyright file="MessageProperty.cs" >
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Sushant hiremath</author>
// <date>12/05/2017 11:39:58 AM </date>
// <summary>Main form to add messages and fields to tree view, Still in development process to convert message to XML/summary>

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
    /// <summary>
    /// This Main form interract with tree view and dictonary to hold message and respective fields.
    /// </summary>
    public partial class XMLGen : Form
    {
        FieldProperty FieldPrp = null;
        MessageProperty MsgPrp = null;
        public static Dictionary<int, Dictionary<int, List<KeyValue>>> MessageInfo = new Dictionary<int,Dictionary<int, List<KeyValue>>>();
        public static int MessageCounts = 0;
        public static int FieldCounts = 0;
        public static TreeNode TN_MessageInfo = new TreeNode();
        public XMLGen()
        {
            InitializeComponent();
            FieldPrp = new FieldProperty();
            MsgPrp = new MessageProperty();
        }

        private void TSSubMenu_FieldPrperties_Click(object sender, EventArgs e)
        {
            FieldPrp.ShowDialog();
        }

        private void Messages_TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Right:
                    {
                        switch (Messages_TreeView.SelectedNode.Level)
                        {
                            case 0 :
                                    addFieldToolStripMenuItem.Enabled = false;
                                    addMessageToolStripMenuItem.Enabled = true;
                                break;
                            case 1:
                                    addFieldToolStripMenuItem.Enabled = true;
                                    addMessageToolStripMenuItem.Enabled = false;
                                    break;
                            default:
                                    addFieldToolStripMenuItem.Enabled = false;
                                    addMessageToolStripMenuItem.Enabled = false;                          
                                break;
                        }
                        cntxtMstrip_TreeNode.Show(Messages_TreeView, e.Location);
                    }
                    break;
        }
        }

        private void addMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageCounts = Messages_TreeView.SelectedNode.Nodes.Count + 1;

            List<KeyValue> mcopy = MessageProperty.MsgAttriblist.Select(o => new KeyValue
            {
                Key = o.Key,
                ValueType = o.ValueType,
                Value = o.Value
            }).ToList();
            Dictionary<int, List<KeyValue>> Msginfo = new Dictionary<int, List<KeyValue>>();
            Msginfo.Add(0, mcopy);

            if (MessageInfo.Keys.Count > 0)
            {
                int LastMessageKey = MessageInfo.Keys.Last();
                MessageInfo.Add(LastMessageKey + 1, Msginfo);
                Messages_TreeView.SelectedNode.Nodes.Add((LastMessageKey + 1).ToString());
            }
            else
            {   
                MessageInfo.Add(0 , Msginfo);
                Messages_TreeView.SelectedNode.Nodes.Add("0");
            }
            //Messages_TreeView.ExpandAll();
        }

        private void deleteMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (! (Messages_TreeView.SelectedNode.Level == 0))
            {
                Messages_TreeView.Nodes.Remove(Messages_TreeView.SelectedNode);
            }
        }

        private void addFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Messages_TreeView.SelectedNode != null)
            {
                List<KeyValue> fcopy = FieldProperty.Fieldlist.Select(o => new KeyValue
                {
                    Key = o.Key,
                    ValueType = o.ValueType,
                    Value = o.Value
                }).ToList();
                int ParentNodeindex = Messages_TreeView.SelectedNode.Index;
                int Nextkey = MessageInfo[ParentNodeindex].Keys.Last();
                MessageInfo[ParentNodeindex].Add(Nextkey + 1, fcopy);
                Messages_TreeView.SelectedNode.Nodes.Add((Nextkey + 1).ToString());
                
                Messages_TreeView.ExpandAll();
            }
        }

        private void messagePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MsgPrp.ShowDialog();
        }

        private void Messages_TreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {

                        switch (Messages_TreeView.SelectedNode.Level)
                        {
                            case 0:
                                dgview_FieldEdit.DataSource = null;
                                break;
                            case 1:
                                int selection = Convert.ToInt32(Messages_TreeView.SelectedNode.Text);
                                dgview_FieldEdit.DataSource = null;
                                List<KeyValue> temp;
                                MessageInfo[selection].TryGetValue(0, out temp);
                                dgview_FieldEdit.DataSource = temp;
                                break;
                            case 2:
                                int Prntselection = Convert.ToInt32(Messages_TreeView.SelectedNode.Parent.Text);
                                int flddselection = Convert.ToInt32(Messages_TreeView.SelectedNode.Text);
                                dgview_FieldEdit.DataSource = null;
                                MessageInfo[Prntselection].TryGetValue(flddselection, out temp);
                                dgview_FieldEdit.DataSource = temp;
                                break;

                                break;
                            default:
                                break;
                        }

                    }
                    break;
            }
        }
    }
}

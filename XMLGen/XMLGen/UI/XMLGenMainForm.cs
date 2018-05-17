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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLGen.Serialization;



namespace XMLGen.UI
{
    /// <summary>
    /// This Main form interract with tree view and dictonary to hold message and respective fields.
    /// </summary>
    public partial class XMLGen : Form
    {
        FieldProperty FieldPrp = null;
        MessageProperty MsgPrp = null;
        int rootimageindex = 4;
        int SelectedMsgImageIndex = 3;
        int UnSelectedMsgImageIndex = 2;
        int SelectedFldImageIndex = 1;
        int UnSelectedFldImageIndex = 0;

        public static Dictionary<int, Dictionary<int, List<KeyValue>>> MessageInfo = new Dictionary<int,Dictionary<int, List<KeyValue>>>();
        public static int MessageCounts = 0;
        public static int FieldCounts = 0;
        public static TreeNode TN_MessageInfo = new TreeNode();
        public XMLGen()
        {
            InitializeComponent();
            //Call to load icons for treeview
            LoadImageList();
        }

        private void TSSubMenu_FieldPrperties_Click(object sender, EventArgs e)
        {
            FieldPrp = new FieldProperty();
            FieldPrp.Show();
        }

        private void Messages_TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        switch (Messages_TreeView.SelectedNode.Level)
                        {
                            case 0:
                                addFieldToolStripBelowMenuItem.Enabled = false;
                                switch (Messages_TreeView.SelectedNode.Index)
                                {
                                    case 0:
                                        addMessageBelowToolStripMenuItem.Enabled = true;
                                        break;
                                    default:                                  
                                        addMessageBelowToolStripMenuItem.Enabled = true;
                                        break;
                                }
                                break;
                            case 1:
                                switch (Messages_TreeView.SelectedNode.Index)
                                {
                                    case 0:
                                        addFieldToolStripBelowMenuItem.Enabled = true;
                                        addMessageBelowToolStripMenuItem.Enabled = true;
                                        break;
                                    default:
                                        addFieldToolStripBelowMenuItem.Enabled = true;
                                        addMessageBelowToolStripMenuItem.Enabled = true;
                                        break;
                                }
                                break;
                            case 2:
                                switch (Messages_TreeView.SelectedNode.Index)
                                {
                                    case 0:
                                        addFieldToolStripBelowMenuItem.Enabled = true;
                                        addMessageBelowToolStripMenuItem.Enabled = false;
                                        break;
                                   default:
                                        addFieldToolStripBelowMenuItem.Enabled = true;
                                        addMessageBelowToolStripMenuItem.Enabled = false;
                                        break;
                                }
                                break;
                            default:
                                addFieldToolStripBelowMenuItem.Enabled = false;
                                addMessageBelowToolStripMenuItem.Enabled = false;
                                break;
                        }
                        cntxtMstrip_TreeNode.Show(Messages_TreeView, e.Location);
                    }
                    break;
                case MouseButtons.Left:
                    {

                    }
                    break;
                
            }
        }

        private void addMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageCounts = Messages_TreeView.SelectedNode.Nodes.Count + 1;


            //Messages_TreeView.ExpandAll();
        }

        private void deleteMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (Messages_TreeView.SelectedNode.Level)
            {
                case 1:
                    {
                        int selectedindex = Messages_TreeView.SelectedNode.Index;
                        if (MessageInfo.ContainsKey(selectedindex))
                        {
                            var tempdict = MessageInfo.Where(x => x.Key > selectedindex).ToDictionary(p => p.Key - 1);
                            foreach (var ele in tempdict)
                            {


                                MessageInfo.Remove(ele.Key);
                                MessageInfo.Add(ele.Key, ele.Value.Value);

                            }
                            MessageInfo.Remove(MessageInfo.Count - 1);
                        }
                        UpdateTreeView();
                    }
                    break;
                case 2:
                    break;
            }


        }

        private void addFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void messagePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MsgPrp = new MessageProperty();
            MsgPrp.Show();
        }

        private void Messages_TreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        if ((Messages_TreeView.SelectedNode != null))
                        {
                            switch (Messages_TreeView.SelectedNode.Level)
                            {
                                case 0:
                                    dgview_FieldEdit.DataSource = null;
                                    break;
                                case 1:
                                    int selection = Messages_TreeView.SelectedNode.Index;
                                    dgview_FieldEdit.DataSource = null;
                                    List<KeyValue> temp;
                                    MessageInfo[selection].TryGetValue(0, out temp);
                                    dgview_FieldEdit.DataSource = temp;
                                    dgview_FieldEdit.Columns[0].ReadOnly = true;
                                    dgview_FieldEdit.Columns[1].ReadOnly = true;

                                    break;
                                case 2:
                                    int Msgselection = Messages_TreeView.SelectedNode.Parent.Index;
                                    int flddselection = Messages_TreeView.SelectedNode.Index;
                                    dgview_FieldEdit.DataSource = null;
                                    MessageInfo[Msgselection].TryGetValue(flddselection + 1, out temp);
                                    dgview_FieldEdit.DataSource = temp;
                                    dgview_FieldEdit.Columns[0].ReadOnly = true;
                                    dgview_FieldEdit.Columns[1].ReadOnly = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
            }
        }

        private void dgview_FieldEdit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Messages_TreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            {
                string editTxt = e.Label;
                TreeNode node = e.Node;
                if (editTxt != null)
                {
                    if (editTxt.Length > 0)
                    {
                        if (Regex.IsMatch(editTxt, @"^\w+$"))
                        {
                            // Stop editing without canceling the label change.
                            e.Node.EndEdit(false);

                            List<KeyValue> temp;
                            switch (node.Level)
                            {
                                case 1:
                                    {
                                        int MI = node.Index;
                                        MessageInfo[MI].TryGetValue(0, out temp);
                                        //con
                                        temp.Find(x => x.Key == "Name").Value = editTxt;
                                    }
                                    break;
                                case 2:
                                    {
                                        int MI = node.Parent.Index;
                                        int FI = node.Index;
                                        MessageInfo[MI].TryGetValue(FI + 1, out temp);
                                        //con
                                        temp.Find(x => x.Key == "Name").Value = editTxt;
                                    }
                                    break;
                            }
                            
                        }
                        else
                        {
                            /* Cancel the label edit action, inform the user, and 
                               place the node in edit mode again. */
                            e.CancelEdit = true;
                            MessageBox.Show("Invalid tree node label.\n" +
                               "The invalid characters are: '@','.', ',', '!'",
                               "Node Label Edit");
                            e.Node.BeginEdit();
                        }
                    }
                    else
                    {
                        /* Cancel the label edit action, inform the user, and 
                           place the node in edit mode again. */
                        e.CancelEdit = true;
                        MessageBox.Show("Invalid tree node label.\nThe label cannot be blank",
                           "Node Label Edit");
                        e.Node.BeginEdit();
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode mySelectedNode = Messages_TreeView.SelectedNode;
            if (mySelectedNode != null)
            {
                switch (mySelectedNode.Level)
                {
                    case 0:

                        break;
                    case 1:
                        //break;
                    case 2:
                        Messages_TreeView.LabelEdit = true;
                        if (!mySelectedNode.IsEditing)
                        {
                            mySelectedNode.BeginEdit();
                        }
                        break;
                    default:
                        break;
                }
            }
        }


        private void addMessageBelowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<KeyValue> mcopy = MessageProperty.MsgAttriblist.Select(o => new KeyValue
            {
                Key = o.Key,
                ValueType = o.ValueType,
                Value = o.Value
            }).ToList();
            Dictionary<int, List<KeyValue>> Msginfo = new Dictionary<int, List<KeyValue>>();
            Msginfo.Add(0, mcopy);



            switch (Messages_TreeView.SelectedNode.Level)
            {
                case 0:
                    {
                        switch (Messages_TreeView.SelectedNode.Index)
                        {
                            case 0:
                            default:
                                int selectedMsgindex = Messages_TreeView.SelectedNode.Index;
                                //if (MessageInfo.ContainsKey(0))
                                {
                                    var tempdict = MessageInfo.Where(x => x.Key >= 0).ToDictionary(p => p.Key + 1);
                                    MessageInfo.Remove(0);
                                    MessageInfo.Add(0, Msginfo);
                                    foreach (var ele in tempdict)
                                    {
                                        MessageInfo.Remove(ele.Key);
                                        MessageInfo.Add(ele.Key, ele.Value.Value);
                                    }
                                }
                                break;

                        }
                    }
                    break;
                case 1:
                    switch (Messages_TreeView.SelectedNode.Index)
                    {
                        case 0:
                        default:
                            int selectedindex = Messages_TreeView.SelectedNode.Index;
                            if (MessageInfo.ContainsKey(selectedindex + 1))
                            {
                                var tempdict = MessageInfo.Where(x => x.Key > selectedindex).ToDictionary(p => p.Key + 1);
                                MessageInfo[selectedindex + 1] = Msginfo;
                                foreach(var ele in tempdict)
                                {                                   
                                        MessageInfo.Remove(ele.Key);
                                        MessageInfo.Add(ele.Key,ele.Value.Value);
                                }

                            }
                            else if (MessageInfo.Keys.Count > 0)
                            {

                                int LastMessageKey = MessageInfo.Keys.Last();
                                MessageInfo.Add(LastMessageKey + 1, Msginfo);
                            }
                            
                            break;
                        
                    }
                    break;
                default:
                    break;
            }
            UpdateTreeView();
        }

        private void addFieldToolStripBelowMenuItem_Click(object sender, EventArgs e)
        {
            if (Messages_TreeView.SelectedNode != null)
            {
                List<KeyValue> fcopy = FieldProperty.Fieldlist.Select(o => new KeyValue
                {
                    Key = o.Key,
                    ValueType = o.ValueType,
                    Value = o.Value
                }).ToList();

                switch (Messages_TreeView.SelectedNode.Level)
                {
                    case 1:
                        {
                            switch (Messages_TreeView.SelectedNode.Index)
                            {
                                case 0:
                                default:
                                    int selectedMsgindex = Messages_TreeView.SelectedNode.Index;
                                    //if (MessageInfo[selectedMsgindex].ContainsKey(1))
                                    {
                                        var tempdict = MessageInfo[selectedMsgindex].Where(x => x.Key > 0).ToDictionary(p => p.Key + 1);
                                        MessageInfo[selectedMsgindex].Remove(1);
                                        MessageInfo[selectedMsgindex].Add(1,fcopy) ;
                                        foreach (var ele in tempdict)
                                        {
                                            MessageInfo[selectedMsgindex].Remove(ele.Key);
                                            MessageInfo[selectedMsgindex].Add(ele.Key, ele.Value.Value);
                                        }
                                    }
                                    break;

                            }
                        }
                        break;
                    case 2:
                        {
                            int ParentNodeindex = Messages_TreeView.SelectedNode.Parent.Index;
                            int SelectedfldNodeindex = Messages_TreeView.SelectedNode.Index;
                            ++SelectedfldNodeindex;
                            if (MessageInfo[ParentNodeindex].ContainsKey(SelectedfldNodeindex + 1))
                            {
                                var tempdict = MessageInfo[ParentNodeindex].Where(x => x.Key > SelectedfldNodeindex).ToDictionary(p => p.Key + 1);
                                MessageInfo[ParentNodeindex].Remove(SelectedfldNodeindex+1);
                                MessageInfo[ParentNodeindex].Add(SelectedfldNodeindex+1, fcopy);
                                foreach (var ele in tempdict)
                                {
                                    MessageInfo[ParentNodeindex].Remove(ele.Key);
                                    MessageInfo[ParentNodeindex].Add(ele.Key, ele.Value.Value);
                                }
                            }
                            else
                            {
                                int LastMessageKey = MessageInfo[ParentNodeindex].Keys.Last();
                                MessageInfo[ParentNodeindex].Add(LastMessageKey + 1, fcopy);
                            }
                        }
                        break;
                }

                UpdateTreeView();
                Messages_TreeView.ExpandAll();
            }
        }



        private void UpdateTreeView()
        {
            try
            {
                Messages_TreeView.Nodes.Clear();
                TreeNode root = new TreeNode("Messages",rootimageindex,rootimageindex);

                //Add The message Leaf here
                TreeNode[] msgs = MessageInfo.
                    Select(x => new TreeNode
                    {
                        Name = x.Key.ToString(),
                        //Text = x.Key.ToString(),
                        Text = GetFldValue(x.Key, x.Value[0]).ToString(),
                        SelectedImageIndex = SelectedMsgImageIndex,
                        ImageIndex = UnSelectedMsgImageIndex
                    })
                        .ToArray<TreeNode>();
                
                foreach (var message in MessageInfo)
                {
                   msgs[message.Key].Nodes.AddRange(MessageInfo[message.Key].Where(y => y.Key > 0)
                  .Select(x => new TreeNode
                  {
                        Name = x.Key.ToString(),
                        Text = GetFldValue(x.Key,x.Value).ToString(),                       
                        SelectedImageIndex = SelectedFldImageIndex,
                        ImageIndex = UnSelectedFldImageIndex
                  })
                  .ToArray<TreeNode>());
                }
                Messages_TreeView.Nodes.Add(root);
                root.Nodes.AddRange(msgs);
                Messages_TreeView.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        static object GetFldValue(int key,List<KeyValue> x)
        {
          if( x.Exists(f => f.Key == "Name"))
            {
                string name = (string)x.Find(f => f.Key == "Name").Value;
                if(!string.IsNullOrEmpty(name))
                {
                    return name;
                }
                else
                {
                    return key;
                }
            }
            return key;
        }

        private void ToolStripMenuItem_Exportbinary_Click(object sender, EventArgs e)
        {
            Serialization.Serialization.Serialize<Dictionary<int, Dictionary<int, List<KeyValue>>>>(MessageInfo, @"\Binarydata\Messages.dat");
            List<KeyValue> mcopy = MessageProperty.MsgAttriblist.Select(o => new KeyValue
            {
                Key = o.Key,
                ValueType = o.ValueType,
                Value = o.Value
            }).ToList();
            Serialization.Serialization.Serialize<List<KeyValue>>(mcopy, @"\Binarydata\MessageProperty.dat");
            List<KeyValue> fcopy = FieldProperty.Fieldlist.Select(o => new KeyValue
            {
                Key = o.Key,
                ValueType = o.ValueType,
                Value = o.Value
            }).ToList();
            Serialization.Serialization.Serialize<List<KeyValue>>(fcopy, @"\Binarydata\FieldProperty.dat");
            toolStripStatusLabel_AppStatus.Text = "DAT File exported successfully";
        }


        private void ToolStripMenuItem_Importbinary_Click(object sender, EventArgs e)
        {
            MessageInfo = Serialization.Serialization.Deserialize<Dictionary<int, Dictionary<int, List<KeyValue>>>>(null, @"\Binarydata\Messages.dat");
            var MSGlist = Serialization.Serialization.Deserialize<List<KeyValue>>(null, @"\Binarydata\MessageProperty.dat");
            MessageProperty.MsgAttriblist.Clear();
            MessageProperty.MsgAttriblist.AddRange(MSGlist);
            var Fldlist = Serialization.Serialization.Deserialize<List<KeyValue>>(null, @"\Binarydata\FieldProperty.dat");
            FieldProperty.Fieldlist.Clear();
            FieldProperty.Fieldlist.AddRange(Fldlist as List<KeyValue>);
            UpdateTreeView();
            toolStripStatusLabel_AppStatus.Text = "DAT File Imported successfully";
        }


        private void LoadImageList()
        {
            string iconfolderpath = AppDomain.CurrentDomain.BaseDirectory + @"\Icons\";
            ImageList nodeimagelist = new ImageList();
            nodeimagelist.Images.Add(Image.FromFile(iconfolderpath+"1.png"));
            nodeimagelist.Images.Add(Image.FromFile(iconfolderpath+"2.png"));
            nodeimagelist.Images.Add(Image.FromFile(iconfolderpath + "3.png"));
            nodeimagelist.Images.Add(Image.FromFile(iconfolderpath + "4.png"));
            nodeimagelist.Images.Add(Image.FromFile(iconfolderpath + "5.png"));
            Messages_TreeView.ImageList = nodeimagelist;
        }
    }
}

// <copyright file="XmlGenr.cs" >
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Sushant hiremath</author>
// <date>17/05/2018 11:39:58 AM </date>
// <summary>Class to export XML</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using XMLGen.UI;

namespace XMLGen.XMLGeneration
{
    class XmlGenr
    {
        static StreamWriter fs = null;
        static string Filepath = AppDomain.CurrentDomain.BaseDirectory;

        public static bool XMLSerialize<Object>(Dictionary<int, Dictionary<int, List<KeyValue>>> dictionary, string filename) 
        {
            bool rettype = true;
            try // try to serialize the collection to a file
            {
                FileInfo Fi = new FileInfo(Filepath + filename);
                if (Fi.Exists)
                {
                    //File.SetAttributes(Filepath + filename, FileAttributes.Normal);
                    File.Delete(Filepath + filename);
                }
                Fi.Directory.Create();
                fs = new StreamWriter(Filepath + filename);
                XDocument result ;
                using (fs)
                {
                    // create BinaryFormatter
                    //Object ret = CreateInstance<Object>();
                    //XmlSerializer serialiser = new XmlSerializer();
                  result = new XDocument(new XElement("Messages",
                  dictionary.Select(i => new XElement("Message",
                      i.Value.Select(v => new XElement("field",
                      v.Value.Select(d => new XAttribute(d.Key.ToString(), d.Value != null ? d.Value.ToString() : "")
                      ))
                  ))
                )));

                    // serialize the collection (EmployeeList1) to file (stream)
                    fs.WriteLine(result.ToString());
                }
                fs.Close();
            }
            catch (IOException)
            {
                return false;
            }
            return rettype;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Diagnostics;

namespace XMLGen.Serialization
{
    class Serialization
    {
        static FileStream fs = null;
        static string Filepath = AppDomain.CurrentDomain.BaseDirectory ;
        
        public static void Serialize<Object>(Object dictionary,string filename)
        {
            try // try to serialize the collection to a file
            {
                FileInfo Fi = new FileInfo(Filepath + filename);
                if(Fi.Exists)
                {
                    //File.SetAttributes(Filepath + filename, FileAttributes.Normal);
                    File.Delete(Filepath + filename);
                }
                Fi.Directory.Create();
                fs = new FileStream(Filepath + filename, FileMode.Create,FileAccess.ReadWrite);

                using (fs)
                {
                    // create BinaryFormatter
                    BinaryFormatter bin = new BinaryFormatter();
                    // serialize the collection (EmployeeList1) to file (stream)
                    bin.Serialize(fs, dictionary);
                }
                fs.Close();
            }
            catch (IOException)
            {
            }
        }

        public static Object Deserialize<Object>(Stream stream, string filename) where Object : new()
        {
            Object ret = CreateInstance<Object>();
            try
            {
                FileInfo Fi = new FileInfo(Filepath+ filename);
                if (Fi.Exists)
                {
                    fs = new FileStream(Filepath + filename, FileMode.Open);
                    using (fs)
                    {
                        // create BinaryFormatter
                        BinaryFormatter bin = new BinaryFormatter();
                        // deserialize the collection (Employee) from file (stream)
                        ret = (Object)bin.Deserialize(fs);
                    }
                }

            }
            catch (IOException)
            {
            }
            return ret;
        }
        // function to create instance of T
        public static Object CreateInstance<Object>() where Object : new()
        {
            return (Object)Activator.CreateInstance(typeof(Object));
        }
    }
}

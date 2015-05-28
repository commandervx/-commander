using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace tra
{
    [Serializable]
    class OperateFile
    {
        public static void writeToFile(ArrayList a, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(fs, a);
            fs.Close();//必须关闭，否则反序列化时产生异常
        }


        public static ArrayList readFromFile(string path)
        {
            ArrayList al = new ArrayList();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bin = new BinaryFormatter();
            if (fs.Length != 0)
                al = bin.Deserialize(fs) as ArrayList;

            fs.Close();
            return al;
        }

        


    }
}
 
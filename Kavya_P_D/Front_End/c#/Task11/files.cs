using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.IO;


namespace File_Operation
{
    internal class FilesOperations
    {


        class FileWrite
        {
            public void WriteData()
            {
                // FileStream fs = new FileStream("F:\\Dlithe\\.net\\DLithe_BC_NFS_T_Task32\\details.txt", FileMode.Append, FileAccess.Write);
                FileStream fs = new FileStream("F:", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("C# File Opearation");
                string str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }
        static void Main(string[] args)
        {
            FileWrite wr = new FileWrite();
            wr.WriteData();
        }
    }
}


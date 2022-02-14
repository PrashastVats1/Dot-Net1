using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MiscQuestions
{
    class Binary
    {
        static void Main6(string[] args)
        {
            FileStream fout = new FileStream("Sample.txt", FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fout);
            string name = "sample";
            bw.Write(name);
            bw.Close();

            FileStream fin = new FileStream("Sample.txt", FileMode.Open);
            BinaryReader br = new BinaryReader(fin);
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            //  string sample = br.ReadString();
            Console.WriteLine(br.ReadString());
            br.Close();



        }
    }
}

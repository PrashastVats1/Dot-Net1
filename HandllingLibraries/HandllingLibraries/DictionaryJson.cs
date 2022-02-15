using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace HandllingLibraries
{
    class DictionaryJson
    {
        static void Main3(string[] args)
        {
            using (StreamReader q = new StreamReader("C://Users//svdsk25//Desktop//sample.json"))
            {
                string json = q.ReadToEnd();
                Student stu = JsonConvert.DeserializeObject<Student>(json);
                Console.WriteLine(stu.StudentId);
                Console.WriteLine(stu.StudentName);
            }
            Student Stu = new Student();
            Stu.StudentName = "Jugemu Jugemu Goko no Surikire Kaijarisuigyo no Suigyomatsu" +
                " Unraimatsu Furaimatsu Ku Neru Tokoro ni Sumu Tokoro Yabura Koji no Bura " +
                "Koji Paipo-paipo Paipo no Shuringan Shuringan no Gurindai Gurindai no " +
                "Ponpokopi no Ponpokona no Chokyumei no Chosuke and Jugemu Jugemu Goko no" +
                " Surikire Kaijarisuigyo no Suigyomatsu Unraimatsu Furaimatsu Ku Neru Tokoro" +
                " ni Sumu Tokoro Yabura Koji no Bura Koji Paipo-paipo Paipo no Shuringan " +
                "Shuringan no Gurindai Gurindai no Ponpokopi no Ponpokona no Chokyumei no Chosuke";
            Stu.StudentId = "12354";
            string json1 = JsonConvert.SerializeObject(Stu);
            System.IO.File.WriteAllText("C://Users//svdsk25//Desktop//new.json", json1);
            Console.WriteLine(Stu.StudentName);
        }
    }
}

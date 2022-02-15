using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace HandllingLibraries
{
    class Xmlread
    {
        static void Main2(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("C://Users//svdsk25//Desktop//sample.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {

                        Console.WriteLine(reader.ReadString());
                        Console.WriteLine(reader.Name.ToString());

                    }

                }
            }
        }
    }
}

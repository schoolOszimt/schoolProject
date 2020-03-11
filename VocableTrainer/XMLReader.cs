using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VocableTrainer
{
    class XMLReader
    {
        private static String Path = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString() + "/../Vokabelliste.xml";
        public static List<Vocable> getAllVocable()
        {
            List<Vocable> vocableList = new List<Vocable>();
            XmlDocument doc = new XmlDocument();
            doc.Load(@Path);
            foreach (XmlElement node in doc.DocumentElement.ChildNodes)
            {

                string voc = node.GetAttribute("Fremdsprache");
                string trans = node.GetAttribute("Deutsch");
                vocableList.Add(new Vocable(voc, trans));
            }
            return vocableList;
        }
    }
}

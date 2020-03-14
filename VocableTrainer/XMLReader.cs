using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace VocableTrainer
{
    static class XMLReader
    {
        private static String Path = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString() + "/../Vokabelliste.xml";
        public static List<Vocable> GetAllVocable()
        {
            List<Vocable> vocableList = new List<Vocable>();
            XDocument doc = XDocument.Load(Path);
            for (int i = 0; i < doc.Descendants("Deutsch").Count(); i++)
            {
                string voc = doc.Descendants("Fremdsprache").ElementAt(i).Value.ToString();
                string trans = doc.Descendants("Deutsch").ElementAt(i).Value.ToString();
                vocableList.Add(new Vocable(voc, trans));
            }
            return vocableList;
        }
    }
}

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
        private static String Path = "../Vokabelliste.xml"; 
        public static List<Vocable> getAllVocable()
        {
            List<Vocable> vocableList = new List<Vocable>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@Path);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string voc = node.Attributes["Fremdsprache"]?.InnerText;
                string trans = node.Attributes["Deutsch"]?.InnerText;
                vocableList.Add(new Vocable(voc, trans));
            }
            return vocableList;
        }
    }
}

using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace VocableTrainer
{
    static class XMLReader
    {
        private static Log log = new Log();
        private static string path = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString() + "/../Vokabelliste.xml";
        public static List<Vocable> GetAllVocable()
        {
            List<Vocable> vocableList = new List<Vocable>();
            try
            {
                XDocument doc = XDocument.Load(path);
                for (int i = 0; i < doc.Descendants("Deutsch").Count(); i++)
                {
                    string voc = doc.Descendants("Fremdsprache").ElementAt(i).Value.ToString();
                    string trans = doc.Descendants("Deutsch").ElementAt(i).Value.ToString();
                    vocableList.Add(new Vocable(voc, trans));
                }
            }catch(ArgumentOutOfRangeException aoor)
            {   
                log.WriteEntry("Fehler in der XML-Datei. Nicht genügend Übersetzungen vorhanden.");
                MessageBox.Show("Es ist ein Fehler in Ihrer Vokabelliste aufgetreten. Bitte konsultieren Sie Ihren Systemverwalter."
                     + Environment.NewLine +"Lösungshinweis: Es fehlt ggf. eine Übersetzung. <Fremdsprache>",
                   "Fehler in der XML-Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }
            catch (System.IO.IOException siio)
            {
                log.WriteEntry("Kritischer Fehler. Dateipfad der XML-Datei wurde nicht gefunden oder XML-Datei ist beschädigt.");
                MessageBox.Show("Es ist ein Fehler in Ihrer Vokabelliste aufgetreten. Bitte konsultieren Sie Ihren Systemverwalter."
                    + Environment.NewLine + "Lösungshinweis: Die XML-Datei ist beschädigt oder nicht vorhanden.",
                   "Kritischer Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }
            return vocableList;
        }
    }
}

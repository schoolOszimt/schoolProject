using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VocableTrainer
{
    class QuestionGenerator
    {
        private static Random random = new Random();
        public static List<Vocable> vocableList;
        private static GUIGame gui = GUIGame.GetInstance(); 
        public QuestionGenerator()
        {
            GenerateQuestion();
        }
        private static string MakeAnswer()
        {
            int i = random.Next(0, vocableList.Count);
            string answer = vocableList[i].Translation;
            while (CheckOnDouble(answer))
            {
                i = random.Next(0, vocableList.Count);
                answer = vocableList[i].Translation;
            }
            return answer;
        }
        public static void GenerateQuestion()
        {
            vocableList = XMLReader.GetAllVocable();
            if (vocableList.Count < 4)
            {
                MessageBox.Show("Es ist ein Fehler in Ihrer Vokabelliste aufgetreten. Bitte konsultieren Sie Ihren Systemverwalter.",
                    "Fehler in der XML-Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }
            else
            {
                gui.Answer1 = MakeAnswer();
                gui.Answer2 = MakeAnswer();
                gui.Answer3 = MakeAnswer();
                gui.Answer4 = MakeAnswer();
                MakeSolutionAndVocableRandom();
            }
        }

        private static bool CheckOnDouble(string answer)
        {
            return gui.Answer1 == answer || gui.Answer2 == answer || gui.Answer3 == answer || gui.Answer4 == answer;
        }
        private static void MakeSolutionAndVocableRandom()
        {
            int i = random.Next(1, 5);
            switch (i)
            {
                case 1:
                    SetSolutionAndVocable(gui.Answer1);
                    return;
                case 2:
                    SetSolutionAndVocable(gui.Answer2);
                    return;
                case 3:
                    SetSolutionAndVocable(gui.Answer3);
                    return;
                case 4:
                    SetSolutionAndVocable(gui.Answer4);
                    return;
            }
        }
        private static void SetSolutionAndVocable(string answer)
        {
            foreach(Vocable voc in vocableList)
            {
                if(voc.Translation == answer)
                {
                    gui.Question = voc.VocableValue;
                    gui.Solution = voc.Translation;
                }
            }
        }
    }
}

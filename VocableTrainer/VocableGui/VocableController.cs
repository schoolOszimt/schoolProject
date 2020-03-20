using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace VocableTrainer
{
    class VocableFunctions
    {
        public Points instance = Points.GetInstance();

        public void Exit(vT_Form form)
        {
            //GUIGame.Close();
            ShowResultDialog(form);
            form.ResetNumberOfVocable();
            form.ShowMainMenu();
        }

        public void Help(VocableGui newDesign)
        {
            int numberOfDeletedTexts = 0;

            for (int i = 0; i < newDesign.Controls.Count; i++)
            {
                if (newDesign.Controls[i] is MaterialLabel label)
                {
                    if (((MaterialLabel)label).Name.Contains("answer")
                        && !GUIGame.IsAnswerCorrect(((MaterialLabel)label).Text, true)
                        && numberOfDeletedTexts < 2)
                    {
                        ((MaterialLabel)label).Text = "";
                        numberOfDeletedTexts++;
                    }
                }
            }
        }

        public void Skip(vT_Form form)
        {
            GUIGame.Next();
            form.SetAnswersAndVocable();
        }

        public void AnswerClick(vT_Form form, MaterialLabel label, VocableGui gui)
        {

            var IsAnswerCorrect = GUIGame.IsAnswerCorrect(label.Text, false);

            gui.timer.Interval = 900;
            gui.timer.Start();
            for (int i = 0; i < gui.Controls.Count; i++)
            {
                if (gui.Controls[i] is MaterialLabel)
                {
                    if(gui.Controls[i].Text == "A") continue;
                    if(gui.Controls[i].Text == "B") continue;
                    if(gui.Controls[i].Text == "C") continue;
                    if(gui.Controls[i].Text == "D") continue;

                    if (GUIGame.IsAnswerCorrect(gui.Controls[i].Text, true))
                    {
                        gui.Controls[i].ForeColor = Color.Green;
                    }
                    else
                    {
                        gui.Controls[i].ForeColor = Color.Red;
                    }
                }
            }
            

            //form.ShowFeedbackToSolution(GUIGame.IsAnswerCorrect(label.Text, false));
            //CodeAfterAnswerButtonPress(form);
        }

        public void ShowResultDialog(vT_Form form)
        {
            int points = instance.right;
            int vocables;


            if (form.numberOfVocable == -1)
            {
                vocables = 1;
            }
            else
            {
                vocables = form.numberOfVocable;
            }

            double percent = (Convert.ToDouble(points) / vocables) * 100;
            //Int * Int wird in ein Int gerundet

            var roundedPercent = Math.Round(percent);
            var grade = GetGrade(roundedPercent);


            MessageBox.Show("Du hast " + points + " von " + vocables + " Vokabeln richtig beantwortet"
                            + Environment.NewLine + "Das sind " + roundedPercent + "% " + "Was eine " + grade + " wäre.",
                      "Ergebnis", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public string GetGrade(double percent)
        {
            if (percent >= 95) return "1";
            if (percent >= 90) return "1-";
            if (percent >= 85) return "2+";
            if (percent >= 80) return "2";
            if (percent >= 75) return "2-";
            if (percent >= 70) return "3+";
            if (percent >= 65) return "3";
            if (percent >= 60) return "3-";
            if (percent >= 55) return "4+";
            if (percent >= 50) return "4";
            if (percent < 50) return "5";
            return "Error";
        }

        public void CodeAfterAnswerButtonPress(vT_Form form)
        {
            form.SetLabelColor();
            form.SetPointLabel(instance.right);
            GUIGame.Next();
            form.SetAnswersAndVocable();
        }

    }
}

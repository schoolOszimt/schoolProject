using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace VocableTrainer
{
    class VocableFunctions
    {
        public Points pointsInstance = Points.GetInstance();

        public void Exit(mfrm_VocTrainerForm form)
        {
            ShowResultDialog(form);
            form.ResetNumberOfVocable();
            form.ShowMainMenu();
        }

        public void Help(object newDesign)
        {
            int numberOfDeletedTexts = 0;

            for (int i = 0; i < ((Button)newDesign).Parent.Parent.Controls.Count; i++)
            {
                if ((((Button)newDesign).Parent.Parent.Controls[i] is Panel panel))
                {
                    foreach (Control c in panel.Controls)
                    {
                        if (c is MaterialLabel)
                        {
                            if (((MaterialLabel)c).Name.Contains("answer") && !GUIGame.IsAnswerCorrect(((MaterialLabel)c).Text)
                                && numberOfDeletedTexts < 2)
                            {
                                c.Text = "";
                                numberOfDeletedTexts++;
                            }
                            
                        }
                    }
                }
            }
        }

        public void Skip(mfrm_VocTrainerForm form)
        {
            GUIGame.Next();
            form.SetAnswersAndVocable();
        }

        public void AnswerClick(mfrm_VocTrainerForm form, MaterialLabel label, VocableGui gui)
        {
            for (int i = 0; i < label.Parent.Parent.Controls.Count; i++)
            {
                if (label.Parent.Parent.Controls[i] is Panel panel && ((Panel)label.Parent.Parent.Controls[i]).Name.Equals("pnl_Antworten"))
                {
                    foreach (Control c in panel.Controls)
                    {
                        if (c is MaterialLabel)
                        {
                            if (((MaterialLabel)c).Name.Contains("answer"))
                            {
                                if (GUIGame.IsAnswerCorrect(((MaterialLabel)c).Text))
                                {
                                    if (((MaterialLabel)c).Name == label.Name)
                                        pointsInstance.WasAnswerRight(true);
                                        ((MaterialLabel)c).ForeColor = Color.Green;
                                    
                                }
                                else
                                {
                                    ((MaterialLabel)c).ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }
                //Damit der Nutzer die Chance hat die Ausgabe zu lesen, wird an dieser Stelle eine Verzögerung eingefügt
                gui.timer.Interval = 950;
                gui.timer.Start();
            }

        }
         
        public void ShowResultDialog(mfrm_VocTrainerForm form)
        {
            if (form.numberOfVocable > 0)
            {
                double percent = 0;
                if (pointsInstance.Right > 0)
                {
                    percent = Math.Round((Convert.ToDouble(pointsInstance.Right) / form.numberOfVocable) * 100, 0);
                }
                MessageBox.Show("Sie haben " + pointsInstance.Right + " von " + form.numberOfVocable + " Fragen richtig beantwortet."
                                + Environment.NewLine + "Das sind " + percent + "%.",
                          "Ergebnis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void CodeAfterAnswerButtonPress(mfrm_VocTrainerForm form)
        {
            form.SetLabelColor();
            form.SetPointLabel(pointsInstance.Right);
            GUIGame.Next();
            form.SetAnswersAndVocable();
        }

    }
}

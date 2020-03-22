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

        public void Exit(vT_Form form)
        {
            ShowResultDialog(form);
            form.ResetNumberOfVocable();
            form.ShowMainMenu();
        }

        public void Help(object newDesign)
        {
            Console.WriteLine("Parent des Buttons: "+((Button)newDesign).Parent.Parent.Name);
            int numberOfDeletedTexts = 0;

            for (int i = 0; i < ((Button)newDesign).Parent.Parent.Controls.Count; i++)
            {
                if ((((Button)newDesign).Parent.Parent.Controls[i] is Panel panel))
                {
                    Console.WriteLine("Panelname: "+panel.Name);
                    foreach (Control c in panel.Controls)
                    {
                        if (c is MaterialLabel)
                        {
                            if (((MaterialLabel)c).Name.Contains("answer") && !GUIGame.IsAnswerCorrect(((MaterialLabel)c).Text, true)
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

        public void Skip(vT_Form form)
        {
            GUIGame.Next();
            form.SetAnswersAndVocable();
        }

        public void AnswerClick(vT_Form form, MaterialLabel label, VocableGui gui)
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
                                if (GUIGame.IsAnswerCorrect(((MaterialLabel)c).Text, true))
                                {
                                    if (((MaterialLabel)c).Name == label.Name) pointsInstance.WasAnswerRight(true);
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

                gui.timer.Interval = 950;
                gui.timer.Start();
            }
          
        }

        public void ShowResultDialog(vT_Form form)
        {
            if (form.numberOfVocable > 0)
            {
                double percent = 0;
                if (pointsInstance.Right > 0)
                {
                    percent = Math.Round((Convert.ToDouble(pointsInstance.Right) / form.numberOfVocable) * 100, 0);
                }
                MessageBox.Show("Du hast " + pointsInstance.Right + " von " + form.numberOfVocable + " Vokabeln richtig beantwortet."
                                + Environment.NewLine + "Das sind " + percent + "%.",
                          "Ergebnis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void CodeAfterAnswerButtonPress(vT_Form form)
        {
            form.SetLabelColor();
            form.SetPointLabel(pointsInstance.Right);
            GUIGame.Next();
            form.SetAnswersAndVocable();
        }

    }
}

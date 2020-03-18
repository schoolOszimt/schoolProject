using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace VocableTrainer
{
    public partial class vocableGui_uc : UserControl
    {
        public vT_Form Parent;
        public Points instance = Points.GetInstance();

        public vocableGui_uc()
        {
            InitializeComponent();
        }

        public void setParent(vT_Form form)
        {
            Parent = form;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            GUIGame.Close();
            ShowResultDialog();
            Parent.ResetNumberOfVocable();
            Parent.ShowMainMenu();
        }

        private void answer1_btn_Click(object sender, EventArgs e)
        {
            Parent.ShowFeedbackToSolution(GUIGame.CheckAnswer(answer1_btn.Text, false));
            CodeAfterAnswerButtonPress();
            //test
        }

        private void answer2_btn_Click(object sender, EventArgs e)
        {
            Parent.ShowFeedbackToSolution(GUIGame.CheckAnswer(answer2_btn.Text, false));
            CodeAfterAnswerButtonPress();
        }

        private void answer3_btn_Click(object sender, EventArgs e)
        {
            Parent.ShowFeedbackToSolution(GUIGame.CheckAnswer(answer3_btn.Text, false));
            CodeAfterAnswerButtonPress();
        }

        private void answer4_btn_Click(object sender, EventArgs e)
        {
            Parent.ShowFeedbackToSolution(GUIGame.CheckAnswer(answer4_btn.Text, false));
            CodeAfterAnswerButtonPress();

        }

        public void ShowResultDialog()
        {
            int points = instance.right;
            int vocables;


            if (Parent.numberOfVocable == -1)
            {
                vocables = 1;
            }
            else
            {
                vocables = Parent.numberOfVocable;
            }

            double percent = (Convert.ToDouble(points) / vocables) * 100;
            //Int * Int wird in ein Int gerundet

            var roundedPercent = Math.Round(percent);
            var grade = GetGrade(roundedPercent);


            MessageBox.Show("Du hast " + points + " von " + vocables + " Vokabeln richtig beantwortet"
                            + Environment.NewLine + "Das sind " + roundedPercent + "% " + "Was eine " + grade + " wäre.",
                      "Ergebnis", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private string GetGrade(double percent)
        {
            if (percent >= 95) return "1" ;
            if (percent >= 90) return "1-";
            if (percent >= 85) return "2+";
            if (percent >= 80) return "2" ;
            if (percent >= 75) return "2-";
            if (percent >= 70) return "3+";
            if (percent >= 65) return "3" ;
            if (percent >= 60) return "3-";
            if (percent >= 55) return "4+";
            if (percent >= 50) return "4" ;
            if (percent < 50) return "5" ;
            return "Error";
        }

        private void CodeAfterAnswerButtonPress()
        {
            Parent.SetPointLabel(instance.right);
            GUIGame.Next();
            Parent.setAnswersAndVocable();
        }

        private void skip_btn_Click(object sender, EventArgs e)
        {
            GUIGame.Next();
            Parent.setAnswersAndVocable();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            int numberOfDeletedTexts = 0;
            if (!GUIGame.CheckAnswer(answer1_btn.Text, true))
            {
                answer1_btn.Text = "";
                numberOfDeletedTexts++;
            }
            if (!GUIGame.CheckAnswer(answer2_btn.Text, true))
            {
                answer2_btn.Text = "";
                numberOfDeletedTexts++;
            }
            if (!GUIGame.CheckAnswer(answer3_btn.Text, true))
            {
                if (numberOfDeletedTexts == 2)
                {

                }
                else
                {
                    answer3_btn.Text = "";
                    numberOfDeletedTexts++;
                }
            }
            if (!GUIGame.CheckAnswer(answer4_btn.Text, true))
            {
                if (numberOfDeletedTexts == 2)
                {

                }
                else
                {
                    answer4_btn.Text = "";
                    numberOfDeletedTexts++;
                }
            }




        }
    }
}

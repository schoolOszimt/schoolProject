using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Linq;

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
            var numberOfDeletedTexts = 0;
            var controls = ((Button) newDesign).Parent.Parent.Controls;
            for (var i = 0; i < controls.Count; i++)
            {
                if (controls[i] is Panel panel)
                {
                    foreach (Control c in panel.Controls)
                    {
                        if (!(c is Label label)) continue;
                        if (label.Name.Contains("answer") &&
                            !GUIGame.IsAnswerCorrect(label.Text) &&
                            numberOfDeletedTexts < 2)
                        {
                            label.Text = "";
                            numberOfDeletedTexts++;
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

        public void AnswerClick(Label label, VocableGui gui)
        {
            var controls = label?.Parent?.Parent?.Controls;
            if (controls == null) throw new ArgumentException(nameof(label));

            var answerLabels = controls
                .Cast<Control>()
                .Where(e => e is Panel panel && panel.Name.Equals("pnl_Antworten"))
                .Cast<Panel>()
                .SelectMany(e => e.Controls.Cast<Control>())
                .Where(e => e is Label answerLabel && answerLabel.Name.Contains("answer"))
                .ToList();

            var correctLabels = answerLabels
                .Where(e => GUIGame.IsAnswerCorrect(e.Text))
                .ToList();

            if (correctLabels.Count != 1) throw new Exception("Only one answer can be correct");

            if (correctLabels.Any(e => e == label))
            {
                pointsInstance.AnswerIsRight();
            }

            var correctLabel = correctLabels.FirstOrDefault();
            if (correctLabel != null) correctLabel.ForeColor = Color.Green;

            var incorrectLabels = answerLabels
                .Where(e => !correctLabels.Contains(e));

            foreach (var answerLabel in incorrectLabels)
            {
                answerLabel.ForeColor = Color.Red;
            }
            gui.timer.Interval = 950;
            gui.timer.Start();
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

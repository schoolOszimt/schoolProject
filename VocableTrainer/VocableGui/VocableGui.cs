using System;
using System.Windows.Forms;

namespace VocableTrainer
{
    public partial class VocableGui : UserControl
    {
        private VocableFunctions vocableFunctions = new VocableFunctions();

        private vT_Form Parent { get; set; }

        public VocableGui()
        {
            InitializeComponent();
        }

        public void SetParent(vT_Form form)
        {
            Parent = form;
        }

        #region Events

        private void exit_btn_Click(object sender, EventArgs e)
        {
            vocableFunctions.Exit(Parent);
        }

        private void answer1_label_Click(object sender, EventArgs e)
        {
            vocableFunctions.AnswerClick(Parent, answer1_label, this);
        }

        private void answer2_label_Click(object sender, EventArgs e)
        {
            vocableFunctions.AnswerClick(Parent, answer2_label, this);
        }

        private void answer3_label_Click(object sender, EventArgs e)
        {
           vocableFunctions.AnswerClick(Parent, answer3_label, this);
        }

        private void answer4_label_Click(object sender, EventArgs e)
        {
            vocableFunctions.AnswerClick(Parent, answer4_label, this);
        }



        private void skip_btn_Click(object sender, EventArgs e)
        {
            vocableFunctions.Skip(Parent);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            vocableFunctions.Help(this);
        }

        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            vocableFunctions.CodeAfterAnswerButtonPress(Parent);
            timer.Stop();
        }
    }

}

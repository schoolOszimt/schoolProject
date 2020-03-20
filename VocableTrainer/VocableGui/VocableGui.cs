using System;
using System.Windows.Forms;

namespace VocableTrainer
{
    public partial class VocableGui : UserControl
    {
        private VocableFunctions vocableFunctions = new VocableFunctions();

        private vT_Form VTForm { get; set; }

        public VocableGui()
        {
            InitializeComponent();
        }

        public void SetVTForm(vT_Form form)
        {
            VTForm = form;
        }

        #region Events

        private void exit_btn_Click(object sender, EventArgs e)
        {
            vocableFunctions.Exit(VTForm);
        }

        private void answer1_label_Click(object sender, EventArgs e)
        {
            vocableFunctions.AnswerClick(VTForm, answer1_label, this);
        }

        private void answer2_label_Click(object sender, EventArgs e)
        {
            vocableFunctions.AnswerClick(VTForm, answer2_label, this);
        }

        private void answer3_label_Click(object sender, EventArgs e)
        {
           vocableFunctions.AnswerClick(VTForm, answer3_label, this);
        }

        private void answer4_label_Click(object sender, EventArgs e)
        {
            vocableFunctions.AnswerClick(VTForm, (MaterialSkin.Controls.MaterialLabel)sender, this);
        }



        private void skip_btn_Click(object sender, EventArgs e)
        {
            vocableFunctions.Skip(VTForm);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            vocableFunctions.Help(sender);
        }

        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            vocableFunctions.CodeAfterAnswerButtonPress(VTForm);
            timer.Stop();
        }
    }

}

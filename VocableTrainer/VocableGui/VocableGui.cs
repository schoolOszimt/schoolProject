using System;
using System.Windows.Forms;

namespace VocableTrainer
{
    public partial class VocableGui : UserControl
    {
        private VocableFunctions vocableFunctions = new VocableFunctions();

        private mfrm_VocTrainerForm VTForm { get; set; }

        public VocableGui()
        {
            InitializeComponent();
        }

        public void SetVTForm(mfrm_VocTrainerForm form)
        {
            VTForm = form;
        }

        #region Events

        private void btn_Back_Click(object sender, EventArgs e)
        {
            vocableFunctions.Exit(VTForm);
        }

        private void answer1_label_Click(object sender, EventArgs e)
        {
            vocableFunctions.AnswerClick(VTForm, lbl_answer1, this);
        }

        private void answer2_label_Click(object sender, EventArgs e)
        {
            vocableFunctions.AnswerClick(VTForm, lbl_answer2, this);
        }

        private void answer3_label_Click(object sender, EventArgs e)
        {
           vocableFunctions.AnswerClick(VTForm, lbl_answer3, this);
        }

        private void answer4_label_Click(object sender, EventArgs e)
        {
            vocableFunctions.AnswerClick(VTForm, (MaterialSkin.Controls.MaterialLabel)sender, this);
        }



        private void btn_Skip_Click(object sender, EventArgs e)
        {
            vocableFunctions.Skip(VTForm);
        }

        private void btn_Help_Click(object sender, EventArgs e)
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

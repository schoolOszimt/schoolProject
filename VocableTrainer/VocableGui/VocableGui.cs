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

        private void answer_label_Click(object sender, EventArgs e)
        {
            if (sender is Label label && !string.IsNullOrEmpty(label.Text))
            {
                vocableFunctions.AnswerClick(label, this);
            }
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

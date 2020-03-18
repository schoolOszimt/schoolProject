using System;
using System.Windows.Forms;

namespace VocableTrainer
{
    public partial class startMenu_uc : UserControl
    {
        private vT_Form Parent { get; set; }
        public startMenu_uc()
        {
            InitializeComponent();
        }

        public void setParent(vT_Form form)
        {
            Parent = form;
        }

        private void start_btn_Click(object sender, EventArgs e)
        { 
            GUIGame.newGame();
            Parent.setAnswersAndVocable();
            Parent.ShowGameMenu();
            Parent.SetPointLabel(0);
            Parent.ResetFeedbackResult();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void options_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator: Falco Sowa, Tobias Trockenbrodt, Korina Schneider, Domenik Bernhardt", "About", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

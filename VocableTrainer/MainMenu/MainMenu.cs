using System;
using System.Windows.Forms;

namespace VocableTrainer
{
    public partial class MainMenu_uc : UserControl
    {
        private vT_Form VTForm { get; set; }
        public MainMenu_uc()
        {
            InitializeComponent();
        }

        public void SetVTForm(vT_Form form)
        {
            VTForm = form;
        }

        private void start_btn_Click(object sender, EventArgs e)
        { 
            GUIGame.NewGame();
            VTForm.SetAnswersAndVocable();
            VTForm.ShowGameMenu();
            VTForm.SetPointLabel(0);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void options_btn_Click(object sender, EventArgs e)
        {
            //überarbeiten
            MessageBox.Show("Creator: Falco Sowa, Tobias Trockenbrodt, Korina Schneider, Domenik Bernhardt", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

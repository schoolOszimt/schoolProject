using System;
using System.Windows.Forms;

namespace VocableTrainer
{
    public partial class MainMenu_uc : UserControl
    {
        private mfrm_VocTrainerForm VTForm { get; set; }
        public MainMenu_uc()
        {
            InitializeComponent();
        }

        public void SetVTForm(mfrm_VocTrainerForm form)
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
            MessageBox.Show("Für Fragen zum Programm wenden Sie sich bitte an Ihren Dozenten." + Environment.NewLine +Environment.NewLine + "Dieser Vokabeltrainer wurde im Auftrag der VHS Berlin erstellt." + Environment.NewLine + "(c)2020 Falco Sowa, Tobias Trockenbrodt, Korina Schneider, Domenik Bernhardt", "Programminformationen",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

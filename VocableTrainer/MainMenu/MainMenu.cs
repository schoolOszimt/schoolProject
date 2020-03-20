using System;
using System.Windows.Forms;

namespace VocableTrainer
{
    public partial class MainMenu_uc : UserControl
    {
        private vT_Form Parent { get; set; }
        public MainMenu_uc()
        {
            InitializeComponent();
        }

        public void SetParent(vT_Form form)
        {
            Parent = form;
        }

        private void start_btn_Click(object sender, EventArgs e)
        { 
            GUIGame.newGame();
            Parent.SetAnswersAndVocable();
            Parent.ShowGameMenu();
            Parent.SetPointLabel(0);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void options_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator: Falco Sowa, Tobias Trockenbrodt, Korina Schneider, Domenik Bernhardt", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

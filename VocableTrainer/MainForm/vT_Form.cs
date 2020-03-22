using System.Drawing;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;

namespace VocableTrainer
{
    public partial class mfrm_VocTrainerForm : MaterialForm
    {
        public MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public int numberOfVocable = -1;
        public mfrm_VocTrainerForm()
        {
            InitializeComponent();

            mmuc_StartUC.SetVTForm(this);
            vgui_VocGui.SetVTForm(this);
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            

        }

        public void ShowGameMenu()
        {
            vgui_VocGui.BringToFront();
            this.BackColor = Color.DarkGray;
            mmuc_StartUC.SendToBack();
        }

        public void ShowMainMenu()
        {
            vgui_VocGui.SendToBack();
            this.BackColor = Color.White;
            mmuc_StartUC.BringToFront();
        }

        public void SetAnswersAndVocable()
        {
            var instance = GUIGame.GetInstance();

            
            vgui_VocGui.lbl_answer1.Text = instance.Answer1;
            vgui_VocGui.lbl_answer2.Text = instance.Answer2;
            vgui_VocGui.lbl_answer3.Text = instance.Answer3;
            vgui_VocGui.lbl_answer4.Text = instance.Answer4;
            vgui_VocGui.vocable_label.Text = instance.Question;

        }

        public void SetPointLabel(int tempPoints)
        {
            numberOfVocable++;

            vgui_VocGui.points_label.Text = tempPoints + "/" + numberOfVocable;
        }

        public void SetLabelColor()
        {
            vgui_VocGui.lbl_answer1.ForeColor = Color.Black;
            vgui_VocGui.lbl_answer2.ForeColor = Color.Black;
            vgui_VocGui.lbl_answer3.ForeColor = Color.Black;
            vgui_VocGui.lbl_answer4.ForeColor = Color.Black;
        }

        public void ResetNumberOfVocable()
        {
            numberOfVocable = -1;
        }
    }
}

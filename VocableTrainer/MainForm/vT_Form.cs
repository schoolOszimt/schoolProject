using System.Drawing;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;

namespace VocableTrainer
{
    public partial class vT_Form : MaterialForm
    {
        public MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public int numberOfVocable = -1;
        public vT_Form()
        {
            InitializeComponent();

            MainMenu_uc1.SetVTForm(this);
            vocableGui1.SetVTForm(this);
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void ShowGameMenu()
        {
            vocableGui1.BringToFront();
            this.BackColor = Color.DarkGray;
            MainMenu_uc1.SendToBack();
        }

        public void ShowMainMenu()
        {
            vocableGui1.SendToBack();
            this.BackColor = Color.White;
            MainMenu_uc1.BringToFront();
        }

        public void SetAnswersAndVocable()
        {
            var instance = GUIGame.GetInstance();

            
            vocableGui1.answer1_label.Text = instance.Answer1;
            vocableGui1.answer2_label.Text = instance.Answer2;
            vocableGui1.answer3_label.Text = instance.Answer3;
            vocableGui1.answer4_label.Text = instance.Answer4;
            vocableGui1.vocable_label.Text = instance.Question;

        }

        public void SetPointLabel(int tempPoints)
        {
            numberOfVocable++;

            vocableGui1.points_label.Text = tempPoints + "/" + numberOfVocable;
        }

        public void SetLabelColor()
        {
            vocableGui1.answer1_label.ForeColor = Color.Black;
            vocableGui1.answer2_label.ForeColor = Color.Black;
            vocableGui1.answer3_label.ForeColor = Color.Black;
            vocableGui1.answer4_label.ForeColor = Color.Black;
        }

        public void ResetNumberOfVocable()
        {
            numberOfVocable = -1;
        }


    }
}

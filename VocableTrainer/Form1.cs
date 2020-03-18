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

            startMenu_uc1.setParent(this);
            vocableGui_uc1.setParent(this);
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void ShowGameMenu()
        {
            vocableGui_uc1.BringToFront();
            startMenu_uc1.SendToBack();
        }

        public void ShowMainMenu()
        {
            vocableGui_uc1.SendToBack();
            startMenu_uc1.BringToFront();
        }

        public void setAnswersAndVocable()
        {
            var instance = GUIGame.GetInstance();

            
            vocableGui_uc1.answer1_btn.Text = instance.Answer1;
            vocableGui_uc1.answer2_btn.Text = instance.Answer2;
            vocableGui_uc1.answer3_btn.Text = instance.Answer3;
            vocableGui_uc1.answer4_btn.Text = instance.Answer4;
            vocableGui_uc1.vocable_label.Text = instance.Question;

        }

        public void ShowFeedbackToSolution(bool isSolutionCorrect)
        {
            if (isSolutionCorrect)
            {
                vocableGui_uc1.feedback_result.Text = "Correct!";
                vocableGui_uc1.feedback_result.ForeColor = Color.Green;
            }
            else
            {
                vocableGui_uc1.feedback_result.Text = "False!";
                vocableGui_uc1.feedback_result.ForeColor = Color.Red;
            }
        }


        public void SetPointLabel(int tempPoints)
        {
            numberOfVocable++;

            vocableGui_uc1.points_label.Text = tempPoints + "/" + numberOfVocable;
        }

        public void ResetFeedbackResult()
        {
            vocableGui_uc1.feedback_result.Text = "";
        }

        public void ResetNumberOfVocable()
        {
            numberOfVocable = -1;
        }


    }
}

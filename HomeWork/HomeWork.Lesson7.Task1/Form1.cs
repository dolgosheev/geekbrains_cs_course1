using System;
using System.Windows.Forms;

namespace HomeWork.Lesson7.Task1
{
    public partial class MainForm : Form
    {
        public Doubler DoublerGame;
        public GuessTheNumber GuessTheNumber;

        public MainForm()
        {
            InitializeComponent();
            tbG2Own.KeyPress += CheckEnter;

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Doubler Game

        private void playDoublerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tControlMain.SelectTab(tPageGameDoubler);
            labelGame1.Hide();

            buttonG1Plus.Visible = true;
            buttonG1Multi.Visible = true;
            buttonG1Back.Visible = true;
            
            labelG1desc.Visible = true;
            labelG1Number.Visible = true;

            labelG1yourdesc.Visible = true;
            labelG1YourNumber.Visible = true;

            labelG1CountSteps.Visible = true;
            labelG1CountStepsSum.Visible = true;
            
            DoublerGame = new Doubler();
            labelG1Number.Text = DoublerGame.Victory.ToString();
            labelG1YourNumber.Text = DoublerGame.Own.ToString();

            MessageBox.Show($"Вы должены постараться получить число {DoublerGame.Victory.ToString()} за минимальное количество ходов", "Игра \"Удвоитель\" начата");
        }

        private void buttonG1Plus_Click(object sender, EventArgs e)
        {
            labelG1YourNumber.Text = DoublerGame.Plus().ToString();
            labelG1CountStepsSum.Text = DoublerGame.SummSteps().ToString();
            DoublerGame.CheckResult();
        }

        private void buttonG1Multi_Click(object sender, EventArgs e)
        {
            labelG1YourNumber.Text = DoublerGame.Multi().ToString();
            labelG1CountStepsSum.Text = DoublerGame.SummSteps().ToString();
            DoublerGame.CheckResult();
        }

        private void buttonG1Back_Click(object sender, EventArgs e)
        {
            labelG1YourNumber.Text = DoublerGame.Back().ToString();
            labelG1CountStepsSum.Text = DoublerGame.SummSteps().ToString();
        }

        #endregion

        #region Guess the number Game

        private void playGuessTheNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tControlMain.SelectTab(tPageGameGuessTheNumber);
            labelGame2.Hide();

            labelG2CountSteps.Visible = true;
            labelG2CountStepsSum.Visible = true;
            labelG2Description.Visible = true;
            tbG2Own.Visible = true;
            tbG2Own.Focus();

            GuessTheNumber = new GuessTheNumber();
        }


        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                if (GuessTheNumber.CheckResult(tbG2Own.Text))
                {
                    MessageBox.Show($"Вы выграли за {GuessTheNumber.CountSteps} ходов", "Победа !!!");
                    return;
                }

                MessageBox.Show($"Ксожалению загадано другое число... Попробуйте еще раз...", "Не отгадали...");
                GuessTheNumber.SummSteps();
                tbG2Own.Clear();
            }
        }
        

        #endregion
    }
}

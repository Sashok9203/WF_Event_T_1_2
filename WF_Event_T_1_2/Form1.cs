using Microsoft.VisualBasic.Logging;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            countRes.Text = $"";
            result.Text = $"";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int maxNumber = 100;
            int minNumber = 1;
            int midle, count = 0; ;
            countRes.Text = $"";
            result.Text = $"";

            DialogResult mBoxResult1 = new();
            while (mBoxResult1 != DialogResult.Yes)
            {
                count++;
                midle = (minNumber + maxNumber) / 2;
                mBoxResult1 = MessageBox.Show($"Ваше число {midle} ?", "Питання", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (mBoxResult1 == DialogResult.Yes)
                {
                    countRes.Text = $"Кількість запитів : {count}";
                    result.Text = $"Ваше число : {midle}";

                    mBoxResult1 = MessageBox.Show($"Зіграєте ще раз ?", "Питання", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (mBoxResult1 == DialogResult.Yes) return;
                    else
                    {
                        this.Close();
                        return;
                    }
                }
                count++;
                var mBoxResult2 = MessageBox.Show($"Ваше число більше за {midle} ?", "Питання", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (mBoxResult2 == DialogResult.Yes) minNumber = midle + 1;
                else maxNumber = midle - 1;

                if (maxNumber < minNumber)
                {

                    MessageBox.Show($"Ваше число не знайдене... сталася помилка ?", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mBoxResult1 = MessageBox.Show($"Зіграєте ще раз ?", "Питання", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (mBoxResult1 == DialogResult.Yes) return;
                    else
                    {
                        this.Close();
                        return;
                    }

                }

            }


        }
    }
}
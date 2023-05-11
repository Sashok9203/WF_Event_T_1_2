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
                mBoxResult1 = MessageBox.Show($"���� ����� {midle} ?", "�������", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (mBoxResult1 == DialogResult.Yes)
                {
                    countRes.Text = $"ʳ������ ������ : {count}";
                    result.Text = $"���� ����� : {midle}";

                    mBoxResult1 = MessageBox.Show($"ǳ����� �� ��� ?", "�������", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (mBoxResult1 == DialogResult.Yes) return;
                    else
                    {
                        this.Close();
                        return;
                    }
                }
                count++;
                var mBoxResult2 = MessageBox.Show($"���� ����� ����� �� {midle} ?", "�������", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (mBoxResult2 == DialogResult.Yes) minNumber = midle + 1;
                else maxNumber = midle - 1;

                if (maxNumber < minNumber)
                {

                    MessageBox.Show($"���� ����� �� ��������... ������� ������� ?", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mBoxResult1 = MessageBox.Show($"ǳ����� �� ��� ?", "�������", MessageBoxButtons.YesNo,
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
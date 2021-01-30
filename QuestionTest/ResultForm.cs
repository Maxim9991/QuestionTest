using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace QuestionTest
{
    public partial class ResultForm : Form
    {
        public int right = 0;
        public int wrong = 0;
        public int proxid = 80;

        public ResultForm(bool[] result)
        {
            InitializeComponent();

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i])
                    right++;
                else
                    wrong++;
            }

            lblNameResult.Text = "ВАШ РЕЗУЛЬТАТ";
            lblgoodresult.Text = $"Відповіли правильно: {right} з {result.Length}";
            lblproc.Text = $"Прохідний бал: {proxid}%";

            int bal = right * 10;
            if (bal == 0)
                pictureBox1.Image = Properties.Resources._0;
            if (bal == 10)
                pictureBox1.Image = Properties.Resources._10;
            if (bal == 20)
                pictureBox1.Image = Properties.Resources._20;
            if (bal == 30)
                pictureBox1.Image = Properties.Resources._30;
            if (bal == 40)
                pictureBox1.Image = Properties.Resources._40;
            if (bal == 50)
                pictureBox1.Image = Properties.Resources._50;
            if (bal == 60)
                pictureBox1.Image = Properties.Resources._60;
            if (bal == 70)
                pictureBox1.Image = Properties.Resources._70;
            if (bal == 80)
                pictureBox1.Image = Properties.Resources._80;
            if (bal == 90)
                pictureBox1.Image = Properties.Resources._90;
            if (bal == 100)
                pictureBox1.Image = Properties.Resources._100;

            if(bal >= 80)
                lblTest.Text = "Складено";
            else if(bal < 80)
                lblTest.Text = "Не складено";
        }
    }
}

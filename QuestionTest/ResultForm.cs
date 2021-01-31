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
            this.progressBar1.Maximum = 100;

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
            {
                this.progressBar1.Value += 0;
                lblTaskProc.Text = "0%";
            }
            if (bal == 10)
            {
                this.progressBar1.Value += 10;
                lblTaskProc.Text = "10%";
            }
            if (bal == 20)
            {
                this.progressBar1.Value += 20;
                lblTaskProc.Text = "20%";
            }
            if (bal == 30)
            {
                this.progressBar1.Value += 30;
                lblTaskProc.Text = "30%";
            }
            if (bal == 40)
            {
                this.progressBar1.Value += 40;
                lblTaskProc.Text = "40%";
            }    
            if (bal == 50)
            {
                this.progressBar1.Value += 50;
                lblTaskProc.Text = "50%";
            }
            if (bal == 60)
            {
                this.progressBar1.Value += 60;
                lblTaskProc.Text = "60%";
            }
            if (bal == 70)
            {
                this.progressBar1.Value += 70;
                lblTaskProc.Text = "70%";
            }
            if (bal == 80)
            {
                this.progressBar1.Value += 80;
                lblTaskProc.Text = "80%";
            }
            if (bal == 90)
            {
                this.progressBar1.Value += 90;
                lblTaskProc.Text = "90%";
            }    
            if (bal == 100)
            {
                this.progressBar1.Value += 100;
                lblTaskProc.Text = "100%";
            }    

            if (bal >= 80)
                lblTest.Text = "Складено";
            else if(bal < 80)
                lblTest.Text = "Не складено";
        }
    }
}

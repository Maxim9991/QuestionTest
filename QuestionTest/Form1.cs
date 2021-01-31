using QuestionTest.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace QuestionTest
{
    public partial class Questing : Form
    {


        List<QuestionClass> listQuestion;
        public int indexQuest = 0;
        public bool[] result;
        public int count = 10;

        System.Timers.Timer t;
        int m = 10, s = 0;


        public int limit = 0;  // Two false form exit!
        public Questing()
        {

            listQuestion = new List<QuestionClass>
            {
                new QuestionClass
                {
                    Text = "У яких напрямках Вам дозволено рух в даній ситуації?",
                    questionAnswerClasses = new List<QuestionAnswerClass>
                    {
                        new QuestionAnswerClass
                        {
                            Text = "Ліворуч і розворот.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Ліворуч.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Прямо, ліворуч і розворот.",
                            IsTrue = true
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Прямо, праворуч, ліворуч і розворот.",
                            IsTrue = false
                        },

                    }
                },
                new QuestionClass
                {
                    Text = "Який попереджувальний сигнал вмикається на транспортних засобах колони під\nчас зупинки на дорозі?",
                    questionAnswerClasses = new List<QuestionAnswerClass>
                    {
                        new QuestionAnswerClass
                        {
                            Text = "Аварійна сигналізація.",
                            IsTrue = true
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Ближнє світло фар.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Габаритні ліхтарі.",
                            IsTrue = false
                        },
                    }
                },
                new QuestionClass
                {
                    Text = "Чи правильно водій, який знаходиться ліворуч, виконує поворот праворуч?",
                    questionAnswerClasses = new List<QuestionAnswerClass>
                    {
                        new QuestionAnswerClass
                        {
                            Text = "Неправильно.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Правильно.",
                            IsTrue = true
                        },
                    }
                },
                new QuestionClass
                {
                    Text = "Чи повинен водій синього автомобіля дати дорогу велосипедистові в даній ситуації?",
                    questionAnswerClasses = new List<QuestionAnswerClass>
                    {
                        new QuestionAnswerClass
                        {
                            Text = "Не повинен.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Повинен.",
                            IsTrue = true
                        },
                    }
                },
                new QuestionClass
                {
                    Text = "Чи дозволено вам випередження по реверсивній смузі, якщо реверсивний світлофор вимкнений?",
                    questionAnswerClasses = new List<QuestionAnswerClass>
                    {
                        new QuestionAnswerClass
                        {
                            Text = "Дозволено.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Заборонено.",
                            IsTrue = true
                        },
                    }
                },
                new QuestionClass
                {
                    Text = "Який із зображених дорожніх знаків встановлюється на початку автомагістралі?",
                    questionAnswerClasses = new List<QuestionAnswerClass>
                    {
                        new QuestionAnswerClass
                        {
                            Text = "Знак 1.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Знак 2.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Знак 3.",
                            IsTrue = true
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Знак 4.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Знак 5.",
                            IsTrue = false
                        },
                    }
                },
                new QuestionClass
                {
                    Text = "Яке значення має жовтий миготливий сигнал світлофора в даній ситуації?",
                    questionAnswerClasses = new List<QuestionAnswerClass>
                    {
                        new QuestionAnswerClass
                        {
                            Text = "Вимагає від водіїв обов'язкової зупинки.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Дозволяє рух й інформує про наявність\nнебезпечного нерегульованого\nперехрестя.",
                            IsTrue = true
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Забороняє рух транспортних засобів.",
                            IsTrue = false
                        },
                    }
                },
                new QuestionClass
                {
                    Text = "Чим повинні керуватися водії під час проїзду даного перехрестя?",
                    questionAnswerClasses = new List<QuestionAnswerClass>
                    {
                        new QuestionAnswerClass
                        {
                            Text = "Знаками пріоритету.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Сигналами регулювальника.",
                            IsTrue = true
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Сигналами світлофора.",
                            IsTrue = false
                        },
                    }
                },
                new QuestionClass
                {
                    Text = "З якою максимальною швидкістю допускається рух на цій дорозі білого легкового\nавтомобіля, якщо він рухається за межами населеного пункту?",
                    questionAnswerClasses = new List<QuestionAnswerClass>
                    {
                        new QuestionAnswerClass
                        {
                            Text = "100 км/год.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "110 км/год.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "70 км/год.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "80 км/год.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "90 км/год.",
                            IsTrue = true
                        },
                    }
                },
                new QuestionClass
                {
                    Text = "На даному перехресті, повертаючи ліворуч, необхідно:",
                    questionAnswerClasses = new List<QuestionAnswerClass>
                    {
                        new QuestionAnswerClass
                        {
                            Text = "Дати дорогу всім автомобілям.",
                            IsTrue = false
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Дати дорогу тільки зустрічному автомобілю.",
                            IsTrue = true
                        },
                        new QuestionAnswerClass
                        {
                            Text = "Проїхати перехрестя першим.",
                            IsTrue = false
                        },
                    }
                }
            };
            InitializeComponent();
            result = new bool[listQuestion.Count];
        }

        private void ShowFormQuesting()
        {
            lblQuestion.Text = listQuestion[indexQuest].Text;

            var answers = listQuestion[indexQuest].questionAnswerClasses;
            int dy = 25;
            int startPosition = 30;

            gbAnwers.Controls.Clear();
            for (int i = 0; i < answers.Count; i++)
            {
                RadioButton gbOneItem;
                gbOneItem = new System.Windows.Forms.RadioButton();
                gbOneItem.AutoSize = true;
                gbOneItem.Location = new System.Drawing.Point(25, startPosition);
                gbOneItem.Name = $"gbItem{i}";
                gbOneItem.Tag = answers[i];
                gbOneItem.Size = new System.Drawing.Size(67, 19);
                gbOneItem.TabIndex = 1;
                gbOneItem.TabStop = true;
                gbOneItem.Text = answers[i].Text;
                gbOneItem.UseVisualStyleBackColor = true;
                gbAnwers.Controls.Add(gbOneItem);
                if (indexQuest == 6)
                    startPosition += 65;
                else
                    startPosition += dy;


                if (indexQuest == 0)
                    pictureBox1.Image = Properties.Resources._1;
                if (indexQuest == 1)
                    pictureBox1.Image = Properties.Resources._2;
                if (indexQuest == 2)
                    pictureBox1.Image = Properties.Resources._3;
                if (indexQuest == 3)
                    pictureBox1.Image = Properties.Resources._4;
                if (indexQuest == 4)
                    pictureBox1.Image = Properties.Resources._5;
                if(indexQuest == 5)
                    pictureBox1.Image = Properties.Resources._6;
                if (indexQuest == 6)
                    pictureBox1.Image = Properties.Resources._7;
                if (indexQuest == 7)
                    pictureBox1.Image = Properties.Resources._8;
                if (indexQuest == 8)
                    pictureBox1.Image = Properties.Resources._9;
                if (indexQuest == 9)
                    pictureBox1.Image = Properties.Resources._10;

                lblCount.Text = $"Залишилось {count} питань";
            }

        }

        private void Questing_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();
            this.progressBar1.Maximum = 10;
            ShowFormQuesting();
        }

        public void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
                if (s < 0)
                {
                    s = 59;
                    --m;
                }
                txtBoxTimer.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

                if (m == 0 && s == 0)
                {
                    t.Stop();
                    txtBoxTimer.Text = "00:00";
                    ResultForm resultform = new ResultForm(result);
                    resultform.ShowDialog();
                    this.Close();
                }

            }));

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            RadioButton gbOneItem = new RadioButton();
            var radioButtons = gbAnwers.Controls.OfType<RadioButton>();

            foreach (RadioButton radio in radioButtons)
            {
                if (radio.Checked)
                {
                    var ans = radio.Tag as QuestionAnswerClass;
                    result[indexQuest] = ans.IsTrue;
                    indexQuest++;
                    count--;
                    this.progressBar1.Value += 1;

                    if(ans.IsTrue == true)
                    {
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.win);
                        soundPlayer.Play();
                        if (indexQuest == 1)
                            lbl1.BackColor = Color.Yellow;
                        if (indexQuest == 2)
                            lbl2.BackColor = Color.Yellow;
                        if (indexQuest == 3)
                            lbl3.BackColor = Color.Yellow;
                        if (indexQuest == 4)
                            lbl4.BackColor = Color.Yellow;
                        if (indexQuest == 5)
                            lbl5.BackColor = Color.Yellow;
                        if (indexQuest == 6)
                            lbl6.BackColor = Color.Yellow;
                        if (indexQuest == 7)
                            lbl7.BackColor = Color.Yellow;
                        if (indexQuest == 8)
                            lbl8.BackColor = Color.Yellow;
                        if (indexQuest == 9)
                            lbl9.BackColor = Color.Yellow;
                        if (indexQuest == 10)
                            lbl10.BackColor = Color.Yellow;
                    }
                    else
                    {
                        limit++;
                        SoundPlayer soundPlayer1 = new SoundPlayer(Properties.Resources.lose);
                          soundPlayer1.Play();
                        if (indexQuest == 1)
                            lbl1.BackColor = Color.Red;
                        if (indexQuest == 2)
                            lbl2.BackColor = Color.Red;
                        if (indexQuest == 3)
                            lbl3.BackColor = Color.Red;
                        if (indexQuest == 4)
                            lbl4.BackColor = Color.Red;
                        if (indexQuest == 5)
                            lbl5.BackColor = Color.Red;
                        if (indexQuest == 6)
                            lbl6.BackColor = Color.Red;
                        if (indexQuest == 7)
                            lbl7.BackColor = Color.Red;
                        if (indexQuest == 8)
                            lbl8.BackColor = Color.Red;
                        if (indexQuest == 9)
                            lbl9.BackColor = Color.Red;
                        if (indexQuest == 10)
                            lbl10.BackColor = Color.Red;
                    }

                    if(limit > 2)
                    {
                        t.Stop();
                        ResultForm resultform = new ResultForm(result);
                        resultform.ShowDialog();
                        this.Close();
                    }

                }
            }

            if (indexQuest < listQuestion.Count)
            {
                ShowFormQuesting();
            }
            else
            {
                t.Stop();
                ResultForm resultform = new ResultForm(result);
                resultform.ShowDialog();
                this.Close();
            }
        }
    }
}

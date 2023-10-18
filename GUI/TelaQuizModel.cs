using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizXmlGUI
{
    public partial class TelaQuizModel : Form
    {
        public bool isUltimo = false;
        public int ScoreMarcado = 0;
        private int auxScore = 0;
        private int qidAtual = 0;
      //private List<QuestData> qds;
        private QuestData qd;
        private List<RadioButton> radBtn = new List<RadioButton>();
        public TelaQuizModel(string idAssunto, int Idquest)
        {
            InitializeComponent();

            //qds = QuestOperation.GetALLQuests(idAssunto);
            qd = QuestOperation.getQuest(idAssunto, Idquest.ToString());
            qidAtual = Idquest;
            
            if (Idquest.ToString() == qd.Id)
            {
                //int aux = Int32.Parse(qds[Idquest].Id) + 1;
                int aux = Int32.Parse(qd.Id) + 1;
                //this.Text = qds[Idquest].Assunto;
                this.Text = qd.Assunto;
                //Quest_tile.Text += aux.ToString();
                Quest_tile.Text += aux.ToString();
                //TxtQuiz.Text = "pts " + qds[Idquest].Score.ToString() + "\n" + aux.ToString() + ") " + qds[Idquest].Pergunta;
                TxtQuiz.Text = "pts " + qd.Score.ToString() + "\n" + aux.ToString() + ") " + qd.Pergunta;

                this.panel2.AutoScroll = true;

                PictureBox qpb = new PictureBox()
                {
                   // ImageLocation = qds[Idquest].ImgURL,
                    ImageLocation = qd.ImgURL,
                    Location = new Point { Y = (int)(TxtQuiz.Location.Y + TxtQuiz.Height + 20), X = TxtQuiz.Location.X },
                    Size = new Size(327,227),
                    SizeMode = PictureBoxSizeMode.StretchImage
                    //SizeMode = PictureBoxSizeMode.Zoom
                };
                //qpb.LoadAsync();

                this.panel2.Controls.Add(qpb);

                foreach(string atxt in qd.Alternativas)
                {
                    RadioButton alternativa = new RadioButton
                    {
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleLeft,
                        FlatStyle = FlatStyle.Flat,
                        Text = atxt,
                        BackColor = Color.Transparent
                    };
                    radBtn.Add(alternativa);
                }
                int i = 0;
                foreach(RadioButton rbtn in radBtn)
                {
                    if (i <= 0)
                    {
                        rbtn.Location = new Point { Y = (int)(qpb.Location.Y + qpb.Height+ 20), X = qpb.Location.X };
                    }
                    else
                    {
                        rbtn.Location = new Point { Y = (int)(radBtn[i - 1].Location.Y + radBtn[i-1].Height + 20), X = TxtQuiz.Location.X };
                    }

                    i++;
                    this.panel2.Controls.Add(rbtn);
                }
            
            }
            else {
                isUltimo = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            }
 
        }

        private void TxtQuiz_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isUltimo = true;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScoreMarcado = ScoreOperation(qd);
            this.DialogResult = DialogResult.OK;
             
        }

        private int ScoreOperation(QuestData qatual) {

            foreach (RadioButton el in radBtn) {
                if (el.Checked) {
                    if (el.Text[0].ToString() == qatual.Resposta) {
                        auxScore = qatual.Score;
                    }
                    break;
                }

            }

            return auxScore;
        }

        private void TelaQuizModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

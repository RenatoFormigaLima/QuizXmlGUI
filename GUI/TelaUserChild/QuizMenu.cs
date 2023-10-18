using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace QuizXmlGUI.GUI.TelaUserChild
{
    public partial class QuizMenu : Form
    {
        public int scoreMarcado = 0;
        private bool scoreValidado = false;
        private string assuntoValido;
        public QuizMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DataAssunto> da = QuestOperation.GetAssuntosForGrindView();
            ListaTopicos.DataSource = da;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchQuest();
        }

        private void searchQuest()
        {
            string[] assuntos = QuestOperation.GetAssuntos();

            for (int i = 0; i < assuntos.Length; i++)
            {
                if (assuntos[i] == textBox2.Text)
                {
                    scoreValidado = false;
                    assuntoValido = "";
                    CallQuest(assuntos[i]);
                    break;
                }
            }
        }
        private void CallQuest(string idA) {
            int idQ = 0;

            TelaQuizModel tq = new TelaQuizModel(idA, idQ)
            {
                StartPosition = FormStartPosition.CenterScreen
            };

            tq.ShowDialog();

            while (!tq.isUltimo) {

                if (tq.DialogResult == DialogResult.OK) {

                    scoreMarcado += tq.ScoreMarcado;
                    tq.Close();

                    idQ++;

                    tq = new TelaQuizModel(idA,idQ);

                    if (!tq.isUltimo)
                    {
                        tq.StartPosition = FormStartPosition.CenterScreen;
                        tq.ShowDialog();
                    }
                    else 
                    {
                        scoreValidado = true;
                        assuntoValido = textBox2.Text;
                    }

                }else if(tq.DialogResult == DialogResult.Cancel) { break; }
            }

            Scorelabel.Text = scoreMarcado.ToString();


        }

        public string AssuntoValido { get { return assuntoValido; } }
        public bool ScoreValidado { get { return scoreValidado; } set { scoreValidado = value; } }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals("enter")) searchQuest();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizXmlGUINative.GUI.TelaUserChild
{
    public partial class ScoreHistoricoMenu : Form
    {
        public ScoreHistoricoMenu(int[] Scores, string[] Assuntos, string UN)
        {
            InitializeComponent();

            List<Label> lblsScoreTxt = new List<Label> {
                s1lbl,
                s2lbl,
                s3lbl,
                s4lbl,
                s5lbl

            };

            List<Label> lblScoreTopics = new List<Label>
            {
                Score1,
                Score2,
                Score3,
                Score4,
                Score5
            };

            UserName.Text = UN;

            for (int i = 0; i < Scores.Length; i++) {
                lblsScoreTxt[i].Text = Scores[i].ToString();
                lblScoreTopics[i].Text = Assuntos[i]+" "+(i+1).ToString() +"°";
            }

        }
    }
}

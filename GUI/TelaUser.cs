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
namespace QuizXmlGUI
{
    public partial class TelaUser : Form
    {
        private Form formAtivo;
        private GUI.TelaUserChild.QuizMenu qm;
        private User user;

        private int[] ScoresMarcados = new int[5];
        private string[] ScoresMarcadosAssunto = new string[5];

        private int aux = -1;
        public TelaUser()
        {
            InitializeComponent();

            TelaLogin tl = new TelaLogin();

            tl.ShowDialog();

            if (tl.DialogResult == DialogResult.OK)
            {
                
                user = new User(tl.Ulogin, tl.Usen);
                tl.Close();

                User_name.Text = user.Login;

                if (user.Lv_acesso == "admin")
                {
                    this.Text = "Painel do Adm";
                    addQuestBtn.Visible = true;
                }
                else
                {
                    addQuestBtn.Visible = false;
                    this.Text = "Painel  do Aluno";
                }

            }
        }

        private void btnPlayQuiz_Click(object sender, EventArgs e)
        {
            qm = new GUI.TelaUserChild.QuizMenu();
            CallChildForm(qm);  
        }

        private void btn_ShowScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (qm.ScoreValidado == true)
                {
                    if (aux >= 4)
                    {
                        aux = -1;
                    }
                    else
                    {
                        aux++;
                    }
                    ScoresMarcados[aux] = qm.scoreMarcado;
                    ScoresMarcadosAssunto[aux] = qm.AssuntoValido;
                    qm.ScoreValidado = false;
                }
            }
            catch(Exception erro) {

                TelaDialogComunication dc = new TelaDialogComunication(1,"Jogue primero antes!")
                {
                    Text = "Aviso"
                };
                dc.ShowDialog();

            }

            CallChildForm(new QuizXmlGUINative.GUI.TelaUserChild.ScoreHistoricoMenu(ScoresMarcados, ScoresMarcadosAssunto, user.Login));
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            for (int i = 0; i < ScoresMarcados.Length; i++) {
                ScoresMarcados[i] = 0;
                ScoresMarcadosAssunto[i] = "";

            }
            this.PainelOperacoes.Controls.Clear();
            this.label1.Text = "Menu";
            TelaLogin tl = new TelaLogin();

            tl.ShowDialog();

            if (tl.DialogResult == DialogResult.OK)
            {

                user = new User(tl.Ulogin, tl.Usen);
                tl.Close();

                User_name.Text = user.Login;

                if (user.Lv_acesso == "admin")
                {
                    this.Text = "Painel do Adm";
                    addQuestBtn.Visible = true;
                }
                else
                {
                    addQuestBtn.Visible = false;
                    this.Text = "Painel  do Aluno";
                }
                this.Show();
            }
            
        }
        private void addQuestBtn_Click(object sender, EventArgs e)
        {

            if (User.AutenticarLogin(user.Login, user.Senha) && user.Lv_acesso == "admin") {
                try
                {
                    System.Diagnostics.Process.Start("QuizXmlConsole.exe");
                }
                catch (Exception erro) {

                    TelaDialogComunication dc = new TelaDialogComunication(0,"")
                    {
                        Text = "Erro:" + erro.ToString()
                    };
                    dc.ShowDialog();
                }
            }
        }
        private void CallChildForm(Form filho)
        {
            if(formAtivo != null)
            {
                formAtivo.Close();
            }

            formAtivo = filho;
            filho.TopLevel = false;
            filho.FormBorderStyle = FormBorderStyle.None;
            filho.Dock = DockStyle.Fill;
            this.PainelOperacoes.Controls.Add(filho);
            this.PainelOperacoes.Tag = filho;
            label1.Text = filho.Text; 
            filho.Show();

        }

        
    }
}

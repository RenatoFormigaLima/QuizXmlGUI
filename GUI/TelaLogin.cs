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
    public partial class TelaLogin : Form
    {
        //private Thread callJanelaUser;
        private string ulogin, usen;
        public TelaLogin()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (User.AutenticarLogin(textBox1.Text,textBox2.Text))
            {
                label4.Text = "";
                label4.Visible = false;
                ulogin = textBox1.Text;
                usen = textBox2.Text;

                this.DialogResult = DialogResult.OK;
                //callJanelaUser = new Thread(CallJanela);
                // callJanelaUser.SetApartmentState(ApartmentState.STA);

                // callJanelaUser.Start();
                //this.Close();

            }
            else
            {
                label4.Text = "Login e/ou senha inválidos!";
                label4.ForeColor = Color.Red;
                label4.Visible = true;
            }
        }
        public string Ulogin { get { return ulogin;} }
        public string Usen { get { return usen; } }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CallJanela(object o) {
          ///  User user = new User(textBox1.Text, textBox2.Text);
           // Application.Run(new TelaUser(user)); 
        }

    }
}

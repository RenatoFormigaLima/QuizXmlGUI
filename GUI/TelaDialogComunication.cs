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
    public partial class TelaDialogComunication : Form
    {
        public TelaDialogComunication(int type, string mensagem)
        {
            InitializeComponent();

            if (type == 0)
            {

                DialogTxt.Text = "Ocorreu um erro!\nAperte no botão Ok para continuar";
            }
            else {

                DialogTxt.Text = mensagem;
                panel1.BackColor = Color.Aqua;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}


namespace QuizXmlGUI
{
    partial class TelaUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUser));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.btn_ShowScore = new System.Windows.Forms.Button();
            this.btnPlayQuiz = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.User_name = new System.Windows.Forms.Label();
            this.User_img = new System.Windows.Forms.Label();
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PainelOperacoes = new System.Windows.Forms.Panel();
            this.addQuestBtn = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.TituloPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.MenuPanel.BackColor = System.Drawing.Color.SlateGray;
            this.MenuPanel.Controls.Add(this.addQuestBtn);
            this.MenuPanel.Controls.Add(this.LogoutBtn);
            this.MenuPanel.Controls.Add(this.btn_ShowScore);
            this.MenuPanel.Controls.Add(this.btnPlayQuiz);
            this.MenuPanel.Controls.Add(this.UserPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(165, 541);
            this.MenuPanel.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 481);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(165, 60);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // btn_ShowScore
            // 
            this.btn_ShowScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ShowScore.FlatAppearance.BorderSize = 0;
            this.btn_ShowScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowScore.Image = ((System.Drawing.Image)(resources.GetObject("btn_ShowScore.Image")));
            this.btn_ShowScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ShowScore.Location = new System.Drawing.Point(0, 120);
            this.btn_ShowScore.Name = "btn_ShowScore";
            this.btn_ShowScore.Size = new System.Drawing.Size(165, 60);
            this.btn_ShowScore.TabIndex = 2;
            this.btn_ShowScore.Text = "Score";
            this.btn_ShowScore.UseVisualStyleBackColor = true;
            this.btn_ShowScore.Click += new System.EventHandler(this.btn_ShowScore_Click);
            // 
            // btnPlayQuiz
            // 
            this.btnPlayQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayQuiz.FlatAppearance.BorderSize = 0;
            this.btnPlayQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayQuiz.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayQuiz.Image")));
            this.btnPlayQuiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayQuiz.Location = new System.Drawing.Point(0, 60);
            this.btnPlayQuiz.Name = "btnPlayQuiz";
            this.btnPlayQuiz.Size = new System.Drawing.Size(165, 60);
            this.btnPlayQuiz.TabIndex = 1;
            this.btnPlayQuiz.Text = "Quiz";
            this.btnPlayQuiz.UseVisualStyleBackColor = true;
            this.btnPlayQuiz.Click += new System.EventHandler(this.btnPlayQuiz_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.UserPanel.Controls.Add(this.User_name);
            this.UserPanel.Controls.Add(this.User_img);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(165, 60);
            this.UserPanel.TabIndex = 0;
            // 
            // User_name
            // 
            this.User_name.AutoSize = true;
            this.User_name.Location = new System.Drawing.Point(79, 23);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(57, 13);
            this.User_name.TabIndex = 1;
            this.User_name.Text = "UserName";
            // 
            // User_img
            // 
            this.User_img.Cursor = System.Windows.Forms.Cursors.Default;
            this.User_img.Dock = System.Windows.Forms.DockStyle.Left;
            this.User_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_img.Image = ((System.Drawing.Image)(resources.GetObject("User_img.Image")));
            this.User_img.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User_img.Location = new System.Drawing.Point(0, 0);
            this.User_img.MaximumSize = new System.Drawing.Size(60, 60);
            this.User_img.Name = "User_img";
            this.User_img.Size = new System.Drawing.Size(60, 60);
            this.User_img.TabIndex = 0;
            this.User_img.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TituloPanel
            // 
            this.TituloPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.TituloPanel.Controls.Add(this.label1);
            this.TituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloPanel.Location = new System.Drawing.Point(165, 0);
            this.TituloPanel.Name = "TituloPanel";
            this.TituloPanel.Size = new System.Drawing.Size(649, 60);
            this.TituloPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(302, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PainelOperacoes
            // 
            this.PainelOperacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelOperacoes.Location = new System.Drawing.Point(165, 60);
            this.PainelOperacoes.Name = "PainelOperacoes";
            this.PainelOperacoes.Size = new System.Drawing.Size(649, 481);
            this.PainelOperacoes.TabIndex = 2;
            // 
            // addQuestBtn
            // 
            this.addQuestBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addQuestBtn.FlatAppearance.BorderSize = 0;
            this.addQuestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addQuestBtn.Image = ((System.Drawing.Image)(resources.GetObject("addQuestBtn.Image")));
            this.addQuestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addQuestBtn.Location = new System.Drawing.Point(0, 180);
            this.addQuestBtn.Name = "addQuestBtn";
            this.addQuestBtn.Size = new System.Drawing.Size(165, 60);
            this.addQuestBtn.TabIndex = 4;
            this.addQuestBtn.Text = "Adicionar Questão";
            this.addQuestBtn.UseVisualStyleBackColor = true;
            this.addQuestBtn.Visible = false;
            this.addQuestBtn.Click += new System.EventHandler(this.addQuestBtn_Click);
            // 
            // TelaUser
            // 
            this.ClientSize = new System.Drawing.Size(814, 541);
            this.Controls.Add(this.PainelOperacoes);
            this.Controls.Add(this.TituloPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "TelaUser";
            this.MenuPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.TituloPanel.ResumeLayout(false);
            this.TituloPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label User_img;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button btn_ShowScore;
        private System.Windows.Forms.Button btnPlayQuiz;
        private System.Windows.Forms.Label User_name;
        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PainelOperacoes;
        private System.Windows.Forms.Button addQuestBtn;
    }
}
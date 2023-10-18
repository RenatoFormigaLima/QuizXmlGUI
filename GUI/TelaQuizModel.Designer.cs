
namespace QuizXmlGUI
{
    partial class TelaQuizModel
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Quest_tile = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtQuiz = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(374, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 20);
            this.button3.TabIndex = 14;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 20);
            this.button2.TabIndex = 15;
            this.button2.Text = "Próximo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.Quest_tile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 31);
            this.panel1.TabIndex = 20;
            // 
            // Quest_tile
            // 
            this.Quest_tile.AutoSize = true;
            this.Quest_tile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Quest_tile.Location = new System.Drawing.Point(213, 8);
            this.Quest_tile.Name = "Quest_tile";
            this.Quest_tile.Size = new System.Drawing.Size(63, 17);
            this.Quest_tile.TabIndex = 0;
            this.Quest_tile.Text = "Questão ";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(1, 100);
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.TxtQuiz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 367);
            this.panel2.TabIndex = 22;
            // 
            // TxtQuiz
            // 
            this.TxtQuiz.AutoSize = true;
            this.TxtQuiz.BackColor = System.Drawing.Color.Transparent;
            this.TxtQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtQuiz.Location = new System.Drawing.Point(12, 15);
            this.TxtQuiz.Name = "TxtQuiz";
            this.TxtQuiz.Size = new System.Drawing.Size(64, 26);
            this.TxtQuiz.TabIndex = 13;
            this.TxtQuiz.Text = "pts xyz\r\nn) Quest_txt";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 60);
            this.panel3.TabIndex = 21;
            // 
            // TelaQuizModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(483, 398);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaQuizModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaQuiz_ex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaQuizModel_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Quest_tile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TxtQuiz;
        private System.Windows.Forms.Panel panel3;
    }
}
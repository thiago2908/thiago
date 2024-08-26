namespace GestorDeEstudantesT6
{
    partial class FormeEstatistica
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelTotalDeAlunos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTotalDeAlunos.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panelTotalDeAlunos
            // 
            this.panelTotalDeAlunos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelTotalDeAlunos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalDeAlunos.Controls.Add(this.label2);
            this.panelTotalDeAlunos.Location = new System.Drawing.Point(12, 12);
            this.panelTotalDeAlunos.Name = "panelTotalDeAlunos";
            this.panelTotalDeAlunos.Size = new System.Drawing.Size(780, 172);
            this.panelTotalDeAlunos.TabIndex = 1;
            this.panelTotalDeAlunos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelTotalDeAlunos.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panelTotalDeAlunos.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de alunos 999";
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMeninos.Controls.Add(this.label3);
            this.panelMeninos.Location = new System.Drawing.Point(12, 198);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(365, 248);
            this.panelMeninos.TabIndex = 0;
            this.panelMeninos.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panelMeninos.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Meninos: 50%";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.Crimson;
            this.panelMeninas.Controls.Add(this.label4);
            this.panelMeninas.Location = new System.Drawing.Point(422, 198);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(370, 248);
            this.panelMeninas.TabIndex = 1;
            this.panelMeninas.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panelMeninas.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Meninas: 50%";
            // 
            // FormeEstatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMeninas);
            this.Controls.Add(this.panelMeninos);
            this.Controls.Add(this.panelTotalDeAlunos);
            this.Controls.Add(this.label1);
            this.Name = "FormeEstatistica";
            this.Text = "FormeEstatistica";
            this.Load += new System.EventHandler(this.FormeEstatistica_Load);
            this.panelTotalDeAlunos.ResumeLayout(false);
            this.panelTotalDeAlunos.PerformLayout();
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTotalDeAlunos;
        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
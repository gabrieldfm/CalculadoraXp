namespace CalculadoraXp
{
    partial class FrmPrincipal
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.GroupOp = new System.Windows.Forms.TabControl();
            this.LbLvlLvl = new System.Windows.Forms.TabPage();
            this.EtXpNec1 = new System.Windows.Forms.TextBox();
            this.LbAba1Xp = new System.Windows.Forms.Label();
            this.LbAba1F = new System.Windows.Forms.Label();
            this.LbAba1I = new System.Windows.Forms.Label();
            this.EtLvlFuturo1 = new System.Windows.Forms.TextBox();
            this.EtLvlAtual1 = new System.Windows.Forms.TextBox();
            this.LbXpLvl = new System.Windows.Forms.TabPage();
            this.EtXpNec2 = new System.Windows.Forms.TextBox();
            this.LbXpAba2 = new System.Windows.Forms.Label();
            this.LbAba2F = new System.Windows.Forms.Label();
            this.LbAba2I = new System.Windows.Forms.Label();
            this.EtAba2F = new System.Windows.Forms.TextBox();
            this.EtXpAtu1 = new System.Windows.Forms.TextBox();
            this.BtCalc = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.TabSobre = new System.Windows.Forms.TabPage();
            this.DadosSite = new System.Windows.Forms.Label();
            this.Contato = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.GroupOp.SuspendLayout();
            this.LbLvlLvl.SuspendLayout();
            this.LbXpLvl.SuspendLayout();
            this.TabSobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::CalculadoraXp.Properties.Resources.logoPxg;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(574, 90);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // GroupOp
            // 
            this.GroupOp.Controls.Add(this.LbLvlLvl);
            this.GroupOp.Controls.Add(this.LbXpLvl);
            this.GroupOp.Controls.Add(this.TabSobre);
            this.GroupOp.Location = new System.Drawing.Point(12, 123);
            this.GroupOp.Name = "GroupOp";
            this.GroupOp.SelectedIndex = 0;
            this.GroupOp.Size = new System.Drawing.Size(573, 134);
            this.GroupOp.TabIndex = 1;
            // 
            // LbLvlLvl
            // 
            this.LbLvlLvl.BackColor = System.Drawing.Color.LightGray;
            this.LbLvlLvl.Controls.Add(this.EtXpNec1);
            this.LbLvlLvl.Controls.Add(this.LbAba1Xp);
            this.LbLvlLvl.Controls.Add(this.LbAba1F);
            this.LbLvlLvl.Controls.Add(this.LbAba1I);
            this.LbLvlLvl.Controls.Add(this.EtLvlFuturo1);
            this.LbLvlLvl.Controls.Add(this.EtLvlAtual1);
            this.LbLvlLvl.Location = new System.Drawing.Point(4, 22);
            this.LbLvlLvl.Name = "LbLvlLvl";
            this.LbLvlLvl.Padding = new System.Windows.Forms.Padding(3);
            this.LbLvlLvl.Size = new System.Drawing.Size(565, 108);
            this.LbLvlLvl.TabIndex = 0;
            this.LbLvlLvl.Text = "Lvl x Lvl";
            // 
            // EtXpNec1
            // 
            this.EtXpNec1.Location = new System.Drawing.Point(100, 55);
            this.EtXpNec1.Name = "EtXpNec1";
            this.EtXpNec1.ReadOnly = true;
            this.EtXpNec1.Size = new System.Drawing.Size(100, 20);
            this.EtXpNec1.TabIndex = 5;
            this.EtXpNec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbAba1Xp
            // 
            this.LbAba1Xp.AutoSize = true;
            this.LbAba1Xp.Location = new System.Drawing.Point(6, 62);
            this.LbAba1Xp.Name = "LbAba1Xp";
            this.LbAba1Xp.Size = new System.Drawing.Size(76, 13);
            this.LbAba1Xp.TabIndex = 4;
            this.LbAba1Xp.Text = "Xp Necessária";
            // 
            // LbAba1F
            // 
            this.LbAba1F.AutoSize = true;
            this.LbAba1F.Location = new System.Drawing.Point(245, 21);
            this.LbAba1F.Name = "LbAba1F";
            this.LbAba1F.Size = new System.Drawing.Size(112, 13);
            this.LbAba1F.TabIndex = 3;
            this.LbAba1F.Text = "Level a ser alcançado";
            // 
            // LbAba1I
            // 
            this.LbAba1I.AutoSize = true;
            this.LbAba1I.Location = new System.Drawing.Point(6, 21);
            this.LbAba1I.Name = "LbAba1I";
            this.LbAba1I.Size = new System.Drawing.Size(60, 13);
            this.LbAba1I.TabIndex = 2;
            this.LbAba1I.Text = "Level Atual";
            // 
            // EtLvlFuturo1
            // 
            this.EtLvlFuturo1.Location = new System.Drawing.Point(375, 14);
            this.EtLvlFuturo1.Name = "EtLvlFuturo1";
            this.EtLvlFuturo1.Size = new System.Drawing.Size(100, 20);
            this.EtLvlFuturo1.TabIndex = 1;
            this.EtLvlFuturo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EtLvlFuturo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EtLvlFuturo1_KeyPress);
            // 
            // EtLvlAtual1
            // 
            this.EtLvlAtual1.Location = new System.Drawing.Point(100, 14);
            this.EtLvlAtual1.Name = "EtLvlAtual1";
            this.EtLvlAtual1.Size = new System.Drawing.Size(100, 20);
            this.EtLvlAtual1.TabIndex = 0;
            this.EtLvlAtual1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EtLvlAtual1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EtLvlAtual1_KeyPress);
            // 
            // LbXpLvl
            // 
            this.LbXpLvl.BackColor = System.Drawing.Color.LightGray;
            this.LbXpLvl.Controls.Add(this.EtXpNec2);
            this.LbXpLvl.Controls.Add(this.LbXpAba2);
            this.LbXpLvl.Controls.Add(this.LbAba2F);
            this.LbXpLvl.Controls.Add(this.LbAba2I);
            this.LbXpLvl.Controls.Add(this.EtAba2F);
            this.LbXpLvl.Controls.Add(this.EtXpAtu1);
            this.LbXpLvl.Location = new System.Drawing.Point(4, 22);
            this.LbXpLvl.Name = "LbXpLvl";
            this.LbXpLvl.Padding = new System.Windows.Forms.Padding(3);
            this.LbXpLvl.Size = new System.Drawing.Size(565, 108);
            this.LbXpLvl.TabIndex = 1;
            this.LbXpLvl.Text = "Xp x Lvl";
            // 
            // EtXpNec2
            // 
            this.EtXpNec2.Location = new System.Drawing.Point(107, 57);
            this.EtXpNec2.Name = "EtXpNec2";
            this.EtXpNec2.ReadOnly = true;
            this.EtXpNec2.Size = new System.Drawing.Size(100, 20);
            this.EtXpNec2.TabIndex = 11;
            this.EtXpNec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbXpAba2
            // 
            this.LbXpAba2.AutoSize = true;
            this.LbXpAba2.Location = new System.Drawing.Point(13, 64);
            this.LbXpAba2.Name = "LbXpAba2";
            this.LbXpAba2.Size = new System.Drawing.Size(76, 13);
            this.LbXpAba2.TabIndex = 10;
            this.LbXpAba2.Text = "Xp Necessária";
            // 
            // LbAba2F
            // 
            this.LbAba2F.AutoSize = true;
            this.LbAba2F.Location = new System.Drawing.Point(247, 22);
            this.LbAba2F.Name = "LbAba2F";
            this.LbAba2F.Size = new System.Drawing.Size(112, 13);
            this.LbAba2F.TabIndex = 9;
            this.LbAba2F.Text = "Level a ser alcançado";
            // 
            // LbAba2I
            // 
            this.LbAba2I.AutoSize = true;
            this.LbAba2I.Location = new System.Drawing.Point(13, 22);
            this.LbAba2I.Name = "LbAba2I";
            this.LbAba2I.Size = new System.Drawing.Size(47, 13);
            this.LbAba2I.TabIndex = 8;
            this.LbAba2I.Text = "Xp Atual";
            // 
            // EtAba2F
            // 
            this.EtAba2F.Location = new System.Drawing.Point(384, 15);
            this.EtAba2F.Name = "EtAba2F";
            this.EtAba2F.Size = new System.Drawing.Size(100, 20);
            this.EtAba2F.TabIndex = 7;
            this.EtAba2F.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EtAba2F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EtAba2F_KeyPress);
            // 
            // EtXpAtu1
            // 
            this.EtXpAtu1.Location = new System.Drawing.Point(107, 15);
            this.EtXpAtu1.Name = "EtXpAtu1";
            this.EtXpAtu1.Size = new System.Drawing.Size(100, 20);
            this.EtXpAtu1.TabIndex = 6;
            this.EtXpAtu1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EtXpAtu1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EtXpAtu1_KeyPress);
            // 
            // BtCalc
            // 
            this.BtCalc.Location = new System.Drawing.Point(425, 263);
            this.BtCalc.Name = "BtCalc";
            this.BtCalc.Size = new System.Drawing.Size(75, 23);
            this.BtCalc.TabIndex = 2;
            this.BtCalc.Text = "Calcular";
            this.BtCalc.UseVisualStyleBackColor = true;
            this.BtCalc.Click += new System.EventHandler(this.BtCalc_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(506, 263);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(75, 23);
            this.BtCancel.TabIndex = 3;
            this.BtCancel.Text = "Fechar";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // TabSobre
            // 
            this.TabSobre.BackColor = System.Drawing.Color.LightGray;
            this.TabSobre.Controls.Add(this.Nome);
            this.TabSobre.Controls.Add(this.Contato);
            this.TabSobre.Controls.Add(this.DadosSite);
            this.TabSobre.Location = new System.Drawing.Point(4, 22);
            this.TabSobre.Name = "TabSobre";
            this.TabSobre.Padding = new System.Windows.Forms.Padding(3);
            this.TabSobre.Size = new System.Drawing.Size(565, 108);
            this.TabSobre.TabIndex = 2;
            this.TabSobre.Text = "Sobre";
            // 
            // DadosSite
            // 
            this.DadosSite.AutoSize = true;
            this.DadosSite.Location = new System.Drawing.Point(6, 12);
            this.DadosSite.Name = "DadosSite";
            this.DadosSite.Size = new System.Drawing.Size(334, 13);
            this.DadosSite.TabIndex = 0;
            this.DadosSite.Text = "Dados coletados de http://www.blogpxg.com/tabela-de-experiencia/";
            this.DadosSite.Click += new System.EventHandler(this.label1_Click);
            // 
            // Contato
            // 
            this.Contato.AutoSize = true;
            this.Contato.Location = new System.Drawing.Point(6, 40);
            this.Contato.Name = "Contato";
            this.Contato.Size = new System.Drawing.Size(168, 13);
            this.Contato.TabIndex = 1;
            this.Contato.Text = "Contato: gabrieldfm13@gmail.com";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(6, 70);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(166, 13);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Carlos Gabriel Dal Farra Machado";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 295);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtCalc);
            this.Controls.Add(this.GroupOp);
            this.Controls.Add(this.Logo);
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora de XP";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.GroupOp.ResumeLayout(false);
            this.LbLvlLvl.ResumeLayout(false);
            this.LbLvlLvl.PerformLayout();
            this.LbXpLvl.ResumeLayout(false);
            this.LbXpLvl.PerformLayout();
            this.TabSobre.ResumeLayout(false);
            this.TabSobre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TabControl GroupOp;
        private System.Windows.Forms.TabPage LbLvlLvl;
        private System.Windows.Forms.TabPage LbXpLvl;
        private System.Windows.Forms.TextBox EtLvlAtual1;
        private System.Windows.Forms.Label LbAba1F;
        private System.Windows.Forms.Label LbAba1I;
        private System.Windows.Forms.TextBox EtLvlFuturo1;
        private System.Windows.Forms.TextBox EtXpNec1;
        private System.Windows.Forms.Label LbAba1Xp;
        private System.Windows.Forms.TextBox EtXpNec2;
        private System.Windows.Forms.Label LbXpAba2;
        private System.Windows.Forms.Label LbAba2F;
        private System.Windows.Forms.Label LbAba2I;
        private System.Windows.Forms.TextBox EtAba2F;
        private System.Windows.Forms.TextBox EtXpAtu1;
        private System.Windows.Forms.Button BtCalc;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.TabPage TabSobre;
        private System.Windows.Forms.Label DadosSite;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Contato;
    }
}


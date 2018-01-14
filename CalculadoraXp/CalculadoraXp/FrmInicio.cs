using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CalculadoraXp
{
    public partial class FrmPrincipal : Form
    {
        public Dados dados;
        public FrmPrincipal()
        {
            InitializeComponent();
            dados = new Dados();
            dados.SetaDdos();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtCalc_Click(object sender, EventArgs e)
        {
            var selecionado = GroupOp.SelectedTab.Name;
            
            switch (selecionado)
            {
                case "LbLvlLvl":
                    CalculaPorLvl();
                    break;
                case "LbXpLvl":
                    CalculaPorXp();
                    break;
            }
                
        }

        #region Métodos

        private void CalculaPorLvl()
        {
            var listaDadosLvl = dados.DicLvl;
            var lvlAtual = Convert.ToInt32(EtLvlAtual1.Text);
            var lvlFuturo = Convert.ToInt32(EtLvlFuturo1.Text);

            if (lvlFuturo <= lvlAtual)
            {
                MessageBox.Show("O level futuro deve ser maior que o level atual!", "Dados inválidos!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            if(lvlFuturo <= 2 || lvlAtual <=1)
            {
                MessageBox.Show("Confira os dados!", "Dados inválidos!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }

            try
            {
                var dadsoLvlIni = listaDadosLvl.Where(x => x.Key == lvlAtual).ToList();
                var dadsoLvlFin = listaDadosLvl.Where(x => x.Key == lvlFuturo).ToList();

                EtXpNec1.Text = Convert.ToString(dadsoLvlFin.First().Value - dadsoLvlIni.First().Value);
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um problema ao processar os dados - " + ex);
            }

        }

        private void CalculaPorXp()
        {
            var listaDadosLvl = dados.DicLvl;
            var xpAtual = Convert.ToInt32(EtXpAtu1.Text);
            var lvlFuturo = Convert.ToInt32(EtAba2F.Text);

            if (listaDadosLvl.FirstOrDefault(x => x.Key == lvlFuturo).Value <= xpAtual)
            {
                MessageBox.Show("A experência do level futuro deve ser maior que a experiência do level atuall!", "Dados inválidos!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }

            
            var dadsoLvlFin = listaDadosLvl.FirstOrDefault(x => x.Key == lvlFuturo).Value;

            EtXpNec2.Text = Convert.ToString(dadsoLvlFin - xpAtual);
        }

        #endregion

        #region Eventos tratamento numberOnly

        private void EtLvlAtual1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void EtLvlFuturo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void EtXpAtu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void EtAba2F_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

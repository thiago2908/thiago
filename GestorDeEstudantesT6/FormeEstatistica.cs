using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormeEstatistica : Form
    {
        public FormeEstatistica()
        {
            InitializeComponent();
        }

        private void FormeEstatistica_Load(object sender, EventArgs e)
        {
            Color corPainel Total = PanelTotalDeAlunos.BackColor;
            Color corPainel Menimos = PanelMeninos.BackColor;
            Color corPainel Meninas = PanelMeninas.BackColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel TotalDealunos  BackColor = Color Black
              labolTotalDeAlunos ForeColor = corPainelTotal;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}

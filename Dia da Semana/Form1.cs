using System;
using System.Windows.Forms;

namespace Dia_da_Semana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        diadasemana cunha = new diadasemana();
        private void Button1_Click(object sender, EventArgs e)
        {
            cunha.recebe = textBox1.Text;
            label1.Text = cunha.envia;
        }
    }
}

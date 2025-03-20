using Etec.FP.Negocios;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            lblCalcFinal.Text += calc.Somar(Convert.ToDouble(txtN1.Text), Convert.ToDouble(txtN2.Text)).ToString();
        }

    }
}

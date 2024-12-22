namespace Task_8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private double Mul(double a, double b) => a * b;  

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;

            if (double.TryParse(textBox1.Text, out double a) && 
                double.TryParse(textBox2.Text, out double b))
            {
                if (rbAdd.Checked)
                {
                    result = Mul(a, b);
                }
                else
                {

                }

                textBox3.Text = result.ToString();
            }
                    
        }
    }
}

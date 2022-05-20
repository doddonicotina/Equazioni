namespace Equazioni
{
    public partial class Risolutore : Form
    {
        public Risolutore()
        {
            InitializeComponent();

            output_x1.Visible= false;
            output_x2.Visible = false;
            x1.Visible = false;
            x2.Visible = false;
            io.Visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            


        }

        private void solve_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(input_coef_1.Text) && string.IsNullOrEmpty(input_coef_2.Text) && string.IsNullOrEmpty(input_coef_3.Text))
            {
                MessageBox.Show("Insersci i dati");

            }
            else
            {
                float a = float.Parse(input_coef_1.Text);
                float b = float.Parse(input_coef_2.Text);
                float c = float.Parse(input_coef_3.Text);

                Eq v = new Eq(a, b, c);
                v.Solu();
                if (v.Solu() == true)
                {

                    output_x1.Visible = true;
                    output_x2.Visible = true;
                    x1.Visible = true;
                    x2.Visible = true;
                    io.Visible = true;
                    output_x1.Text = v.x1.ToString();
                    output_x2.Text = v.x2.ToString();
                }
                else
                {
                    MessageBox.Show("coefficiente = 0");
                }
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            output_x1.Text = "";
            output_x2.Text = "";
            input_coef_1.Text = "";
            input_coef_2.Text = "";
            input_coef_3.Text = "";

            output_x1.Visible = false;
            output_x2.Visible = false;
            x1.Visible = false;
            x2.Visible = false;
            io.Visible = false;

        }

        private void input_coef_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_coef_1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void input_coef_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
               ){
                e.Handled = true;
            }

        }

        private void input_coef_1_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.Control == true)
            {
                MessageBox.Show("ahaha non puoi");
            }
        }
    }
    
}
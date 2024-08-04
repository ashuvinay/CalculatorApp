namespace Calculator
{
    public partial class frmMain : Form
    {
        
        private string result = string.Empty;

        public frmMain()
        {
            InitializeComponent();
            AddControlEvents();
        }


        private void AddControlEvents()
        {
            btnDecimal.Click += BtnDecimal_Click;
            btn0.Click += BtnNums_Click;
            btn1.Click += BtnNums_Click;
            btn2.Click += BtnNums_Click;
            btn3.Click += BtnNums_Click;
            btn4.Click += BtnNums_Click;
            btn5.Click += BtnNums_Click;
            btn6.Click += BtnNums_Click;
            btn7.Click += BtnNums_Click;
            btn8.Click += BtnNums_Click;
            btn9.Click += BtnNums_Click;

            this.KeyPress += new KeyPressEventHandler(frmMain_KeyPress);
        }

        private void BtnNums_Click(object? sender, EventArgs e)
        {
            try
            {
                if (txtResultBox.Text == result)
                    txtResultBox.Text = "0";

                btnPlus.Enabled = true;
                btnMinus.Enabled = true;
                btnMultiply.Enabled = true;
                btnDivide.Enabled = true;

                Button button = (Button)sender;
                if (txtResultBox.Text == "0")
                {
                    txtResultBox.Text = button.Text;
                }
                else
                {
                    txtResultBox.Text += button.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDecimal_Click(object? sender, EventArgs e)
        {
            if (!txtResultBox.Text.Contains('.'))
            {
                txtResultBox.Text += ".";
            }
        }

        private void frmMain_KeyPress(object? sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar))
                {
                    BtnNums_Click(this.Controls.Find("btn" + e.KeyChar, true).FirstOrDefault(), e);
                }
                else if (e.KeyChar == '.')
                {
                    BtnDecimal_Click(btnDecimal, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

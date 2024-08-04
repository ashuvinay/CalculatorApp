using CalculatorLibrary;

namespace Calculator
{
    public partial class frmMain : Form
    {

        private decimal fstNum, secNum = 0.0m;
        private string result = string.Empty;
        private string operation = string.Empty;
        private readonly CalculatorService calculatorService;

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
            btnEquals.Click += BtnEquals_Click;

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

        private void BtnEquals_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(txtResultBox.Text, out secNum))
            {
                btnC.PerformClick();
                return;
            }

            secNum = decimal.Parse(txtResultBox.Text);

            if (operation == "+")
            {
                txtDisplayOp.Text = "";
                txtDisplayOp.Text = $"{secNum} {operation} {fstNum} =";
            }
            else
            {
                txtDisplayOp.Text = "";
                txtDisplayOp.Text = $" {fstNum} {operation} {secNum} =";
            }

            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMultiply.Enabled = true;
            btnDivide.Enabled = true;

            try
            {
                decimal calculationResult = calculatorService.ExecuteOperation(operation, fstNum, secNum);
                if (calculationResult % 1 == 0)
                {
                    result = txtResultBox.Text = calculationResult.ToString("F0");
                }
                else
                {
                    result = txtResultBox.Text = calculationResult.ToString("F5");
                }
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("The Number Is Too Long.");
            }
            catch (DivideByZeroException)
            {
                result = txtResultBox.Text = "Infinity";
            }
            catch (InvalidOperationException)
            {
                txtDisplayOp.Text = $"{txtResultBox.Text} =";
            }
        }
    }
}

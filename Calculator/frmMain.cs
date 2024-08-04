using CalculatorLibrary;
using System.Diagnostics;

namespace Calculator
{
    public partial class frmMain : Form
    {
        #region Variable Declaration
        private decimal fstNum, secNum = 0.0m;
        private string result = string.Empty;
        private string operation = string.Empty;
        private readonly CalculatorService calculatorService;
        #endregion

        #region Constructors
        public frmMain()
        {
            InitializeComponent();
            AddControlEvents();
            calculatorService = new CalculatorService();
        }
        #endregion

        #region Private Methods
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

            btnSquire.Click += BtnOperation_Click;
            btnSqrt.Click += BtnOperation_Click;
            btn1x.Click += BtnOperation_Click;
            btnPercent.Click += BtnOperation_Click;
            btnPlusMinus.Click += BtnOperation_Click;

            btnDivide.Click += Operation_Click;
            btnMultiply.Click += Operation_Click;
            btnMinus.Click += Operation_Click;
            btnPlus.Click += Operation_Click;

            btnCE.Click += BtnCE_Click;
            btnC.Click += BtnC_Click;
            btnBack.Click += BtnBack_Click;
            btnEquals.Click += BtnEquals_Click;

            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmMain_KeyPress);
            this.KeyDown += new KeyEventHandler(frmMain_KeyDown);
            this.txtResultBox.KeyPress += TxtResultBox_KeyPress;
        }
        #endregion

        #region Control Events

        private void BtnDecimal_Click(object? sender, EventArgs e)
        {
            if (txtResultBox.Text == "Infinity" || txtResultBox.Text == "∞")
            {
                MessageBox.Show("Can not operate with infinity");
                btnC.PerformClick();
                return;
            }

            if (!txtResultBox.Text.Contains('.'))
            {
                txtResultBox.Text += ".";
            }
        }

        private void BtnNums_Click(object? sender, EventArgs e)
        {
            try
            {
                if (txtResultBox.Text == "Infinity" || txtResultBox.Text == "∞")
                {
                    MessageBox.Show("Can not operate with infinity");
                    btnC.PerformClick();
                    return;
                }

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

        private void BtnOperation_Click(object? sender, EventArgs e)
        {
            try
            {

                if (txtResultBox.Text == "Infinity" || txtResultBox.Text == "∞")
                {
                    MessageBox.Show("Can not operate with infinity");
                    btnC.PerformClick();
                }
                else
                {
                    Button button = (Button)sender;
                    operation = button.Text;
                    switch (operation)
                    {
                        case "√x":
                            txtDisplayOp.Text = $"√({txtResultBox.Text})";
                            result = Convert.ToString(Math.Sqrt(Convert.ToDouble(txtResultBox.Text)));
                            break;
                        case "^2":
                            txtDisplayOp.Text = $"({txtResultBox.Text})^2";
                            result = Convert.ToString(Convert.ToDouble(txtResultBox.Text) * (Convert.ToDouble(txtResultBox.Text)));
                            break;
                        case "¹/x":
                            txtDisplayOp.Text = $"¹/({txtResultBox.Text})";
                            result = Convert.ToString(1.0 / Convert.ToDouble(txtResultBox.Text));
                            break;
                        case "%":
                            txtDisplayOp.Text = $"%({txtResultBox.Text})";
                            result = Convert.ToString(Convert.ToDouble(txtResultBox.Text) / Convert.ToDouble(100));
                            break;
                        case "+/-":
                            //txtDis.Text = $"%({txtResultBox.Text})";
                            result = Convert.ToString(-Convert.ToDouble(txtResultBox.Text));
                            break;

                        default:
                            break;
                    }

                    if (result == "∞")
                    {
                        txtResultBox.Text = "Infinity";
                        return;
                    }

                    if (!string.IsNullOrEmpty(result))
                    {
                        decimal CalResult = decimal.Parse(result);

                        if (CalResult % 1 == 0)
                        {
                            result = txtResultBox.Text = CalResult.ToString("F0");
                        }
                        else
                        {
                            result = txtResultBox.Text = CalResult.ToString("F5");
                        }

                    }
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

                string logMessage = $" 'Fisrt Operand:' {fstNum} 'Operation:' {operation} 'Second Operand:' {secNum} 'Result:' {result}";

#if DEBUG
                Debug.WriteLine(logMessage);
#else
                string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
                File.AppendAllText(logFilePath, logMessage+Environment.NewLine,new UTF8Encoding(true));
#endif
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

        private void BtnBack_Click(object? sender, EventArgs e)
        {
            try
            {
                if (txtResultBox.Text.ToLower() == "infinity" || txtResultBox.Text.ToLower() == "∞")
                {
                    btnC.PerformClick();
                }

                if (txtResultBox.Text.Length > 0)
                {
                    txtResultBox.Text = txtResultBox.Text.Remove(txtResultBox.Text.Length - 1, 1);
                }
                if (txtResultBox.Text == "")
                    txtResultBox.Text = txtResultBox.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCE_Click(object? sender, EventArgs e)
        {
            txtResultBox.Text = "0";
        }

        private void BtnC_Click(object? sender, EventArgs e)
        {
            fstNum = 0; secNum = 0.0m;
            operation = string.Empty;
            txtDisplayOp.Text = "";
            txtResultBox.Text = "0";
        }

        private void Operation_Click(object? sender, EventArgs e)
        {
            if (txtResultBox.Text == "Infinity" || txtResultBox.Text == "∞")
            {
                MessageBox.Show("Can not operate with infinity");
                btnC.PerformClick();
            }
            else
            {
                try
                {


                    btnEquals.PerformClick();

                    Button button = (Button)sender;
                    fstNum = decimal.Parse(txtResultBox.Text);
                    operation = button.Text;
                    txtResultBox.Text = "0";

                    txtDisplayOp.Text = fstNum.ToString() + " " + operation;

                    btnPlus.Enabled = false;
                    btnMinus.Enabled = false;
                    btnMultiply.Enabled = false;
                    btnDivide.Enabled = false;
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("The Number Is Too Long.");
                }
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

        private void TxtResultBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '.')
                {
                    if (e.KeyChar == '.')
                    {
                        if ((sender as TextBox).Text.IndexOf('.') > -1)
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        string currentText = (sender as TextBox).Text;
                        if (currentText.Length >= 5 && char.IsDigit(e.KeyChar))
                        {
                            e.Handled = true;
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        BtnEquals_Click(btnEquals, e);
                        break;
                    case Keys.Back:
                        BtnBack_Click(btnBack, e);
                        break;
                    case Keys.Add:
                        Operation_Click(btnPlus, e);
                        break;
                    case Keys.Subtract:
                        Operation_Click(btnMinus, e);
                        break;
                    case Keys.Multiply:
                        Operation_Click(btnMultiply, e);
                        break;
                    case Keys.Divide:
                        Operation_Click(btnDivide, e);
                        break;
                    case Keys.Escape:
                        BtnCE_Click(btnCE, e);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }

}

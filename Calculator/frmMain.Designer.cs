namespace Calculator
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            txtResultBox = new TextBox();
            txtDisplayOp = new TextBox();
            panelMain = new Panel();
            btnBack = new Button();
            btnC = new Button();
            btnCE = new Button();
            btnPercent = new Button();
            btnEquals = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btnPlusMinus = new Button();
            btnPlus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMinus = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMultiply = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDivide = new Button();
            btnSqrt = new Button();
            btnSquire = new Button();
            btn1x = new Button();
            pnlHeader.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(32, 32, 32);
            pnlHeader.Controls.Add(txtResultBox);
            pnlHeader.Controls.Add(txtDisplayOp);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(414, 120);
            pnlHeader.TabIndex = 0;
            // 
            // txtResultBox
            // 
            txtResultBox.BackColor = Color.FromArgb(32, 32, 32);
            txtResultBox.BorderStyle = BorderStyle.None;
            txtResultBox.Cursor = Cursors.IBeam;
            txtResultBox.Dock = DockStyle.Fill;
            txtResultBox.Font = new Font("Gadugi", 30F, FontStyle.Bold);
            txtResultBox.ForeColor = Color.WhiteSmoke;
            txtResultBox.Location = new Point(0, 28);
            txtResultBox.Multiline = true;
            txtResultBox.Name = "txtResultBox";
            txtResultBox.Size = new Size(414, 92);
            txtResultBox.TabIndex = 1;
            txtResultBox.Text = "0";
            txtResultBox.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDisplayOp
            // 
            txtDisplayOp.BackColor = Color.FromArgb(32, 32, 32);
            txtDisplayOp.BorderStyle = BorderStyle.None;
            txtDisplayOp.Dock = DockStyle.Top;
            txtDisplayOp.Font = new Font("Gadugi", 14F);
            txtDisplayOp.ForeColor = Color.DarkGray;
            txtDisplayOp.Location = new Point(0, 0);
            txtDisplayOp.Multiline = true;
            txtDisplayOp.Name = "txtDisplayOp";
            txtDisplayOp.ReadOnly = true;
            txtDisplayOp.Size = new Size(414, 28);
            txtDisplayOp.TabIndex = 0;
            txtDisplayOp.TextAlign = HorizontalAlignment.Right;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(32, 32, 32);
            panelMain.Controls.Add(btnBack);
            panelMain.Controls.Add(btnC);
            panelMain.Controls.Add(btnCE);
            panelMain.Controls.Add(btnPercent);
            panelMain.Controls.Add(btnEquals);
            panelMain.Controls.Add(btnDecimal);
            panelMain.Controls.Add(btn0);
            panelMain.Controls.Add(btnPlusMinus);
            panelMain.Controls.Add(btnPlus);
            panelMain.Controls.Add(btn3);
            panelMain.Controls.Add(btn2);
            panelMain.Controls.Add(btn1);
            panelMain.Controls.Add(btnMinus);
            panelMain.Controls.Add(btn6);
            panelMain.Controls.Add(btn5);
            panelMain.Controls.Add(btn4);
            panelMain.Controls.Add(btnMultiply);
            panelMain.Controls.Add(btn9);
            panelMain.Controls.Add(btn8);
            panelMain.Controls.Add(btn7);
            panelMain.Controls.Add(btnDivide);
            panelMain.Controls.Add(btnSqrt);
            panelMain.Controls.Add(btnSquire);
            panelMain.Controls.Add(btn1x);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 120);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(414, 431);
            panelMain.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(50, 50, 50);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 18F);
            btnBack.ForeColor = Color.FromArgb(224, 224, 224);
            btnBack.Image = Properties.Resources.img_20240803;
            btnBack.Location = new Point(307, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 70);
            btnBack.TabIndex = 23;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(50, 50, 50);
            btnC.Cursor = Cursors.Hand;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Segoe UI", 18F);
            btnC.ForeColor = Color.FromArgb(224, 224, 224);
            btnC.Location = new Point(207, 4);
            btnC.Name = "btnC";
            btnC.Size = new Size(100, 70);
            btnC.TabIndex = 22;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.FromArgb(50, 50, 50);
            btnCE.Cursor = Cursors.Hand;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Font = new Font("Segoe UI", 18F);
            btnCE.ForeColor = Color.FromArgb(224, 224, 224);
            btnCE.Location = new Point(107, 4);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(100, 70);
            btnCE.TabIndex = 21;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.FromArgb(50, 50, 50);
            btnPercent.Cursor = Cursors.Hand;
            btnPercent.FlatStyle = FlatStyle.Flat;
            btnPercent.Font = new Font("Segoe UI", 18F);
            btnPercent.ForeColor = Color.FromArgb(224, 224, 224);
            btnPercent.Location = new Point(7, 4);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(100, 70);
            btnPercent.TabIndex = 20;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.SeaGreen;
            btnEquals.Cursor = Cursors.Hand;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.Font = new Font("Segoe UI", 18F);
            btnEquals.ForeColor = Color.FromArgb(224, 224, 224);
            btnEquals.Location = new Point(307, 354);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(100, 70);
            btnEquals.TabIndex = 19;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.FromArgb(60, 60, 60);
            btnDecimal.Cursor = Cursors.Hand;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Segoe UI", 18F);
            btnDecimal.ForeColor = Color.FromArgb(224, 224, 224);
            btnDecimal.Location = new Point(207, 354);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(100, 70);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(60, 60, 60);
            btn0.Cursor = Cursors.Hand;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 18F);
            btn0.ForeColor = Color.FromArgb(224, 224, 224);
            btn0.Location = new Point(107, 354);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 70);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.FromArgb(60, 60, 60);
            btnPlusMinus.Cursor = Cursors.Hand;
            btnPlusMinus.FlatStyle = FlatStyle.Flat;
            btnPlusMinus.Font = new Font("Segoe UI", 18F);
            btnPlusMinus.ForeColor = Color.FromArgb(224, 224, 224);
            btnPlusMinus.Location = new Point(7, 354);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(100, 70);
            btnPlusMinus.TabIndex = 16;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(50, 50, 50);
            btnPlus.Cursor = Cursors.Hand;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 18F);
            btnPlus.ForeColor = Color.FromArgb(224, 224, 224);
            btnPlus.Location = new Point(307, 284);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(100, 70);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(60, 60, 60);
            btn3.Cursor = Cursors.Hand;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 18F);
            btn3.ForeColor = Color.FromArgb(224, 224, 224);
            btn3.Location = new Point(207, 284);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 70);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(60, 60, 60);
            btn2.Cursor = Cursors.Hand;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 18F);
            btn2.ForeColor = Color.FromArgb(224, 224, 224);
            btn2.Location = new Point(107, 284);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 70);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(60, 60, 60);
            btn1.Cursor = Cursors.Hand;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 18F);
            btn1.ForeColor = Color.FromArgb(224, 224, 224);
            btn1.Location = new Point(7, 284);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 70);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(50, 50, 50);
            btnMinus.Cursor = Cursors.Hand;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 18F);
            btnMinus.ForeColor = Color.FromArgb(224, 224, 224);
            btnMinus.Location = new Point(307, 214);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(100, 70);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(60, 60, 60);
            btn6.Cursor = Cursors.Hand;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 18F);
            btn6.ForeColor = Color.FromArgb(224, 224, 224);
            btn6.Location = new Point(207, 214);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 70);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(60, 60, 60);
            btn5.Cursor = Cursors.Hand;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 18F);
            btn5.ForeColor = Color.FromArgb(224, 224, 224);
            btn5.Location = new Point(107, 214);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 70);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(60, 60, 60);
            btn4.Cursor = Cursors.Hand;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 18F);
            btn4.ForeColor = Color.FromArgb(224, 224, 224);
            btn4.Location = new Point(7, 214);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 70);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(50, 50, 50);
            btnMultiply.Cursor = Cursors.Hand;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 18F);
            btnMultiply.ForeColor = Color.FromArgb(224, 224, 224);
            btnMultiply.Location = new Point(307, 144);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(100, 70);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(60, 60, 60);
            btn9.Cursor = Cursors.Hand;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 18F);
            btn9.ForeColor = Color.FromArgb(224, 224, 224);
            btn9.Location = new Point(207, 144);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 70);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(60, 60, 60);
            btn8.Cursor = Cursors.Hand;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 18F);
            btn8.ForeColor = Color.FromArgb(224, 224, 224);
            btn8.Location = new Point(107, 144);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 70);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(60, 60, 60);
            btn7.Cursor = Cursors.Hand;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 18F);
            btn7.ForeColor = Color.FromArgb(224, 224, 224);
            btn7.Location = new Point(7, 144);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 70);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(50, 50, 50);
            btnDivide.Cursor = Cursors.Hand;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI", 18F);
            btnDivide.ForeColor = Color.FromArgb(224, 224, 224);
            btnDivide.Location = new Point(307, 74);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(100, 70);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.FromArgb(50, 50, 50);
            btnSqrt.Cursor = Cursors.Hand;
            btnSqrt.FlatStyle = FlatStyle.Flat;
            btnSqrt.Font = new Font("Segoe UI", 18F);
            btnSqrt.ForeColor = Color.FromArgb(224, 224, 224);
            btnSqrt.Location = new Point(207, 74);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(100, 70);
            btnSqrt.TabIndex = 2;
            btnSqrt.Text = "√x";
            btnSqrt.UseVisualStyleBackColor = false;
            // 
            // btnSquire
            // 
            btnSquire.BackColor = Color.FromArgb(50, 50, 50);
            btnSquire.Cursor = Cursors.Hand;
            btnSquire.FlatStyle = FlatStyle.Flat;
            btnSquire.Font = new Font("Segoe UI", 18F);
            btnSquire.ForeColor = Color.FromArgb(224, 224, 224);
            btnSquire.Location = new Point(107, 74);
            btnSquire.Name = "btnSquire";
            btnSquire.Size = new Size(100, 70);
            btnSquire.TabIndex = 1;
            btnSquire.Text = "^2";
            btnSquire.UseVisualStyleBackColor = false;
            // 
            // btn1x
            // 
            btn1x.BackColor = Color.FromArgb(50, 50, 50);
            btn1x.Cursor = Cursors.Hand;
            btn1x.FlatStyle = FlatStyle.Flat;
            btn1x.Font = new Font("Segoe UI", 18F);
            btn1x.ForeColor = Color.FromArgb(224, 224, 224);
            btn1x.Location = new Point(7, 74);
            btn1x.Name = "btn1x";
            btn1x.Size = new Size(100, 70);
            btn1x.TabIndex = 0;
            btn1x.Text = "¹/x";
            btn1x.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 551);
            Controls.Add(panelMain);
            Controls.Add(pnlHeader);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel panelMain;
        private TextBox txtResultBox;
        private TextBox txtDisplayOp;
        private Button btn1x;
        private Button btnEquals;
        private Button btnDecimal;
        private Button btn0;
        private Button btnPlusMinus;
        private Button btnPlus;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMinus;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMultiply;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDivide;
        private Button btnSqrt;
        private Button btnSquire;
        private Button btnBack;
        private Button btnC;
        private Button btnCE;
        private Button btnPercent;
    }
}

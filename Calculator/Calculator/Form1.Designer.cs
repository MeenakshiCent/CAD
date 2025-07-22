namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnEq = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(309, 55);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(309, 111);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Location = new System.Drawing.Point(205, 55);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(33, 13);
            this.Num1.TabIndex = 2;
            this.Num1.Text = "num1";
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Location = new System.Drawing.Point(205, 111);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(33, 13);
            this.Num2.TabIndex = 3;
            this.Num2.Text = "num2";
            this.Num2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sub";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(259, 249);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(37, 13);
            this.LblResult.TabIndex = 6;
            this.LblResult.Text = "Result";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Multiply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(446, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Division";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.97701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.02299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btndiv, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnmul, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnsub, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnadd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btndot, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEq, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnclear, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(568, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 170);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(39, 70);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(37, 23);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberButton_click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(3, 3);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(30, 23);
            this.btnclear.TabIndex = 0;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(122, 3);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(39, 23);
            this.btndiv.TabIndex = 1;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.OperationButton);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 38);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(30, 23);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberButton_click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(39, 38);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(37, 26);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberButton_click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(82, 38);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(34, 23);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberButton_click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(122, 38);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(39, 23);
            this.btnmul.TabIndex = 5;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.OperationButton);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 70);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(30, 23);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberButton_click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(82, 70);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(34, 23);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberButton_click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(122, 70);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(39, 23);
            this.btnsub.TabIndex = 13;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.OperationButton);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 99);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(30, 23);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberButton_click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(39, 99);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(37, 23);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberButton_click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(82, 99);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(34, 23);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberButton_click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(122, 99);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(39, 23);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.OperationButton);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(3, 137);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(30, 23);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberButton_click);
            // 
            // btndot
            // 
            this.btndot.Location = new System.Drawing.Point(39, 137);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(37, 23);
            this.btndot.TabIndex = 19;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btnEq
            // 
            this.btnEq.Location = new System.Drawing.Point(82, 137);
            this.btnEq.Name = "btnEq";
            this.btnEq.Size = new System.Drawing.Size(34, 23);
            this.btnEq.TabIndex = 20;
            this.btnEq.Text = "=";
            this.btnEq.UseVisualStyleBackColor = true;
            this.btnEq.Click += new System.EventHandler(this.btnEq_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.AutoSize = true;
            this.txtDisplay.Location = new System.Drawing.Point(647, 54);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(43, 13);
            this.txtDisplay.TabIndex = 10;
            this.txtDisplay.Text = "000000\r\n";
            this.txtDisplay.Click += new System.EventHandler(this.OperationButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.NumberButton_click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label txtDisplay;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnEq;
    }
}


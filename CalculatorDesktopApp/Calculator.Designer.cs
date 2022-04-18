namespace CalculatorDesktopApp
{
    partial class Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.InputNum = new System.Windows.Forms.TextBox();
            this.WholeEquation = new System.Windows.Forms.Label();
            this.OperandDisplay = new System.Windows.Forms.Label();
            this.Equals = new System.Windows.Forms.Button();
            this.buttonCLR = new System.Windows.Forms.Button();
            this.buttonDEC = new System.Windows.Forms.Button();
            this.buttonBIN = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(160, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(241, 149);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(79, 178);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(160, 178);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(241, 178);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Division
            // 
            this.Division.AccessibleDescription = "Button to display division symbol";
            this.Division.AccessibleName = "Division button";
            this.Division.Location = new System.Drawing.Point(355, 120);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 9;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Multiply
            // 
            this.Multiply.AccessibleDescription = "Button to display multiply symbol";
            this.Multiply.AccessibleName = "Multiply button";
            this.Multiply.Location = new System.Drawing.Point(355, 149);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 10;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Subtract
            // 
            this.Subtract.AccessibleDescription = "Button to display subtraction symbol";
            this.Subtract.AccessibleName = "Subtraction Button";
            this.Subtract.Location = new System.Drawing.Point(355, 178);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(75, 23);
            this.Subtract.TabIndex = 11;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Addition
            // 
            this.Addition.AccessibleDescription = "Button to display Addition symbol";
            this.Addition.AccessibleName = "Addition Button";
            this.Addition.Location = new System.Drawing.Point(355, 207);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(75, 23);
            this.Addition.TabIndex = 12;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // InputNum
            // 
            this.InputNum.AccessibleDescription = "Text box for inputting numbers";
            this.InputNum.AccessibleName = "InputNumBox";
            this.InputNum.Location = new System.Drawing.Point(135, 91);
            this.InputNum.Name = "InputNum";
            this.InputNum.ReadOnly = true;
            this.InputNum.Size = new System.Drawing.Size(100, 23);
            this.InputNum.TabIndex = 13;
            // 
            // WholeEquation
            // 
            this.WholeEquation.AccessibleDescription = "Displays the whole equation";
            this.WholeEquation.AccessibleName = "Whole Equation";
            this.WholeEquation.AutoSize = true;
            this.WholeEquation.Location = new System.Drawing.Point(181, 62);
            this.WholeEquation.Name = "WholeEquation";
            this.WholeEquation.Size = new System.Drawing.Size(54, 15);
            this.WholeEquation.TabIndex = 14;
            this.WholeEquation.Text = "Equation";
            this.WholeEquation.Visible = false;
            // 
            // OperandDisplay
            // 
            this.OperandDisplay.AccessibleDescription = "Displays operand symbol";
            this.OperandDisplay.AccessibleName = "Operand Symbol";
            this.OperandDisplay.AutoSize = true;
            this.OperandDisplay.Location = new System.Drawing.Point(241, 94);
            this.OperandDisplay.Name = "OperandDisplay";
            this.OperandDisplay.Size = new System.Drawing.Size(53, 15);
            this.OperandDisplay.TabIndex = 15;
            this.OperandDisplay.Text = "Operand";
            this.OperandDisplay.Visible = false;
            // 
            // Equals
            // 
            this.Equals.AccessibleDescription = "Button to display Equals symbol";
            this.Equals.AccessibleName = "Equals Button";
            this.Equals.Location = new System.Drawing.Point(355, 236);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(75, 23);
            this.Equals.TabIndex = 16;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // buttonCLR
            // 
            this.buttonCLR.Location = new System.Drawing.Point(160, 207);
            this.buttonCLR.Name = "buttonCLR";
            this.buttonCLR.Size = new System.Drawing.Size(75, 23);
            this.buttonCLR.TabIndex = 17;
            this.buttonCLR.Text = "0";
            this.buttonCLR.UseVisualStyleBackColor = true;
            this.buttonCLR.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDEC
            // 
            this.buttonDEC.Location = new System.Drawing.Point(79, 236);
            this.buttonDEC.Name = "buttonDEC";
            this.buttonDEC.Size = new System.Drawing.Size(75, 23);
            this.buttonDEC.TabIndex = 18;
            this.buttonDEC.Text = "DEC";
            this.buttonDEC.UseVisualStyleBackColor = true;
            this.buttonDEC.Click += new System.EventHandler(this.buttonDEC_Click);
            // 
            // buttonBIN
            // 
            this.buttonBIN.Location = new System.Drawing.Point(160, 236);
            this.buttonBIN.Name = "buttonBIN";
            this.buttonBIN.Size = new System.Drawing.Size(75, 23);
            this.buttonBIN.TabIndex = 19;
            this.buttonBIN.Text = "BIN";
            this.buttonBIN.UseVisualStyleBackColor = true;
            this.buttonBIN.Click += new System.EventHandler(this.buttonBIN_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(160, 265);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "CLR";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Calculator
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 375);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonBIN);
            this.Controls.Add(this.buttonDEC);
            this.Controls.Add(this.buttonCLR);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.OperandDisplay);
            this.Controls.Add(this.WholeEquation);
            this.Controls.Add(this.InputNum);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button Division;
        private Button Multiply;
        private Button Subtract;
        private Button Addition;
        private TextBox InputNum;
        private Label WholeEquation;
        private Label OperandDisplay;
        private Button Equals;
        private Button buttonCLR;
        private Button buttonDEC;
        private Button buttonBIN;
        private Button button10;
    }
}
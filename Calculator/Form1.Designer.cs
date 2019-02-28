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
            this.button_seven = new System.Windows.Forms.Button();
            this.button_eight = new System.Windows.Forms.Button();
            this.button_nine = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_delall = new System.Windows.Forms.Button();
            this.button_four = new System.Windows.Forms.Button();
            this.button_five = new System.Windows.Forms.Button();
            this.button_six = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_one = new System.Windows.Forms.Button();
            this.button_two = new System.Windows.Forms.Button();
            this.button_three = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_zero = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.Text_result = new System.Windows.Forms.TextBox();
            this.labelcurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_seven
            // 
            this.button_seven.Location = new System.Drawing.Point(30, 144);
            this.button_seven.Name = "button_seven";
            this.button_seven.Size = new System.Drawing.Size(36, 37);
            this.button_seven.TabIndex = 0;
            this.button_seven.Text = "7";
            this.button_seven.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_seven.UseVisualStyleBackColor = true;
            this.button_seven.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_eight
            // 
            this.button_eight.Location = new System.Drawing.Point(81, 144);
            this.button_eight.Name = "button_eight";
            this.button_eight.Size = new System.Drawing.Size(37, 37);
            this.button_eight.TabIndex = 1;
            this.button_eight.Text = "8";
            this.button_eight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_eight.UseVisualStyleBackColor = true;
            this.button_eight.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_nine
            // 
            this.button_nine.Location = new System.Drawing.Point(135, 144);
            this.button_nine.Name = "button_nine";
            this.button_nine.Size = new System.Drawing.Size(39, 37);
            this.button_nine.TabIndex = 2;
            this.button_nine.Text = "9";
            this.button_nine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_nine.UseVisualStyleBackColor = true;
            this.button_nine.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_divide
            // 
            this.button_divide.Location = new System.Drawing.Point(191, 144);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(42, 37);
            this.button_divide.TabIndex = 3;
            this.button_divide.Text = "/";
            this.button_divide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.Operator_click);
            // 
            // button_delall
            // 
            this.button_delall.Location = new System.Drawing.Point(253, 144);
            this.button_delall.Name = "button_delall";
            this.button_delall.Size = new System.Drawing.Size(46, 37);
            this.button_delall.TabIndex = 4;
            this.button_delall.Text = "CE";
            this.button_delall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delall.UseVisualStyleBackColor = true;
            this.button_delall.Click += new System.EventHandler(this.button_delall_Click);
            // 
            // button_four
            // 
            this.button_four.Location = new System.Drawing.Point(30, 197);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(36, 38);
            this.button_four.TabIndex = 5;
            this.button_four.Text = "4";
            this.button_four.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_four.UseVisualStyleBackColor = true;
            this.button_four.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_five
            // 
            this.button_five.Location = new System.Drawing.Point(81, 197);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(37, 38);
            this.button_five.TabIndex = 6;
            this.button_five.Text = "5";
            this.button_five.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_five.UseVisualStyleBackColor = true;
            this.button_five.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_six
            // 
            this.button_six.Location = new System.Drawing.Point(135, 197);
            this.button_six.Name = "button_six";
            this.button_six.Size = new System.Drawing.Size(39, 38);
            this.button_six.TabIndex = 7;
            this.button_six.Text = "6";
            this.button_six.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_six.UseVisualStyleBackColor = true;
            this.button_six.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(191, 197);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(42, 38);
            this.button_multiply.TabIndex = 8;
            this.button_multiply.Text = "*";
            this.button_multiply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.Operator_click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(253, 197);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(46, 38);
            this.button_del.TabIndex = 9;
            this.button_del.Text = "C";
            this.button_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_one
            // 
            this.button_one.Location = new System.Drawing.Point(30, 254);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(36, 33);
            this.button_one.TabIndex = 10;
            this.button_one.Text = "1";
            this.button_one.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_one.UseVisualStyleBackColor = true;
            this.button_one.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_two
            // 
            this.button_two.Location = new System.Drawing.Point(81, 254);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(37, 33);
            this.button_two.TabIndex = 11;
            this.button_two.Text = "2";
            this.button_two.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_two.UseVisualStyleBackColor = true;
            this.button_two.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_three
            // 
            this.button_three.Location = new System.Drawing.Point(135, 254);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(39, 33);
            this.button_three.TabIndex = 12;
            this.button_three.Text = "3";
            this.button_three.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_three.UseVisualStyleBackColor = true;
            this.button_three.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(191, 254);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(42, 33);
            this.button_minus.TabIndex = 13;
            this.button_minus.Text = "-";
            this.button_minus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.Operator_click);
            // 
            // button_zero
            // 
            this.button_zero.Location = new System.Drawing.Point(30, 305);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(97, 36);
            this.button_zero.TabIndex = 15;
            this.button_zero.Text = "0";
            this.button_zero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_zero.UseVisualStyleBackColor = true;
            // 
            // button_dot
            // 
            this.button_dot.Location = new System.Drawing.Point(135, 305);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(39, 36);
            this.button_dot.TabIndex = 17;
            this.button_dot.Text = ".";
            this.button_dot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(191, 305);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(42, 36);
            this.button_plus.TabIndex = 18;
            this.button_plus.Text = "+";
            this.button_plus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.Operator_click);
            // 
            // button_equals
            // 
            this.button_equals.Location = new System.Drawing.Point(253, 254);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(46, 87);
            this.button_equals.TabIndex = 19;
            this.button_equals.Text = "=";
            this.button_equals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_equals.UseVisualStyleBackColor = true;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // Text_result
            // 
            this.Text_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_result.Location = new System.Drawing.Point(31, 51);
            this.Text_result.Multiline = true;
            this.Text_result.Name = "Text_result";
            this.Text_result.Size = new System.Drawing.Size(268, 64);
            this.Text_result.TabIndex = 20;
            this.Text_result.Text = "0";
            this.Text_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelcurrentOperation
            // 
            this.labelcurrentOperation.AutoSize = true;
            this.labelcurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcurrentOperation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelcurrentOperation.Location = new System.Drawing.Point(27, 28);
            this.labelcurrentOperation.Name = "labelcurrentOperation";
            this.labelcurrentOperation.Size = new System.Drawing.Size(0, 20);
            this.labelcurrentOperation.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 353);
            this.Controls.Add(this.labelcurrentOperation);
            this.Controls.Add(this.Text_result);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_zero);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_three);
            this.Controls.Add(this.button_two);
            this.Controls.Add(this.button_one);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_six);
            this.Controls.Add(this.button_five);
            this.Controls.Add(this.button_four);
            this.Controls.Add(this.button_delall);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_nine);
            this.Controls.Add(this.button_eight);
            this.Controls.Add(this.button_seven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_seven;
        private System.Windows.Forms.Button button_eight;
        private System.Windows.Forms.Button button_nine;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_delall;
        private System.Windows.Forms.Button button_four;
        private System.Windows.Forms.Button button_five;
        private System.Windows.Forms.Button button_six;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_two;
        private System.Windows.Forms.Button button_three;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_zero;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.TextBox Text_result;
        private System.Windows.Forms.Button button_one;
        private System.Windows.Forms.Label labelcurrentOperation;
    }
}



namespace lab1
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.answer = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.White;
            this.answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(12, 12);
            this.answer.MaxLength = 24;
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(202, 33);
            this.answer.TabIndex = 0;
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.answer.TextChanged += new System.EventHandler(this.answer_TextChanged);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Lime;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(12, 58);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(46, 28);
            this.clear.TabIndex = 1;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.Lime;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspace.Location = new System.Drawing.Point(168, 58);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(46, 28);
            this.backspace.TabIndex = 2;
            this.backspace.Text = "<---";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Lime;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(64, 58);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(98, 28);
            this.equal.TabIndex = 30;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.LimeGreen;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(12, 92);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(46, 46);
            this.seven.TabIndex = 31;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.number_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.LimeGreen;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.Location = new System.Drawing.Point(64, 92);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(46, 46);
            this.eight.TabIndex = 32;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.number_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.LimeGreen;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.Location = new System.Drawing.Point(116, 92);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(46, 46);
            this.nine.TabIndex = 33;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.number_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.LawnGreen;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(12, 144);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(46, 46);
            this.four.TabIndex = 34;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.number_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.LawnGreen;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(64, 144);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(46, 46);
            this.five.TabIndex = 35;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.number_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.LawnGreen;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(116, 144);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(46, 46);
            this.six.TabIndex = 36;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.number_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.LimeGreen;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(168, 92);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(46, 46);
            this.plus.TabIndex = 37;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.LawnGreen;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(168, 144);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(46, 46);
            this.minus.TabIndex = 38;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.GreenYellow;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.ForeColor = System.Drawing.Color.Black;
            this.multiply.Location = new System.Drawing.Point(168, 248);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(46, 46);
            this.multiply.TabIndex = 46;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.Chartreuse;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(168, 196);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(46, 46);
            this.divide.TabIndex = 45;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.GreenYellow;
            this.load.ForeColor = System.Drawing.Color.Black;
            this.load.Location = new System.Drawing.Point(116, 248);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(46, 46);
            this.load.TabIndex = 44;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.GreenYellow;
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(64, 248);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(46, 46);
            this.save.TabIndex = 43;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.GreenYellow;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.ForeColor = System.Drawing.Color.Black;
            this.zero.Location = new System.Drawing.Point(12, 248);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(46, 46);
            this.zero.TabIndex = 42;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.number_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.Chartreuse;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(116, 196);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(46, 46);
            this.three.TabIndex = 41;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.number_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.Chartreuse;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(64, 196);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(46, 46);
            this.two.TabIndex = 40;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.number_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Chartreuse;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(12, 196);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(46, 46);
            this.one.TabIndex = 39;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.number_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(225, 306);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.answer);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
    }
}



namespace WindowsCalculator
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
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.ButtonSignClear = new System.Windows.Forms.Button();
            this.ButtonNum7 = new System.Windows.Forms.Button();
            this.ButtonNum8 = new System.Windows.Forms.Button();
            this.ButtonNum9 = new System.Windows.Forms.Button();
            this.ButtonSignAdd = new System.Windows.Forms.Button();
            this.ButtonSignSub = new System.Windows.Forms.Button();
            this.ButtonNum6 = new System.Windows.Forms.Button();
            this.ButtonNum5 = new System.Windows.Forms.Button();
            this.ButtonNum4 = new System.Windows.Forms.Button();
            this.ButtonSignMult = new System.Windows.Forms.Button();
            this.ButtonNum3 = new System.Windows.Forms.Button();
            this.ButtonNum2 = new System.Windows.Forms.Button();
            this.ButtonNum1 = new System.Windows.Forms.Button();
            this.ButtonSignDiv = new System.Windows.Forms.Button();
            this.ButtonSignEqual = new System.Windows.Forms.Button();
            this.ButtonSignComma = new System.Windows.Forms.Button();
            this.ButtonNum0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDisplay
            // 
            this.textDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay.Location = new System.Drawing.Point(28, 44);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.Size = new System.Drawing.Size(218, 53);
            this.textDisplay.TabIndex = 17;
            this.textDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonSignClear
            // 
            this.ButtonSignClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignClear.Location = new System.Drawing.Point(28, 136);
            this.ButtonSignClear.Name = "ButtonSignClear";
            this.ButtonSignClear.Size = new System.Drawing.Size(50, 50);
            this.ButtonSignClear.TabIndex = 18;
            this.ButtonSignClear.Text = "C";
            this.ButtonSignClear.UseVisualStyleBackColor = true;
            this.ButtonSignClear.Click += new System.EventHandler(this.ButtonSignClear_Click);
            // 
            // ButtonNum7
            // 
            this.ButtonNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum7.Location = new System.Drawing.Point(28, 192);
            this.ButtonNum7.Name = "ButtonNum7";
            this.ButtonNum7.Size = new System.Drawing.Size(50, 50);
            this.ButtonNum7.TabIndex = 19;
            this.ButtonNum7.Text = "7";
            this.ButtonNum7.UseVisualStyleBackColor = true;
            this.ButtonNum7.Click += new System.EventHandler(this.ButtonNum7_Click);
            // 
            // ButtonNum8
            // 
            this.ButtonNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum8.Location = new System.Drawing.Point(84, 192);
            this.ButtonNum8.Name = "ButtonNum8";
            this.ButtonNum8.Size = new System.Drawing.Size(50, 50);
            this.ButtonNum8.TabIndex = 20;
            this.ButtonNum8.Text = "8";
            this.ButtonNum8.UseVisualStyleBackColor = true;
            this.ButtonNum8.Click += new System.EventHandler(this.ButtonNum8_Click);
            // 
            // ButtonNum9
            // 
            this.ButtonNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum9.Location = new System.Drawing.Point(140, 192);
            this.ButtonNum9.Name = "ButtonNum9";
            this.ButtonNum9.Size = new System.Drawing.Size(50, 50);
            this.ButtonNum9.TabIndex = 21;
            this.ButtonNum9.Text = "9";
            this.ButtonNum9.UseVisualStyleBackColor = true;
            this.ButtonNum9.Click += new System.EventHandler(this.ButtonNum9_Click);
            // 
            // ButtonSignAdd
            // 
            this.ButtonSignAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignAdd.Location = new System.Drawing.Point(196, 192);
            this.ButtonSignAdd.Name = "ButtonSignAdd";
            this.ButtonSignAdd.Size = new System.Drawing.Size(50, 50);
            this.ButtonSignAdd.TabIndex = 22;
            this.ButtonSignAdd.Text = "+";
            this.ButtonSignAdd.UseVisualStyleBackColor = true;
            this.ButtonSignAdd.Click += new System.EventHandler(this.opMethod);
            // 
            // ButtonSignSub
            // 
            this.ButtonSignSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignSub.Location = new System.Drawing.Point(196, 248);
            this.ButtonSignSub.Name = "ButtonSignSub";
            this.ButtonSignSub.Size = new System.Drawing.Size(50, 50);
            this.ButtonSignSub.TabIndex = 26;
            this.ButtonSignSub.Text = "-";
            this.ButtonSignSub.UseVisualStyleBackColor = true;
            this.ButtonSignSub.Click += new System.EventHandler(this.opMethod);
            // 
            // ButtonNum6
            // 
            this.ButtonNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum6.Location = new System.Drawing.Point(140, 248);
            this.ButtonNum6.Name = "ButtonNum6";
            this.ButtonNum6.Size = new System.Drawing.Size(50, 50);
            this.ButtonNum6.TabIndex = 25;
            this.ButtonNum6.Text = "6";
            this.ButtonNum6.UseVisualStyleBackColor = true;
            this.ButtonNum6.Click += new System.EventHandler(this.ButtonNum6_Click);
            // 
            // ButtonNum5
            // 
            this.ButtonNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum5.Location = new System.Drawing.Point(84, 248);
            this.ButtonNum5.Name = "ButtonNum5";
            this.ButtonNum5.Size = new System.Drawing.Size(50, 50);
            this.ButtonNum5.TabIndex = 24;
            this.ButtonNum5.Text = "5";
            this.ButtonNum5.UseVisualStyleBackColor = true;
            this.ButtonNum5.Click += new System.EventHandler(this.ButtonNum5_Click);
            // 
            // ButtonNum4
            // 
            this.ButtonNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum4.Location = new System.Drawing.Point(28, 248);
            this.ButtonNum4.Name = "ButtonNum4";
            this.ButtonNum4.Size = new System.Drawing.Size(50, 50);
            this.ButtonNum4.TabIndex = 23;
            this.ButtonNum4.Text = "4";
            this.ButtonNum4.UseVisualStyleBackColor = true;
            this.ButtonNum4.Click += new System.EventHandler(this.ButtonNum4_Click);
            // 
            // ButtonSignMult
            // 
            this.ButtonSignMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignMult.Location = new System.Drawing.Point(196, 304);
            this.ButtonSignMult.Name = "ButtonSignMult";
            this.ButtonSignMult.Size = new System.Drawing.Size(50, 50);
            this.ButtonSignMult.TabIndex = 30;
            this.ButtonSignMult.Text = "x";
            this.ButtonSignMult.UseVisualStyleBackColor = true;
            this.ButtonSignMult.Click += new System.EventHandler(this.opMethod);
            // 
            // ButtonNum3
            // 
            this.ButtonNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum3.Location = new System.Drawing.Point(140, 304);
            this.ButtonNum3.Name = "ButtonNum3";
            this.ButtonNum3.Size = new System.Drawing.Size(50, 50);
            this.ButtonNum3.TabIndex = 29;
            this.ButtonNum3.Text = "3";
            this.ButtonNum3.UseVisualStyleBackColor = true;
            this.ButtonNum3.Click += new System.EventHandler(this.ButtonNum3_Click);
            // 
            // ButtonNum2
            // 
            this.ButtonNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum2.Location = new System.Drawing.Point(84, 304);
            this.ButtonNum2.Name = "ButtonNum2";
            this.ButtonNum2.Size = new System.Drawing.Size(50, 50);
            this.ButtonNum2.TabIndex = 28;
            this.ButtonNum2.Text = "2";
            this.ButtonNum2.UseVisualStyleBackColor = true;
            this.ButtonNum2.Click += new System.EventHandler(this.ButtonNum2_Click);
            // 
            // ButtonNum1
            // 
            this.ButtonNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum1.Location = new System.Drawing.Point(28, 304);
            this.ButtonNum1.Name = "ButtonNum1";
            this.ButtonNum1.Size = new System.Drawing.Size(50, 50);
            this.ButtonNum1.TabIndex = 27;
            this.ButtonNum1.Text = "1";
            this.ButtonNum1.UseVisualStyleBackColor = true;
            this.ButtonNum1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonNum1_MouseClick);
            // 
            // ButtonSignDiv
            // 
            this.ButtonSignDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignDiv.Location = new System.Drawing.Point(196, 360);
            this.ButtonSignDiv.Name = "ButtonSignDiv";
            this.ButtonSignDiv.Size = new System.Drawing.Size(50, 50);
            this.ButtonSignDiv.TabIndex = 34;
            this.ButtonSignDiv.Text = "÷";
            this.ButtonSignDiv.UseVisualStyleBackColor = true;
            this.ButtonSignDiv.Click += new System.EventHandler(this.opMethod);
            // 
            // ButtonSignEqual
            // 
            this.ButtonSignEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignEqual.Location = new System.Drawing.Point(140, 360);
            this.ButtonSignEqual.Name = "ButtonSignEqual";
            this.ButtonSignEqual.Size = new System.Drawing.Size(50, 50);
            this.ButtonSignEqual.TabIndex = 33;
            this.ButtonSignEqual.Text = "=";
            this.ButtonSignEqual.UseVisualStyleBackColor = true;
            this.ButtonSignEqual.Click += new System.EventHandler(this.ButtonSignEqual_Click);
            // 
            // ButtonSignComma
            // 
            this.ButtonSignComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignComma.Location = new System.Drawing.Point(84, 360);
            this.ButtonSignComma.Name = "ButtonSignComma";
            this.ButtonSignComma.Size = new System.Drawing.Size(50, 50);
            this.ButtonSignComma.TabIndex = 32;
            this.ButtonSignComma.Text = ",";
            this.ButtonSignComma.UseVisualStyleBackColor = true;
            this.ButtonSignComma.Click += new System.EventHandler(this.ButtonSignComma_Click);
            // 
            // ButtonNum0
            // 
            this.ButtonNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum0.Location = new System.Drawing.Point(28, 360);
            this.ButtonNum0.Name = "ButtonNum0";
            this.ButtonNum0.Size = new System.Drawing.Size(50, 50);
            this.ButtonNum0.TabIndex = 31;
            this.ButtonNum0.Text = "0";
            this.ButtonNum0.UseVisualStyleBackColor = true;
            this.ButtonNum0.Click += new System.EventHandler(this.ButtonNum0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(271, 437);
            this.Controls.Add(this.ButtonSignDiv);
            this.Controls.Add(this.ButtonSignEqual);
            this.Controls.Add(this.ButtonSignComma);
            this.Controls.Add(this.ButtonNum0);
            this.Controls.Add(this.ButtonSignMult);
            this.Controls.Add(this.ButtonNum3);
            this.Controls.Add(this.ButtonNum2);
            this.Controls.Add(this.ButtonNum1);
            this.Controls.Add(this.ButtonSignSub);
            this.Controls.Add(this.ButtonNum6);
            this.Controls.Add(this.ButtonNum5);
            this.Controls.Add(this.ButtonNum4);
            this.Controls.Add(this.ButtonSignAdd);
            this.Controls.Add(this.ButtonNum9);
            this.Controls.Add(this.ButtonNum8);
            this.Controls.Add(this.ButtonNum7);
            this.Controls.Add(this.ButtonSignClear);
            this.Controls.Add(this.textDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Kalkylator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.Button ButtonSignClear;
        private System.Windows.Forms.Button ButtonNum7;
        private System.Windows.Forms.Button ButtonNum8;
        private System.Windows.Forms.Button ButtonNum9;
        private System.Windows.Forms.Button ButtonSignAdd;
        private System.Windows.Forms.Button ButtonSignSub;
        private System.Windows.Forms.Button ButtonNum6;
        private System.Windows.Forms.Button ButtonNum5;
        private System.Windows.Forms.Button ButtonNum4;
        private System.Windows.Forms.Button ButtonSignMult;
        private System.Windows.Forms.Button ButtonNum3;
        private System.Windows.Forms.Button ButtonNum2;
        private System.Windows.Forms.Button ButtonNum1;
        private System.Windows.Forms.Button ButtonSignDiv;
        private System.Windows.Forms.Button ButtonSignEqual;
        private System.Windows.Forms.Button ButtonSignComma;
        private System.Windows.Forms.Button ButtonNum0;
    }
}


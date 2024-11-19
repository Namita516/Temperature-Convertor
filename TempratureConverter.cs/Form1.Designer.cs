namespace TempratureConverter.cs
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
            this.lbfSelect = new System.Windows.Forms.Label();
            this.lbfResult = new System.Windows.Forms.Label();
            this.lbfValue = new System.Windows.Forms.Label();
            this.lbfTemprature = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.rbtnF2C = new System.Windows.Forms.RadioButton();
            this.rbtnC2F = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbfSelect
            // 
            this.lbfSelect.AutoSize = true;
            this.lbfSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfSelect.Location = new System.Drawing.Point(88, 197);
            this.lbfSelect.Name = "lbfSelect";
            this.lbfSelect.Size = new System.Drawing.Size(135, 29);
            this.lbfSelect.TabIndex = 0;
            this.lbfSelect.Text = "Select Unit:";
            // 
            // lbfResult
            // 
            this.lbfResult.AutoSize = true;
            this.lbfResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfResult.Location = new System.Drawing.Point(475, 120);
            this.lbfResult.Name = "lbfResult";
            this.lbfResult.Size = new System.Drawing.Size(87, 29);
            this.lbfResult.TabIndex = 1;
            this.lbfResult.Text = "Result:";
            // 
            // lbfValue
            // 
            this.lbfValue.AutoSize = true;
            this.lbfValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfValue.Location = new System.Drawing.Point(80, 120);
            this.lbfValue.Name = "lbfValue";
            this.lbfValue.Size = new System.Drawing.Size(143, 29);
            this.lbfValue.TabIndex = 2;
            this.lbfValue.Text = "Enter Value:";
            // 
            // lbfTemprature
            // 
            this.lbfTemprature.AutoSize = true;
            this.lbfTemprature.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfTemprature.Location = new System.Drawing.Point(211, 23);
            this.lbfTemprature.Name = "lbfTemprature";
            this.lbfTemprature.Size = new System.Drawing.Size(351, 37);
            this.lbfTemprature.TabIndex = 3;
            this.lbfTemprature.Text = "Temprature Converter";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(586, 120);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 26);
            this.txtResult.TabIndex = 4;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(246, 124);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 26);
            this.txtValue.TabIndex = 5;
            // 
            // rbtnF2C
            // 
            this.rbtnF2C.AutoSize = true;
            this.rbtnF2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnF2C.Location = new System.Drawing.Point(229, 270);
            this.rbtnF2C.Name = "rbtnF2C";
            this.rbtnF2C.Size = new System.Drawing.Size(221, 29);
            this.rbtnF2C.TabIndex = 6;
            this.rbtnF2C.TabStop = true;
            this.rbtnF2C.Text = "Fahrenheit to Celsius";
            this.rbtnF2C.UseVisualStyleBackColor = true;
            // 
            // rbtnC2F
            // 
            this.rbtnC2F.AutoSize = true;
            this.rbtnC2F.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnC2F.Location = new System.Drawing.Point(229, 210);
            this.rbtnC2F.Name = "rbtnC2F";
            this.rbtnC2F.Size = new System.Drawing.Size(226, 29);
            this.rbtnC2F.TabIndex = 7;
            this.rbtnC2F.TabStop = true;
            this.rbtnC2F.Text = "Celsius to Fahrenheit ";
            this.rbtnC2F.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(576, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 46);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(348, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 46);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(110, 373);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(133, 46);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rbtnC2F);
            this.Controls.Add(this.rbtnF2C);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lbfTemprature);
            this.Controls.Add(this.lbfValue);
            this.Controls.Add(this.lbfResult);
            this.Controls.Add(this.lbfSelect);
            this.Name = "Form1";
            this.Text = "Temprature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbfSelect;
        private System.Windows.Forms.Label lbfResult;
        private System.Windows.Forms.Label lbfValue;
        private System.Windows.Forms.Label lbfTemprature;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.RadioButton rbtnF2C;
        private System.Windows.Forms.RadioButton rbtnC2F;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConvert;
    }
}


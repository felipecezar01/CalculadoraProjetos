namespace CalculadoraGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonSomar = new Button();
            buttonSubtrair = new Button();
            buttonMultiplicar = new Button();
            buttonDividir = new Button();
            buttonIgual = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(35, 39, 42);
            txtDisplay.Font = new Font("Tempus Sans ITC", 24F, FontStyle.Bold);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(388, 139);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(326, 49);
            txtDisplay.TabIndex = 0;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(58, 61, 66);
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            button0.ForeColor = Color.White;
            button0.Location = new Point(471, 434);
            button0.Name = "button0";
            button0.Size = new Size(77, 54);
            button0.TabIndex = 21;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += ButtonNumero_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(58, 61, 66);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(388, 374);
            button1.Name = "button1";
            button1.Size = new Size(77, 54);
            button1.TabIndex = 22;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ButtonNumero_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(58, 61, 66);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(471, 374);
            button2.Name = "button2";
            button2.Size = new Size(77, 54);
            button2.TabIndex = 23;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ButtonNumero_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(58, 61, 66);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(554, 374);
            button3.Name = "button3";
            button3.Size = new Size(77, 54);
            button3.TabIndex = 24;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += ButtonNumero_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(58, 61, 66);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(388, 314);
            button4.Name = "button4";
            button4.Size = new Size(77, 54);
            button4.TabIndex = 25;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += ButtonNumero_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(58, 61, 66);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(471, 314);
            button5.Name = "button5";
            button5.Size = new Size(77, 54);
            button5.TabIndex = 26;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += ButtonNumero_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(58, 61, 66);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(554, 314);
            button6.Name = "button6";
            button6.Size = new Size(77, 54);
            button6.TabIndex = 27;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += ButtonNumero_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(58, 61, 66);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(388, 254);
            button7.Name = "button7";
            button7.Size = new Size(77, 54);
            button7.TabIndex = 28;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += ButtonNumero_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(58, 61, 66);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(471, 254);
            button8.Name = "button8";
            button8.Size = new Size(77, 54);
            button8.TabIndex = 29;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += ButtonNumero_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(58, 61, 66);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(554, 254);
            button9.Name = "button9";
            button9.Size = new Size(77, 54);
            button9.TabIndex = 30;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += ButtonNumero_Click;
            // 
            // buttonSomar
            // 
            buttonSomar.BackColor = Color.FromArgb(114, 137, 218);
            buttonSomar.FlatAppearance.BorderSize = 0;
            buttonSomar.FlatStyle = FlatStyle.Flat;
            buttonSomar.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            buttonSomar.ForeColor = Color.White;
            buttonSomar.Location = new Point(637, 374);
            buttonSomar.Name = "buttonSomar";
            buttonSomar.Size = new Size(77, 54);
            buttonSomar.TabIndex = 31;
            buttonSomar.Text = "+";
            buttonSomar.UseVisualStyleBackColor = false;
            buttonSomar.Click += ButtonOperador_Click;
            // 
            // buttonSubtrair
            // 
            buttonSubtrair.BackColor = Color.FromArgb(114, 137, 218);
            buttonSubtrair.FlatAppearance.BorderSize = 0;
            buttonSubtrair.FlatStyle = FlatStyle.Flat;
            buttonSubtrair.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            buttonSubtrair.ForeColor = Color.White;
            buttonSubtrair.Location = new Point(637, 314);
            buttonSubtrair.Name = "buttonSubtrair";
            buttonSubtrair.Size = new Size(77, 54);
            buttonSubtrair.TabIndex = 32;
            buttonSubtrair.Text = "-";
            buttonSubtrair.UseVisualStyleBackColor = false;
            buttonSubtrair.Click += ButtonOperador_Click;
            // 
            // buttonMultiplicar
            // 
            buttonMultiplicar.BackColor = Color.FromArgb(114, 137, 218);
            buttonMultiplicar.FlatAppearance.BorderSize = 0;
            buttonMultiplicar.FlatStyle = FlatStyle.Flat;
            buttonMultiplicar.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            buttonMultiplicar.ForeColor = Color.White;
            buttonMultiplicar.Location = new Point(637, 254);
            buttonMultiplicar.Name = "buttonMultiplicar";
            buttonMultiplicar.Size = new Size(77, 54);
            buttonMultiplicar.TabIndex = 33;
            buttonMultiplicar.Text = "x";
            buttonMultiplicar.UseVisualStyleBackColor = false;
            buttonMultiplicar.Click += ButtonOperador_Click;
            // 
            // buttonDividir
            // 
            buttonDividir.BackColor = Color.FromArgb(114, 137, 218);
            buttonDividir.FlatAppearance.BorderSize = 0;
            buttonDividir.FlatStyle = FlatStyle.Flat;
            buttonDividir.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            buttonDividir.ForeColor = Color.White;
            buttonDividir.Location = new Point(637, 194);
            buttonDividir.Name = "buttonDividir";
            buttonDividir.Size = new Size(77, 54);
            buttonDividir.TabIndex = 34;
            buttonDividir.Text = "/";
            buttonDividir.UseVisualStyleBackColor = false;
            buttonDividir.Click += ButtonOperador_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.BackColor = Color.FromArgb(88, 101, 242);
            buttonIgual.FlatAppearance.BorderSize = 0;
            buttonIgual.FlatStyle = FlatStyle.Flat;
            buttonIgual.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            buttonIgual.ForeColor = Color.White;
            buttonIgual.Location = new Point(637, 434);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(77, 54);
            buttonIgual.TabIndex = 35;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = false;
            buttonIgual.Click += ButtonIgual_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(114, 137, 218);
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(388, 194);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(77, 54);
            buttonClear.TabIndex = 36;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += ButtonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(1060, 668);
            Controls.Add(buttonClear);
            Controls.Add(buttonIgual);
            Controls.Add(buttonDividir);
            Controls.Add(buttonMultiplicar);
            Controls.Add(buttonSubtrair);
            Controls.Add(buttonSomar);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonSomar;
        private System.Windows.Forms.Button buttonSubtrair;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonClear;
    }
}

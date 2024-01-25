namespace Calculadorinha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrimeiroNúmero = new System.Windows.Forms.Label();
            this.txtNmro1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNmro2 = new System.Windows.Forms.TextBox();
            this.lblSegundoNúmero = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrimeiroNúmero
            // 
            this.lblPrimeiroNúmero.AutoSize = true;
            this.lblPrimeiroNúmero.Location = new System.Drawing.Point(18, 16);
            this.lblPrimeiroNúmero.Name = "lblPrimeiroNúmero";
            this.lblPrimeiroNúmero.Size = new System.Drawing.Size(84, 13);
            this.lblPrimeiroNúmero.TabIndex = 0;
            this.lblPrimeiroNúmero.Text = "Primeiro Número";
            this.lblPrimeiroNúmero.Click += new System.EventHandler(this.lblPrimeiroNúmero_Click);
            // 
            // txtNmro1
            // 
            this.txtNmro1.Location = new System.Drawing.Point(21, 32);
            this.txtNmro1.Name = "txtNmro1";
            this.txtNmro1.Size = new System.Drawing.Size(100, 20);
            this.txtNmro1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.btnDividir);
            this.groupBox1.Controls.Add(this.btnMultiplicar);
            this.groupBox1.Controls.Add(this.btnSubtrair);
            this.groupBox1.Controls.Add(this.btnSomar);
            this.groupBox1.Controls.Add(this.txtNmro2);
            this.groupBox1.Controls.Add(this.lblSegundoNúmero);
            this.groupBox1.Controls.Add(this.txtNmro1);
            this.groupBox1.Controls.Add(this.lblPrimeiroNúmero);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtNmro2
            // 
            this.txtNmro2.Location = new System.Drawing.Point(21, 71);
            this.txtNmro2.Name = "txtNmro2";
            this.txtNmro2.Size = new System.Drawing.Size(100, 20);
            this.txtNmro2.TabIndex = 3;
            // 
            // lblSegundoNúmero
            // 
            this.lblSegundoNúmero.AutoSize = true;
            this.lblSegundoNúmero.Location = new System.Drawing.Point(18, 55);
            this.lblSegundoNúmero.Name = "lblSegundoNúmero";
            this.lblSegundoNúmero.Size = new System.Drawing.Size(90, 13);
            this.lblSegundoNúmero.TabIndex = 2;
            this.lblSegundoNúmero.Text = "Segundo Número";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(21, 109);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(102, 109);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 5;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(183, 109);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(264, 109);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 7;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(32, 152);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(99, 152);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(15, 16);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNúmero;
        private System.Windows.Forms.TextBox txtNmro1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtNmro2;
        private System.Windows.Forms.Label lblSegundoNúmero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDividir;
    }
}


namespace RSA_Cabrini
{
    partial class RSA_Cabrini
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA_Cabrini));
            this.btnCrypt = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtDecriptado = new System.Windows.Forms.TextBox();
            this.plainLen = new System.Windows.Forms.Label();
            this.txtEncriptado = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.clearStatusTmr = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.dBox = new System.Windows.Forms.TextBox();
            this.txtPhi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.pLabel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p2Len = new System.Windows.Forms.Label();
            this.p1Len = new System.Windows.Forms.Label();
            this.btnGeraPrimos = new System.Windows.Forms.Button();
            this.txtPrimo2 = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtPrimo1 = new System.Windows.Forms.TextBox();
            this.pLabel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nLen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrypt
            // 
            this.btnCrypt.Enabled = false;
            this.btnCrypt.Location = new System.Drawing.Point(418, 59);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(128, 32);
            this.btnCrypt.TabIndex = 3;
            this.btnCrypt.Text = "Encripta";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(9, 47);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagem.Size = new System.Drawing.Size(395, 132);
            this.txtMensagem.TabIndex = 2;
            this.txtMensagem.TextChanged += new System.EventHandler(this.txtMensagem_TextChanged);
            // 
            // txtDecriptado
            // 
            this.txtDecriptado.Location = new System.Drawing.Point(557, 47);
            this.txtDecriptado.Multiline = true;
            this.txtDecriptado.Name = "txtDecriptado";
            this.txtDecriptado.ReadOnly = true;
            this.txtDecriptado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecriptado.Size = new System.Drawing.Size(381, 132);
            this.txtDecriptado.TabIndex = 6;
            // 
            // plainLen
            // 
            this.plainLen.AutoSize = true;
            this.plainLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainLen.Location = new System.Drawing.Point(301, 31);
            this.plainLen.Name = "plainLen";
            this.plainLen.Size = new System.Drawing.Size(62, 13);
            this.plainLen.TabIndex = 2;
            this.plainLen.Text = "Lenght: --";
            // 
            // txtEncriptado
            // 
            this.txtEncriptado.Location = new System.Drawing.Point(9, 205);
            this.txtEncriptado.Multiline = true;
            this.txtEncriptado.Name = "txtEncriptado";
            this.txtEncriptado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncriptado.Size = new System.Drawing.Size(929, 61);
            this.txtEncriptado.TabIndex = 4;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(418, 102);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(128, 32);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decripta";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mensagem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(437, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Encriptação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Decriptção";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMensagem);
            this.groupBox1.Controls.Add(this.btnCrypt);
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.txtEncriptado);
            this.groupBox1.Controls.Add(this.txtDecriptado);
            this.groupBox1.Controls.Add(this.plainLen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 284);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Implementação das Chaves";
            // 
            // progressTimer
            // 
            this.progressTimer.Interval = 50;
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // dBox
            // 
            this.dBox.Location = new System.Drawing.Point(488, 309);
            this.dBox.Multiline = true;
            this.dBox.Name = "dBox";
            this.dBox.ReadOnly = true;
            this.dBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dBox.Size = new System.Drawing.Size(450, 66);
            this.dBox.TabIndex = 3;
            this.dBox.TabStop = false;
            // 
            // txtPhi
            // 
            this.txtPhi.Location = new System.Drawing.Point(488, 198);
            this.txtPhi.Multiline = true;
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.ReadOnly = true;
            this.txtPhi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhi.Size = new System.Drawing.Size(450, 64);
            this.txtPhi.TabIndex = 3;
            this.txtPhi.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Multiplicação (N=p*q)";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(6, 198);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = true;
            this.txtN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtN.Size = new System.Drawing.Size(450, 64);
            this.txtN.TabIndex = 3;
            this.txtN.TabStop = false;
            // 
            // pLabel2
            // 
            this.pLabel2.AutoSize = true;
            this.pLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel2.Location = new System.Drawing.Point(488, 20);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(141, 16);
            this.pLabel2.TabIndex = 2;
            this.pLabel2.Text = "Número Primo 2 (q)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phi (M=(p-1)*(q-1))";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inverso Multiplicativo (d)";
            // 
            // p2Len
            // 
            this.p2Len.AutoSize = true;
            this.p2Len.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Len.Location = new System.Drawing.Point(840, 20);
            this.p2Len.Name = "p2Len";
            this.p2Len.Size = new System.Drawing.Size(75, 13);
            this.p2Len.TabIndex = 8;
            this.p2Len.Text = "Tamanho: --";
            // 
            // p1Len
            // 
            this.p1Len.AutoSize = true;
            this.p1Len.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Len.Location = new System.Drawing.Point(353, 20);
            this.p1Len.Name = "p1Len";
            this.p1Len.Size = new System.Drawing.Size(75, 13);
            this.p1Len.TabIndex = 9;
            this.p1Len.Text = "Tamanho: --";
            // 
            // btnGeraPrimos
            // 
            this.btnGeraPrimos.Location = new System.Drawing.Point(270, 127);
            this.btnGeraPrimos.Name = "btnGeraPrimos";
            this.btnGeraPrimos.Size = new System.Drawing.Size(186, 32);
            this.btnGeraPrimos.TabIndex = 1;
            this.btnGeraPrimos.Text = "Gerar Números Primos";
            this.btnGeraPrimos.UseVisualStyleBackColor = true;
            this.btnGeraPrimos.Click += new System.EventHandler(this.btnGeraPrimos_Click);
            // 
            // txtPrimo2
            // 
            this.txtPrimo2.Location = new System.Drawing.Point(488, 40);
            this.txtPrimo2.Multiline = true;
            this.txtPrimo2.Name = "txtPrimo2";
            this.txtPrimo2.ReadOnly = true;
            this.txtPrimo2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrimo2.Size = new System.Drawing.Size(450, 75);
            this.txtPrimo2.TabIndex = 1;
            this.txtPrimo2.TabStop = false;
            this.txtPrimo2.TextChanged += new System.EventHandler(this.txtPrimo2_TextChanged);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(488, 127);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(150, 32);
            this.btnCalcula.TabIndex = 0;
            this.btnCalcula.Text = "Calcular Chaves";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtPrimo1
            // 
            this.txtPrimo1.Location = new System.Drawing.Point(6, 40);
            this.txtPrimo1.Multiline = true;
            this.txtPrimo1.Name = "txtPrimo1";
            this.txtPrimo1.ReadOnly = true;
            this.txtPrimo1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrimo1.Size = new System.Drawing.Size(450, 75);
            this.txtPrimo1.TabIndex = 7;
            this.txtPrimo1.TabStop = false;
            this.txtPrimo1.TextChanged += new System.EventHandler(this.txtPrimo1_TextChanged);
            // 
            // pLabel1
            // 
            this.pLabel1.AutoSize = true;
            this.pLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel1.Location = new System.Drawing.Point(6, 20);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(137, 16);
            this.pLabel1.TabIndex = 2;
            this.pLabel1.Text = "Número Primo1 (p)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Controls.Add(this.txtE);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pLabel1);
            this.groupBox2.Controls.Add(this.txtPrimo1);
            this.groupBox2.Controls.Add(this.btnCalcula);
            this.groupBox2.Controls.Add(this.txtPrimo2);
            this.groupBox2.Controls.Add(this.btnGeraPrimos);
            this.groupBox2.Controls.Add(this.p1Len);
            this.groupBox2.Controls.Add(this.p2Len);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nLen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pLabel2);
            this.groupBox2.Controls.Add(this.txtN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPhi);
            this.groupBox2.Controls.Add(this.dBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 393);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geração das Chaves";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "e.d mod (N) =1";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(6, 353);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(450, 22);
            this.txt1.TabIndex = 12;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(6, 309);
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.Size = new System.Drawing.Size(450, 22);
            this.txtE.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "1 < e < phi";
            // 
            // nLen
            // 
            this.nLen.AutoSize = true;
            this.nLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLen.Location = new System.Drawing.Point(368, 265);
            this.nLen.Name = "nLen";
            this.nLen.Size = new System.Drawing.Size(60, 13);
            this.nLen.TabIndex = 7;
            this.nLen.Text = "Bitsize: --";
            // 
            // RSA_Cabrini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSA_Cabrini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Implementation Test";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrypt;
        protected internal System.Windows.Forms.TextBox txtMensagem;
        protected internal System.Windows.Forms.TextBox txtDecriptado;
        private System.Windows.Forms.Label plainLen;
        protected internal System.Windows.Forms.TextBox txtEncriptado;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Timer clearStatusTmr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.TextBox dBox;
        private System.Windows.Forms.TextBox txtPhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label pLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label p2Len;
        private System.Windows.Forms.Label p1Len;
        private System.Windows.Forms.Button btnGeraPrimos;
        protected internal System.Windows.Forms.TextBox txtPrimo2;
        private System.Windows.Forms.Button btnCalcula;
        protected internal System.Windows.Forms.TextBox txtPrimo1;
        private System.Windows.Forms.Label pLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label nLen;
    }
}


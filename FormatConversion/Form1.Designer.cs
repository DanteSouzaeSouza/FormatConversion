namespace FormatConversion
{
    partial class FrmNumConv
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblConvertido = new System.Windows.Forms.Label();
            this.lblDigite = new System.Windows.Forms.Label();
            this.btnConverte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(15, 44);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(184, 20);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblConvertido
            // 
            this.lblConvertido.AutoSize = true;
            this.lblConvertido.Location = new System.Drawing.Point(53, 108);
            this.lblConvertido.Name = "lblConvertido";
            this.lblConvertido.Size = new System.Drawing.Size(0, 13);
            this.lblConvertido.TabIndex = 1;
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Location = new System.Drawing.Point(12, 9);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(187, 13);
            this.lblDigite.TabIndex = 2;
            this.lblDigite.Text = "Digite um número com casas decimais";
            // 
            // btnConverte
            // 
            this.btnConverte.Location = new System.Drawing.Point(69, 165);
            this.btnConverte.Name = "btnConverte";
            this.btnConverte.Size = new System.Drawing.Size(75, 23);
            this.btnConverte.TabIndex = 3;
            this.btnConverte.Text = "Converte!";
            this.btnConverte.UseVisualStyleBackColor = true;
            this.btnConverte.Click += new System.EventHandler(this.btnConverte_Click);
            // 
            // FrmNumConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 226);
            this.Controls.Add(this.btnConverte);
            this.Controls.Add(this.lblDigite);
            this.Controls.Add(this.lblConvertido);
            this.Controls.Add(this.txtNumero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNumConv";
            this.Text = "Conversão de tipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblConvertido;
        private System.Windows.Forms.Label lblDigite;
        private System.Windows.Forms.Button btnConverte;
    }
}


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
            this.lblConvertido = new System.Windows.Forms.Label();
            this.lblDigite = new System.Windows.Forms.Label();
            this.btnConverte = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblConvertido
            // 
            this.lblConvertido.AutoSize = true;
            this.lblConvertido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertido.Location = new System.Drawing.Point(71, 133);
            this.lblConvertido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConvertido.Name = "lblConvertido";
            this.lblConvertido.Size = new System.Drawing.Size(0, 32);
            this.lblConvertido.TabIndex = 1;
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Location = new System.Drawing.Point(16, 11);
            this.lblDigite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(249, 17);
            this.lblDigite.TabIndex = 2;
            this.lblDigite.Text = "Digite um número com casas decimais";
            // 
            // btnConverte
            // 
            this.btnConverte.Location = new System.Drawing.Point(92, 203);
            this.btnConverte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConverte.Name = "btnConverte";
            this.btnConverte.Size = new System.Drawing.Size(100, 28);
            this.btnConverte.TabIndex = 3;
            this.btnConverte.Text = "Converte!";
            this.btnConverte.UseVisualStyleBackColor = true;
            this.btnConverte.Click += new System.EventHandler(this.btnConverte_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(19, 52);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(245, 22);
            this.txtNumero.TabIndex = 4;
            // 
            // FrmNumConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 278);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnConverte);
            this.Controls.Add(this.lblDigite);
            this.Controls.Add(this.lblConvertido);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNumConv";
            this.Text = "Conversão de tipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConvertido;
        private System.Windows.Forms.Label lblDigite;
        private System.Windows.Forms.Button btnConverte;
        private System.Windows.Forms.TextBox txtNumero;
    }
}


namespace InterestCalculate
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
            this.lblPrincipalValue = new System.Windows.Forms.Label();
            this.txtPrincipalValue = new System.Windows.Forms.TextBox();
            this.txtAnnualFee = new System.Windows.Forms.TextBox();
            this.lblAnnualFee = new System.Windows.Forms.Label();
            this.txtNumberOfInstallments = new System.Windows.Forms.TextBox();
            this.lblNumberOfInstallments = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCalculatedValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrincipalValue
            // 
            this.lblPrincipalValue.AutoSize = true;
            this.lblPrincipalValue.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipalValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPrincipalValue.Location = new System.Drawing.Point(309, 46);
            this.lblPrincipalValue.Name = "lblPrincipalValue";
            this.lblPrincipalValue.Size = new System.Drawing.Size(288, 25);
            this.lblPrincipalValue.TabIndex = 0;
            this.lblPrincipalValue.Text = "Insira o Valor do Emprestimo";
            this.lblPrincipalValue.Click += new System.EventHandler(this.lblPrincipalValue_Click);
            // 
            // txtPrincipalValue
            // 
            this.txtPrincipalValue.Location = new System.Drawing.Point(314, 74);
            this.txtPrincipalValue.Name = "txtPrincipalValue";
            this.txtPrincipalValue.Size = new System.Drawing.Size(283, 20);
            this.txtPrincipalValue.TabIndex = 1;
            // 
            // txtAnnualFee
            // 
            this.txtAnnualFee.Location = new System.Drawing.Point(314, 165);
            this.txtAnnualFee.Name = "txtAnnualFee";
            this.txtAnnualFee.Size = new System.Drawing.Size(283, 20);
            this.txtAnnualFee.TabIndex = 3;
            this.txtAnnualFee.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAnnualFee
            // 
            this.lblAnnualFee.AutoSize = true;
            this.lblAnnualFee.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnualFee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAnnualFee.Location = new System.Drawing.Point(309, 137);
            this.lblAnnualFee.Name = "lblAnnualFee";
            this.lblAnnualFee.Size = new System.Drawing.Size(240, 25);
            this.lblAnnualFee.TabIndex = 2;
            this.lblAnnualFee.Text = "Taxa de Juros Anual (%)";
            this.lblAnnualFee.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumberOfInstallments
            // 
            this.txtNumberOfInstallments.Location = new System.Drawing.Point(314, 259);
            this.txtNumberOfInstallments.Name = "txtNumberOfInstallments";
            this.txtNumberOfInstallments.Size = new System.Drawing.Size(283, 20);
            this.txtNumberOfInstallments.TabIndex = 5;
            // 
            // lblNumberOfInstallments
            // 
            this.lblNumberOfInstallments.AutoSize = true;
            this.lblNumberOfInstallments.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfInstallments.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNumberOfInstallments.Location = new System.Drawing.Point(309, 231);
            this.lblNumberOfInstallments.Name = "lblNumberOfInstallments";
            this.lblNumberOfInstallments.Size = new System.Drawing.Size(200, 25);
            this.lblNumberOfInstallments.TabIndex = 4;
            this.lblNumberOfInstallments.Text = "Número de Parcelas";
            this.lblNumberOfInstallments.Click += new System.EventHandler(this.lblNumberOfInstallments_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(386, 328);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(134, 43);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "CALCULAR";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCalculatedValue
            // 
            this.lblCalculatedValue.AutoSize = true;
            this.lblCalculatedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatedValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCalculatedValue.Location = new System.Drawing.Point(310, 397);
            this.lblCalculatedValue.Name = "lblCalculatedValue";
            this.lblCalculatedValue.Size = new System.Drawing.Size(299, 24);
            this.lblCalculatedValue.TabIndex = 7;
            this.lblCalculatedValue.Text = "VALOR TOTAL A SER PAGO R$: ";
            this.lblCalculatedValue.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1017, 510);
            this.Controls.Add(this.lblCalculatedValue);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumberOfInstallments);
            this.Controls.Add(this.lblNumberOfInstallments);
            this.Controls.Add(this.txtAnnualFee);
            this.Controls.Add(this.lblAnnualFee);
            this.Controls.Add(this.txtPrincipalValue);
            this.Controls.Add(this.lblPrincipalValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipalValue;
        private System.Windows.Forms.TextBox txtPrincipalValue;
        private System.Windows.Forms.TextBox txtAnnualFee;
        private System.Windows.Forms.Label lblAnnualFee;
        private System.Windows.Forms.TextBox txtNumberOfInstallments;
        private System.Windows.Forms.Label lblNumberOfInstallments;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCalculatedValue;
    }
}


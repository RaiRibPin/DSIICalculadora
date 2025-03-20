namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            lblCalcFinal = new Label();
            lblSomar = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(463, 285);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(283, 67);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtN1
            // 
            txtN1.Location = new Point(447, 89);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(320, 31);
            txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(447, 197);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(320, 31);
            txtN2.TabIndex = 2;
            // 
            // lblCalcFinal
            // 
            lblCalcFinal.AutoSize = true;
            lblCalcFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalcFinal.Location = new Point(495, 380);
            lblCalcFinal.Name = "lblCalcFinal";
            lblCalcFinal.Size = new Size(123, 32);
            lblCalcFinal.TabIndex = 3;
            lblCalcFinal.Text = "Resultado:";
            // 
            // lblSomar
            // 
            lblSomar.AutoSize = true;
            lblSomar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSomar.Location = new Point(588, 143);
            lblSomar.Name = "lblSomar";
            lblSomar.Size = new Size(30, 32);
            lblSomar.TabIndex = 4;
            lblSomar.Text = "+";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 519);
            Controls.Add(lblSomar);
            Controls.Add(lblCalcFinal);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "    ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label lblCalcFinal;
        private Label lblSomar;
    }
}

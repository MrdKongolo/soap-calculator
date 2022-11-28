namespace ServiceWebDemo
{
    partial class frmAccueil
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnMultiplier = new System.Windows.Forms.Button();
            this.btnDiviser = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A :";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(99, 18);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(90, 21);
            this.txtA.TabIndex = 0;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNumeric);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "B :";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(99, 50);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(90, 21);
            this.txtB.TabIndex = 1;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNumeric);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Résultat :";
            // 
            // txtResultat
            // 
            this.txtResultat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResultat.Location = new System.Drawing.Point(99, 83);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.Size = new System.Drawing.Size(152, 21);
            this.txtResultat.TabIndex = 2;
            this.txtResultat.TabStop = false;
            this.txtResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Location = new System.Drawing.Point(55, 120);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(37, 27);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoins.Location = new System.Drawing.Point(94, 120);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(37, 27);
            this.btnMoins.TabIndex = 3;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = false;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnMultiplier
            // 
            this.btnMultiplier.BackColor = System.Drawing.SystemColors.Control;
            this.btnMultiplier.Location = new System.Drawing.Point(134, 120);
            this.btnMultiplier.Name = "btnMultiplier";
            this.btnMultiplier.Size = new System.Drawing.Size(37, 27);
            this.btnMultiplier.TabIndex = 4;
            this.btnMultiplier.Text = "*";
            this.btnMultiplier.UseVisualStyleBackColor = false;
            this.btnMultiplier.Click += new System.EventHandler(this.btnMultiplier_Click);
            // 
            // btnDiviser
            // 
            this.btnDiviser.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiviser.Location = new System.Drawing.Point(174, 120);
            this.btnDiviser.Name = "btnDiviser";
            this.btnDiviser.Size = new System.Drawing.Size(37, 27);
            this.btnDiviser.TabIndex = 5;
            this.btnDiviser.Text = "/";
            this.btnDiviser.UseVisualStyleBackColor = false;
            this.btnDiviser.Click += new System.EventHandler(this.btnDiviser_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.SystemColors.Control;
            this.btnMessage.Location = new System.Drawing.Point(215, 120);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(77, 27);
            this.btnMessage.TabIndex = 6;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 165);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnDiviser);
            this.Controls.Add(this.btnMultiplier);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculatrice";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnMultiplier;
        private System.Windows.Forms.Button btnDiviser;
        private System.Windows.Forms.Button btnMessage;
    }
}


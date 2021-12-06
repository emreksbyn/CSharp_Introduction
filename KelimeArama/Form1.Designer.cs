namespace KelimeArama
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
            this.btnCountAra = new System.Windows.Forms.Button();
            this.txtAranacak = new System.Windows.Forms.TextBox();
            this.richtxtMetin = new System.Windows.Forms.RichTextBox();
            this.btnLenAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCountAra
            // 
            this.btnCountAra.BackColor = System.Drawing.Color.Black;
            this.btnCountAra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCountAra.ForeColor = System.Drawing.Color.Yellow;
            this.btnCountAra.Location = new System.Drawing.Point(289, 59);
            this.btnCountAra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCountAra.Name = "btnCountAra";
            this.btnCountAra.Size = new System.Drawing.Size(133, 46);
            this.btnCountAra.TabIndex = 0;
            this.btnCountAra.Text = " COUNT İLE ARA";
            this.btnCountAra.UseVisualStyleBackColor = false;
            this.btnCountAra.Click += new System.EventHandler(this.btnCountAra_Click);
            // 
            // txtAranacak
            // 
            this.txtAranacak.BackColor = System.Drawing.Color.Yellow;
            this.txtAranacak.Location = new System.Drawing.Point(289, 13);
            this.txtAranacak.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAranacak.Name = "txtAranacak";
            this.txtAranacak.Size = new System.Drawing.Size(132, 22);
            this.txtAranacak.TabIndex = 1;
            // 
            // richtxtMetin
            // 
            this.richtxtMetin.BackColor = System.Drawing.Color.Yellow;
            this.richtxtMetin.Location = new System.Drawing.Point(16, 13);
            this.richtxtMetin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richtxtMetin.Name = "richtxtMetin";
            this.richtxtMetin.Size = new System.Drawing.Size(243, 304);
            this.richtxtMetin.TabIndex = 2;
            this.richtxtMetin.Text = "";
            // 
            // btnLenAra
            // 
            this.btnLenAra.BackColor = System.Drawing.Color.Black;
            this.btnLenAra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLenAra.ForeColor = System.Drawing.Color.Yellow;
            this.btnLenAra.Location = new System.Drawing.Point(289, 124);
            this.btnLenAra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLenAra.Name = "btnLenAra";
            this.btnLenAra.Size = new System.Drawing.Size(133, 46);
            this.btnLenAra.TabIndex = 3;
            this.btnLenAra.Text = "LENGHT İLE ARA";
            this.btnLenAra.UseVisualStyleBackColor = false;
            this.btnLenAra.Click += new System.EventHandler(this.btnLenghtAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(489, 401);
            this.Controls.Add(this.btnLenAra);
            this.Controls.Add(this.richtxtMetin);
            this.Controls.Add(this.txtAranacak);
            this.Controls.Add(this.btnCountAra);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaç Tane Var?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCountAra;
        private System.Windows.Forms.TextBox txtAranacak;
        private System.Windows.Forms.RichTextBox richtxtMetin;
        private System.Windows.Forms.Button btnLenAra;
    }
}


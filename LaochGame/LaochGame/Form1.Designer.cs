namespace LaochGame
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.btnChoice4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(13, 13);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(423, 258);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "lblDisplay";
            // 
            // btnChoice1
            // 
            this.btnChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice1.Location = new System.Drawing.Point(13, 275);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(423, 30);
            this.btnChoice1.TabIndex = 1;
            this.btnChoice1.Text = "Choice 1";
            this.btnChoice1.UseVisualStyleBackColor = true;
            // 
            // btnChoice2
            // 
            this.btnChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice2.Location = new System.Drawing.Point(13, 311);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(423, 30);
            this.btnChoice2.TabIndex = 2;
            this.btnChoice2.Text = "Choice 2";
            this.btnChoice2.UseVisualStyleBackColor = true;
            // 
            // btnChoice3
            // 
            this.btnChoice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice3.Location = new System.Drawing.Point(13, 347);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(423, 30);
            this.btnChoice3.TabIndex = 3;
            this.btnChoice3.Text = "Choice 3";
            this.btnChoice3.UseVisualStyleBackColor = true;
            // 
            // btnChoice4
            // 
            this.btnChoice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice4.Location = new System.Drawing.Point(13, 383);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.Size = new System.Drawing.Size(423, 30);
            this.btnChoice4.TabIndex = 4;
            this.btnChoice4.Text = "Choice4";
            this.btnChoice4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 495);
            this.Controls.Add(this.btnChoice4);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laoch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Button btnChoice3;
        private System.Windows.Forms.Button btnChoice4;
    }
}


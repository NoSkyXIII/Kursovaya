namespace Kursovaya
{
    partial class Question
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
            this.Yap = new System.Windows.Forms.Button();
            this.Nope = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ты новый пользователь?";
            // 
            // Yap
            // 
            this.Yap.BackColor = System.Drawing.Color.Aquamarine;
            this.Yap.Font = new System.Drawing.Font("Monotype Corsiva", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yap.Location = new System.Drawing.Point(188, 234);
            this.Yap.Name = "Yap";
            this.Yap.Size = new System.Drawing.Size(146, 75);
            this.Yap.TabIndex = 1;
            this.Yap.Text = "Да";
            this.Yap.UseVisualStyleBackColor = false;
            this.Yap.Click += new System.EventHandler(this.Yap_Click);
            // 
            // Nope
            // 
            this.Nope.BackColor = System.Drawing.Color.Aquamarine;
            this.Nope.Font = new System.Drawing.Font("Monotype Corsiva", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nope.Location = new System.Drawing.Point(467, 234);
            this.Nope.Name = "Nope";
            this.Nope.Size = new System.Drawing.Size(143, 75);
            this.Nope.TabIndex = 2;
            this.Nope.Text = "Нет";
            this.Nope.UseVisualStyleBackColor = false;
            this.Nope.Click += new System.EventHandler(this.Nope_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nope);
            this.Controls.Add(this.Yap);
            this.Controls.Add(this.label1);
            this.Name = "Question";
            this.Text = "От лица врача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Yap;
        private System.Windows.Forms.Button Nope;
    }
}
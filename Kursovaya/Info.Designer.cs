namespace Kursovaya
{
    partial class Info
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
            this.Inform = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gogogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inform
            // 
            this.Inform.AutoEllipsis = true;
            this.Inform.AutoSize = true;
            this.Inform.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inform.Location = new System.Drawing.Point(181, 33);
            this.Inform.Name = "Inform";
            this.Inform.Size = new System.Drawing.Size(411, 39);
            this.Inform.TabIndex = 0;
            this.Inform.Text = "Это программа \"От лица врача\".";
            this.Inform.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Здесь ты сможешь узнать о медицинских инструментах ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(103, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "в мгновение! Перемещайся по локациям, и находи ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(724, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "инструменты, наводи на них курсор и узнай о них больше!";
            // 
            // gogogo
            // 
            this.gogogo.BackColor = System.Drawing.Color.Aquamarine;
            this.gogogo.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gogogo.Location = new System.Drawing.Point(253, 277);
            this.gogogo.Name = "gogogo";
            this.gogogo.Size = new System.Drawing.Size(286, 65);
            this.gogogo.TabIndex = 4;
            this.gogogo.Text = "Вперёд к науке!";
            this.gogogo.UseVisualStyleBackColor = false;
            this.gogogo.Click += new System.EventHandler(this.gogogo_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.gogogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inform);
            this.Name = "Info";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gogogo;
    }
}
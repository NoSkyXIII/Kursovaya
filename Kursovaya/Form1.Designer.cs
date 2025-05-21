namespace Kursovaya
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.goTo = new System.Windows.Forms.Button();
            this.outMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(228, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "От лица врача";
            // 
            // goTo
            // 
            this.goTo.BackColor = System.Drawing.Color.Aquamarine;
            this.goTo.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goTo.Location = new System.Drawing.Point(325, 234);
            this.goTo.Name = "goTo";
            this.goTo.Size = new System.Drawing.Size(140, 66);
            this.goTo.TabIndex = 1;
            this.goTo.Text = "Далее";
            this.goTo.UseVisualStyleBackColor = false;
            this.goTo.Click += new System.EventHandler(this.goTo_Click);
            // 
            // outMed
            // 
            this.outMed.BackColor = System.Drawing.Color.Aquamarine;
            this.outMed.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outMed.Location = new System.Drawing.Point(329, 336);
            this.outMed.Name = "outMed";
            this.outMed.Size = new System.Drawing.Size(135, 56);
            this.outMed.TabIndex = 2;
            this.outMed.Text = "Выход";
            this.outMed.UseVisualStyleBackColor = false;
            this.outMed.Click += new System.EventHandler(this.outMed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outMed);
            this.Controls.Add(this.goTo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "От лица врача";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goTo;
        private System.Windows.Forms.Button outMed;
    }
}


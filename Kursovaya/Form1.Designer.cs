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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "От лица врача";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top; // Центрирование по горизонтали
            // 
            // goTo
            // 
            this.goTo.BackColor = System.Drawing.Color.FromArgb(0, 120, 215); // Современный синий
            this.goTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goTo.FlatAppearance.BorderSize = 0;
            this.goTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goTo.ForeColor = System.Drawing.Color.White;
            this.goTo.Location = new System.Drawing.Point(330, 180);
            this.goTo.Name = "goTo";
            this.goTo.Size = new System.Drawing.Size(140, 50);
            this.goTo.TabIndex = 1;
            this.goTo.Text = "Далее";
            this.goTo.UseVisualStyleBackColor = false;
            this.goTo.Click += new System.EventHandler(this.goTo_Click);
            this.goTo.MouseEnter += new System.EventHandler(this.goTo_MouseEnter);
            this.goTo.MouseLeave += new System.EventHandler(this.goTo_MouseLeave);
            this.goTo.Anchor = System.Windows.Forms.AnchorStyles.None; // Центрирование управляется вручную
            // 
            // outMed
            // 
            this.outMed.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); // Красный для выхода
            this.outMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outMed.FlatAppearance.BorderSize = 0;
            this.outMed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outMed.ForeColor = System.Drawing.Color.White;
            this.outMed.Location = new System.Drawing.Point(330, 250);
            this.outMed.Name = "outMed";
            this.outMed.Size = new System.Drawing.Size(140, 50);
            this.outMed.TabIndex = 2;
            this.outMed.Text = "Выход";
            this.outMed.UseVisualStyleBackColor = false;
            this.outMed.Click += new System.EventHandler(this.outMed_Click);
            this.outMed.MouseEnter += new System.EventHandler(this.outMed_MouseEnter);
            this.outMed.MouseLeave += new System.EventHandler(this.outMed_MouseLeave);
            this.outMed.Anchor = System.Windows.Forms.AnchorStyles.None; // Центрирование управляется вручную
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 248, 255); // Светлый фон (AliceBlue)
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outMed);
            this.Controls.Add(this.goTo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "От лица врача";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goTo;
        private System.Windows.Forms.Button outMed;
    }
}
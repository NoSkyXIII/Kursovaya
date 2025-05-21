namespace Kursovaya
{
    partial class Kabin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kabin1));
            this.Kabinet1 = new System.Windows.Forms.PictureBox();
            this.right1 = new System.Windows.Forms.PictureBox();
            this.left1 = new System.Windows.Forms.PictureBox();
            this.SupIns = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Kabinet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kabinet1
            // 
            this.Kabinet1.Image = ((System.Drawing.Image)(resources.GetObject("Kabinet1.Image")));
            this.Kabinet1.Name = "Kabinet1";
            this.Kabinet1.Size = new System.Drawing.Size(1078, 694);
            this.Kabinet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kabinet1.TabIndex = 0;
            this.Kabinet1.TabStop = false;
            this.Kabinet1.Dock = System.Windows.Forms.DockStyle.Fill; // Заполняет форму, на заднем плане
            // 
            // right1
            // 
            this.right1.BackColor = System.Drawing.Color.Transparent;
            this.right1.Image = ((System.Drawing.Image)(resources.GetObject("right1.Image")));
            this.right1.Location = new System.Drawing.Point(984, 342);
            this.right1.Name = "right1";
            this.right1.Size = new System.Drawing.Size(76, 79);
            this.right1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right1.TabIndex = 1;
            this.right1.TabStop = false;
            this.right1.Visible = false;
            this.right1.Click += new System.EventHandler(this.right1_Click);
            this.right1.MouseLeave += new System.EventHandler(this.right1_MouseLeave);
            this.right1.MouseHover += new System.EventHandler(this.right1_MouseHover);
            this.right1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // left1
            // 
            this.left1.BackColor = System.Drawing.Color.Transparent;
            this.left1.Image = ((System.Drawing.Image)(resources.GetObject("left1.Image")));
            this.left1.Location = new System.Drawing.Point(212, 338);
            this.left1.Name = "left1";
            this.left1.Size = new System.Drawing.Size(84, 83);
            this.left1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left1.TabIndex = 2;
            this.left1.TabStop = false;
            this.left1.Click += new System.EventHandler(this.left1_Click);
            this.left1.MouseLeave += new System.EventHandler(this.left1_MouseLeave);
            this.left1.MouseHover += new System.EventHandler(this.left1_MouseHover);
            this.left1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            // 
            // SupIns
            // 
            this.SupIns.Location = new System.Drawing.Point(0, 427);
            this.SupIns.Name = "SupIns";
            this.SupIns.Size = new System.Drawing.Size(1078, 267);
            this.SupIns.TabIndex = 3;
            this.SupIns.TabStop = false;
            this.SupIns.Visible = false;
            this.SupIns.Dock = System.Windows.Forms.DockStyle.Bottom; // Закреплен внизу
            // 
            // Kabin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1078, 694);
            this.Controls.Add(this.Kabinet1); // Kabinet1 добавлен первым для нижнего Z-уровня
            this.Controls.Add(this.SupIns);
            this.Controls.Add(this.left1);
            this.Controls.Add(this.right1);
            this.Name = "Kabin1";
            this.Text = "От лица врача";
            ((System.ComponentModel.ISupportInitialize)(this.Kabinet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox Kabinet1;
        private System.Windows.Forms.PictureBox right1;
        private System.Windows.Forms.PictureBox left1;
        private System.Windows.Forms.GroupBox SupIns;
    }
}
namespace UAS_PABD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataPengirimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEkspedisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKurirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPengantaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPengirimToolStripMenuItem,
            this.dataEkspedisiToolStripMenuItem,
            this.dataKurirToolStripMenuItem,
            this.dataPengantaranToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // dataPengirimToolStripMenuItem
            // 
            this.dataPengirimToolStripMenuItem.Name = "dataPengirimToolStripMenuItem";
            this.dataPengirimToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPengirimToolStripMenuItem.Text = "Data Pengirim";
            // 
            // dataEkspedisiToolStripMenuItem
            // 
            this.dataEkspedisiToolStripMenuItem.Name = "dataEkspedisiToolStripMenuItem";
            this.dataEkspedisiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataEkspedisiToolStripMenuItem.Text = "Data Ekspedisi";
            // 
            // dataKurirToolStripMenuItem
            // 
            this.dataKurirToolStripMenuItem.Name = "dataKurirToolStripMenuItem";
            this.dataKurirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataKurirToolStripMenuItem.Text = "Data Kurir";
            // 
            // dataPengantaranToolStripMenuItem
            // 
            this.dataPengantaranToolStripMenuItem.Name = "dataPengantaranToolStripMenuItem";
            this.dataPengantaranToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPengantaranToolStripMenuItem.Text = "Data Pengantaran";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem dataPengirimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataEkspedisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKurirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPengantaranToolStripMenuItem;
    }
}


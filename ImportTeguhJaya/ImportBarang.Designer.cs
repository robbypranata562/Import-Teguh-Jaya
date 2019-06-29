namespace ImportTeguhJaya
{
    partial class ImportBarang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPilihFile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGImport = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PBData = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnImport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGImport)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnPilihFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 52);
            this.panel1.TabIndex = 0;
            // 
            // BtnPilihFile
            // 
            this.BtnPilihFile.Location = new System.Drawing.Point(12, 12);
            this.BtnPilihFile.Name = "BtnPilihFile";
            this.BtnPilihFile.Size = new System.Drawing.Size(75, 34);
            this.BtnPilihFile.TabIndex = 0;
            this.BtnPilihFile.Text = "Pilih File";
            this.BtnPilihFile.UseVisualStyleBackColor = true;
            this.BtnPilihFile.Click += new System.EventHandler(this.BtnPilihFile_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGImport);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 231);
            this.panel3.TabIndex = 2;
            // 
            // DGImport
            // 
            this.DGImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGImport.Location = new System.Drawing.Point(0, 0);
            this.DGImport.Name = "DGImport";
            this.DGImport.Size = new System.Drawing.Size(682, 190);
            this.DGImport.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PBData);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(682, 41);
            this.panel4.TabIndex = 0;
            // 
            // PBData
            // 
            this.PBData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBData.Location = new System.Drawing.Point(0, 0);
            this.PBData.Name = "PBData";
            this.PBData.Size = new System.Drawing.Size(682, 41);
            this.PBData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnImport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 53);
            this.panel2.TabIndex = 1;
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(595, 7);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(75, 34);
            this.BtnImport.TabIndex = 0;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // ImportBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 336);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImportBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Barang";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGImport)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DGImport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar PBData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Button BtnPilihFile;
    }
}
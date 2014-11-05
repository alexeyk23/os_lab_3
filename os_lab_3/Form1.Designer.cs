namespace os_lab_3
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
            this.btnGet = new System.Windows.Forms.Button();
            this.txbxRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(138, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(159, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Получить Информацию";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txbxRes
            // 
            this.txbxRes.Location = new System.Drawing.Point(12, 41);
            this.txbxRes.Multiline = true;
            this.txbxRes.Name = "txbxRes";
            this.txbxRes.ReadOnly = true;
            this.txbxRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbxRes.Size = new System.Drawing.Size(285, 277);
            this.txbxRes.TabIndex = 4;
            this.txbxRes.TextChanged += new System.EventHandler(this.txbxRes_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 341);
            this.Controls.Add(this.txbxRes);
            this.Controls.Add(this.btnGet);
            this.Name = "Form1";
            this.Text = "Лаба 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txbxRes;
    }
}


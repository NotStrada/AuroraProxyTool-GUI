
namespace Aurora_Proxy_Tool
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minBtt = new System.Windows.Forms.Button();
            this.closeBtt = new System.Windows.Forms.Button();
            this.scrapeBtt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.proxies = new System.Windows.Forms.TextBox();
            this.checkBtt = new System.Windows.Forms.Button();
            this.validLbl = new System.Windows.Forms.Label();
            this.deadLbl = new System.Windows.Forms.Label();
            this.aliveTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtt = new System.Windows.Forms.Button();
            this.timeoutInp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.threadsInp = new System.Windows.Forms.NumericUpDown();
            this.threadsLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutInp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadsInp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.minBtt);
            this.panel1.Controls.Add(this.closeBtt);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 67);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // minBtt
            // 
            this.minBtt.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtt.Location = new System.Drawing.Point(548, 15);
            this.minBtt.Name = "minBtt";
            this.minBtt.Size = new System.Drawing.Size(53, 40);
            this.minBtt.TabIndex = 1;
            this.minBtt.Text = "-";
            this.minBtt.UseVisualStyleBackColor = true;
            this.minBtt.Click += new System.EventHandler(this.minBtt_Click);
            // 
            // closeBtt
            // 
            this.closeBtt.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtt.Location = new System.Drawing.Point(607, 15);
            this.closeBtt.Name = "closeBtt";
            this.closeBtt.Size = new System.Drawing.Size(53, 40);
            this.closeBtt.TabIndex = 0;
            this.closeBtt.Text = "X";
            this.closeBtt.UseVisualStyleBackColor = true;
            this.closeBtt.Click += new System.EventHandler(this.button1_Click);
            // 
            // scrapeBtt
            // 
            this.scrapeBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrapeBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.scrapeBtt.Location = new System.Drawing.Point(12, 189);
            this.scrapeBtt.Name = "scrapeBtt";
            this.scrapeBtt.Size = new System.Drawing.Size(210, 53);
            this.scrapeBtt.TabIndex = 1;
            this.scrapeBtt.Text = "Scrape Proxies";
            this.scrapeBtt.UseVisualStyleBackColor = true;
            this.scrapeBtt.Click += new System.EventHandler(this.scrapeBtt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HTTP / HTTPs",
            "Socks4",
            "Socks5"});
            this.comboBox1.Location = new System.Drawing.Point(11, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // proxies
            // 
            this.proxies.Location = new System.Drawing.Point(235, 79);
            this.proxies.Multiline = true;
            this.proxies.Name = "proxies";
            this.proxies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.proxies.Size = new System.Drawing.Size(210, 365);
            this.proxies.TabIndex = 3;
            this.proxies.TextChanged += new System.EventHandler(this.proxies_TextChanged);
            // 
            // checkBtt
            // 
            this.checkBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBtt.Location = new System.Drawing.Point(11, 248);
            this.checkBtt.Name = "checkBtt";
            this.checkBtt.Size = new System.Drawing.Size(210, 53);
            this.checkBtt.TabIndex = 5;
            this.checkBtt.Text = "Check Proxies";
            this.checkBtt.UseVisualStyleBackColor = true;
            this.checkBtt.Click += new System.EventHandler(this.checkBtt_Click);
            // 
            // validLbl
            // 
            this.validLbl.AutoSize = true;
            this.validLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.validLbl.Location = new System.Drawing.Point(14, 337);
            this.validLbl.Name = "validLbl";
            this.validLbl.Size = new System.Drawing.Size(179, 24);
            this.validLbl.TabIndex = 6;
            this.validLbl.Text = "Valid proxies:     0";
            // 
            // deadLbl
            // 
            this.deadLbl.AutoSize = true;
            this.deadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deadLbl.Location = new System.Drawing.Point(12, 304);
            this.deadLbl.Name = "deadLbl";
            this.deadLbl.Size = new System.Drawing.Size(181, 24);
            this.deadLbl.TabIndex = 7;
            this.deadLbl.Text = "Dead proxies:     0";
            // 
            // aliveTxt
            // 
            this.aliveTxt.Location = new System.Drawing.Point(451, 79);
            this.aliveTxt.Multiline = true;
            this.aliveTxt.Name = "aliveTxt";
            this.aliveTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aliveTxt.Size = new System.Drawing.Size(210, 306);
            this.aliveTxt.TabIndex = 8;
            this.aliveTxt.TextChanged += new System.EventHandler(this.aliveTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scraped proxies:     0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Timeout (ms):";
            // 
            // saveBtt
            // 
            this.saveBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.saveBtt.Location = new System.Drawing.Point(451, 394);
            this.saveBtt.Name = "saveBtt";
            this.saveBtt.Size = new System.Drawing.Size(210, 53);
            this.saveBtt.TabIndex = 11;
            this.saveBtt.Text = "Save Proxies";
            this.saveBtt.UseVisualStyleBackColor = true;
            this.saveBtt.Click += new System.EventHandler(this.saveBtt_Click);
            // 
            // timeoutInp
            // 
            this.timeoutInp.Location = new System.Drawing.Point(157, 136);
            this.timeoutInp.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.timeoutInp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeoutInp.Name = "timeoutInp";
            this.timeoutInp.Size = new System.Drawing.Size(64, 20);
            this.timeoutInp.TabIndex = 12;
            this.timeoutInp.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(59, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Threads:";
            // 
            // threadsInp
            // 
            this.threadsInp.Location = new System.Drawing.Point(158, 162);
            this.threadsInp.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.threadsInp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadsInp.Name = "threadsInp";
            this.threadsInp.Size = new System.Drawing.Size(64, 20);
            this.threadsInp.TabIndex = 14;
            this.threadsInp.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // threadsLbl
            // 
            this.threadsLbl.AutoSize = true;
            this.threadsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.threadsLbl.Location = new System.Drawing.Point(12, 162);
            this.threadsLbl.Name = "threadsLbl";
            this.threadsLbl.Size = new System.Drawing.Size(21, 24);
            this.threadsLbl.TabIndex = 15;
            this.threadsLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 51);
            this.label4.TabIndex = 2;
            this.label4.Text = "Aurora Proxy Tool";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(672, 459);
            this.Controls.Add(this.threadsLbl);
            this.Controls.Add(this.threadsInp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeoutInp);
            this.Controls.Add(this.saveBtt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aliveTxt);
            this.Controls.Add(this.deadLbl);
            this.Controls.Add(this.validLbl);
            this.Controls.Add(this.checkBtt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proxies);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.scrapeBtt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutInp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadsInp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minBtt;
        private System.Windows.Forms.Button closeBtt;
        private System.Windows.Forms.Button scrapeBtt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox proxies;
        private System.Windows.Forms.Button checkBtt;
        private System.Windows.Forms.Label validLbl;
        private System.Windows.Forms.Label deadLbl;
        private System.Windows.Forms.TextBox aliveTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtt;
        private System.Windows.Forms.NumericUpDown timeoutInp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown threadsInp;
        private System.Windows.Forms.Label threadsLbl;
        private System.Windows.Forms.Label label4;
    }
}


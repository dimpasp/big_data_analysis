
namespace predictEnergy
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btStats = new System.Windows.Forms.Button();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btGetAllData = new System.Windows.Forms.Button();
            this.btPredictions = new System.Windows.Forms.Button();
            this.lbDash = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNextPredict = new System.Windows.Forms.TextBox();
            this.lbNewDay = new System.Windows.Forms.Label();
            this.lbLastWeek = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btStats);
            this.panel1.Controls.Add(this.lbWelcome);
            this.panel1.Controls.Add(this.btGetAllData);
            this.panel1.Controls.Add(this.btPredictions);
            this.panel1.Controls.Add(this.lbDash);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 396);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 271);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btStats
            // 
            this.btStats.BackColor = System.Drawing.Color.Azure;
            this.btStats.Location = new System.Drawing.Point(10, 202);
            this.btStats.Name = "btStats";
            this.btStats.Size = new System.Drawing.Size(90, 50);
            this.btStats.TabIndex = 6;
            this.btStats.Text = "See Stats";
            this.btStats.UseVisualStyleBackColor = false;
            this.btStats.Click += new System.EventHandler(this.btStats_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(3, 366);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(0, 13);
            this.lbWelcome.TabIndex = 5;
            this.lbWelcome.Visible = false;
            // 
            // btGetAllData
            // 
            this.btGetAllData.BackColor = System.Drawing.Color.Azure;
            this.btGetAllData.Location = new System.Drawing.Point(10, 147);
            this.btGetAllData.Margin = new System.Windows.Forms.Padding(2);
            this.btGetAllData.Name = "btGetAllData";
            this.btGetAllData.Size = new System.Drawing.Size(90, 50);
            this.btGetAllData.TabIndex = 3;
            this.btGetAllData.Text = "History of all data";
            this.btGetAllData.UseVisualStyleBackColor = false;
            this.btGetAllData.Click += new System.EventHandler(this.btGetAllData_Click);
            // 
            // btPredictions
            // 
            this.btPredictions.BackColor = System.Drawing.Color.Azure;
            this.btPredictions.Location = new System.Drawing.Point(11, 85);
            this.btPredictions.Margin = new System.Windows.Forms.Padding(2);
            this.btPredictions.Name = "btPredictions";
            this.btPredictions.Size = new System.Drawing.Size(90, 50);
            this.btPredictions.TabIndex = 2;
            this.btPredictions.Text = "History of predictions";
            this.btPredictions.UseVisualStyleBackColor = false;
            this.btPredictions.Click += new System.EventHandler(this.btPredictions_Click);
            // 
            // lbDash
            // 
            this.lbDash.AutoSize = true;
            this.lbDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbDash.Location = new System.Drawing.Point(82, 37);
            this.lbDash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDash.Name = "lbDash";
            this.lbDash.Size = new System.Drawing.Size(81, 18);
            this.lbDash.TabIndex = 1;
            this.lbDash.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbNextPredict
            // 
            this.tbNextPredict.Location = new System.Drawing.Point(182, 360);
            this.tbNextPredict.Margin = new System.Windows.Forms.Padding(2);
            this.tbNextPredict.Name = "tbNextPredict";
            this.tbNextPredict.ReadOnly = true;
            this.tbNextPredict.Size = new System.Drawing.Size(114, 20);
            this.tbNextPredict.TabIndex = 1;
            // 
            // lbNewDay
            // 
            this.lbNewDay.AutoSize = true;
            this.lbNewDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbNewDay.Location = new System.Drawing.Point(314, 363);
            this.lbNewDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewDay.Name = "lbNewDay";
            this.lbNewDay.Size = new System.Drawing.Size(171, 17);
            this.lbNewDay.TabIndex = 2;
            this.lbNewDay.Text = "Predict price for next hour";
            // 
            // lbLastWeek
            // 
            this.lbLastWeek.AutoSize = true;
            this.lbLastWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbLastWeek.Location = new System.Drawing.Point(179, 19);
            this.lbLastWeek.Name = "lbLastWeek";
            this.lbLastWeek.Size = new System.Drawing.Size(138, 18);
            this.lbLastWeek.TabIndex = 4;
            this.lbLastWeek.Text = "Daily predictions ";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(182, 60);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(406, 223);
            this.cartesianChart1.TabIndex = 5;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(650, 396);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.lbLastWeek);
            this.Controls.Add(this.lbNewDay);
            this.Controls.Add(this.tbNextPredict);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Εφαρμοσμένα Συστήματα Αυτοματοποίησης";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btGetAllData;
        private System.Windows.Forms.Button btPredictions;
        private System.Windows.Forms.Label lbDash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNextPredict;
        private System.Windows.Forms.Label lbNewDay;
        private System.Windows.Forms.Label lbLastWeek;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        public System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btStats;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


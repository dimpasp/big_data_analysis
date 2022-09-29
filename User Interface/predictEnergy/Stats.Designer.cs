namespace predictEnergy
{
    partial class Stats
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
            this.tbLastYear = new System.Windows.Forms.TextBox();
            this.tbMaxValue = new System.Windows.Forms.TextBox();
            this.tbMinValue = new System.Windows.Forms.TextBox();
            this.lbList = new System.Windows.Forms.Label();
            this.lbLastYear = new System.Windows.Forms.Label();
            this.lbmax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.getTodayValues = new System.Windows.Forms.DataGridView();
            this.checkIfDataIsUp = new System.Windows.Forms.CheckBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.getTodayValues)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLastYear
            // 
            this.tbLastYear.Location = new System.Drawing.Point(265, 217);
            this.tbLastYear.Name = "tbLastYear";
            this.tbLastYear.Size = new System.Drawing.Size(188, 20);
            this.tbLastYear.TabIndex = 1;
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.Location = new System.Drawing.Point(265, 243);
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.Size = new System.Drawing.Size(188, 20);
            this.tbMaxValue.TabIndex = 2;
            // 
            // tbMinValue
            // 
            this.tbMinValue.Location = new System.Drawing.Point(265, 269);
            this.tbMinValue.Name = "tbMinValue";
            this.tbMinValue.Size = new System.Drawing.Size(188, 20);
            this.tbMinValue.TabIndex = 3;
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.Location = new System.Drawing.Point(93, 178);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(137, 13);
            this.lbList.TabIndex = 4;
            this.lbList.Text = "List of all today preedictions";
            // 
            // lbLastYear
            // 
            this.lbLastYear.AutoSize = true;
            this.lbLastYear.Location = new System.Drawing.Point(93, 224);
            this.lbLastYear.Name = "lbLastYear";
            this.lbLastYear.Size = new System.Drawing.Size(108, 13);
            this.lbLastYear.TabIndex = 5;
            this.lbLastYear.Text = "Last month prediction";
            // 
            // lbmax
            // 
            this.lbmax.AutoSize = true;
            this.lbmax.Location = new System.Drawing.Point(93, 250);
            this.lbmax.Name = "lbmax";
            this.lbmax.Size = new System.Drawing.Size(136, 13);
            this.lbmax.TabIndex = 6;
            this.lbmax.Text = "Max predict value of Month";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(93, 276);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(132, 13);
            this.lbMin.TabIndex = 7;
            this.lbMin.Text = "Min predict value of month";
            // 
            // getTodayValues
            // 
            this.getTodayValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getTodayValues.Location = new System.Drawing.Point(265, 35);
            this.getTodayValues.Name = "getTodayValues";
            this.getTodayValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.getTodayValues.Size = new System.Drawing.Size(267, 156);
            this.getTodayValues.TabIndex = 8;
            // 
            // checkIfDataIsUp
            // 
            this.checkIfDataIsUp.AutoSize = true;
            this.checkIfDataIsUp.Location = new System.Drawing.Point(96, 381);
            this.checkIfDataIsUp.Name = "checkIfDataIsUp";
            this.checkIfDataIsUp.Size = new System.Drawing.Size(122, 17);
            this.checkIfDataIsUp.TabIndex = 9;
            this.checkIfDataIsUp.Text = "dataset is up to date";
            this.checkIfDataIsUp.UseVisualStyleBackColor = true;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(96, 404);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 10;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(76, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.checkIfDataIsUp);
            this.Controls.Add(this.getTodayValues);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbmax);
            this.Controls.Add(this.lbLastYear);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.tbMinValue);
            this.Controls.Add(this.tbMaxValue);
            this.Controls.Add(this.tbLastYear);
            this.Name = "Stats";
            this.Text = "Εφαρμοσμένα Συστήματα Αυτοματοποίησης";
            this.Load += new System.EventHandler(this.Stats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getTodayValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLastYear;
        private System.Windows.Forms.TextBox tbMaxValue;
        private System.Windows.Forms.TextBox tbMinValue;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.Label lbLastYear;
        private System.Windows.Forms.Label lbmax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.DataGridView getTodayValues;
        private System.Windows.Forms.CheckBox checkIfDataIsUp;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button button1;
    }
}
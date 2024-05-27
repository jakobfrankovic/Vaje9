namespace DataBaseVmesnikFilmi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtYearFrom;
        private System.Windows.Forms.TextBox txtYearTo;
        private System.Windows.Forms.TextBox txtRatingFrom;
        private System.Windows.Forms.TextBox txtRatingTo;
        private System.Windows.Forms.TextBox txtLengthFrom;
        private System.Windows.Forms.TextBox txtLengthTo;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblYearFrom;
        private System.Windows.Forms.Label lblYearTo;
        private System.Windows.Forms.Label lblRatingFrom;
        private System.Windows.Forms.Label lblRatingTo;
        private System.Windows.Forms.Label lblLengthFrom;
        private System.Windows.Forms.Label lblLengthTo;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Inicializacija komponent uporabniškega vmesnika
        private void InitializeComponent()
        {
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.inputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblYearFrom = new System.Windows.Forms.Label();
            this.txtYearFrom = new System.Windows.Forms.TextBox();
            this.lblYearTo = new System.Windows.Forms.Label();
            this.txtYearTo = new System.Windows.Forms.TextBox();
            this.lblRatingFrom = new System.Windows.Forms.Label();
            this.txtRatingFrom = new System.Windows.Forms.TextBox();
            this.lblRatingTo = new System.Windows.Forms.Label();
            this.txtRatingTo = new System.Windows.Forms.TextBox();
            this.lblLengthFrom = new System.Windows.Forms.Label();
            this.txtLengthFrom = new System.Windows.Forms.TextBox();
            this.lblLengthTo = new System.Windows.Forms.Label();
            this.txtLengthTo = new System.Windows.Forms.TextBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.grpInputs.SuspendLayout();
            this.inputTableLayoutPanel.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.pictureBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.grpInputs, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.grpResults, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1006, 750);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::DataBaseVmesnikFilmi.Properties.Resources.IskalecFilmov;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1000, 218);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // grpInputs
            // 
            this.grpInputs.BackColor = System.Drawing.Color.LightGray;
            this.grpInputs.Controls.Add(this.inputTableLayoutPanel);
            this.grpInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInputs.Location = new System.Drawing.Point(2, 226);
            this.grpInputs.Margin = new System.Windows.Forms.Padding(2);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Padding = new System.Windows.Forms.Padding(2);
            this.grpInputs.Size = new System.Drawing.Size(1002, 206);
            this.grpInputs.TabIndex = 0;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Filter Vnosi";
            // 
            // inputTableLayoutPanel
            // 
            this.inputTableLayoutPanel.AutoSize = true;
            this.inputTableLayoutPanel.ColumnCount = 2;
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.31313F));
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.68687F));
            this.inputTableLayoutPanel.Controls.Add(this.lblYearFrom, 0, 0);
            this.inputTableLayoutPanel.Controls.Add(this.txtYearFrom, 1, 0);
            this.inputTableLayoutPanel.Controls.Add(this.lblYearTo, 0, 1);
            this.inputTableLayoutPanel.Controls.Add(this.txtYearTo, 1, 1);
            this.inputTableLayoutPanel.Controls.Add(this.lblRatingFrom, 0, 2);
            this.inputTableLayoutPanel.Controls.Add(this.txtRatingFrom, 1, 2);
            this.inputTableLayoutPanel.Controls.Add(this.lblRatingTo, 0, 3);
            this.inputTableLayoutPanel.Controls.Add(this.txtRatingTo, 1, 3);
            this.inputTableLayoutPanel.Controls.Add(this.lblLengthFrom, 0, 4);
            this.inputTableLayoutPanel.Controls.Add(this.txtLengthFrom, 1, 4);
            this.inputTableLayoutPanel.Controls.Add(this.lblLengthTo, 0, 5);
            this.inputTableLayoutPanel.Controls.Add(this.txtLengthTo, 1, 5);
            this.inputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTableLayoutPanel.Location = new System.Drawing.Point(2, 15);
            this.inputTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            this.inputTableLayoutPanel.RowCount = 6;
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.inputTableLayoutPanel.Size = new System.Drawing.Size(998, 189);
            this.inputTableLayoutPanel.TabIndex = 0;
            // 
            // lblYearFrom
            // 
            this.lblYearFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearFrom.AutoSize = true;
            this.lblYearFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblYearFrom.Location = new System.Drawing.Point(124, 5);
            this.lblYearFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYearFrom.Name = "lblYearFrom";
            this.lblYearFrom.Size = new System.Drawing.Size(63, 20);
            this.lblYearFrom.TabIndex = 7;
            this.lblYearFrom.Text = "Leto od";
            this.lblYearFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYearFrom
            // 
            this.txtYearFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYearFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtYearFrom.Location = new System.Drawing.Point(401, 2);
            this.txtYearFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtYearFrom.Name = "txtYearFrom";
            this.txtYearFrom.Size = new System.Drawing.Size(508, 26);
            this.txtYearFrom.TabIndex = 0;
            this.txtYearFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYearFrom.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // lblYearTo
            // 
            this.lblYearTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearTo.AutoSize = true;
            this.lblYearTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblYearTo.Location = new System.Drawing.Point(124, 36);
            this.lblYearTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYearTo.Name = "lblYearTo";
            this.lblYearTo.Size = new System.Drawing.Size(63, 20);
            this.lblYearTo.TabIndex = 8;
            this.lblYearTo.Text = "Leto do";
            this.lblYearTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYearTo
            // 
            this.txtYearTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYearTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtYearTo.Location = new System.Drawing.Point(401, 33);
            this.txtYearTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtYearTo.Name = "txtYearTo";
            this.txtYearTo.Size = new System.Drawing.Size(508, 26);
            this.txtYearTo.TabIndex = 1;
            this.txtYearTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYearTo.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // lblRatingFrom
            // 
            this.lblRatingFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRatingFrom.AutoSize = true;
            this.lblRatingFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRatingFrom.Location = new System.Drawing.Point(117, 67);
            this.lblRatingFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRatingFrom.Name = "lblRatingFrom";
            this.lblRatingFrom.Size = new System.Drawing.Size(78, 20);
            this.lblRatingFrom.TabIndex = 9;
            this.lblRatingFrom.Text = "Ocena od";
            this.lblRatingFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRatingFrom
            // 
            this.txtRatingFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRatingFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRatingFrom.Location = new System.Drawing.Point(401, 64);
            this.txtRatingFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtRatingFrom.Name = "txtRatingFrom";
            this.txtRatingFrom.Size = new System.Drawing.Size(508, 26);
            this.txtRatingFrom.TabIndex = 2;
            this.txtRatingFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRatingFrom.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // lblRatingTo
            // 
            this.lblRatingTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRatingTo.AutoSize = true;
            this.lblRatingTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRatingTo.Location = new System.Drawing.Point(117, 98);
            this.lblRatingTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRatingTo.Name = "lblRatingTo";
            this.lblRatingTo.Size = new System.Drawing.Size(78, 20);
            this.lblRatingTo.TabIndex = 10;
            this.lblRatingTo.Text = "Ocena do";
            this.lblRatingTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRatingTo
            // 
            this.txtRatingTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRatingTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRatingTo.Location = new System.Drawing.Point(401, 95);
            this.txtRatingTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRatingTo.Name = "txtRatingTo";
            this.txtRatingTo.Size = new System.Drawing.Size(508, 26);
            this.txtRatingTo.TabIndex = 3;
            this.txtRatingTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRatingTo.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // lblLengthFrom
            // 
            this.lblLengthFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLengthFrom.AutoSize = true;
            this.lblLengthFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLengthFrom.Location = new System.Drawing.Point(114, 129);
            this.lblLengthFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLengthFrom.Name = "lblLengthFrom";
            this.lblLengthFrom.Size = new System.Drawing.Size(84, 20);
            this.lblLengthFrom.TabIndex = 11;
            this.lblLengthFrom.Text = "Dolžina od";
            this.lblLengthFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLengthFrom
            // 
            this.txtLengthFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLengthFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLengthFrom.Location = new System.Drawing.Point(401, 126);
            this.txtLengthFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtLengthFrom.Name = "txtLengthFrom";
            this.txtLengthFrom.Size = new System.Drawing.Size(508, 26);
            this.txtLengthFrom.TabIndex = 4;
            this.txtLengthFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLengthFrom.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // lblLengthTo
            // 
            this.lblLengthTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLengthTo.AutoSize = true;
            this.lblLengthTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLengthTo.Location = new System.Drawing.Point(114, 162);
            this.lblLengthTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLengthTo.Name = "lblLengthTo";
            this.lblLengthTo.Size = new System.Drawing.Size(84, 20);
            this.lblLengthTo.TabIndex = 12;
            this.lblLengthTo.Text = "Dolžina do";
            this.lblLengthTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLengthTo
            // 
            this.txtLengthTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLengthTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLengthTo.Location = new System.Drawing.Point(401, 159);
            this.txtLengthTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLengthTo.Name = "txtLengthTo";
            this.txtLengthTo.Size = new System.Drawing.Size(508, 26);
            this.txtLengthTo.TabIndex = 5;
            this.txtLengthTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLengthTo.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // grpResults
            // 
            this.grpResults.BackColor = System.Drawing.Color.LightGray;
            this.grpResults.Controls.Add(this.lstResults);
            this.grpResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResults.Location = new System.Drawing.Point(2, 436);
            this.grpResults.Margin = new System.Windows.Forms.Padding(2);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(2);
            this.grpResults.Size = new System.Drawing.Size(1002, 312);
            this.grpResults.TabIndex = 1;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Rezultati";
            // 
            // lstResults
            // 
            this.lstResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 20;
            this.lstResults.Location = new System.Drawing.Point(2, 15);
            this.lstResults.Margin = new System.Windows.Forms.Padding(2);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(998, 295);
            this.lstResults.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 750);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Filter Filmov";
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.inputTableLayoutPanel.ResumeLayout(false);
            this.inputTableLayoutPanel.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

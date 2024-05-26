namespace DataBaseVmesnik
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtYearFrom;
        private System.Windows.Forms.TextBox txtYearTo;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblYearFrom;
        private System.Windows.Forms.Label lblYearTo;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.Panel visualizationPanel;
        private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.visualizationPanel = new System.Windows.Forms.Panel();
            this.inputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtYearFrom = new System.Windows.Forms.TextBox();
            this.txtYearTo = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblYearFrom = new System.Windows.Forms.Label();
            this.lblYearTo = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();

            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.inputPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.visualizationPanel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.resultsPanel, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.SetColumnSpan(this.resultsPanel, 2);

            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.inputTableLayoutPanel);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.BackgroundImage = System.Drawing.Image.FromFile("Neutral_Background.png"); // Nastavi sliko ozadja
            this.inputPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; // Nastavi način razporeditve slike ozadja
            this.inputPanel.Padding = new System.Windows.Forms.Padding(10);

            // 
            // inputTableLayoutPanel
            // 
            this.inputTableLayoutPanel.ColumnCount = 2;
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.inputTableLayoutPanel.Controls.Add(this.lblYearFrom, 0, 0);
            this.inputTableLayoutPanel.Controls.Add(this.txtYearFrom, 1, 0);
            this.inputTableLayoutPanel.Controls.Add(this.lblYearTo, 0, 1);
            this.inputTableLayoutPanel.Controls.Add(this.txtYearTo, 1, 1);
            this.inputTableLayoutPanel.Controls.Add(this.lblCategory, 0, 2);
            this.inputTableLayoutPanel.Controls.Add(this.cmbCategory, 1, 2);
            this.inputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            this.inputTableLayoutPanel.RowCount = 4;
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inputTableLayoutPanel.Size = new System.Drawing.Size(400, 150);
            this.inputTableLayoutPanel.TabIndex = 0;

            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.lstResults);
            this.resultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsPanel.BackgroundImage = System.Drawing.Image.FromFile("Neutral_Background2.png"); // Nastavi sliko ozadja
            this.resultsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; // Nastavi način razporeditve slike ozadja
            this.resultsPanel.Padding = new System.Windows.Forms.Padding(10);

            // 
            // visualizationPanel
            // 
            this.visualizationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizationPanel.BackgroundImage = System.Drawing.Image.FromFile("Data_Viewer.png"); // Nastavi sliko ozadja
            this.visualizationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; // Nastavi način razporeditve slike ozadja
            this.visualizationPanel.Padding = new System.Windows.Forms.Padding(10);

            // 
            // lblYearFrom
            // 
            this.lblYearFrom.AutoSize = true;
            this.lblYearFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYearFrom.Location = new System.Drawing.Point(3, 0);
            this.lblYearFrom.Name = "lblYearFrom";
            this.lblYearFrom.Size = new System.Drawing.Size(114, 37);
            this.lblYearFrom.TabIndex = 5;
            this.lblYearFrom.Text = "Leto Od:";
            this.lblYearFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // txtYearFrom
            // 
            this.txtYearFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYearFrom.Location = new System.Drawing.Point(123, 7);
            this.txtYearFrom.Name = "txtYearFrom";
            this.txtYearFrom.Size = new System.Drawing.Size(274, 22);
            this.txtYearFrom.TabIndex = 0;
            this.txtYearFrom.TextChanged += new System.EventHandler(this.txtYearFrom_TextChanged);

            // 
            // lblYearTo
            // 
            this.lblYearTo.AutoSize = true;
            this.lblYearTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYearTo.Location = new System.Drawing.Point(3, 37);
            this.lblYearTo.Name = "lblYearTo";
            this.lblYearTo.Size = new System.Drawing.Size(114, 37);
            this.lblYearTo.TabIndex = 6;
            this.lblYearTo.Text = "Leto Do:";
            this.lblYearTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // txtYearTo
            // 
            this.txtYearTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYearTo.Location = new System.Drawing.Point(123, 44);
            this.txtYearTo.Name = "txtYearTo";
            this.txtYearTo.Size = new System.Drawing.Size(274, 22);
            this.txtYearTo.TabIndex = 1;
            this.txtYearTo.TextChanged += new System.EventHandler(this.txtYearTo_TextChanged);

            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Location = new System.Drawing.Point(3, 74);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(114, 37);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Kategorija:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(123, 80);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(274, 24);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);

            // 
            // lstResults
            // 
            this.lstResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(10, 10);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(770, 430);
            this.lstResults.TabIndex = 3;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 400); // Nastavi velikost okna
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Form1";
            this.Text = "Iskanje Nobelovih nagrad";
            this.ResumeLayout(false);
        }
    }
}

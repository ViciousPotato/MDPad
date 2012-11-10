namespace MDPad
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.textPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.previewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.Controls.Add(this.separatorPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.previewPanel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 580);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // separatorPanel
            // 
            this.separatorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.separatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.separatorPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.separatorPanel.Location = new System.Drawing.Point(500, 0);
            this.separatorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(1, 580);
            this.separatorPanel.TabIndex = 0;
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.richTextBox1);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPanel.Location = new System.Drawing.Point(0, 0);
            this.textPanel.Margin = new System.Windows.Forms.Padding(0);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(500, 580);
            this.textPanel.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(500, 580);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // previewPanel
            // 
            this.previewPanel.Controls.Add(this.webBrowser1);
            this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPanel.Location = new System.Drawing.Point(504, 3);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(494, 574);
            this.previewPanel.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(494, 574);
            this.webBrowser1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDPad";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.textPanel.ResumeLayout(false);
            this.previewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel separatorPanel;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}


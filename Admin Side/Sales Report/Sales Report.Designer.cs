﻿namespace sims.Admin_Side.Sales_Report
{
    partial class Sales_Report
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
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CoffeeSalesViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CoffeeSales1 = new sims.CoffeeSales();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NonCoffeeSalesViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.NonCoffeeSales1 = new sims.NonCoffeeSales();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HotCoffeeSalesViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PastriesSalesViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.HotCoffeeSales1 = new sims.HotCoffeeSales();
            this.PastriesSales1 = new sims.PastriesSales();
            this.panel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gunaElipsePanel2);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 53);
            this.panel1.TabIndex = 53;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.label4);
            this.gunaElipsePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 7;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(1170, 53);
            this.gunaElipsePanel2.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 34);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dashboard / Sales Report\r\n";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.tabControl1);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineTop = 0;
            this.gunaGroupBox2.Location = new System.Drawing.Point(12, 76);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 10;
            this.gunaGroupBox2.Size = new System.Drawing.Size(1171, 607);
            this.gunaGroupBox2.TabIndex = 54;
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 15);
            this.gunaGroupBox2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 607);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1163, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Coffee Sales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CoffeeSalesViewer);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1163, 571);
            this.panel5.TabIndex = 39;
            // 
            // CoffeeSalesViewer
            // 
            this.CoffeeSalesViewer.ActiveViewIndex = 0;
            this.CoffeeSalesViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoffeeSalesViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CoffeeSalesViewer.DisplayStatusBar = false;
            this.CoffeeSalesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoffeeSalesViewer.Location = new System.Drawing.Point(0, 0);
            this.CoffeeSalesViewer.Name = "CoffeeSalesViewer";
            this.CoffeeSalesViewer.ReportSource = this.CoffeeSales1;
            this.CoffeeSalesViewer.Size = new System.Drawing.Size(1161, 569);
            this.CoffeeSalesViewer.TabIndex = 0;
            this.CoffeeSalesViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1163, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Non-Coffee Sales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NonCoffeeSalesViewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 571);
            this.panel2.TabIndex = 1;
            // 
            // NonCoffeeSalesViewer
            // 
            this.NonCoffeeSalesViewer.ActiveViewIndex = 0;
            this.NonCoffeeSalesViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NonCoffeeSalesViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.NonCoffeeSalesViewer.DisplayStatusBar = false;
            this.NonCoffeeSalesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NonCoffeeSalesViewer.Location = new System.Drawing.Point(0, 0);
            this.NonCoffeeSalesViewer.Name = "NonCoffeeSalesViewer";
            this.NonCoffeeSalesViewer.ReportSource = this.NonCoffeeSales1;
            this.NonCoffeeSalesViewer.Size = new System.Drawing.Size(1163, 571);
            this.NonCoffeeSalesViewer.TabIndex = 1;
            this.NonCoffeeSalesViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1163, 571);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hot Coffee Sales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.HotCoffeeSalesViewer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1163, 571);
            this.panel3.TabIndex = 2;
            // 
            // HotCoffeeSalesViewer
            // 
            this.HotCoffeeSalesViewer.ActiveViewIndex = 0;
            this.HotCoffeeSalesViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HotCoffeeSalesViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.HotCoffeeSalesViewer.DisplayStatusBar = false;
            this.HotCoffeeSalesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotCoffeeSalesViewer.Location = new System.Drawing.Point(0, 0);
            this.HotCoffeeSalesViewer.Name = "HotCoffeeSalesViewer";
            this.HotCoffeeSalesViewer.ReportSource = this.HotCoffeeSales1;
            this.HotCoffeeSalesViewer.Size = new System.Drawing.Size(1163, 571);
            this.HotCoffeeSalesViewer.TabIndex = 1;
            this.HotCoffeeSalesViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1163, 571);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pastries";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PastriesSalesViewer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1163, 571);
            this.panel4.TabIndex = 2;
            // 
            // PastriesSalesViewer
            // 
            this.PastriesSalesViewer.ActiveViewIndex = 0;
            this.PastriesSalesViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PastriesSalesViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PastriesSalesViewer.DisplayStatusBar = false;
            this.PastriesSalesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PastriesSalesViewer.Location = new System.Drawing.Point(0, 0);
            this.PastriesSalesViewer.Name = "PastriesSalesViewer";
            this.PastriesSalesViewer.ReportSource = this.PastriesSales1;
            this.PastriesSalesViewer.Size = new System.Drawing.Size(1163, 571);
            this.PastriesSalesViewer.TabIndex = 0;
            this.PastriesSalesViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1194, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaGroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Report";
            this.Text = "Sales_Report";
            this.Load += new System.EventHandler(this.Sales_Report_Load);
            this.panel1.ResumeLayout(false);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        internal System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CoffeeSalesViewer;
        private System.Windows.Forms.Panel panel2;
        private sims.NonCoffeeSales NonCoffeeSales1;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer HotCoffeeSalesViewer;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer NonCoffeeSalesViewer;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer PastriesSalesViewer;
        private sims.CoffeeSales CoffeeSales1;
        private sims.HotCoffeeSales HotCoffeeSales1;
        private sims.PastriesSales PastriesSales1;
    }
}
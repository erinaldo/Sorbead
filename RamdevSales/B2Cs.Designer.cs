﻿namespace RamdevSales
{
    partial class B2Cs
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
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.DTPTo = new System.Windows.Forms.DateTimePicker();
            this.btnclose = new System.Windows.Forms.Button();
            this.BtnViewReport = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.DTPFrom = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.LVclient = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.White;
            this.textBox14.Location = new System.Drawing.Point(2, 1);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(1039, 30);
            this.textBox14.TabIndex = 204;
            this.textBox14.TabStop = false;
            this.textBox14.Text = "B2C SMALL INVOICE";
            // 
            // DTPTo
            // 
            this.DTPTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPTo.Location = new System.Drawing.Point(171, 55);
            this.DTPTo.Name = "DTPTo";
            this.DTPTo.Size = new System.Drawing.Size(147, 22);
            this.DTPTo.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(940, 50);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(97, 34);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            this.btnclose.MouseEnter += new System.EventHandler(this.btnclose_MouseEnter);
            this.btnclose.MouseLeave += new System.EventHandler(this.btnclose_MouseLeave);
            // 
            // BtnViewReport
            // 
            this.BtnViewReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewReport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewReport.ForeColor = System.Drawing.Color.White;
            this.BtnViewReport.Location = new System.Drawing.Point(330, 48);
            this.BtnViewReport.Name = "BtnViewReport";
            this.BtnViewReport.Size = new System.Drawing.Size(97, 34);
            this.BtnViewReport.TabIndex = 2;
            this.BtnViewReport.Text = "&OK";
            this.BtnViewReport.UseVisualStyleBackColor = false;
            this.BtnViewReport.Click += new System.EventHandler(this.BtnViewReport_Click);
            this.BtnViewReport.MouseEnter += new System.EventHandler(this.BtnViewReport_MouseEnter);
            this.BtnViewReport.MouseLeave += new System.EventHandler(this.BtnViewReport_MouseLeave);
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.Color.White;
            this.btnexcel.Location = new System.Drawing.Point(841, 51);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(97, 34);
            this.btnexcel.TabIndex = 3;
            this.btnexcel.Text = "&Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            this.btnexcel.MouseEnter += new System.EventHandler(this.btnexcel_MouseEnter);
            this.btnexcel.MouseLeave += new System.EventHandler(this.btnexcel_MouseLeave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(54, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 16);
            this.Label1.TabIndex = 218;
            this.Label1.Text = "From Date";
            // 
            // DTPFrom
            // 
            this.DTPFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFrom.Location = new System.Drawing.Point(13, 55);
            this.DTPFrom.Name = "DTPFrom";
            this.DTPFrom.Size = new System.Drawing.Size(147, 22);
            this.DTPFrom.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(212, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 16);
            this.Label2.TabIndex = 219;
            this.Label2.Text = "To Date";
            // 
            // LVclient
            // 
            this.LVclient.BackColor = System.Drawing.SystemColors.Window;
            this.LVclient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LVclient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVclient.ForeColor = System.Drawing.Color.Navy;
            this.LVclient.FullRowSelect = true;
            this.LVclient.GridLines = true;
            this.LVclient.HideSelection = false;
            this.LVclient.Location = new System.Drawing.Point(13, 91);
            this.LVclient.MultiSelect = false;
            this.LVclient.Name = "LVclient";
            this.LVclient.Size = new System.Drawing.Size(1024, 428);
            this.LVclient.TabIndex = 5;
            this.LVclient.UseCompatibleStateImageBehavior = false;
            this.LVclient.View = System.Windows.Forms.View.Details;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(812, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(208, 104);
            this.dataGridView1.TabIndex = 223;
            this.dataGridView1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 498);
            this.panel1.TabIndex = 224;
            // 
            // B2Cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 536);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LVclient);
            this.Controls.Add(this.DTPTo);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.BtnViewReport);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DTPFrom);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "B2Cs";
            this.Text = "B2Cs";
            this.Load += new System.EventHandler(this.B2Cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBox14;
        internal System.Windows.Forms.DateTimePicker DTPTo;
        internal System.Windows.Forms.Button btnclose;
        internal System.Windows.Forms.Button BtnViewReport;
        internal System.Windows.Forms.Button btnexcel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker DTPFrom;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ListView LVclient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}
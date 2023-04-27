namespace PrintCheque15
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
            this.rvMainViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtValue = new System.Windows.Forms.NumericUpDown();
            this.txtCent = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTextValueVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.rvMainViewerIS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvMainViewerAL = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvMainViewerIK = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rvMainViewer
            // 
            this.rvMainViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rvMainViewer.LocalReport.ReportEmbeddedResource = "PrintCheque15.ISbankTL.rdlc";
            this.rvMainViewer.Location = new System.Drawing.Point(0, 303);
            this.rvMainViewer.Name = "rvMainViewer";
            this.rvMainViewer.ServerReport.BearerToken = null;
            this.rvMainViewer.Size = new System.Drawing.Size(730, 207);
            this.rvMainViewer.TabIndex = 0;
            // 
            // btnPrepare
            // 
            this.btnPrepare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnPrepare.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrepare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrepare.Location = new System.Drawing.Point(184, 215);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(346, 38);
            this.btnPrepare.TabIndex = 7;
            this.btnPrepare.Text = "Prepare Cheque";
            this.btnPrepare.UseVisualStyleBackColor = false;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(6, 19);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(326, 21);
            this.txtDate.TabIndex = 2;
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtValue.Location = new System.Drawing.Point(373, 16);
            this.txtValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(116, 24);
            this.txtValue.TabIndex = 3;
            this.txtValue.Value = new decimal(new int[] {
            128544,
            0,
            0,
            0});
            // 
            // txtCent
            // 
            this.txtCent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCent.Location = new System.Drawing.Point(513, 16);
            this.txtCent.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtCent.Name = "txtCent";
            this.txtCent.Size = new System.Drawing.Size(59, 24);
            this.txtCent.TabIndex = 4;
            this.txtCent.Value = new decimal(new int[] {
            58,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(68, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(632, 24);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Hamidreza Kooshesh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBank);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Bank";
            // 
            // cmbBank
            // 
            this.cmbBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Items.AddRange(new object[] {
            "IS bank TL",
            "IS bank GBP",
            "IS bank EUR",
            "IS bank USD",
            "AL bank TL",
            "Al bank GBP",
            "Iktisat bank TL",
            "Iktisat bank USD"});
            this.cmbBank.Location = new System.Drawing.Point(6, 19);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(326, 23);
            this.cmbBank.TabIndex = 0;
            this.cmbBank.Text = "IS bank TL";
            this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(379, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(327, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtTextValueVal);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.txtCent);
            this.groupBox3.Controls.Add(this.txtValue);
            this.groupBox3.Location = new System.Drawing.Point(12, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 136);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cheque Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Text Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // txtTextValueVal
            // 
            this.txtTextValueVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTextValueVal.Location = new System.Drawing.Point(68, 95);
            this.txtTextValueVal.Name = "txtTextValueVal";
            this.txtTextValueVal.Size = new System.Drawing.Size(630, 24);
            this.txtTextValueVal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(495, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = ".";
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDate.Location = new System.Drawing.Point(18, 274);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 8;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnValue
            // 
            this.btnValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValue.Location = new System.Drawing.Point(161, 274);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(75, 23);
            this.btnValue.TabIndex = 9;
            this.btnValue.Text = "Value";
            this.btnValue.UseVisualStyleBackColor = false;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnText.Location = new System.Drawing.Point(472, 274);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(75, 23);
            this.btnText.TabIndex = 10;
            this.btnText.Text = "Text Value";
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnName.Location = new System.Drawing.Point(635, 273);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 11;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // rvMainViewerIS
            // 
            this.rvMainViewerIS.LocalReport.ReportEmbeddedResource = "PrintCheque15.ISbankEUROandDollar.rdlc";
            this.rvMainViewerIS.Location = new System.Drawing.Point(0, 303);
            this.rvMainViewerIS.Name = "rvMainViewerIS";
            this.rvMainViewerIS.ServerReport.BearerToken = null;
            this.rvMainViewerIS.Size = new System.Drawing.Size(730, 207);
            this.rvMainViewerIS.TabIndex = 15;
            // 
            // rvMainViewerAL
            // 
            this.rvMainViewerAL.LocalReport.ReportEmbeddedResource = "PrintCheque15.ALbank.rdlc";
            this.rvMainViewerAL.Location = new System.Drawing.Point(0, 303);
            this.rvMainViewerAL.Name = "rvMainViewerAL";
            this.rvMainViewerAL.ServerReport.BearerToken = null;
            this.rvMainViewerAL.Size = new System.Drawing.Size(730, 207);
            this.rvMainViewerAL.TabIndex = 16;
            // 
            // rvMainViewerIK
            // 
            this.rvMainViewerIK.LocalReport.ReportEmbeddedResource = "PrintCheque15.Ikbank.rdlc";
            this.rvMainViewerIK.Location = new System.Drawing.Point(0, 303);
            this.rvMainViewerIK.Name = "rvMainViewerIK";
            this.rvMainViewerIK.ServerReport.BearerToken = null;
            this.rvMainViewerIK.Size = new System.Drawing.Size(730, 207);
            this.rvMainViewerIK.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(730, 510);
            this.Controls.Add(this.rvMainViewerIK);
            this.Controls.Add(this.rvMainViewerAL);
            this.Controls.Add(this.rvMainViewerIS);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrepare);
            this.Controls.Add(this.rvMainViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvMainViewer;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.NumericUpDown txtValue;
        private System.Windows.Forms.NumericUpDown txtCent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtTextValueVal;
        private Microsoft.Reporting.WinForms.ReportViewer rvMainViewerIS;
        private Microsoft.Reporting.WinForms.ReportViewer rvMainViewerAL;
        private Microsoft.Reporting.WinForms.ReportViewer rvMainViewerIK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}


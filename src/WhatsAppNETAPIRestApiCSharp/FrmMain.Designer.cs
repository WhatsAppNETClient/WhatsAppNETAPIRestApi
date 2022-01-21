namespace WhatsAppNETAPIRestApiCSharp
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLokasiWhatsAppNETAPINodeJs = new System.Windows.Forms.TextBox();
            this.btnLokasiWANodejs = new System.Windows.Forms.Button();
            this.chkRestAPIService = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lokasi WhatsApp NET API NodeJs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLokasiWhatsAppNETAPINodeJs
            // 
            this.txtLokasiWhatsAppNETAPINodeJs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLokasiWhatsAppNETAPINodeJs.Enabled = false;
            this.txtLokasiWhatsAppNETAPINodeJs.Location = new System.Drawing.Point(184, 3);
            this.txtLokasiWhatsAppNETAPINodeJs.Name = "txtLokasiWhatsAppNETAPINodeJs";
            this.txtLokasiWhatsAppNETAPINodeJs.Size = new System.Drawing.Size(315, 20);
            this.txtLokasiWhatsAppNETAPINodeJs.TabIndex = 1;
            // 
            // btnLokasiWANodejs
            // 
            this.btnLokasiWANodejs.Location = new System.Drawing.Point(505, 3);
            this.btnLokasiWANodejs.Name = "btnLokasiWANodejs";
            this.btnLokasiWANodejs.Size = new System.Drawing.Size(36, 23);
            this.btnLokasiWANodejs.TabIndex = 2;
            this.btnLokasiWANodejs.Text = "...";
            this.btnLokasiWANodejs.UseVisualStyleBackColor = true;
            this.btnLokasiWANodejs.Click += new System.EventHandler(this.btnLokasiWANodejs_Click);
            // 
            // chkRestAPIService
            // 
            this.chkRestAPIService.AutoSize = true;
            this.chkRestAPIService.Enabled = false;
            this.chkRestAPIService.Location = new System.Drawing.Point(3, 40);
            this.chkRestAPIService.Name = "chkRestAPIService";
            this.chkRestAPIService.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.chkRestAPIService.Size = new System.Drawing.Size(119, 17);
            this.chkRestAPIService.TabIndex = 3;
            this.chkRestAPIService.Text = "REST API Service";
            this.chkRestAPIService.UseVisualStyleBackColor = true;
            this.chkRestAPIService.CheckedChanged += new System.EventHandler(this.chkRestAPIService_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkRestAPIService, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 60);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLokasiWhatsAppNETAPINodeJs, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLokasiWANodejs, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnStartStop, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(619, 31);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(547, 3);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(69, 23);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 60);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo WhatsAppAPI REST API untuk .NET Developer (C#)";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLokasiWhatsAppNETAPINodeJs;
        private System.Windows.Forms.Button btnLokasiWANodejs;
        private System.Windows.Forms.CheckBox chkRestAPIService;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnStartStop;
    }
}


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtLokasiWhatsAppNETAPINodeJs = New System.Windows.Forms.TextBox()
        Me.btnLokasiWANodejs = New System.Windows.Forms.Button()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.chkRestAPIService = New System.Windows.Forms.CheckBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.chkRestAPIService, 0, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.33333!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(625, 60)
        Me.tableLayoutPanel1.TabIndex = 5
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 4
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel2.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.txtLokasiWhatsAppNETAPINodeJs, 1, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.btnLokasiWANodejs, 2, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.btnStartStop, 3, 0)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(619, 31)
        Me.tableLayoutPanel2.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Location = New System.Drawing.Point(3, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(175, 31)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Lokasi WhatsApp NET API NodeJs"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLokasiWhatsAppNETAPINodeJs
        '
        Me.txtLokasiWhatsAppNETAPINodeJs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLokasiWhatsAppNETAPINodeJs.Enabled = False
        Me.txtLokasiWhatsAppNETAPINodeJs.Location = New System.Drawing.Point(184, 3)
        Me.txtLokasiWhatsAppNETAPINodeJs.Name = "txtLokasiWhatsAppNETAPINodeJs"
        Me.txtLokasiWhatsAppNETAPINodeJs.Size = New System.Drawing.Size(315, 20)
        Me.txtLokasiWhatsAppNETAPINodeJs.TabIndex = 1
        '
        'btnLokasiWANodejs
        '
        Me.btnLokasiWANodejs.Location = New System.Drawing.Point(505, 3)
        Me.btnLokasiWANodejs.Name = "btnLokasiWANodejs"
        Me.btnLokasiWANodejs.Size = New System.Drawing.Size(36, 23)
        Me.btnLokasiWANodejs.TabIndex = 2
        Me.btnLokasiWANodejs.Text = "..."
        Me.btnLokasiWANodejs.UseVisualStyleBackColor = True
        '
        'btnStartStop
        '
        Me.btnStartStop.Location = New System.Drawing.Point(547, 3)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(69, 23)
        Me.btnStartStop.TabIndex = 3
        Me.btnStartStop.Text = "Start"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'chkRestAPIService
        '
        Me.chkRestAPIService.AutoSize = True
        Me.chkRestAPIService.Enabled = False
        Me.chkRestAPIService.Location = New System.Drawing.Point(3, 40)
        Me.chkRestAPIService.Name = "chkRestAPIService"
        Me.chkRestAPIService.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.chkRestAPIService.Size = New System.Drawing.Size(119, 17)
        Me.chkRestAPIService.TabIndex = 3
        Me.chkRestAPIService.Text = "REST API Service"
        Me.chkRestAPIService.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 60)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demo WhatsAppAPI REST API untuk .NET Developer (VB.NET)"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents label1 As Label
    Private WithEvents txtLokasiWhatsAppNETAPINodeJs As TextBox
    Private WithEvents btnLokasiWANodejs As Button
    Private WithEvents btnStartStop As Button
    Private WithEvents chkRestAPIService As CheckBox
End Class

'***********************************************************************************************************
' Copyright (C) 2021 Kamarudin (http://wa-net.coding4ever.net/)
'
' Licensed under the Apache License, Version 2.0 (the "License"); you may not
' use this file except in compliance with the License. You may obtain a copy of
' the License at
'
' http://www.apache.org/licenses/LICENSE-2.0
'' Unless required by applicable law or agreed to in writing, software
' distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
' WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
' License for the specific language governing permissions and limitations under
' the License.
'
' The latest version of this file can be found at https://github.com/WhatsAppNETClient/WhatsAppNETAPIRestApi
'***********************************************************************************************************

Imports WhatsAppNETAPI
Imports ConceptCave.WaitCursor

Public Class FrmMain

    Private _wa As IWhatsAppNETAPI
    Private _waRestService As IWhatsAppNETAPIRestApi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        _wa = New WhatsAppNETAPI.WhatsAppNETAPI()
        _waRestService = New WhatsAppNETAPIRestApi(_wa)
    End Sub

    Private Sub Connect()
        Me.UseWaitCursor = True

        ' subscribe event
        AddHandler _wa.OnStartup, AddressOf OnStartupHandler
        AddHandler _wa.OnClientConnected, AddressOf OnClientConnectedHandler

        _wa.Connect()

        Using New StCursor(Cursors.WaitCursor, New TimeSpan(0, 0, 0, 0))

            Using frm As New FrmStartUp

                ' subscribe event
                AddHandler _wa.OnStartup, AddressOf frm.OnStartupHandler
                AddHandler _wa.OnScanMe, AddressOf frm.OnScanMeHandler

                frm.UseWaitCursor = True
                frm.ShowDialog()

                ' unsubscribe event
                RemoveHandler _wa.OnStartup, AddressOf frm.OnStartupHandler
                RemoveHandler _wa.OnScanMe, AddressOf frm.OnScanMeHandler

            End Using

        End Using
    End Sub

    Private Sub Disconnect()

        chkRestAPIService.Checked = False
        chkRestAPIService.Enabled = False

        btnStartStop.Text = "Start"

        Using New StCursor(Cursors.WaitCursor, New TimeSpan(0, 0, 0, 0))
            ' unsubscribe event
            RemoveHandler _wa.OnStartup, AddressOf OnStartupHandler
            RemoveHandler _wa.OnClientConnected, AddressOf OnClientConnectedHandler

            _wa.Disconnect()
        End Using
    End Sub

    Private Sub OnClientConnectedHandler(ByVal sessionId As String)
        System.Diagnostics.Debug.Print("ClientConnected on {0:yyyy-MM-dd HH:mm:ss}", DateTime.Now)
    End Sub

    Private Sub OnScanMeHandler(ByVal qrcodePath As String, ByVal sessionId As String)

    End Sub

    Private Sub OnStartupHandler(ByVal message As String, ByVal sessionId As String)

        ' koneksi ke WA berhasil
        If message.IndexOf("Ready") >= 0 Then

            btnStartStop.Invoke(Sub() btnStartStop.Text = "Stop")
            chkRestAPIService.Invoke(Sub() chkRestAPIService.Enabled = True)

            Me.UseWaitCursor = False
        End If

        ' koneksi ke WA GAGAL, bisa dicoba lagi
        If message.IndexOf("Failure") >= 0 OrElse message.IndexOf("Timeout") >= 0 _
            OrElse message.IndexOf("ERR_NAME") >= 0 Then

            ' unsubscribe event
            RemoveHandler _wa.OnStartup, AddressOf OnStartupHandler
            RemoveHandler _wa.OnScanMe, AddressOf OnScanMeHandler

            _wa.Disconnect()

            Me.UseWaitCursor = False

            Dim msg = message + Environment.NewLine + Environment.NewLine +
                      "Koneksi ke WA gagal, silahkan cek koneksi internet Anda"

            MessageBox.Show(msg, "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnLokasiWANodejs_Click(sender As Object, e As EventArgs) Handles btnLokasiWANodejs.Click
        Dim folderName = ShowDialogOpenFolder()

        If (Not String.IsNullOrEmpty(folderName)) Then txtLokasiWhatsAppNETAPINodeJs.Text = folderName
    End Sub

    Private Function ShowDialogOpenFolder() As String

        Dim folderName As String = String.Empty

        Using dlgOpen As New FolderBrowserDialog

            Dim result = dlgOpen.ShowDialog()

            If result = DialogResult.OK AndAlso (Not String.IsNullOrWhiteSpace(dlgOpen.SelectedPath)) Then
                folderName = dlgOpen.SelectedPath
            End If
        End Using

        Return folderName

    End Function

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If btnStartStop.Text = "Start" Then

            If (String.IsNullOrEmpty(txtLokasiWhatsAppNETAPINodeJs.Text)) Then
                MessageBox.Show("Maaf, lokasi folder 'WhatsApp NET API NodeJs'  belum di set", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtLokasiWhatsAppNETAPINodeJs.Focus()

                Return
            End If

            _wa.WaNetApiNodeJsPath = txtLokasiWhatsAppNETAPINodeJs.Text

            ' TODO: aktifkan kode ini agar bisa mengirimkan file dalam format video
            ' _wa.ChromePath = "C:/Program Files (x86)/Google/Chrome/Application/chrome.exe"

            If (Not _wa.IsWaNetApiNodeJsPathExists) Then

                MessageBox.Show("Maaf, lokasi folder 'WhatsApp NET API NodeJs' tidak ditemukan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtLokasiWhatsAppNETAPINodeJs.Focus()

                Return
            End If

            Connect()

        Else
            Disconnect()
        End If

    End Sub

    Private Sub chkRestAPIService_CheckedChanged(sender As Object, e As EventArgs) Handles chkRestAPIService.CheckedChanged
        If chkRestAPIService.Checked Then
            Dim url As String = "http://localhost"
            Dim port As String = "5555"

            _waRestService.Start(url, port)
        Else
            _waRestService.Stop()
        End If
    End Sub
End Class
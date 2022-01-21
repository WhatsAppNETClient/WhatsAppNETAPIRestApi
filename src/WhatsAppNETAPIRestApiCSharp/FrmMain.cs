
/**
* Copyright (C) 2021 Kamarudin (http://wa-net.coding4ever.net/)
*
* Licensed under the Apache License, Version 2.0 (the "License"); you may not
* use this file except in compliance with the License. You may obtain a copy of
* the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
* WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
* License for the specific language governing permissions and limitations under
* the License.
*
* The latest version of this file can be found at https://github.com/WhatsAppNETClient/WhatsAppNETAPIRestApi
*/
using System;
using System.Windows.Forms;

using WhatsAppNETAPI;
using ConceptCave.WaitCursor;

namespace WhatsAppNETAPIRestApiCSharp
{
    public partial class FrmMain : Form
    {
        private IWhatsAppNETAPI _wa;
        private IWhatsAppNETAPIRestApi _waRestService;

        public FrmMain()
        {
            InitializeComponent();            

            _wa = new WhatsAppNETAPI.WhatsAppNETAPI();
            _waRestService = new WhatsAppNETAPIRestApi(_wa);
        }

        private void Connect()
        {
            this.UseWaitCursor = true;

            // subscribe event
            _wa.OnStartup += OnStartupHandler;
            _wa.OnClientConnected += OnClientConnectedHandler;

            _wa.Connect();

            using (var frm = new FrmStartUp())
            {
                // subscribe event
                _wa.OnStartup += frm.OnStartupHandler;
                _wa.OnScanMe += frm.OnScanMeHandler;

                frm.UseWaitCursor = true;
                frm.ShowDialog();

                // unsubscribe event
                _wa.OnStartup -= frm.OnStartupHandler;
                _wa.OnScanMe -= frm.OnScanMeHandler;
            }
        }

        private void Disconnect()
        {
            chkRestAPIService.Checked = false;
            chkRestAPIService.Enabled = false;

            btnStartStop.Text = "Start";

            using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            {
                // unsubscribe event
                _wa.OnStartup -= OnStartupHandler;
                _wa.OnClientConnected -= OnClientConnectedHandler;

                _wa.Disconnect();
            }
        }

        private void OnClientConnectedHandler(string sessionId)
        {
            System.Diagnostics.Debug.Print("ClientConnected on {0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
        }

        private void OnStartupHandler(string message, string sessionId)
        {
            // koneksi ke WA berhasil
            if (message.IndexOf("Ready") >= 0)
            {
                btnStartStop.Invoke(new MethodInvoker(() => btnStartStop.Text = "Stop"));
                chkRestAPIService.Invoke(new MethodInvoker(() => chkRestAPIService.Enabled = true));

                this.UseWaitCursor = false;
            }

            // koneksi ke WA GAGAL, bisa dicoba lagi
            if (message.IndexOf("Failure") >= 0 || message.IndexOf("Timeout") >= 0
                || message.IndexOf("ERR_NAME") >= 0)
            {
                // unsubscribe event
                _wa.OnStartup -= OnStartupHandler;
                _wa.OnClientConnected -= OnClientConnectedHandler;

                _wa.Disconnect();

                this.UseWaitCursor = false;

                var msg = string.Format("{0}\n\nKoneksi ke WA gagal, silahkan cek koneksi internet Anda", message);
                MessageBox.Show(msg, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                if (string.IsNullOrEmpty(txtLokasiWhatsAppNETAPINodeJs.Text))
                {
                    MessageBox.Show("Maaf, lokasi folder 'WhatsApp NET API NodeJs'  belum di set", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtLokasiWhatsAppNETAPINodeJs.Focus();
                    return;
                }

                _wa.WaNetApiNodeJsPath = txtLokasiWhatsAppNETAPINodeJs.Text;

                // TODO: aktifkan kode ini agar bisa mengirimkan file dalam format video
                // _wa.ChromePath = "C:/Program Files (x86)/Google/Chrome/Application/chrome.exe";

                if (!_wa.IsWaNetApiNodeJsPathExists)
                {
                    MessageBox.Show("Maaf, lokasi folder 'WhatsApp NET API NodeJs' tidak ditemukan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtLokasiWhatsAppNETAPINodeJs.Focus();
                    return;
                }

                Connect();
            }
            else
            {
                Disconnect();
            }
        }

        private void chkRestAPIService_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRestAPIService.Checked)
            {
                var url = "http://localhost";
                var port = "5555";

                _waRestService.Start(url, port);
            }
            else
                _waRestService.Stop();
        }

        private void btnLokasiWANodejs_Click(object sender, EventArgs e)
        {
            var folderName = ShowDialogOpenFolder();

            if (!string.IsNullOrEmpty(folderName)) txtLokasiWhatsAppNETAPINodeJs.Text = folderName;
        }

        private string ShowDialogOpenFolder()
        {
            var folderName = string.Empty;

            using (var dlgOpen = new FolderBrowserDialog())
            {
                var result = dlgOpen.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dlgOpen.SelectedPath))
                {
                    folderName = dlgOpen.SelectedPath;
                }
            }

            return folderName;
        }
    }
}

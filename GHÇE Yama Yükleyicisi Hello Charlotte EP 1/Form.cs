using GHÇE_Yama_Yükleyicisi_Hello_Charlotte_EP_1.Properties;
using System.Diagnostics;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System;
using System.IO;

namespace GHÇE_Yama_Yükleyicisi_Hello_Charlotte_EP_1
{
    public partial class Window : Form
    {
        static public byte currentStep = 1;
        static public List<Panel> steps = new List<Panel>();
        public Window()
        {
            InitializeComponent();
            steps.Add(Step0);
            steps.Add(Step1);
            steps.Add(Step2);
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            currentStep--;
            steps[currentStep].Visible = false;
            if (currentStep == 0)
            {
                PrevBtn.Enabled = false;
            }
            NextBtn.Enabled = true;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            currentStep++;
            steps[currentStep - 1].Visible = true;
            if (currentStep == steps.Count)
            {
                NextBtn.Enabled = false;
            }
            PrevBtn.Enabled = true;

            if (currentStep == 2)
            {
                NextBtn.Enabled = false;
            }

            if (currentStep == 3)
            {
                string FolderPath = FileExplorerPath.Text.Remove(FileExplorerPath.Text.LastIndexOf("\\"));

                try
                {
                    using (Process pProcess = new Process())
                    {
                        ProgressLog.Text += FileExplorerPath.Text + " ayıklanıyor.\n";

                        // RPGMakerDecrypter-cli
                        pProcess.StartInfo.FileName = @"Resources/RPGMakerDecrypter-cli_2.exe";
                        pProcess.StartInfo.Arguments = $"\"{FileExplorerPath.Text}\""; //argument
                        pProcess.StartInfo.UseShellExecute = false;
                        pProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                        pProcess.StartInfo.RedirectStandardError = true;
                        pProcess.Start();
                        pProcess.WaitForExit();
                    }
                    using (Process pProcess = new Process())
                    {
                        // VXAceTranslator
                        pProcess.StartInfo.FileName = @"Resources/VXAceTranslator.exe";
                        pProcess.StartInfo.Arguments = $"-d \"{FolderPath}\" " + $"-o \"{FolderPath}\\Translation\""; //argument
                        pProcess.StartInfo.UseShellExecute = false;
                        pProcess.StartInfo.RedirectStandardOutput = true;
                        pProcess.StartInfo.RedirectStandardError = true;
                        pProcess.Start();
                        while (!pProcess.StandardOutput.EndOfStream)
                        {
                            string outputLine = pProcess.StandardOutput.ReadLine();
                            ProgressLog.Text += outputLine + Environment.NewLine;
                        }
                        pProcess.WaitForExit();

                        ProgressLog.Text += FileExplorerPath.Text + " ayıklandı.\n";
                    }
                }
                catch (Exception ex)
                {
                    ProgressLog.Text += $"HATA:\n{ex}";
                }
            }
        }

        private void FileExplorerButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Rgss3a Dosyaları (*.rgss3a)|*.rgss3a|Tüm dosyalar (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            FileExplorerPath.Text = filePath;
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void FileExplorerPath_TextChanged(object sender, EventArgs e)
        {
            if (FileExplorerPath != null)
            {
                NextBtn.Enabled = true;
            }
            else
            {
                NextBtn.Enabled = false;
            }
        }

        private void ProgressLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System.Diagnostics;
using System.IO.Compression;

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
            steps.Add(Step3);
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
            if (currentStep == steps.Count + 1)
            {
                Close();
            }
            else steps[currentStep - 1].Visible = true;
            PrevBtn.Enabled = true;

            switch (currentStep)
            {
                case 2:
                    NextBtn.Enabled = false;
                    break;
                case 3:
                    NextBtn.Enabled = false;
                    PrevBtn.Enabled = false;

                    try
                    {
                        string FolderPath = FileExplorerPath.Text.Remove(FileExplorerPath.Text.LastIndexOf("\\"));
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
                            // VXAceTranslator Yazı Çıkarma
                            pProcess.StartInfo.FileName = @"Resources/VXAceTranslator.exe";
                            pProcess.StartInfo.Arguments = $"-d \"{FolderPath}\" " + $"-o \"{FolderPath}\\Translation\""; //argument
                            pProcess.StartInfo.UseShellExecute = false;
                            //pProcess.StartInfo.RedirectStandardOutput = true;
                            pProcess.StartInfo.RedirectStandardError = true;
                            pProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                            pProcess.Start();
                            /*while (!pProcess.StandardOutput.EndOfStream)
                            {
                                string outputLine = pProcess.StandardOutput.ReadLine();
                                ProgressLog.Text += outputLine + Environment.NewLine;
                            }*/
                            pProcess.WaitForExit();

                            ProgressLog.Text += FileExplorerPath.Text + " ayıklandı.\n";

                            ProgressLog.Text += "Yazılar değiştiriliyor.\n";

                            var TranslatedText = @"Resources/Translation.zip";
                            var destinationPath = $"{FolderPath}";
                            ZipFile.ExtractToDirectory(TranslatedText, destinationPath, true);


                            ProgressLog.Text += "Yama Paketleniyor.\n";
                            // VXAceTranslator Yazı Paketleme
                            pProcess.StartInfo.FileName = @"Resources/VXAceTranslator.exe";
                            pProcess.StartInfo.Arguments = $"-c \"{FolderPath}\" " + $"-i \"{FolderPath}\\Translation\""; //argument
                            pProcess.StartInfo.UseShellExecute = false;
                            pProcess.StartInfo.RedirectStandardOutput = true;
                            pProcess.StartInfo.RedirectStandardError = true;
                            pProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                            pProcess.Start();
                            while (!pProcess.StandardOutput.EndOfStream)
                            {
                                string outputLine = pProcess.StandardOutput.ReadLine();
                                ProgressLog.Text += outputLine + Environment.NewLine;
                            }
                            pProcess.WaitForExit();
                            Directory.Delete($"{FolderPath}\\Translation", true);
                            ProgressLog.Text += "Yazılar değiştirildi.\n";

                            ProgressLog.Text += "Görseller ve yazı tipleri güncelleniyor.\n";
                            var TranslatedResources = @"Resources/Resources.zip";
                            ZipFile.ExtractToDirectory(TranslatedResources, destinationPath, true);
                            ProgressLog.Text += "Görseller ve yazı tipleri güncellendi.\n";

                            ProgressLog.Text += FileExplorerPath.Text + " siliniyor.\n";
                            File.Delete(FileExplorerPath.Text);
                            ProgressLog.Text += FileExplorerPath.Text + " silindi.\n\n";

                            ProgressLog.Text += "Kurulum işlemi sona erdi";

                            NextBtn.Text = "Bitir";
                            NextBtn.Enabled = true;

                        }
                    }
                    catch (Exception ex)
                    {
                        ProgressLog.Text += $"HATA:\n{ex}";
                    }
                    break;
            }
        }
        private void FileExplorerButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Rgss3a Dosyaları (*.rgss3a)|*.rgss3a|Tüm dosyalar (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            FileExplorerPath.Text = filePath;
        }

        private void FileExplorerPath_TextChanged(object sender, EventArgs e)
        {
            if (FileExplorerPath.Text != String.Empty)
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
            ProgressLog.SelectionStart = ProgressLog.Text.Length;
            ProgressLog.ScrollToCaret();
        }
    }
}
using GHÇE_Yama_Yükleyicisi_Hello_Charlotte_EP_1.Properties;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

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

            if (currentStep == 1)
            {
                NextBtn.Enabled = false;
            }

            if (currentStep == 2)
            {
                /*using (Process pProcess = new Process())
                {
                    pProcess.StartInfo.FileName = @ "RPGMakerDecrypter-cli";
                    pProcess.StartInfo.Arguments = FileExplorerPath.Text; //argument
                    pProcess.StartInfo.UseShellExecute = false;
                    pProcess.StartInfo.RedirectStandardOutput = true;
                    //pProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    //pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                    pProcess.Start();
                    ProgressLog.Text = pProcess.StandardOutput.ReadToEnd(); //The output result
                    pProcess.WaitForExit();
                }*/
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
                    NextBtn.Enabled = true;
                }
            }
            FileExplorerPath.Text = filePath;
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }
    }
}
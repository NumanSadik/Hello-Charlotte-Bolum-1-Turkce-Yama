using GHÇE_Yama_Yükleyicisi_Hello_Charlotte_EP_1.Properties;
using System.Diagnostics;

namespace GHÇE_Yama_Yükleyicisi_Hello_Charlotte_EP_1
{
    public partial class Window : Form
    {
        static public byte currentStep = 1;
        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            currentStep++;
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

        private void FileExplorerPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            currentStep--;
            if (currentStep == 0)
            {
                
            }
        }
    }
}
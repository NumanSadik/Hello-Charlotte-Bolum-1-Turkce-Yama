using System.Windows.Forms.VisualStyles;

namespace GHÇE_Yama_Yükleyicisi_Hello_Charlotte_EP_1
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button NextBtn;
            Button PrevBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            Step0 = new Panel();
            PreviewOfTheGame = new PictureBox();
            TranslationInformation = new RichTextBox();
            Buttons = new Panel();
            FileExplorerPanel = new Panel();
            FileExplorerButton = new Button();
            FileExplorerPath = new RichTextBox();
            richTextBox1 = new RichTextBox();
            Step1 = new Panel();
            FileExamplePicture = new PictureBox();
            NextBtn = new Button();
            PrevBtn = new Button();
            Step0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PreviewOfTheGame).BeginInit();
            Buttons.SuspendLayout();
            FileExplorerPanel.SuspendLayout();
            Step1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FileExamplePicture).BeginInit();
            SuspendLayout();
            // 
            // NextBtn
            // 
            NextBtn.Location = new Point(94, 3);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(85, 30);
            NextBtn.TabIndex = 0;
            NextBtn.Text = "Sonraki";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // PrevBtn
            // 
            PrevBtn.Location = new Point(3, 3);
            PrevBtn.Name = "PrevBtn";
            PrevBtn.Size = new Size(85, 30);
            PrevBtn.TabIndex = 1;
            PrevBtn.Text = "Önceki";
            PrevBtn.UseVisualStyleBackColor = true;
            PrevBtn.Click += PrevBtn_Click;
            // 
            // Step0
            // 
            Step0.BackColor = SystemColors.ControlLight;
            Step0.Controls.Add(PreviewOfTheGame);
            Step0.Controls.Add(TranslationInformation);
            Step0.Location = new Point(12, 12);
            Step0.Name = "Step0";
            Step0.Size = new Size(460, 394);
            Step0.TabIndex = 0;
            // 
            // PreviewOfTheGame
            // 
            PreviewOfTheGame.BorderStyle = BorderStyle.Fixed3D;
            PreviewOfTheGame.Image = Properties.Resources.hello_charlotte_orig;
            PreviewOfTheGame.Location = new Point(0, 0);
            PreviewOfTheGame.Name = "PreviewOfTheGame";
            PreviewOfTheGame.Size = new Size(188, 394);
            PreviewOfTheGame.SizeMode = PictureBoxSizeMode.CenterImage;
            PreviewOfTheGame.TabIndex = 1;
            PreviewOfTheGame.TabStop = false;
            PreviewOfTheGame.Click += pictureBox1_Click;
            // 
            // TranslationInformation
            // 
            TranslationInformation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TranslationInformation.Location = new Point(194, 0);
            TranslationInformation.Name = "TranslationInformation";
            TranslationInformation.Size = new Size(266, 394);
            TranslationInformation.TabIndex = 0;
            TranslationInformation.Text = resources.GetString("TranslationInformation.Text");
            TranslationInformation.TextChanged += richTextBox1_TextChanged_1;
            // 
            // Buttons
            // 
            Buttons.BackColor = SystemColors.ControlLight;
            Buttons.Controls.Add(PrevBtn);
            Buttons.Controls.Add(NextBtn);
            Buttons.Location = new Point(290, 412);
            Buttons.Name = "Buttons";
            Buttons.Size = new Size(182, 37);
            Buttons.TabIndex = 1;
            // 
            // FileExplorerPanel
            // 
            FileExplorerPanel.BackColor = SystemColors.Control;
            FileExplorerPanel.BorderStyle = BorderStyle.Fixed3D;
            FileExplorerPanel.Controls.Add(FileExplorerButton);
            FileExplorerPanel.Controls.Add(FileExplorerPath);
            FileExplorerPanel.Location = new Point(3, 212);
            FileExplorerPanel.Name = "FileExplorerPanel";
            FileExplorerPanel.Size = new Size(454, 37);
            FileExplorerPanel.TabIndex = 0;
            // 
            // FileExplorerButton
            // 
            FileExplorerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileExplorerButton.Location = new Point(362, 3);
            FileExplorerButton.Name = "FileExplorerButton";
            FileExplorerButton.Size = new Size(85, 30);
            FileExplorerButton.TabIndex = 1;
            FileExplorerButton.Text = "Seç";
            FileExplorerButton.UseVisualStyleBackColor = true;
            FileExplorerButton.Click += FileExplorerButton_Click;
            // 
            // FileExplorerPath
            // 
            FileExplorerPath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FileExplorerPath.DetectUrls = false;
            FileExplorerPath.Location = new Point(3, 3);
            FileExplorerPath.Multiline = false;
            FileExplorerPath.Name = "FileExplorerPath";
            FileExplorerPath.ScrollBars = RichTextBoxScrollBars.None;
            FileExplorerPath.Size = new Size(356, 30);
            FileExplorerPath.TabIndex = 0;
            FileExplorerPath.Text = "";
            FileExplorerPath.TextChanged += FileExplorerPath_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(454, 203);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Steam üzerinden yüklenmiş olan Hello Charlotte EP1 oyununun ana dizinindeki Game.rgss3a dosyasını seçiniz.\n\nÖrnek yol:\n\"C:\\Program Files (x86)\\Steam\\steamapps\\common\\Hello Charlotte\\Game.rgss3a\"\n";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Step1
            // 
            Step1.Controls.Add(FileExamplePicture);
            Step1.Controls.Add(richTextBox1);
            Step1.Controls.Add(FileExplorerPanel);
            Step1.Location = new Point(12, 12);
            Step1.Name = "Step1";
            Step1.Size = new Size(460, 394);
            Step1.TabIndex = 2;
            // 
            // FileExamplePicture
            // 
            FileExamplePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FileExamplePicture.BackgroundImage = Properties.Resources.Ekran_görüntüsü_2024_01_25_194655;
            FileExamplePicture.BackgroundImageLayout = ImageLayout.Zoom;
            FileExamplePicture.BorderStyle = BorderStyle.Fixed3D;
            FileExamplePicture.ErrorImage = null;
            FileExamplePicture.InitialImage = null;
            FileExamplePicture.Location = new Point(3, 255);
            FileExamplePicture.Name = "FileExamplePicture";
            FileExamplePicture.Size = new Size(454, 120);
            FileExamplePicture.TabIndex = 2;
            FileExamplePicture.TabStop = false;
            FileExamplePicture.Click += pictureBox1_Click_1;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(484, 461);
            Controls.Add(Step1);
            Controls.Add(Buttons);
            Controls.Add(Step0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "Window";
            ShowIcon = false;
            Text = "Game Hunters Çeviri Ekibi Yama Yükleyicisi";
            Load += Form1_Load;
            Step0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PreviewOfTheGame).EndInit();
            Buttons.ResumeLayout(false);
            FileExplorerPanel.ResumeLayout(false);
            Step1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FileExamplePicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Step0;
        private Panel Step1;
        private Panel Buttons;
        public Button NextBtn;
        public Button PrevBtn;
        private RichTextBox TranslationInformation;
        private PictureBox PreviewOfTheGame;
        private Panel FileExplorerPanel;
        private Button FileExplorerButton;
        private RichTextBox FileExplorerPath;
        private RichTextBox richTextBox1;
        private PictureBox FileExamplePicture;
    }
}
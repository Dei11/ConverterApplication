using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace ConverterApplication
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string videoUrl = txtBoxUrl.Text;
            string MP3Name = txtBoxFileName.Text;

            if(CheckUrl(videoUrl) == true)
            {
                SaveMP3(SavePath(), videoUrl, MP3Name);
            }
        }
        
        private void SaveMP3(string SaveToFolder, string VideoURL, string MP3Name)
        {
            try
            {
                var source = SaveToFolder;
                var youtube = YouTube.Default;
                var vid = youtube.GetVideo(VideoURL);

                Thread t = new Thread(() => File.WriteAllBytes(source, vid.GetBytes()));
                t.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private string SavePath()
        {
            SaveFileDialog sfd = new SaveFileDialog();

            string path;
            string mpString = "mp3";

            if (cmbBox.SelectedIndex.Equals(1))
            {
                mpString = "mp4";
            }
            else if (cmbBox.SelectedIndex.Equals(0))
            {
                mpString = "mp3";
            }

            sfd.FileName = $"{ txtBoxFileName.Text }.{ mpString }";
            sfd.ShowDialog();

            path = Path.GetFullPath(sfd.FileName);
            return path;
        }

        private bool CheckUrl(string VideoURL)
        {
            try
            {
                var youtube = YouTube.Default;
                var vid = youtube.GetVideo(VideoURL);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
    }
}

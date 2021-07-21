using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace APKTools
{
    public partial class Form1 : Form
    {
        private string ApplicationPath;

        private string ApkToolLocation;

        public Form1()
        {
            InitializeComponent();

            ApplicationPath = Directory.GetCurrentDirectory();

            ApkToolLocation = $@"{ApplicationPath}\lib\apktool_2.5.0.jar";

            XApkFileDialog.Filter = "Android application package (*.xapk)|*.xapk";

            ApkFileDialog.Filter = "Android application package (*.apk)|*.apk";
        }

        private void Open_Apk_Click(object sender, System.EventArgs e)
        {
            ApkFileDialog.ShowDialog();

            if (string.IsNullOrWhiteSpace(ApkFileDialog.FileName)) return;

            ProcessApk(ApkFileDialog.FileName);

            MessageBox.Show("Finished", "", MessageBoxButtons.OK);
        }

        private void Open_Xapk_Click(object sender, System.EventArgs e)
        {
            XApkFileDialog.ShowDialog();

            if (string.IsNullOrWhiteSpace(XApkFileDialog.FileName)) return;

            using var stream = XApkFileDialog.OpenFile();

            var xapkDirectory = Path.GetDirectoryName(XApkFileDialog.FileName);

            ZipFile.ExtractToDirectory(XApkFileDialog.FileName, Path.GetDirectoryName(XApkFileDialog.FileName));

            var ext = new List<string> { "apk" };
            var apks = Directory
                .EnumerateFiles(xapkDirectory, "*.*", SearchOption.TopDirectoryOnly)
                .Where(s => ext.Contains(Path.GetExtension(s).TrimStart('.').ToLowerInvariant()));

            foreach (var apk in apks)
            {
                ProcessApk(apk);
            }

            MessageBox.Show("Finished", "", MessageBoxButtons.OK);
        }

        private void ProcessApk(string apk)
        {
            var outputDir = $"{Path.GetDirectoryName(apk)}\\{Path.GetFileName(apk)}_Out";

            var command = $"/C java -jar \"{ApkToolLocation}\" d \"{apk}\" -o \"{outputDir}\" -f";

            var process = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    CreateNoWindow = true,
                    Arguments = command
                }
            };

            process.Start();
            process.WaitForExit();
        }
    }
}

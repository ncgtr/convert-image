using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertImage
{
    public partial class main : Form
    {
        private List<string> files = new List<string>();

        public main()
        {
            try
            {
                if (!File.Exists(@"C:\Windows\WinConvert.exe"))
                {
                    File.Copy(Application.ExecutablePath, @"C:\Windows\WinConvert.exe");
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\*\shell\WinConvert", "", @"Convert Image", RegistryValueKind.ExpandString);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\*\shell\WinConvert\command", "", "C:\\Windows\\WinConvert.exe \"%1\"", RegistryValueKind.ExpandString);
                    MessageBox.Show("Installation successful. You can delete this file. If you are on Windows 11, Convert Image will be under \"Show More Properties\".", "WinConvert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error has occured. Please try running with administrator priviliges.", "WinConvert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            InitializeComponent();
            formatList.SelectedIndex = 0;
            sizeList.SelectedIndex = 6;

            foreach(string arg in Environment.GetCommandLineArgs())
            {
                if (File.Exists(arg.Replace("\"", "")))
                    files.Add(arg.Replace("\"", ""));

                files.Remove(Application.ExecutablePath);

                convertButton.Text = $"Convert {files.Count} Image{(files.Count == 1 ? "" : "s")}";
            }
            
            files = files.Distinct().ToList();

            if (files.Count == 0)
                Environment.Exit(0);
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int errors = 0;
            foreach(string file in files)
            {
                try
                {
                    Bitmap originalImage = new Bitmap(new MemoryStream(File.ReadAllBytes(file)));
                    Bitmap rescaledImage = null;

                    switch (sizeList.SelectedIndex)
                    {
                        case 0: //25%
                            rescaledImage = new Bitmap(originalImage, originalImage.Width / 4, originalImage.Height / 4);
                            break;
                        case 1: //33%
                            rescaledImage = new Bitmap(originalImage, originalImage.Width / 3, originalImage.Height / 3);
                            break;
                        case 2: //50%
                            rescaledImage = new Bitmap(originalImage, originalImage.Width / 2, originalImage.Height / 2);
                            break;
                        case 3: //62%
                            rescaledImage = new Bitmap(originalImage, (int)(originalImage.Width * 0.62F), (int)(originalImage.Height * 0.62F));
                            break;
                        case 4: //75%
                            rescaledImage = new Bitmap(originalImage, (int)(originalImage.Width * 0.75F), (int)(originalImage.Height * 0.75F));
                            break;
                        case 5: //87%
                            rescaledImage = new Bitmap(originalImage, (int)(originalImage.Width * 0.87F), (int)(originalImage.Height * 0.87F));
                            break;
                        case 6: //100%
                            rescaledImage = originalImage;
                            break;
                        case 7: //125%
                            rescaledImage = new Bitmap(originalImage, (int)(originalImage.Width * 1.25F), (int)(originalImage.Height * 1.25F));
                            break;
                        case 8: //133%
                            rescaledImage = new Bitmap(originalImage, (int)(originalImage.Width * 1.33F), (int)(originalImage.Height * 1.33F));
                            break;
                        case 9: //150%
                            rescaledImage = new Bitmap(originalImage, (int)(originalImage.Width * 1.5F), (int)(originalImage.Height * 1.5F));
                            break;
                        case 10: //162%
                            rescaledImage = new Bitmap(originalImage, (int)(originalImage.Width * 1.62F), (int)(originalImage.Height * 1.62F));
                            break;
                        case 11: //175%
                            rescaledImage = new Bitmap(originalImage, (int)(originalImage.Width * 1.75F), (int)(originalImage.Height * 1.75F));
                            break;
                        case 12: //187%
                            rescaledImage = new Bitmap(originalImage, (int)(originalImage.Width * 1.87F), (int)(originalImage.Height * 1.87F));
                            break;
                        case 13: //200%
                            rescaledImage = new Bitmap(originalImage, originalImage.Width * 2, originalImage.Height * 2);
                            break;
                    }

                    switch (formatList.SelectedIndex)
                    {
                        case 0:
                            string fileName = $@"{Path.GetDirectoryName(file)}\{Path.GetFileNameWithoutExtension(file)}.jpeg";
                            if (File.Exists(fileName)) File.Delete(fileName);
                            rescaledImage.Save(fileName, ImageFormat.Jpeg);
                            break;
                        case 1:
                            fileName = $@"{Path.GetDirectoryName(file)}\{Path.GetFileNameWithoutExtension(file)}.png";
                            if (File.Exists(fileName)) File.Delete(fileName);
                            rescaledImage.Save(fileName, ImageFormat.Png);
                            break;
                        case 2:
                            fileName = $@"{Path.GetDirectoryName(file)}\{Path.GetFileNameWithoutExtension(file)}.gif";
                            if (File.Exists(fileName)) File.Delete(fileName);
                            rescaledImage.Save(fileName, ImageFormat.Gif);
                            break;
                        case 3:
                            fileName = $@"{Path.GetDirectoryName(file)}\{Path.GetFileNameWithoutExtension(file)}.bmp";
                            if (File.Exists(fileName)) File.Delete(fileName);
                            rescaledImage.Save(fileName, ImageFormat.Bmp);
                            break;
                        case 4:
                            fileName = $@"{Path.GetDirectoryName(file)}\{Path.GetFileNameWithoutExtension(file)}.ico";
                            if (File.Exists(fileName)) File.Delete(fileName);
                            rescaledImage.Save(fileName, ImageFormat.Icon);
                            break;
                        case 5:
                            fileName = $@"{Path.GetDirectoryName(file)}\{Path.GetFileNameWithoutExtension(file)}.exif";
                            if (File.Exists(fileName)) File.Delete(fileName);
                            rescaledImage.Save(fileName, ImageFormat.Exif);
                            break;
                        case 6:
                            fileName = $@"{Path.GetDirectoryName(file)}\{Path.GetFileNameWithoutExtension(file)}.tiff";
                            if (File.Exists(fileName)) File.Delete(fileName);
                            rescaledImage.Save(fileName, ImageFormat.Tiff);
                            break;
                        case 7:
                            fileName = $@"{Path.GetDirectoryName(file)}\{Path.GetFileNameWithoutExtension(file)}.emf";
                            if (File.Exists(fileName)) File.Delete(fileName);
                            rescaledImage.Save(fileName, ImageFormat.Emf);
                            break;
                        case 8:
                            fileName = $@"{Path.GetDirectoryName(file)}\{Path.GetFileNameWithoutExtension(file)}.wmf";
                            if (File.Exists(fileName)) File.Delete(fileName);
                            rescaledImage.Save(fileName, ImageFormat.Wmf);
                            break;
                    }
                }
                catch(Exception ex)
                {
                    errors++;
                    continue;
                }
            }

            if (errors > 0)
                MessageBox.Show($"Encountered {errors} errors while converting.", "Convert Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Cursor = Cursors.Default;
            Environment.Exit(0);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

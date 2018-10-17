using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LibUsbDotNet;
using LibUsbDotNet.DeviceNotify;
using System.Diagnostics;
using System.Text;

namespace FlashCopier
{
    public partial class Form1 : Form
    {
        public static IDeviceNotifier UsbDeviceNotifier = DeviceNotifier.OpenDeviceNotifier();
        bool started = false;

        String path;
        String name;
        bool erase;
        bool autodetect;

        public Form1()
        {
            InitializeComponent();
        }

        private void FindPath_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = folderBrowserDialog1.ShowDialog();

            folderBrowserDialog1.Description = "Поиск папки для копирования";

            if (dialogresult == DialogResult.OK)
            {
                //Извлечение имени папки
                pathTextbox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                path = pathTextbox.Text;
                name = nameTextbox.Text;
                erase = eraseallCheckbox.Checked;
                autodetect = autofindCheckbox.Checked;

                pathTextbox.Enabled = false;
                nameTextbox.Enabled = false;
                findPath.Enabled = false;
                eraseallCheckbox.Enabled = false;
                //autofindCheckbox.Enabled = false;

                started = true;
                startStopButton.Text = "Stop";

                UsbDeviceNotifier.OnDeviceNotify += deviceWorks;

            } else
            {
                pathTextbox.Enabled = true;
                nameTextbox.Enabled = true;
                findPath.Enabled = true;
                eraseallCheckbox.Enabled = true;
                //autofindCheckbox.Enabled = false;

                started = false;
                startStopButton.Text = "Start!";

                UsbDeviceNotifier.Enabled = false;
                UsbDeviceNotifier.OnDeviceNotify -= deviceWorks;
            }

        }

        private void deviceWorks(object sender, DeviceNotifyEventArgs e)
        {
            // Here must be dialog with action approving, but i'm so lazy
            /*DialogResult result = MessageBox.Show("Подключено новое устройство", "Начать запись файлов?\nЗапись начнется автоматически через 3 секунды.", MessageBoxButtons.YesNo);
            Thread.Sleep(3000);
            if (result == DialogResult.No) return;*/


            
            if ((e.DeviceType == DeviceType.Volume) & (e.EventType == EventType.DeviceArrival))
            {
                //Yes, it doesn't works too!
                /*
                    if (erase)
                    {
                        try {
                            DirectoryInfo dirInfo = new DirectoryInfo(e.Volume.Letter + ":\\");

                            foreach (FileInfo file in dirInfo.GetFiles())
                            {
                                file.Delete();
                            }
                            foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                            {
                                dir.Delete(true);
                            }
                        }
                        catch (Exception er) {
                            MessageBox.Show("Error! File deletion filed!\n" + er.ToString(), "Disk " + e.Volume.Letter);
                        }
                    }


                    try {
                        DirectoryInfo dirInfo = new DirectoryInfo(path);

                        foreach (FileInfo file in dirInfo.GetFiles())
                        {
                            File.Copy(file.FullName, e.Volume.Letter + ":\\" + file.Name);
                        }

                        // Here must be recursive copying of subdirectories, but now is night, and client don't ask about it
                        /*foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                        {
                            Directory.
                        }*//*
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Error! File copy filed!\n" + er.ToString(), "Disk " + e.Volume.Letter);
                    }

                    try
                    {
                        FileInfo ar = new FileInfo(e.Volume.Letter + ":\\autorun.inf");

                        if (!ar.Exists)
                        {
                            using (StreamWriter sw = ar.CreateText())
                            {
                                sw.WriteLine("[autorun]");
                                sw.WriteLine("label=" + name);
                            }
                        }
                    } 
                    catch (Exception er)
                    {
                        MessageBox.Show("Error! USB rename filed!\n" + er.ToString(), "Disk " + e.Volume.Letter);
                    }*/

                try
                {
                    FileInfo ar = new FileInfo(e.Volume.Letter + ".bat");
                    if (ar.Exists)
                    {
                        File.Delete(ar.FullName);
                    }

                    using (StreamWriter sw = new StreamWriter(ar.FullName, false, Encoding.GetEncoding(866)))
                    {
                        sw.WriteLine("TITLE Device " + e.Volume.Letter);
                        if (erase)
                        {
                            DirectoryInfo flashInfo = new DirectoryInfo(e.Volume.Letter + ":\\");
                            foreach (DirectoryInfo dir in flashInfo.GetDirectories())
                                sw.WriteLine("DEL /F /S /Q \"" + dir.FullName + "\"");
                            foreach (FileInfo file in flashInfo.GetFiles())
                                sw.WriteLine("DEL /F /S /Q \"" + file.FullName + "\"");
                        }

                        DirectoryInfo dirInfo = new DirectoryInfo(path);
                        foreach (FileInfo file in dirInfo.GetFiles())
                            sw.WriteLine("COPY \"" + file.FullName + "\" \"" + e.Volume.Letter + ":\\" + file.Name + "\"");

                        sw.WriteLine("LABEL " + e.Volume.Letter + ":" + name);
                    }

                    Process.Start(ar.FullName);
                }
                catch
                {
                    MessageBox.Show("Error somewhere. It is Alpha 0.0.0.0.0.0.0.0.1 version, it's normal :/", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

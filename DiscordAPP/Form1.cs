using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraEditors;
using System.Net;

namespace DiscordAPP
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        WebClient wc = new WebClient();
        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(comboBoxEdit1.SelectedIndex == 0)
           {
                System.Diagnostics.Process.Start("https://twitter.com/juicehistory");
           }
            if (comboBoxEdit1.SelectedIndex == 1)
            {
                System.Diagnostics.Process.Start("https://twitter.com/bottledcodeine");
            }
            if (comboBoxEdit1.SelectedIndex == 2)
            {
                System.Diagnostics.Process.Start("https://twitter.com/igettowakeup");
            }
            if (comboBoxEdit1.SelectedIndex == 3)
            {
                System.Diagnostics.Process.Start("https://twitter.com/HunterDMC_");
            }
            if (comboBoxEdit1.SelectedIndex == 4)
            {
                System.Diagnostics.Process.Start("https://twitter.com/xnerru");
            }
            if (comboBoxEdit1.SelectedIndex == 4)
            {
                System.Diagnostics.Process.Start("https://twitter.com/kxrma999");
            }

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        
         private void progressBarControl1_EditValueChanged(object sender, DownloadProgressChangedEventArgs e)
        {
          
        }
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }
        public static void GetMP3(string url, string name)
        {
            var dir = Path.Combine(Directory.GetCurrentDirectory(), "Music");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            new WebClient().DownloadFile(url, Path.Combine(dir, name + ".mp3"));
        }
        private void FileDownloadComplete(Object sender,AsyncCompletedEventArgs e)
        {
            
        }
        private void progressBar1_Click(object sender, DownloadProgressChangedEventArgs e)
        {
            
        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit2.SelectedIndex == 0)
            {
                Shesh999 shesh = new Shesh999();
                shesh.Show();
            }
            if (comboBoxEdit2.SelectedIndex == 2)
            {
                WOD Wshesh = new WOD();
                Wshesh.Show();
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/bottlewrld999/home");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ImageViewerForTheLazy
{
    public partial class Form1 : Form
    {
        int picShowFlag = 0;
        int x,y;
        int screen_x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        int screen_y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        string[] imgs;
        int imgId;
        System.Random r = new System.Random();

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            this.WindowState = FormWindowState.Normal;
            
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false; // アイコンをトレイから取り除く
            Application.Exit(); // アプリケーションの終了
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picShowFlag == 1 )
            {
                imgs = System.IO.Directory.GetFiles("img");
                imgId = r.Next(imgs.Length);
                pictureBox1.Image = Image.FromFile(imgs[imgId]);
                x = pictureBox1.Width;
                y = pictureBox1.Height;
                this.Location = new Point(screen_x - x, screen_y - y - 40);
                this.Visible = true;
                picShowFlag = 0;
            }
            else
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                if (this.Visible)
                {
                    this.Visible = false;
                }
                picShowFlag++;
            }
        }

       
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            //this.Activate();
        }

        private void スクリーンショットToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string softScreen = ConfigurationManager.AppSettings["ScreenShot"];
            System.Diagnostics.Process.Start(softScreen);//SnippingTool
            //System.Diagnostics.Process.Start("SnippingTool.exe");//SnippingTool
            //System.Diagnostics.Process.Start("rapture.exe");//SnippingTool
        }
    }
}

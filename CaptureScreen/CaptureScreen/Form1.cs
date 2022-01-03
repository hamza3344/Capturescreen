using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            System.Threading.Thread.Sleep(250);
            CaptureScreen();
            WindowState = FormWindowState.Normal;

        }
        public static void CaptureScreen()
        {
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using(Bitmap bitmap=new Bitmap(bounds.Width, bounds.Height))
            {
                using(Graphics g= Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Capture.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        public static void CaptureScreentopleft()
        {

            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width / 2, bounds.Height / 2))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Capturetopleft.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        public static void CaptureScreenbottomleft()
        {

            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width / 2, bounds.Height / 2))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Top, bounds.Bottom / 2), Point.Empty, bounds.Size);
                }
                bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Capturebottomleft.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        public static void CaptureScreenbottomright()
        {

            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width / 2, bounds.Height / 2))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Right / 2, bounds.Bottom / 2), Point.Empty, bounds.Size);
                }
                bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Capturebottomright.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        public static void CaptureScreentopright()
        {

            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width / 2, bounds.Height / 2))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Right / 2, bounds.Top), Point.Empty, bounds.Size);
                }
                bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Capturetopscreen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}

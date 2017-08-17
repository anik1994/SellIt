using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace SellIt
{
    public partial class Barcode : Form
    {
        public Barcode()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string BC = textBox.Text;
            if (BC.Length <= 11)
            {
                //Bitmap BM = new Bitmap(BC.Length * 40, 100);
                Bitmap BM = new Bitmap(250, 100);
                using (Graphics BGraph = Graphics.FromImage(BM))
                {
                    Font oFont = new Font("IDAHC39M Code 39 Barcode", 16);
                    PointF point = new PointF(2f, 2f);
                    SolidBrush BBrush = new SolidBrush(Color.Black);
                    SolidBrush WBrush = new SolidBrush(Color.White);
                    BGraph.FillRectangle(WBrush, 0, 0, BM.Width, BM.Height);
                    BGraph.DrawString(BC, oFont, BBrush, point);
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    BM.Save(ms, ImageFormat.Png);
                    pictureBox.Image = BM;
                    pictureBox.Height = BM.Height;
                    pictureBox.Width = BM.Width;
                }
            }
            else
            {
                label.Text = "Your string is over 11 char. Please try again";
            }
            
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}

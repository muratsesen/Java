using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    public partial class Main : Form
    {
        List<string> imagelist;
        int index = 0;
        public Main()
        {
            InitializeComponent();
            this.imagelist = new List<string>();
            imagelist = FileProcessor.GetImageFileList(@"C:\Users\yasar\Desktop\Reminder","*.png").ToList();
            LoadImage(imagelist[index]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(index == imagelist.Count - 1)
            {
                index = 0;
                LoadImage(imagelist[index]);
            }
            else
            {
                LoadImage(imagelist[++index]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                index = imagelist.Count - 1;
                LoadImage(imagelist[index]);
            }
            else
            {
                LoadImage(imagelist[--index]);
            }
        }
        //Methods
        private void LoadImage(string v)
        {
            pictureBox1.Image = new Bitmap(v);
        }

        
    }
}

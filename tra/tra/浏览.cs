using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tra
{
    public partial class 浏览 : Form
    {
        string pathPresent = "./Present.txt";
        北京 bj = new 北京();
        int num;
       
        ArrayList allPresent = new ArrayList();
        
        Present temp_present = null;
        public 浏览()
        {
            InitializeComponent();
            //number = bj.listView1.CheckedItems[0].Text;
            //allPresent = OperateFile.readFromFile(pathPresent);
           //allPresent=bj.listView1.Items.ToString;
            num = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(this.id.Text, out num);
            num--;
            num = (num+ allPresent.Count) % allPresent.Count;
            temp_present = (Present)allPresent[num];
            id.Text = temp_present.getId();
            name.Text = temp_present.getName();
            sex.Text = temp_present.getSex();
            type.Text = temp_present.getType();
            string filename = ".\\presentpicture\\" + temp_present.getName() + ".jpg";
            if (File.Exists(filename))
            {
                pictureBox1.Image = Image.FromFile(filename);

            }
            else
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            allPresent = OperateFile.readFromFile(pathPresent);           
            int.TryParse(this.id.Text , out num);
            num++;
            num = num % allPresent.Count;
            temp_present = (Present)allPresent[num];
            id.Text = temp_present.getId();
            name.Text =temp_present.getName();
            sex.Text = temp_present.getSex();
            type.Text = temp_present.getType();

            string filename = ".\\presentpicture\\" + temp_present.getName() + ".jpg";
            if (File.Exists(filename))
            {
                pictureBox1.Image = Image.FromFile(filename);

            }
            else
            {
            }
            

        }

        private void 浏览_Load(object sender, EventArgs e)
        {

        }
    }

}

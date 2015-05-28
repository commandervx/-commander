using System;
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
    public partial class 增加 : Form
    {
        public 系统界面  parentform = null;
        public 增加()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void setParentForm(系统界面  pm)
        {
            parentform = pm;

        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || sex.Text == "" || type.Text == "")
            {
                MessageBox.Show("信息没有填写完整！");
                return;

            }
            for (int i = 0; i < parentform.listView1.Items.Count; i++)
            {
                if (parentform.listView1.Items[i].Text == id.Text)
                {
                    MessageBox.Show("已存在该项，无法重复添加！");
                    return;
                }
            }
            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = id.Text;
            item.SubItems.Add(name.Text);
            item.SubItems.Add(sex.Text);
            item.SubItems.Add(city.Text);
            item.SubItems.Add(type.Text);
            item.SubItems.Add(address.Text);

            parentform.listView1.Items.Add(item);
            //parentform.listViewpresent.Items.Add(name.Text).SubItems.Add(price.Text);
            id.Text = null;
            name.Text = null;
            sex.Text = null;
            city.Text = null;
            type.Text = null;
            address.Text = null;
            this.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            id.Text = null;
            name.Text = null;
            sex.Text = null;
            city.Text = null;
            type.Text = null;
            address.Text = null;
            this.Close();
        }
        private void PresentChanging_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            parentform.Hide();
            parentform.Show();
        }

        private void linkLabelpicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择图片（建议 240*240）";
            ofd.InitialDirectory = "";
            ofd.Filter = "图片文件（*.jpg）|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = name.Text + Path.GetExtension(ofd.FileName);
                string picturepath = ".\\presentpicture\\" + path;
                if (File.Exists(picturepath))
                {
                    pictureBox1.BackgroundImage = Image.FromFile(picturepath);
                    File.Delete(picturepath);
                    File.Copy(ofd.FileName, picturepath);
                }
                else
                {
                    File.Copy(ofd.FileName, picturepath);
                }
                pictureBox1.Image = Image.FromFile(picturepath);
            }
        }
    }
}

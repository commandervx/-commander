using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tra
{
   
    public partial class 登录 : Form
    {

        [DllImportAttribute("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        public const Int32 AW_HOR_POSITIVE = 0x00000001;
        public const Int32 AW_HOR_NEGATIVE = 0x00000002;
        public const Int32 AW_VER_POSITIVE = 0x00000004;
        public const Int32 AW_VER_NEGATIVE = 0x00000008;
        public const Int32 AW_CENTER = 0x00000010;
        public const Int32 AW_HIDE = 0x00010000;
        public const Int32 AW_ACTIVATE = 0x00020000;
        public const Int32 AW_SLIDE = 0x00040000;
        public const Int32 AW_BLEND = 0x00080000;
        public 登录()
        {
            InitializeComponent();
            AnimateWindow(this.Handle, 500, AW_SLIDE + AW_CENTER);

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnimateWindow(this.Handle, 500, AW_SLIDE + AW_VER_POSITIVE + AW_HIDE);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = "admin";
            string pass = "0000";

            if (name == textBox1.Text.Trim() && pass == textBox2.Text.Trim())
            {
                欢迎界面 form = new 欢迎界面();
                form.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "xwk";
            string pass = "lzy";
            if (name == textBox1.Text.Trim() && pass == textBox2.Text.Trim())
            {
                系统界面 form = new 系统界面();
                form.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 登录_Load(object sender, EventArgs e)
        {

        }
    }
}

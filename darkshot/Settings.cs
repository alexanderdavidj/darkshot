using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darkshot {
    public partial class Settings : Form {
        public DarkshotForm dsform;
        public void goTo(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                Process.Start(e.Link.LinkData as string);
            } catch {
                return;
            }
        }

        public Settings(DarkshotForm darkshotForm) {
            InitializeComponent();
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/alexanderdavidj/";

            credit2.LinkClicked += goTo;
            credit2.Links.Add(link);

            dsform = darkshotForm;

            textBox1.Text = dsform.options.PROXY_URL;
            textBox2.Text = dsform.options.BASE_URL;
        }

        private void button2_Click(object sender, EventArgs e) {
            dsform.options = dsform.defaults;
            textBox1.Text = dsform.defaults.PROXY_URL;
            textBox2.Text = dsform.defaults.BASE_URL;
        }

        private void button1_Click(object sender, EventArgs e) {
            dsform.options.PROXY_URL = textBox1.Text;
            dsform.options.BASE_URL = textBox2.Text;
            Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            textBox1.Text = dsform.options.PROXY_URL;
            textBox2.Text = dsform.options.BASE_URL;
        }

        private void button3_MouseHover(object sender, EventArgs e) {
            ToolTip tt = new ToolTip();
            tt.Show("LOAD SETTINGS IF BROKEN", (IWin32Window)sender);
        }
    }
}

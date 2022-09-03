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
using System.Threading;

namespace Darkshot {
    public partial class DarkshotForm : Form {
        public Options options = new Options();
        public Defaults defaults = new Defaults();
        public string proxy;
        public string baseurl;
        public char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();

        public class Options {
            public string BASE_URL { get; set; }
            public string PROXY_URL { get; set; }
        }

        public class Defaults : Options {
            public new string BASE_URL = "https://prnt.sc/$id$";
            public new string PROXY_URL = "$link$";
        }

        public DarkshotForm() {
            InitializeComponent();

            options.BASE_URL = defaults.BASE_URL;
            options.PROXY_URL = defaults.PROXY_URL;
        }

        public void goTo(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                Process.Start(e.Link.LinkData as string);
            } catch {
                return;
            }
        }

        public string generateID(int remove, string input = "w73ojf") {
            try {
                Random rnd = new Random();
                string returnS = input.Remove(input.Length - remove);

                for (int i = 0; i < remove; i++) {
                    returnS = returnS + alphabet[rnd.Next(25)];
                }

                return returnS;
            } catch (Exception ex) {
                return ex.Message.ToString();
            }
        }

        public string generateLink() {
            try {
                return options.PROXY_URL.Replace("$link$", options.BASE_URL.Replace("$id$", generateID(nChars.Value, idItext.Text)));
            } catch (Exception ex) {
                return ex.Message.ToString();
            } 
        }

        private void Form1_Load(object sender, EventArgs e) {
            try {
                LinkLabel.Link link = new LinkLabel.Link();
                link.LinkData = "https://github.com/alexanderdavidj/";

                credit2.LinkClicked += goTo;
                credit2.Links.Add(link);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                for (int i = 0; i < linksCount.Value; i++) {
                    links.Items.Add(generateLink());
                    Thread.Sleep(50);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void copyBtn_Click(object sender, EventArgs e) {
            try {
                Process.Start(links.SelectedItem.ToString());
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            try {
                links.Items.Clear();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void copy2Btn_Click(object sender, EventArgs e) {
            try {
                Clipboard.SetText(links.SelectedItem.ToString());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void idItext_TextChanged(object sender, EventArgs e) {
            try {
                nChars.Maximum = idItext.TextLength;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void openAllBtn_Click(object sender, EventArgs e) {
            try {
                foreach (object item in links.Items) {
                    Process.Start(item.ToString());
                    Thread.Sleep(50);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click_2(object sender, EventArgs e) {
            idItext.Text = generateID(nChars.Value, "w73ojf");
            //nChars.Maximum = idItext.TextLength;
        }

        private void linksCount_MouseHover(object sender, EventArgs e) {
            ToolTip tt = new ToolTip();
            tt.Show("LINKS GENERATOR COUNT", (IWin32Window)sender);
        }

        private void nChars_Scroll(object sender, EventArgs e) {
            nChars.Maximum = idItext.TextLength;
        }

        private void nChars_MouseHover(object sender, EventArgs e) {
            ToolTip tt = new ToolTip();
            tt.Show("CHARS RANDOMIZATION", (IWin32Window)sender);
        }

        private void button2_Click(object sender, EventArgs e) {
            Settings settings = new Settings(this);
            settings.Show();
        }
    }
}

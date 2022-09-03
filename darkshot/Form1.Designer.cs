namespace Darkshot {
    partial class DarkshotForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DarkshotForm));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.generateBtn = new System.Windows.Forms.Button();
            this.idItext = new System.Windows.Forms.TextBox();
            this.links = new System.Windows.Forms.ListBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.nChars = new System.Windows.Forms.TrackBar();
            this.copy2Btn = new System.Windows.Forms.Button();
            this.linksCount = new System.Windows.Forms.TrackBar();
            this.openAllBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.credit2 = new System.Windows.Forms.LinkLabel();
            this.credit1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksCount)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 14);
            this.linkLabel1.TabIndex = 0;
            // 
            // generateBtn
            // 
            this.generateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Futura", 9F);
            this.generateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.generateBtn.Location = new System.Drawing.Point(264, 417);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(109, 39);
            this.generateBtn.TabIndex = 3;
            this.generateBtn.Text = "GENERATE";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // idItext
            // 
            this.idItext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.idItext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.idItext.Font = new System.Drawing.Font("Futura", 9F);
            this.idItext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.idItext.Location = new System.Drawing.Point(264, 166);
            this.idItext.MaxLength = 32;
            this.idItext.Name = "idItext";
            this.idItext.Size = new System.Drawing.Size(109, 23);
            this.idItext.TabIndex = 4;
            this.idItext.TextChanged += new System.EventHandler(this.idItext_TextChanged);
            // 
            // links
            // 
            this.links.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.links.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.links.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.links.Font = new System.Drawing.Font("Futura", 11F);
            this.links.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.links.FormattingEnabled = true;
            this.links.ItemHeight = 19;
            this.links.Location = new System.Drawing.Point(12, 12);
            this.links.Name = "links";
            this.links.Size = new System.Drawing.Size(223, 380);
            this.links.TabIndex = 5;
            // 
            // copyBtn
            // 
            this.copyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBtn.Font = new System.Drawing.Font("Futura", 8.25F);
            this.copyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.copyBtn.Location = new System.Drawing.Point(264, 327);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(109, 39);
            this.copyBtn.TabIndex = 6;
            this.copyBtn.Text = "OPEN SELECTED LINK";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Futura", 9F);
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.clearBtn.Location = new System.Drawing.Point(264, 237);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(109, 39);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "CLEAR LIST";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nChars
            // 
            this.nChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nChars.Location = new System.Drawing.Point(264, 64);
            this.nChars.Maximum = 2;
            this.nChars.Minimum = 1;
            this.nChars.Name = "nChars";
            this.nChars.Size = new System.Drawing.Size(109, 45);
            this.nChars.TabIndex = 8;
            this.nChars.Value = 1;
            this.nChars.Scroll += new System.EventHandler(this.nChars_Scroll);
            this.nChars.MouseHover += new System.EventHandler(this.nChars_MouseHover);
            // 
            // copy2Btn
            // 
            this.copy2Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copy2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy2Btn.Font = new System.Drawing.Font("Futura", 8.25F);
            this.copy2Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.copy2Btn.Location = new System.Drawing.Point(264, 372);
            this.copy2Btn.Name = "copy2Btn";
            this.copy2Btn.Size = new System.Drawing.Size(109, 39);
            this.copy2Btn.TabIndex = 9;
            this.copy2Btn.Text = "COPY SELECTED LINK";
            this.copy2Btn.UseVisualStyleBackColor = true;
            this.copy2Btn.Click += new System.EventHandler(this.copy2Btn_Click);
            // 
            // linksCount
            // 
            this.linksCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linksCount.Location = new System.Drawing.Point(264, 115);
            this.linksCount.Minimum = 1;
            this.linksCount.Name = "linksCount";
            this.linksCount.Size = new System.Drawing.Size(109, 45);
            this.linksCount.TabIndex = 15;
            this.linksCount.Value = 1;
            this.linksCount.MouseHover += new System.EventHandler(this.linksCount_MouseHover);
            // 
            // openAllBtn
            // 
            this.openAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openAllBtn.Font = new System.Drawing.Font("Futura", 9F);
            this.openAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.openAllBtn.Location = new System.Drawing.Point(264, 282);
            this.openAllBtn.Name = "openAllBtn";
            this.openAllBtn.Size = new System.Drawing.Size(109, 39);
            this.openAllBtn.TabIndex = 16;
            this.openAllBtn.Text = "OPEN ALL LINKS";
            this.openAllBtn.UseVisualStyleBackColor = true;
            this.openAllBtn.Click += new System.EventHandler(this.openAllBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Futura", 9F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button1.Location = new System.Drawing.Point(264, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "SAMPLE ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Futura", 9F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button2.Location = new System.Drawing.Point(149, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "SETTINGS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // credit2
            // 
            this.credit2.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.credit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.credit2.AutoSize = true;
            this.credit2.BackColor = System.Drawing.Color.Transparent;
            this.credit2.Font = new System.Drawing.Font("Futura", 10F);
            this.credit2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.credit2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.credit2.Location = new System.Drawing.Point(50, 433);
            this.credit2.Name = "credit2";
            this.credit2.Size = new System.Drawing.Size(106, 18);
            this.credit2.TabIndex = 25;
            this.credit2.TabStop = true;
            this.credit2.Text = "alexanderdavidj";
            this.credit2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            // 
            // credit1
            // 
            this.credit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.credit1.AutoSize = true;
            this.credit1.Font = new System.Drawing.Font("Futura", 10F);
            this.credit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.credit1.Location = new System.Drawing.Point(9, 417);
            this.credit1.Name = "credit1";
            this.credit1.Size = new System.Drawing.Size(61, 18);
            this.credit1.TabIndex = 24;
            this.credit1.Text = "made by";
            // 
            // DarkshotForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(385, 466);
            this.Controls.Add(this.credit2);
            this.Controls.Add(this.credit1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openAllBtn);
            this.Controls.Add(this.linksCount);
            this.Controls.Add(this.copy2Btn);
            this.Controls.Add(this.nChars);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.links);
            this.Controls.Add(this.idItext);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.linkLabel1);
            this.Font = new System.Drawing.Font("Futura", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DarkshotForm";
            this.Text = "Darkshot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox idItext;
        private System.Windows.Forms.ListBox links;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TrackBar nChars;
        private System.Windows.Forms.Button copy2Btn;
        private System.Windows.Forms.TrackBar linksCount;
        private System.Windows.Forms.Button openAllBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel credit2;
        private System.Windows.Forms.Label credit1;
    }
}


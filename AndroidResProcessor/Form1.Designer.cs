namespace AndroidResProcessor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bDoMerge = new System.Windows.Forms.Button();
            this.lSelectMerge = new System.Windows.Forms.Label();
            this.lSelectOrig = new System.Windows.Forms.Label();
            this.bSelectMerge = new System.Windows.Forms.Button();
            this.bSelectOrig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb2Digits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSaveResult = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lSmaliDir = new System.Windows.Forms.Label();
            this.bSmaliDir = new System.Windows.Forms.Button();
            this.l8 = new System.Windows.Forms.Label();
            this.bDoUpdate = new System.Windows.Forms.Button();
            this.lSelectFrom = new System.Windows.Forms.Label();
            this.lSelectCur = new System.Windows.Forms.Label();
            this.bSelectFrom = new System.Windows.Forms.Button();
            this.bSelectCur = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bPNGProcess2 = new System.Windows.Forms.Button();
            this.bPNGProcess = new System.Windows.Forms.Button();
            this.lPNGsPath = new System.Windows.Forms.Label();
            this.bPNGsPath = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bReplaceProcess2 = new System.Windows.Forms.Button();
            this.tbReplaceReplace = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbReplaceFind = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bReplaceProcess = new System.Windows.Forms.Button();
            this.lReplaceFolderSmali = new System.Windows.Forms.Label();
            this.bReplaceFolderSmali = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bDoMerge);
            this.tabPage1.Controls.Add(this.lSelectMerge);
            this.tabPage1.Controls.Add(this.lSelectOrig);
            this.tabPage1.Controls.Add(this.bSelectMerge);
            this.tabPage1.Controls.Add(this.bSelectOrig);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Merge";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bDoMerge
            // 
            this.bDoMerge.Location = new System.Drawing.Point(19, 104);
            this.bDoMerge.Name = "bDoMerge";
            this.bDoMerge.Size = new System.Drawing.Size(75, 23);
            this.bDoMerge.TabIndex = 6;
            this.bDoMerge.Text = "Do Merge";
            this.bDoMerge.UseVisualStyleBackColor = true;
            this.bDoMerge.Click += new System.EventHandler(this.bDoMerge_Click);
            // 
            // lSelectMerge
            // 
            this.lSelectMerge.AutoSize = true;
            this.lSelectMerge.Location = new System.Drawing.Point(174, 58);
            this.lSelectMerge.Name = "lSelectMerge";
            this.lSelectMerge.Size = new System.Drawing.Size(59, 13);
            this.lSelectMerge.TabIndex = 5;
            this.lSelectMerge.Text = "<Full path>";
            // 
            // lSelectOrig
            // 
            this.lSelectOrig.AutoSize = true;
            this.lSelectOrig.Location = new System.Drawing.Point(174, 19);
            this.lSelectOrig.Name = "lSelectOrig";
            this.lSelectOrig.Size = new System.Drawing.Size(59, 13);
            this.lSelectOrig.TabIndex = 4;
            this.lSelectOrig.Text = "<Full path>";
            // 
            // bSelectMerge
            // 
            this.bSelectMerge.Location = new System.Drawing.Point(137, 53);
            this.bSelectMerge.Name = "bSelectMerge";
            this.bSelectMerge.Size = new System.Drawing.Size(31, 23);
            this.bSelectMerge.TabIndex = 3;
            this.bSelectMerge.Text = "...";
            this.bSelectMerge.UseVisualStyleBackColor = true;
            this.bSelectMerge.Click += new System.EventHandler(this.bSelectMerge_Click);
            // 
            // bSelectOrig
            // 
            this.bSelectOrig.Location = new System.Drawing.Point(137, 14);
            this.bSelectOrig.Name = "bSelectOrig";
            this.bSelectOrig.Size = new System.Drawing.Size(31, 23);
            this.bSelectOrig.TabIndex = 2;
            this.bSelectOrig.Text = "...";
            this.bSelectOrig.UseVisualStyleBackColor = true;
            this.bSelectOrig.Click += new System.EventHandler(this.bSelectOrig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Merge from public.xml";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original public.xml";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb2Digits);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbSaveResult);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lSmaliDir);
            this.tabPage2.Controls.Add(this.bSmaliDir);
            this.tabPage2.Controls.Add(this.l8);
            this.tabPage2.Controls.Add(this.bDoUpdate);
            this.tabPage2.Controls.Add(this.lSelectFrom);
            this.tabPage2.Controls.Add(this.lSelectCur);
            this.tabPage2.Controls.Add(this.bSelectFrom);
            this.tabPage2.Controls.Add(this.bSelectCur);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb2Digits
            // 
            this.tb2Digits.Location = new System.Drawing.Point(145, 19);
            this.tb2Digits.MaxLength = 2;
            this.tb2Digits.Name = "tb2Digits";
            this.tb2Digits.Size = new System.Drawing.Size(100, 20);
            this.tb2Digits.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "First 2 hex digits";
            // 
            // cbSaveResult
            // 
            this.cbSaveResult.AutoSize = true;
            this.cbSaveResult.Location = new System.Drawing.Point(124, 174);
            this.cbSaveResult.Name = "cbSaveResult";
            this.cbSaveResult.Size = new System.Drawing.Size(79, 17);
            this.cbSaveResult.TabIndex = 18;
            this.cbSaveResult.Text = "Save result";
            this.cbSaveResult.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(17, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(530, 199);
            this.textBox1.TabIndex = 17;
            this.textBox1.WordWrap = false;
            // 
            // lSmaliDir
            // 
            this.lSmaliDir.AutoSize = true;
            this.lSmaliDir.Location = new System.Drawing.Point(182, 57);
            this.lSmaliDir.Name = "lSmaliDir";
            this.lSmaliDir.Size = new System.Drawing.Size(59, 13);
            this.lSmaliDir.TabIndex = 16;
            this.lSmaliDir.Text = "<Full path>";
            // 
            // bSmaliDir
            // 
            this.bSmaliDir.Location = new System.Drawing.Point(145, 52);
            this.bSmaliDir.Name = "bSmaliDir";
            this.bSmaliDir.Size = new System.Drawing.Size(31, 23);
            this.bSmaliDir.TabIndex = 15;
            this.bSmaliDir.Text = "...";
            this.bSmaliDir.UseVisualStyleBackColor = true;
            this.bSmaliDir.Click += new System.EventHandler(this.bSmaliDir_Click);
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Location = new System.Drawing.Point(24, 57);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(84, 13);
            this.l8.TabIndex = 14;
            this.l8.Text = "Folder with smali";
            // 
            // bDoUpdate
            // 
            this.bDoUpdate.Location = new System.Drawing.Point(27, 170);
            this.bDoUpdate.Name = "bDoUpdate";
            this.bDoUpdate.Size = new System.Drawing.Size(75, 23);
            this.bDoUpdate.TabIndex = 13;
            this.bDoUpdate.Text = "Do Update";
            this.bDoUpdate.UseVisualStyleBackColor = true;
            this.bDoUpdate.Click += new System.EventHandler(this.bDoUpdate_Click);
            // 
            // lSelectFrom
            // 
            this.lSelectFrom.AutoSize = true;
            this.lSelectFrom.Location = new System.Drawing.Point(182, 139);
            this.lSelectFrom.Name = "lSelectFrom";
            this.lSelectFrom.Size = new System.Drawing.Size(59, 13);
            this.lSelectFrom.TabIndex = 12;
            this.lSelectFrom.Text = "<Full path>";
            // 
            // lSelectCur
            // 
            this.lSelectCur.AutoSize = true;
            this.lSelectCur.Location = new System.Drawing.Point(182, 100);
            this.lSelectCur.Name = "lSelectCur";
            this.lSelectCur.Size = new System.Drawing.Size(59, 13);
            this.lSelectCur.TabIndex = 11;
            this.lSelectCur.Text = "<Full path>";
            // 
            // bSelectFrom
            // 
            this.bSelectFrom.Location = new System.Drawing.Point(145, 134);
            this.bSelectFrom.Name = "bSelectFrom";
            this.bSelectFrom.Size = new System.Drawing.Size(31, 23);
            this.bSelectFrom.TabIndex = 10;
            this.bSelectFrom.Text = "...";
            this.bSelectFrom.UseVisualStyleBackColor = true;
            this.bSelectFrom.Click += new System.EventHandler(this.bSelectFrom_Click);
            // 
            // bSelectCur
            // 
            this.bSelectCur.Location = new System.Drawing.Point(145, 95);
            this.bSelectCur.Name = "bSelectCur";
            this.bSelectCur.Size = new System.Drawing.Size(31, 23);
            this.bSelectCur.TabIndex = 9;
            this.bSelectCur.Text = "...";
            this.bSelectCur.UseVisualStyleBackColor = true;
            this.bSelectCur.Click += new System.EventHandler(this.bSelectCur_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Merge from public.xml";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "New public.xml";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bPNGProcess2);
            this.tabPage3.Controls.Add(this.bPNGProcess);
            this.tabPage3.Controls.Add(this.lPNGsPath);
            this.tabPage3.Controls.Add(this.bPNGsPath);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(566, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PNG Process";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // bPNGProcess2
            // 
            this.bPNGProcess2.Location = new System.Drawing.Point(142, 84);
            this.bPNGProcess2.Name = "bPNGProcess2";
            this.bPNGProcess2.Size = new System.Drawing.Size(75, 23);
            this.bPNGProcess2.TabIndex = 21;
            this.bPNGProcess2.Text = "Process2";
            this.bPNGProcess2.UseVisualStyleBackColor = true;
            this.bPNGProcess2.Click += new System.EventHandler(this.bPNGProcess2_Click);
            // 
            // bPNGProcess
            // 
            this.bPNGProcess.Location = new System.Drawing.Point(28, 78);
            this.bPNGProcess.Name = "bPNGProcess";
            this.bPNGProcess.Size = new System.Drawing.Size(75, 23);
            this.bPNGProcess.TabIndex = 20;
            this.bPNGProcess.Text = "Process";
            this.bPNGProcess.UseVisualStyleBackColor = true;
            this.bPNGProcess.Click += new System.EventHandler(this.button2_Click);
            // 
            // lPNGsPath
            // 
            this.lPNGsPath.AutoSize = true;
            this.lPNGsPath.Location = new System.Drawing.Point(179, 27);
            this.lPNGsPath.Name = "lPNGsPath";
            this.lPNGsPath.Size = new System.Drawing.Size(59, 13);
            this.lPNGsPath.TabIndex = 19;
            this.lPNGsPath.Text = "<Full path>";
            // 
            // bPNGsPath
            // 
            this.bPNGsPath.Location = new System.Drawing.Point(132, 22);
            this.bPNGsPath.Name = "bPNGsPath";
            this.bPNGsPath.Size = new System.Drawing.Size(31, 23);
            this.bPNGsPath.TabIndex = 18;
            this.bPNGsPath.Text = "...";
            this.bPNGsPath.UseVisualStyleBackColor = true;
            this.bPNGsPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Folder with PNGs";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bReplaceProcess2);
            this.tabPage4.Controls.Add(this.tbReplaceReplace);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.tbReplaceFind);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.bReplaceProcess);
            this.tabPage4.Controls.Add(this.lReplaceFolderSmali);
            this.tabPage4.Controls.Add(this.bReplaceFolderSmali);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(566, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Replace";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bReplaceProcess2
            // 
            this.bReplaceProcess2.Location = new System.Drawing.Point(179, 183);
            this.bReplaceProcess2.Name = "bReplaceProcess2";
            this.bReplaceProcess2.Size = new System.Drawing.Size(75, 23);
            this.bReplaceProcess2.TabIndex = 29;
            this.bReplaceProcess2.Text = "Process2";
            this.bReplaceProcess2.UseVisualStyleBackColor = true;
            this.bReplaceProcess2.Click += new System.EventHandler(this.bReplaceProcess2_Click);
            // 
            // tbReplaceReplace
            // 
            this.tbReplaceReplace.Location = new System.Drawing.Point(143, 96);
            this.tbReplaceReplace.MaxLength = 0;
            this.tbReplaceReplace.Name = "tbReplaceReplace";
            this.tbReplaceReplace.Size = new System.Drawing.Size(402, 20);
            this.tbReplaceReplace.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Replace";
            // 
            // tbReplaceFind
            // 
            this.tbReplaceFind.Location = new System.Drawing.Point(143, 66);
            this.tbReplaceFind.MaxLength = 0;
            this.tbReplaceFind.Name = "tbReplaceFind";
            this.tbReplaceFind.Size = new System.Drawing.Size(402, 20);
            this.tbReplaceFind.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Find";
            // 
            // bReplaceProcess
            // 
            this.bReplaceProcess.Location = new System.Drawing.Point(25, 183);
            this.bReplaceProcess.Name = "bReplaceProcess";
            this.bReplaceProcess.Size = new System.Drawing.Size(75, 23);
            this.bReplaceProcess.TabIndex = 24;
            this.bReplaceProcess.Text = "Process";
            this.bReplaceProcess.UseVisualStyleBackColor = true;
            this.bReplaceProcess.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lReplaceFolderSmali
            // 
            this.lReplaceFolderSmali.AutoSize = true;
            this.lReplaceFolderSmali.Location = new System.Drawing.Point(176, 33);
            this.lReplaceFolderSmali.Name = "lReplaceFolderSmali";
            this.lReplaceFolderSmali.Size = new System.Drawing.Size(59, 13);
            this.lReplaceFolderSmali.TabIndex = 23;
            this.lReplaceFolderSmali.Text = "<Full path>";
            // 
            // bReplaceFolderSmali
            // 
            this.bReplaceFolderSmali.Location = new System.Drawing.Point(129, 28);
            this.bReplaceFolderSmali.Name = "bReplaceFolderSmali";
            this.bReplaceFolderSmali.Size = new System.Drawing.Size(31, 23);
            this.bReplaceFolderSmali.TabIndex = 22;
            this.bReplaceFolderSmali.Text = "...";
            this.bReplaceFolderSmali.UseVisualStyleBackColor = true;
            this.bReplaceFolderSmali.Click += new System.EventHandler(this.bReplaceFolderSmali_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Folder with Smali";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Public.xml|*.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lSelectMerge;
        private System.Windows.Forms.Label lSelectOrig;
        private System.Windows.Forms.Button bSelectMerge;
        private System.Windows.Forms.Button bSelectOrig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bDoMerge;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lSmaliDir;
        private System.Windows.Forms.Button bSmaliDir;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Button bDoUpdate;
        private System.Windows.Forms.Label lSelectFrom;
        private System.Windows.Forms.Label lSelectCur;
        private System.Windows.Forms.Button bSelectFrom;
        private System.Windows.Forms.Button bSelectCur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbSaveResult;
        private System.Windows.Forms.TextBox tb2Digits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lPNGsPath;
        private System.Windows.Forms.Button bPNGsPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bPNGProcess;
        private System.Windows.Forms.Button bPNGProcess2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bReplaceProcess;
        private System.Windows.Forms.Label lReplaceFolderSmali;
        private System.Windows.Forms.Button bReplaceFolderSmali;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbReplaceReplace;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbReplaceFind;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bReplaceProcess2;
    }
}


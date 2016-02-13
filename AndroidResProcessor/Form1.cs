using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace AndroidResProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lSelectCur.Text = Properties.Settings.Default.PathCur;
            lSelectFrom.Text = Properties.Settings.Default.PathFrom;
            lSelectMerge.Text = Properties.Settings.Default.PathMerge;
            lSelectOrig.Text = Properties.Settings.Default.PathOrig;
            lSmaliDir.Text = Properties.Settings.Default.PathSmali;
            lPNGsPath.Text = Properties.Settings.Default.PathPNGs;
            lReplaceFolderSmali.Text = Properties.Settings.Default.PathReplace;
            tb2Digits.Text = Properties.Settings.Default.Digits;
        }

        private void bSelectOrig_Click(object sender, EventArgs e)
        {
            if (!lSelectOrig.Text.StartsWith("<"))
            {
                openFileDialog1.FileName = lSelectOrig.Text;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lSelectOrig.Text = openFileDialog1.FileName;
            }
        }

        private void bSelectMerge_Click(object sender, EventArgs e)
        {
            if (!lSelectMerge.Text.StartsWith("<"))
            {
                openFileDialog1.FileName = lSelectMerge.Text;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lSelectMerge.Text = openFileDialog1.FileName;
            }
        }

        private void bDoMerge_Click(object sender, EventArgs e)
        {
            Resources resOrigUnsort = Resources.Load(lSelectOrig.Text);
            Resources resOrig = Resources.Load(lSelectOrig.Text);
            Resources resMerge = Resources.Load(lSelectMerge.Text);

            resOrig.PublicItems.Sort((p1, p2) =>
            {
                var c1 = p1.type.CompareTo(p2.type);
                var c2 = p1.id.CompareTo(p2.id);
                return (c1 != 0 ? c1 : c2);
            });
            resMerge.PublicItems.Sort((p1, p2) =>
            {
                var c1 = p1.type.CompareTo(p2.type);
                var c2 = p1.id.CompareTo(p2.id);
                return c2; //(c1 != 0 ? c1 : c2);
            });

            Dictionary<string, string> maxIds = new Dictionary<string, string>();
            for (int i = 0; i < resMerge.PublicItems.Count; i++)
            {
                var pi = resMerge.PublicItems[i];

                var oi = resOrig.PublicItems.Find(p => p.name.Equals(pi.name) && p.type.Equals(pi.type));
                if (oi == null)
                {
                    var t = pi.type;
                    if (!maxIds.ContainsKey(t))
                    {
                        var ttItem = resOrig.PublicItems.FindLast(p => p.type.Equals(t));
                        var ttId = "";
                        if (ttItem == null)
                        {
                            ttItem = resOrig.PublicItems[resOrig.PublicItems.Count - 1];
                            var tmp = ttItem.id;
                            ttId = tmp.Remove(6) + "0000";
                        }
                        else
                        {
                            var tmp = ttItem.id;
                            ttId = tmp.Remove(6) + (Convert.ToInt32(tmp.Substring(6), 16) + 1).ToString("x4");
                        }
                        maxIds[t] = ttId;
                    }
                    var maxId = maxIds[t];
                    resOrigUnsort.PublicItems.Add(new PublicItem() { id = maxId, name = pi.name, type = pi.type });
                    maxId = maxId.Remove(6) + (Convert.ToInt32(maxId.Substring(6), 16) + 1).ToString("x4");
                    maxIds[t] = maxId;
                }
            }

            resOrigUnsort.Save(Path.GetDirectoryName(lSelectOrig.Text) + "\\" +
                Path.GetFileNameWithoutExtension(lSelectOrig.Text) + "1" + Path.GetExtension(lSelectOrig.Text));
        }

        private void bSmaliDir_Click(object sender, EventArgs e)
        {
            if (!lSmaliDir.Text.StartsWith("<"))
            {
                folderBrowserDialog1.SelectedPath = lSmaliDir.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lSmaliDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bSelectCur_Click(object sender, EventArgs e)
        {
            if (!lSelectCur.Text.StartsWith("<"))
            {
                openFileDialog1.FileName = lSelectCur.Text;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lSelectCur.Text = openFileDialog1.FileName;
            }
        }

        private void bSelectFrom_Click(object sender, EventArgs e)
        {
            if (!lSelectFrom.Text.StartsWith("<"))
            {
                openFileDialog1.FileName = lSelectFrom.Text;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lSelectFrom.Text = openFileDialog1.FileName;
            }
        }

        private void bDoUpdate_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            List<string> fileList = GetFiles(lSmaliDir.Text);
            Resources resCur = Resources.Load(lSelectCur.Text);
            Resources resFrom = Resources.Load(lSelectFrom.Text);
            String regex1 = "0x" + tb2Digits.Text + "[a-f\\d]{5,}";
            String regex2 = "0x" + tb2Digits.Text + "[a-f\\d]{1,}";

            foreach (string fileName in fileList)
            {
                string[] fileLines = File.ReadAllLines(fileName);
                for (int l = 0; l < fileLines.Length; l++)
                {
                    string text = fileLines[l];
                    Match m = Regex.Match(text, regex1, RegexOptions.IgnoreCase);
                    if (!m.Success) m = Regex.Match(text, regex2, RegexOptions.IgnoreCase);
                    if (m.Success)
                    {
                        var rId = m.Value;
                        if (rId.Length <= 6) rId += "0000";

                        if (rId.Length < 10)
                        {
                            rId = "0x" + rId.Substring(2).PadLeft(8, '0');
                        }

                        var fromRes = resFrom.PublicItems.Find(p => p.id.Equals(rId));
                        if (fromRes == null)
                        {
                            if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Text += "\r\n";
                            //textBox1.Text += "Id not found in FROM. Unknown id (" + m.Value + ") in line " + l + " of " + fileName + ".";
                            textBox1.Text += "Id not found in FROM. Line to check : " + fileLines[l] + ", file - " + fileName + ", line - " + l;
                        }
                        else
                        {
                            var curRes = resCur.PublicItems.Find(p => p.name.Equals(fromRes.name) && p.type.Equals(fromRes.type));
                            if (curRes == null)
                            {
                                if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Text += "\r\n";
                                textBox1.Text += "Name not found in CUR. Unknown id (" + m.Value + "/" + fromRes.name + ") in line " + l + " of " + fileName + ".";
                            }
                            else
                            {
                                if (rId.EndsWith("0000"))
                                {
                                    if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Text += "\r\n";
                                    textBox1.Text += "Line to check : " + fileLines[l] + ", file - " + fileName + ", line - " + l;
                                    //fileLines[l] = "!!!" + fileLines[l];
                                }
                                else 
                                {
                                    string curId = Regex.Replace(curRes.id, "^0x0+", "0x");
                                    if (m.Value.ToLower() != curId.ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(textBox1.Text)) textBox1.Text += "\r\n";
                                        textBox1.Text += "Line updated (" + m.Value + "->" + curId + ") : " + fileLines[l] + ", file - " + fileName + ", line - " + l;
                                        fileLines[l] = text.Remove(m.Index, m.Length).Insert(m.Index, curId);
                                    }
                                }
                            }
                        }
                    }
                }

                if (cbSaveResult.Checked)
                {
                    File.WriteAllLines(fileName, fileLines);
                }
            }
        }

        private List<string> GetFiles(string dir)
        {
            List<string> res = new List<string>();
            string[] files = Directory.GetFiles(dir);
            string[] dirs = Directory.GetDirectories(dir);

            res.AddRange(files);
            foreach (string dd in dirs)
            {
                List<string> ff = GetFiles(dd);
                res.AddRange(ff);
            }
            return res;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Digits = tb2Digits.Text;
            Properties.Settings.Default.PathCur = lSelectCur.Text;
            Properties.Settings.Default.PathFrom = lSelectFrom.Text;
            Properties.Settings.Default.PathMerge = lSelectMerge.Text;
            Properties.Settings.Default.PathOrig = lSelectOrig.Text;
            Properties.Settings.Default.PathSmali = lSmaliDir.Text;
            Properties.Settings.Default.PathPNGs = lPNGsPath.Text;
            Properties.Settings.Default.PathReplace = lReplaceFolderSmali.Text;
            Properties.Settings.Default.Save();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!lPNGsPath.Text.StartsWith("<"))
            {
                folderBrowserDialog1.SelectedPath = lPNGsPath.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lPNGsPath.Text = folderBrowserDialog1.SelectedPath;
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int accuracy1 = 80;
            List<string> fileList = GetFiles(lPNGsPath.Text);
            foreach (string fileName in fileList)
            {
                string ext = Path.GetExtension(fileName);
                if (".PNG".Equals(ext.ToUpper()))
                {
                    Image img = Image.FromFile(fileName);
                    Bitmap bmp = new Bitmap(img);
                    int mc = 0, mr = 0, mg = 0, mb = 0;
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            Color c = bmp.GetPixel(x, y);
                            if ((c.R > mr && c.R > mg && c.R > mb) ||
                                (c.R > mr && c.R > mg && c.R > mb) ||
                                (c.R > mr && c.R > mg && c.R > mb))
                            {
                                mc = c.ToArgb() & 0xFFFFFF;
                                mr = c.R; mg = c.G; mb = c.B;
                            }
                        }
                    }
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            Color c = bmp.GetPixel(x, y);
                            int v = c.ToArgb() & 0xFFFFFF;
                            double f = 1.0f * v / 0xFFFFFF * 0xFF;
                            int a = Convert.ToInt32(Math.Round(f));
                            Color cn = Color.FromArgb(a, 255, 255, 255);
                            if (c.R - c.G > accuracy1 || c.R - c.B > accuracy1 || c.G - c.B > accuracy1 ||
                                c.G - c.R > accuracy1 || c.B - c.R > accuracy1 || c.B - c.G > accuracy1)
                            {
                                float br = c.GetBrightness();
                                if (br > 0.3f)
                                {
                                    cn = c;
                                }
                                else
                                {
                                    a = Convert.ToInt32(Math.Round(br * 3.33f * 0xFF));
                                    cn = Color.FromArgb(a, c.R, c.G, c.B);
                                }
                            }
                            bmp.SetPixel(x, y, cn);
                        }
                    }
                    img.Dispose();

                    string fn = fileName;
                        //Path.GetDirectoryName(lPNGsPath.Text) + "\\" +
                        //Path.GetFileNameWithoutExtension(lPNGsPath.Text) + "1" +
                        //Path.GetExtension(lPNGsPath.Text);
                    bmp.Save(fn, ImageFormat.Png);
                }
            }
        }

        private void bPNGProcess2_Click(object sender, EventArgs e)
        {
            int accuracy1 = 10;
            List<string> fileList = GetFiles(lPNGsPath.Text);
            foreach (string fileName in fileList)
            {
                string ext = Path.GetExtension(fileName);
                if (".PNG".Equals(ext.ToUpper()))
                {
                    Image img = Image.FromFile(fileName);
                    Bitmap bmp = new Bitmap(img);
                    
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            Color c = bmp.GetPixel(x, y);
                            if (x == 0 && y == 0)
                            {
                                bmp.SetPixel(x + 1, y, c);
                            }
                            else if (x == bmp.Width - 2 && y == 0)
                            {
                                bmp.SetPixel(x, y, bmp.GetPixel(x + 1, y));
                                continue;
                            }
                            else if (x == 0 && y == bmp.Height - 1)
                            {
                                bmp.SetPixel(x + 1, y, c);
                            }
                            else if (x == bmp.Width - 2 && y == bmp.Height - 1)
                            {
                                bmp.SetPixel(x, y, bmp.GetPixel(x + 1, y));
                                continue;
                            }
                            else if (x == 1 && (y == 0 || y == bmp.Height - 1))
                            {
                                continue;
                            }
                            if (x == 0 || x == bmp.Width - 1)
                            {
                                bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                                continue;
                            }

                            int v = c.ToArgb() & 0xFFFFFF;
                            Color cn = c;
                            if (c.R < 180 && c.G < 180 && c.B < 180 &&
                                !(c.R - c.G > accuracy1 || c.R - c.B > accuracy1 || c.G - c.B > accuracy1 ||
                                  c.G - c.R > accuracy1 || c.B - c.R > accuracy1 || c.B - c.G > accuracy1))
                            {
                                cn = Color.FromArgb(127, c.R, c.G, c.B);
                            }
                            bmp.SetPixel(x, y, cn);
                        }
                    }
                    img.Dispose();

                    string fn = fileName;
                    bmp.Save(fn, ImageFormat.Png);
                }
            }
        }

        private void bReplaceFolderSmali_Click(object sender, EventArgs e)
        {
            if (!lReplaceFolderSmali.Text.StartsWith("<"))
            {
                folderBrowserDialog1.SelectedPath = lReplaceFolderSmali.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lReplaceFolderSmali.Text = folderBrowserDialog1.SelectedPath;
            } 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String txtFind = tbReplaceFind.Text;
            String txtReplace = tbReplaceReplace.Text;
            List<string> fileList = GetFiles(lReplaceFolderSmali.Text);
            foreach (string fileName in fileList)
            {
                string ext = Path.GetExtension(fileName);
                if (".SMALI".Equals(ext.ToUpper()))
                {
                    string[] fileLines = File.ReadAllLines(fileName);
                    bool f = false;
                    for (int l = 0; l < fileLines.Length; l++)
                    {
                        string text = fileLines[l];
                        if (text.Contains(txtFind))
                        {
                            fileLines[l] = text.Replace(txtFind, txtReplace);
                            f = true;
                        }
                    }
                    if (f)
                    {
                        File.WriteAllLines(fileName, fileLines);
                    }
                }
            }
        }

        private void bReplaceProcess2_Click(object sender, EventArgs e)
        {
            string regex1 = "L[a-zA-Z0-9\\$/]+;";
            String txtFind = tbReplaceFind.Text;
            String txtReplace = tbReplaceReplace.Text;
            List<string> fileList = GetFiles(lReplaceFolderSmali.Text);
            foreach (string fileName in fileList)
            {
                string ext = Path.GetExtension(fileName);
                if (".SMALI".Equals(ext.ToUpper()))
                {
                    FileStream fs = File.OpenRead(fileName);
                    StreamReader reader = new StreamReader(fs);
                    string line1 = reader.ReadLine();
                    reader.Close();
                    Match m = Regex.Match(line1, regex1);
                    if (m.Success && m.Value.Contains(txtFind))
                    {
                        string clsName = m.Value;
                        string clsNewName = clsName.Replace(txtFind, txtReplace);
                        foreach (string fn in fileList)
                        {
                            string ext2 = Path.GetExtension(fn);
                            if (".SMALI".Equals(ext2.ToUpper()))
                            {
                                string[] fileLines = File.ReadAllLines(fn);
                                bool f = false;
                                for (int l = 0; l < fileLines.Length; l++)
                                {
                                    string text = fileLines[l];
                                    if (text.Contains(clsName))
                                    {
                                        fileLines[l] = text.Replace(clsName, clsNewName);
                                        f = true;
                                    }
                                }
                                if (f)
                                {
                                    File.WriteAllLines(fn, fileLines);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

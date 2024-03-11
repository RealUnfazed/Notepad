using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Notepad : Form
    {
        public string openedFile = null;
        public float defaultFontSize;
        public bool isSaved;
        public Notepad()
        {
            InitializeComponent();
            UpdateTitle("N/A", true);
            defaultFontSize = noteBox.Font.Size;
        }

        private void iAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program made by Alireza Asakareh and It's available on Github.", "ABOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AlirezaPlusOfficial/Notepad");
        }

        private void iZoomIn_Click(object sender, EventArgs e)
        {
            noteBox.Font = new Font(noteBox.SelectionFont.FontFamily.Name, noteBox.Font.Size + 1);
        }

        private void iZoomOut_Click(object sender, EventArgs e)
        {
            noteBox.Font = new Font(noteBox.SelectionFont.FontFamily.Name, noteBox.Font.Size - 1);
        }

        private void iDefaultZoom_Click(object sender, EventArgs e)
        {
            noteBox.Font = new Font(noteBox.SelectionFont.FontFamily, defaultFontSize);
        }

        private void iUndo_Click(object sender, EventArgs e)
        {
            noteBox.Undo();
        }

        private void iRedo_Click(object sender, EventArgs e)
        {
            noteBox.Redo();
        }

        private void iCut_Click(object sender, EventArgs e)
        {
            noteBox.Cut();
        }

        private void iCopy_Click(object sender, EventArgs e)
        {
            noteBox.Copy();
        }

        private void iPaste_Click(object sender, EventArgs e)
        {
            noteBox.Paste();
        }

        private void iDelete_Click(object sender, EventArgs e)
        {
            noteBox.SelectedText = string.Empty;
        }

        private void iSelectAll_Click(object sender, EventArgs e)
        {
            noteBox.SelectAll();
        }

        private void iFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                noteBox.Font = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, fontDialog.Font.Style);
            }
        }

        private void iFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                noteBox.ForeColor = colorDialog.Color;
            }
        }

        private void iWordWrap_Click(object sender, EventArgs e)
        {
            noteBox.WordWrap = !noteBox.WordWrap;
            if (iWordWrap.Checked) { noteBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical; } else { noteBox.ScrollBars = RichTextBoxScrollBars.ForcedBoth; }
        }
        
        private void iStatusBar_Click(object sender, EventArgs e)
        {
            iStatusLabel.Visible = !iStatusLabel.Visible;
        }

        private void noteBox_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
            UpdateTitle(openedFile, true);
        }

        private void UpdateStatusBar()
        {
            ////////// Column And Line
            int startPosition = noteBox.SelectionStart;
            int tLine = noteBox.GetLineFromCharIndex(startPosition) + 1;
            int tCol = startPosition - noteBox.GetFirstCharIndexOfCurrentLine() + 1;

            ///////// Word And Paragraph
            int wordC = noteBox.Text.Split(new char[] { ' ', '.', ',', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            string[] paragraphs = noteBox.Text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            int paragraphC = paragraphs.Length;

            //////// Result
            iStatusLabel.Text = "Ln " + tLine + " | " + "Col " + tCol + " | " + "Words " + wordC + " | " + "Paragraphs " + paragraphC;
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void iSave_Click(object sender, EventArgs e)
        {
            if (noteBox.Text != String.Empty)
            {
                if (openedFile == null)
                {
                    string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Saved Notes", DateTime.Today.ToString("dd_MMM_yy"), DateTime.Now.ToString("HH-mm-ss") + ".txt");

                    if (!Directory.Exists(Path.GetDirectoryName(currentDirectory)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(currentDirectory));
                    }

                    FileStream fs = new FileStream(currentDirectory, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    sw.Write(noteBox.Text);

                    sw.Close();
                    fs.Close();

                    UpdateTitle(currentDirectory, true);
                    openedFile = currentDirectory;
                    MessageBox.Show("File Saved Into: " + currentDirectory, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    StreamWriter sw = new StreamWriter(openedFile);
                    sw.Write(noteBox.Text);
                    UpdateTitle(openedFile, true);
                    sw.Close();
                }
            }
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Any unsaved progress will be lost, Do you wanna Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void iExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Any unsaved progress will be lost, Do you wanna Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog.FileName;
                StreamReader sr = new StreamReader(fName);
                string fContent = sr.ReadToEnd();
                noteBox.Text = fContent;
                openedFile = fName;
                UpdateTitle(fName, true);
                sr.Close();
            }
        }


        private void UpdateTitle(string Filename, bool SaveStatus)
        {
            
            string Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = (SaveStatus ? "" : "*") + "Notepad" + " | " + (Filename != null ? Filename : "N/A") + " | " + $"{Version}";
        }

        private void noteBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTitle(openedFile, false);
        }
    }
}
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

namespace ModernPasswordGenerator
{
    public partial class ModernPasswordGenerator : Form
    {
        OpenFileDialog dialog = new OpenFileDialog
        {
            Multiselect = false
        };
        int loadedWordsCount = 0;

        //Code of my old PWGen
        String[] words = new String[100000];

        public void LoadWords(String file)
        {
            if (File.Exists(file))
            {

                string line = "";
                StreamReader reader = new StreamReader(file);
                words = new string[100000];
                loadedWordsCount = 0;
                while ((line = reader.ReadLine()) != null)
                {

                    if (loadedWordsCount < words.Length)
                    {
                        words[loadedWordsCount] = line;
                        loadedWordsCount++;
                    }
                    else
                        break;
                }

                lblStatus.Text = "Loaded " + loadedWordsCount + " words";
            }
            else
            {
                lblStatus.Text = "Loading of file " + file + " failed!";
            }

        }

        public void CopyToClipboard()
        {
            try
            {
                Clipboard.SetText(txtPassword.Text);
            }
            catch
            {}
            
        }



        public void ImportWords()
        {
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                LoadWords(dialog.FileName);
            }
            else
            {
                lblStatus.Text = "Did you select a file?";
            }
        }

        //End of Copy


        int wordAmount = 2;
        bool autoCopy = false;
        
        public ModernPasswordGenerator()
        {
            InitializeComponent();
            LoadWords("words.txt");
        }

        private Point m_offset;
        private Point m_Pos;

        private void EM_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                m_Pos = Control.MousePosition;
                m_Pos.Offset(m_offset.X, m_offset.Y);
                Location = m_Pos;
            }
        }

        private void EM_MouseDown(object sender, MouseEventArgs e)
        {
            m_offset = new Point(-e.X, -e.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtWords_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtWords.Text, out wordAmount))
            {
                wordAmount = 2;
                txtWords.Text = "2";
            }
        }

        private void btnAutoCopy_Click(object sender, EventArgs e)
        {
            if (autoCopy)
            {
                setAutoCopy(false);
            }
            else{
                setAutoCopy(true);
            }
        }

        private void setAutoCopy(bool state)
        {
            if(state == true)
            {
                autoCopy = true;
                Color color = Color.FromArgb(255, 188, 36);

                lblTitle.ForeColor = color;
                btnClose.ForeColor = color;
                txtPassword.BackColor = color;
                txtWords.BackColor = color;
                lblWords.ForeColor = color;
                lblAutoCopy.ForeColor = color;
                btnCopy.ForeColor = color;
                btnImport.ForeColor = color;
                btnAutoCopy.ForeColor = color;
                btnGenerate.ForeColor = color;
                lblStatus.ForeColor = color;
                lblOwnersRights.ForeColor = color;

                lblAutoCopy.Text = "Enabled";
            }
            else{
                autoCopy = false;
                Color color = Color.FromArgb(45, 176, 44);

                lblTitle.ForeColor = color;
                btnClose.ForeColor = color;
                txtPassword.BackColor = color;
                txtWords.BackColor = color;
                lblWords.ForeColor = color;
                lblAutoCopy.ForeColor = color;
                btnCopy.ForeColor = color;
                btnImport.ForeColor = color;
                btnAutoCopy.ForeColor = color;
                btnGenerate.ForeColor = color;
                lblStatus.ForeColor = color;
                lblOwnersRights.ForeColor = color;

                lblAutoCopy.Text = "Disabled";
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblWords_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try {
                Random rnd = new Random();
                string msg = "";
                int num;
                for (int i = 0; i < wordAmount; i++)
                {
                    msg += words[rnd.Next(0, loadedWordsCount - 1)];
                }
                num = rnd.Next(01, 99);

                txtPassword.Text = msg + num;

                if (autoCopy)
                {
                    CopyToClipboard();
                }
            }
            catch { }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportWords();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void lblOwnersRights_Click(object sender, EventArgs e)
        {
            try
            {
                    System.Diagnostics.Process.Start("https://bit.ly/SkillExceptionTweets");
            }
            catch{}
        }

        private void ModernPasswordGenerator_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ModernPasswordGenerator_KeyPress(object sender, KeyEventArgs e)
        {

        }
    }
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace text_editor
{
    public partial class Form1 : Form
    {
        private string stringtoPrint = string.Empty;
        static int CountWords(string Text) 
        {
            int countWords = 0;
            for (int i = 1; i < Text.Length; i++)
            {
                if (Text[i] == ' ' && Text[i-1] != ' ') countWords++; 
            }
            return countWords; 
        }
        static int CountSentences(string Text)
        {
            int countSentences = 0;
            for (int i = 0; i < Text.Length-1; i++)
            {
                if ((Text[i] == '.' || Text[i] == '!' || Text[i] == '?') && (Text[i+1] != '.' || Text[i+1] != '!' || Text[i+1] != '?')) countSentences++;
            }
            return countSentences;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = $"Количество слов: {CountWords(rtbText.Text)}";
            toolStripStatusLabel3.Text = $"Количество предложений: {CountSentences(rtbText.Text)}";
        }

        private void cms_TollBox_Opening(object sender, CancelEventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент 2231122 группы Шнайдер Артур", "Справка");
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bFileOpen_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                rtbText.LoadFile(openFD.FileName);
                toolStripStatusLabel1.Text = openFD.FileName;
            }
        }

        private void bFileSave_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel1.Text = saveFD.FileName;
                rtbText.SaveFile(saveFD.FileName);
            }
        }

        private void bFileNew_Click(object sender, EventArgs e)
        {
            if (rtbText.Text.Length > 0)
            {
                if (MessageBox.Show("Сохранить содержимое окна редактирования?","Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bFileSave_Click(sender, e);
            }
            rtbText.Clear();
            toolStripStatusLabel1.Text = "Безымянный";
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            bFileNew_Click(sender, e);
            Close();
        }

        private void bFileClose_Click(object sender, EventArgs e)
        {
            if (rtbText.Text.Length > 0 && toolStripStatusLabel1.Text == "Безымянный")
                bFileSave_Click(sender, e);
            else
            {
                rtbText.SaveFile(toolStripStatusLabel1.Text);
                rtbText.Clear();
                toolStripStatusLabel1.Text = "Безымянный";
            }
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void bCut_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        private void скрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolBar.Visible = false;
            bTBShow.Visible = true;
        }

        private void bTBShow_Click(object sender, EventArgs e)
        {
            toolBar.Visible = true;
            bTBShow.Visible = false;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialogRtb.ShowDialog() == DialogResult.OK)
            {
                rtbText.Font = fontDialogRtb.Font;
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorTD.ShowDialog() == DialogResult.OK)
            {
                rtbText.BackColor = colorTD.Color;
            }
        }

        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorTD.ShowDialog() == DialogResult.OK)
            {
                rtbText.ForeColor = colorTD.Color;
            }
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string finding_text = findMSG.Text;
            rtbText.Find(finding_text, RichTextBoxFinds.None);
            findMSG.Text = "Введите искомый текст";
            findMSG.ForeColor = Color.FromArgb (191, 205, 219);
        }

        private void findMSG_Click(object sender, EventArgs e)
        {
            ((ToolStripTextBox)sender).Clear();
            ((ToolStripTextBox)sender).ForeColor = Color.Black;
        }

        private void заменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (replacedMSG.Text != "" || replacingMSG.Text != "")
            {
                if (MessageBox.Show($"Заменить \"{replacingMSG.Text}\" на  \"{replacedMSG.Text}\"?", "Замена", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int countReplaces = 0;
                    string[] separator = { replacingMSG.Text };
                    string[] splitted_arr = rtbText.Text.Split(separator, StringSplitOptions.None);
                    countReplaces = splitted_arr.Length - 1;
                    rtbText.Text = rtbText.Text.Replace(oldValue: replacingMSG.Text, newValue: replacedMSG.Text);
                    MessageBox.Show($"Количество замен: {countReplaces}", "Замена");
                    replacingMSG.Text = "Заменяемый текст";
                    findMSG.ForeColor = Color.FromArgb(191, 205, 219);
                    replacedMSG.Text = "Заменить на";
                    replacedMSG.ForeColor = Color.FromArgb(191, 205, 219);
                }
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bFileClose_Click(sender, e);
            if (printFD.ShowDialog() == DialogResult.OK)
            {
                string docName = "textPage.rtf";
                string docPath = @"C:\";
                string fullPath = System.IO.Path.Combine(docPath, docName);

                printDocument1.DocumentName = docName;

                stringtoPrint = rtbText.Text;

                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charatersOnPage = 0;
            int linesPerPage = 0;

            e.Graphics.MeasureString(stringtoPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charatersOnPage, out linesPerPage);

            e.Graphics.DrawString(stringtoPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            stringtoPrint = stringtoPrint.Substring(charatersOnPage);

            e.HasMorePages = (stringtoPrint.Length > 0);
        }

        private void openFD_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

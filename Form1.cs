using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;
//
using StringTransformations;

namespace PT
{
    public partial class Form1 : Form
    {
        ArrayList MyList = new ArrayList();
        ArrayList OldList = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
            this.Height = 338;
        }

        public void ClearLb()
        {
            lbFiles.Items.Clear();
            tbNew.Clear();
            tbOld.Clear();
            MyList.Clear();
        }
       
        public void Change(int i)
        {
            try
            {
                string ext;
                string path;
                string t1;

                ext = Path.GetExtension(lbFiles.Items[i].ToString());
                path = Path.GetDirectoryName(lbFiles.Items[i].ToString()) ;
                t1 = (string)MyList[i];
                t1 = RefreshTitle(t1);
                string m = path + "\\" + t1 + ext;
                if (File.Exists(m) == false)
                {
                    File.Move(lbFiles.Items[i].ToString(), path + "\\" + t1 + ext);
                }
                else 
                {
                    tbNew.Text = "";
                    tbOld.Text = "";
                    MessageBox.Show("File " + t1 + ext + " is already exist.","Can't rename file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MyList.RemoveAt(i);
                    lbFiles.Items.RemoveAt(i);
                    lbFiles.SelectedIndex = 0;
                }
            }
            catch (IOException) { MessageBox.Show("File " + Path.GetFileName(lbFiles.Items[i].ToString()) + Path.GetExtension(lbFiles.Items[i].ToString()) + " is busy with other application", "Can't rename file", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (ArgumentOutOfRangeException) { }
        }

        public string RefreshTitle(string title)
        {
            string result = title;
            if (chbAddArtist.Checked)
            {
                result = Functions.AddArtist(result, tbArtist.Text);
            }
            if (chbRemoveNum.Checked)
            {
                result = Functions.RemoveNumber(result);
            }
            if (chbTranslit.Checked)
            {
                result = Functions.Translit(result);
            }
            if (chbReplace.Checked)
            {
                result = Functions.Replacer(result, tbFirst_String.Text, tbSecond_String.Text);
            
            }
            if (chbDef.Checked == true)
            {
                result = Functions.StrTrans(result);
            }
            return result;
        
        }

        public void Cancel_function(int i)
        {
            File.Move(lbFiles.Items[i].ToString(), OldList[i].ToString());
        }


        //--------------------------------------------------------------------------------------------------------------------------
        
        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lbFiles.SelectedIndex;

                Change(i);
                string ext;
                string path;
                string t1;

                ext = Path.GetExtension(lbFiles.Items[i].ToString());
                path = Path.GetDirectoryName(lbFiles.Items[i].ToString());
                if (path.Length > 4) { path = path + "\\"; }
                t1 = (string)MyList[i];
                t1 = RefreshTitle(t1);
              
                    if (chbDelOrNot.Checked == true)
                    {
                        lbFiles.Items.RemoveAt(i);
                        tbOld.Text = "";
                        tbNew.Text = "";
                        MyList.RemoveAt(i);
                    }
                    else { MyList[i] = t1; lbFiles.Items[i] = path + t1 + ext; }
                
                
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            string title1;
            int count;
            count = lbFiles.Items.Count;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int j = 0; j < openFileDialog1.FileNames.Length; j++)
                {
                    lbFiles.Items.Add(openFileDialog1.FileNames[j]);
                    OldList.Add(openFileDialog1.FileNames[j]);
                }

                for (int i = count; i < lbFiles.Items.Count; i++)
                {
                    title1 = Functions.StrTrans(Path.GetFileNameWithoutExtension(lbFiles.Items[i].ToString()));
                    MyList.Add(title1);
                }
                if (lbFiles.SelectedIndex > 0)
                { }
                else { lbFiles.SelectedIndex = -1; }
                if (lbFiles.Items.Count > 0) { tbNew.ReadOnly = false; }
                lbFiles.SetSelected(0, true);
            }
        }

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                string t1;

                i = lbFiles.SelectedIndex;
                t1 = (string)MyList[i];
                tbOld.Text = Path.GetFileNameWithoutExtension(lbFiles.Items[lbFiles.SelectedIndex].ToString());
                tbNew.Text = t1;
                tbNew.Text = RefreshTitle(tbNew.Text);
            }
            catch (ArgumentOutOfRangeException) { }
            if (lbFiles.Items.Count > 0) { tbNew.ReadOnly = false; }
        }

        private void lbFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.All;
        }

        private void lbFiles_DragDrop(object sender, DragEventArgs e)
        {
            int count;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            count = lbFiles.Items.Count;
            foreach( string file in files )
                {
                lbFiles.Items.Add(file);
                OldList.Add(file);
                }
            string title1;
            for (int i = count; i < lbFiles.Items.Count; i++)
                {
                title1 = Functions.StrTrans(Path.GetFileNameWithoutExtension(lbFiles.Items[i].ToString()));
                MyList.Add(title1);
                }
            if (lbFiles.SelectedIndex > 0)
            { }
            else { lbFiles.SelectedIndex = 0; }
            
            
        }
       
        private void bClear_Click(object sender, EventArgs e)
        {
            ClearLb();
            tbNew.ReadOnly = true;

        }

        private void chbRemoveNum_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                string t1;
                i = lbFiles.SelectedIndex;
                t1 = (string)MyList[i];
                tbNew.Text = t1;
                tbNew.Text = RefreshTitle(tbNew.Text);
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void chbTranslit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                string t1;
                i = lbFiles.SelectedIndex;
                t1 = (string)MyList[i];
                tbNew.Text = t1;
                tbNew.Text = RefreshTitle(tbNew.Text);
            }
            catch (ArgumentOutOfRangeException) { };
            
        }

        private void tbArtist_TextChanged(object sender, EventArgs e)
        {
            tbNew.Text = tbNew.Text;
        }

        private void tbNew_KeyUp(object sender, KeyEventArgs e)
        {
            try 
            {
                int i;
                string t1;
                i = lbFiles.SelectedIndex;
                t1 = tbNew.Text;
                MyList[i] = t1;
            }
            catch (ArgumentOutOfRangeException) {}
           
            
        }

        private void tbArtist_KeyDown(object sender, KeyEventArgs e)
        {
            int i = lbFiles.SelectedIndex;
            if (e.KeyCode == Keys.Enter)
            {
                tbNew.Text = RefreshTitle((string)MyList[i]);
 
            }
        }

        private void chbAddArtist_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbAddArtist.Checked) { tbArtist.Enabled = true; }
                else { tbArtist.Enabled = false; }
                int i = lbFiles.SelectedIndex;
                tbNew.Text = RefreshTitle((string)MyList[i]);
                
            }
            catch(ArgumentOutOfRangeException){}

        }

        private void tbSecond_String_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int i = lbFiles.SelectedIndex;
                if (e.KeyCode == Keys.Enter)
                {
                    tbNew.Text = RefreshTitle((string)MyList[i]);

                }
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void chbReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (chbReplace.Checked)
            {
                tbFirst_String.Enabled = true;
                tbSecond_String.Enabled = true;
            }
            else 
            {
                tbFirst_String.Enabled = false;
                tbSecond_String.Enabled = false;
            }
        }

        private void lbFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int i = lbFiles.SelectedIndex;
                lbFiles.Items.RemoveAt(i);
                MyList.RemoveAt(i);
                OldList.RemoveAt(i);
            }
        }

        private void bChangeAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbFiles.Items.Count; i++)
            {
                Change(i);
                string ext;
                string path;
                string t1;

                ext = Path.GetExtension(lbFiles.Items[i].ToString());
                path = Path.GetDirectoryName(lbFiles.Items[i].ToString()) + "\\";
                t1 = (string)MyList[i];
                t1 = RefreshTitle(t1);
                lbFiles.Items[i] = path.Substring(0, path.Length - 1) + t1 + ext;
                MyList[i] = t1;
                
            }
            if (chbDelOrNot.Checked == true)
                {
                    lbFiles.Items.Clear();
                    tbOld.Text = "";
                    tbNew.Text = "";
                    MyList.Clear();
                }                
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Height == 338)
            { this.Height = this.Height + 90; button1.Text = "Hide Properties"; }
            else
            { this.Height = this.Height - 90; button1.Text = "Show Properties..."; }
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lbFiles.SelectedIndex;
                tbNew.Text = RefreshTitle((string)MyList[i]);
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void chbDef_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bUndo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbFiles.Items.Count; i++)
            {
                Cancel_function(i);
            }
            lbFiles.Items.Clear();
            OldList.Clear();
            MyList.Clear();
        }

    }
}

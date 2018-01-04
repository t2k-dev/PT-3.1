namespace PT
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lold = new System.Windows.Forms.Label();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chbRemoveNum = new System.Windows.Forms.CheckBox();
            this.chbAddArtist = new System.Windows.Forms.CheckBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOld = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSecond_String = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirst_String = new System.Windows.Forms.TextBox();
            this.chbReplace = new System.Windows.Forms.CheckBox();
            this.chbTranslit = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chbDelOrNot = new System.Windows.Forms.CheckBox();
            this.chbDef = new System.Windows.Forms.CheckBox();
            this.ttHint = new System.Windows.Forms.ToolTip(this.components);
            this.bCancel = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bChangeAll = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bChange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lold
            // 
            this.lold.AutoSize = true;
            this.lold.Location = new System.Drawing.Point(5, 9);
            this.lold.Name = "lold";
            this.lold.Size = new System.Drawing.Size(60, 13);
            this.lold.TabIndex = 1;
            this.lold.Text = "Old Name :";
            // 
            // lbFiles
            // 
            this.lbFiles.AllowDrop = true;
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(6, 128);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(408, 147);
            this.lbFiles.TabIndex = 5;
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
            this.lbFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFiles_DragDrop);
            this.lbFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFiles_DragEnter);
            this.lbFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbFiles_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // chbRemoveNum
            // 
            this.chbRemoveNum.AutoSize = true;
            this.chbRemoveNum.Location = new System.Drawing.Point(12, 63);
            this.chbRemoveNum.Name = "chbRemoveNum";
            this.chbRemoveNum.Size = new System.Drawing.Size(104, 17);
            this.chbRemoveNum.TabIndex = 9;
            this.chbRemoveNum.Text = "Remove number";
            this.chbRemoveNum.UseVisualStyleBackColor = true;
            this.chbRemoveNum.CheckedChanged += new System.EventHandler(this.chbRemoveNum_CheckedChanged);
            // 
            // chbAddArtist
            // 
            this.chbAddArtist.AutoSize = true;
            this.chbAddArtist.Location = new System.Drawing.Point(12, 17);
            this.chbAddArtist.Name = "chbAddArtist";
            this.chbAddArtist.Size = new System.Drawing.Size(71, 17);
            this.chbAddArtist.TabIndex = 6;
            this.chbAddArtist.Text = "Add Artist";
            this.chbAddArtist.UseVisualStyleBackColor = true;
            this.chbAddArtist.CheckedChanged += new System.EventHandler(this.chbAddArtist_CheckedChanged);
            // 
            // tbArtist
            // 
            this.tbArtist.Enabled = false;
            this.tbArtist.Location = new System.Drawing.Point(87, 14);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(100, 20);
            this.tbArtist.TabIndex = 7;
            this.tbArtist.TextChanged += new System.EventHandler(this.tbArtist_TextChanged);
            this.tbArtist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbArtist_KeyDown);
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(75, 37);
            this.tbNew.Name = "tbNew";
            this.tbNew.ReadOnly = true;
            this.tbNew.Size = new System.Drawing.Size(334, 20);
            this.tbNew.TabIndex = 13;
            this.tbNew.TabStop = false;
            this.tbNew.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNew_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbOld);
            this.panel1.Controls.Add(this.tbNew);
            this.panel1.Controls.Add(this.lold);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 77);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "New Name :";
            // 
            // tbOld
            // 
            this.tbOld.Location = new System.Drawing.Point(75, 6);
            this.tbOld.Name = "tbOld";
            this.tbOld.ReadOnly = true;
            this.tbOld.Size = new System.Drawing.Size(334, 20);
            this.tbOld.TabIndex = 14;
            this.tbOld.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bCancel);
            this.panel2.Controls.Add(this.bRefresh);
            this.panel2.Controls.Add(this.bChangeAll);
            this.panel2.Controls.Add(this.bClear);
            this.panel2.Controls.Add(this.bAdd);
            this.panel2.Controls.Add(this.bChange);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 45);
            this.panel2.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.tbSecond_String);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbFirst_String);
            this.groupBox1.Controls.Add(this.chbReplace);
            this.groupBox1.Controls.Add(this.chbTranslit);
            this.groupBox1.Controls.Add(this.tbArtist);
            this.groupBox1.Controls.Add(this.chbRemoveNum);
            this.groupBox1.Controls.Add(this.chbAddArtist);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(6, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 90);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // tbSecond_String
            // 
            this.tbSecond_String.Enabled = false;
            this.tbSecond_String.Location = new System.Drawing.Point(308, 63);
            this.tbSecond_String.Name = "tbSecond_String";
            this.tbSecond_String.Size = new System.Drawing.Size(70, 20);
            this.tbSecond_String.TabIndex = 12;
            this.tbSecond_String.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSecond_String_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "On this :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "This :";
            // 
            // tbFirst_String
            // 
            this.tbFirst_String.Enabled = false;
            this.tbFirst_String.Location = new System.Drawing.Point(308, 37);
            this.tbFirst_String.Name = "tbFirst_String";
            this.tbFirst_String.Size = new System.Drawing.Size(70, 20);
            this.tbFirst_String.TabIndex = 11;
            // 
            // chbReplace
            // 
            this.chbReplace.AutoSize = true;
            this.chbReplace.Location = new System.Drawing.Point(252, 14);
            this.chbReplace.Name = "chbReplace";
            this.chbReplace.Size = new System.Drawing.Size(66, 17);
            this.chbReplace.TabIndex = 10;
            this.chbReplace.Text = "Replace";
            this.chbReplace.UseVisualStyleBackColor = true;
            this.chbReplace.CheckedChanged += new System.EventHandler(this.chbReplace_CheckedChanged);
            // 
            // chbTranslit
            // 
            this.chbTranslit.AutoSize = true;
            this.chbTranslit.Location = new System.Drawing.Point(12, 40);
            this.chbTranslit.Name = "chbTranslit";
            this.chbTranslit.Size = new System.Drawing.Size(60, 17);
            this.chbTranslit.TabIndex = 8;
            this.chbTranslit.Text = "Translit";
            this.chbTranslit.UseVisualStyleBackColor = true;
            this.chbTranslit.CheckedChanged += new System.EventHandler(this.chbTranslit_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show Properties...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbDelOrNot
            // 
            this.chbDelOrNot.AutoSize = true;
            this.chbDelOrNot.Location = new System.Drawing.Point(272, 282);
            this.chbDelOrNot.Name = "chbDelOrNot";
            this.chbDelOrNot.Size = new System.Drawing.Size(137, 17);
            this.chbDelOrNot.TabIndex = 5;
            this.chbDelOrNot.Text = "Remove after changing";
            this.chbDelOrNot.UseVisualStyleBackColor = true;
            // 
            // chbDef
            // 
            this.chbDef.AutoSize = true;
            this.chbDef.Checked = true;
            this.chbDef.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDef.Location = new System.Drawing.Point(152, 282);
            this.chbDef.Name = "chbDef";
            this.chbDef.Size = new System.Drawing.Size(114, 17);
            this.chbDef.TabIndex = 18;
            this.chbDef.Text = "Use default editing";
            this.chbDef.UseVisualStyleBackColor = true;
            this.chbDef.CheckedChanged += new System.EventHandler(this.chbDef_CheckedChanged);
            // 
            // bCancel
            // 
            this.bCancel.Image = ((System.Drawing.Image)(resources.GetObject("bCancel.Image")));
            this.bCancel.Location = new System.Drawing.Point(291, 5);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(32, 34);
            this.bCancel.TabIndex = 6;
            this.ttHint.SetToolTip(this.bCancel, "Cancel all changes");
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bUndo_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.Image = ((System.Drawing.Image)(resources.GetObject("bRefresh.Image")));
            this.bRefresh.Location = new System.Drawing.Point(165, 5);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(40, 34);
            this.bRefresh.TabIndex = 5;
            this.bRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttHint.SetToolTip(this.bRefresh, "Refresh the list");
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bChangeAll
            // 
            this.bChangeAll.Image = ((System.Drawing.Image)(resources.GetObject("bChangeAll.Image")));
            this.bChangeAll.Location = new System.Drawing.Point(248, 5);
            this.bChangeAll.Name = "bChangeAll";
            this.bChangeAll.Size = new System.Drawing.Size(37, 34);
            this.bChangeAll.TabIndex = 4;
            this.bChangeAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttHint.SetToolTip(this.bChangeAll, "Change all the titles");
            this.bChangeAll.UseVisualStyleBackColor = true;
            this.bChangeAll.Click += new System.EventHandler(this.bChangeAll_Click);
            // 
            // bClear
            // 
            this.bClear.Image = ((System.Drawing.Image)(resources.GetObject("bClear.Image")));
            this.bClear.Location = new System.Drawing.Point(119, 5);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(40, 34);
            this.bClear.TabIndex = 2;
            this.bClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttHint.SetToolTip(this.bClear, "Clear the list");
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bAdd
            // 
            this.bAdd.Image = ((System.Drawing.Image)(resources.GetObject("bAdd.Image")));
            this.bAdd.Location = new System.Drawing.Point(76, 5);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(37, 34);
            this.bAdd.TabIndex = 1;
            this.bAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttHint.SetToolTip(this.bAdd, "Add new files to the list");
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bChange
            // 
            this.bChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bChange.BackgroundImage")));
            this.bChange.Image = ((System.Drawing.Image)(resources.GetObject("bChange.Image")));
            this.bChange.Location = new System.Drawing.Point(211, 5);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(31, 34);
            this.bChange.TabIndex = 3;
            this.bChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttHint.SetToolTip(this.bChange, "Change the selected title");
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 405);
            this.Controls.Add(this.chbDef);
            this.Controls.Add(this.chbDelOrNot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfect Title (v3.0)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lold;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chbRemoveNum;
        private System.Windows.Forms.CheckBox chbAddArtist;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOld;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bChangeAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSecond_String;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirst_String;
        private System.Windows.Forms.CheckBox chbReplace;
        private System.Windows.Forms.CheckBox chbTranslit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbDelOrNot;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.CheckBox chbDef;
        private System.Windows.Forms.ToolTip ttHint;
        private System.Windows.Forms.Button bCancel;
    }
}


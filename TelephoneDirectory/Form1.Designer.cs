
namespace TelephoneDirectory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGander = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblCountt = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblDiapozonPage = new System.Windows.Forms.Label();
            this.lblPageNum = new System.Windows.Forms.Label();
            this.btnPage = new System.Windows.Forms.Button();
            this.txtBoxPage = new System.Windows.Forms.TextBox();
            this.lblNotFOuND = new System.Windows.Forms.Label();
            this.lblSearhc1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSearchBox = new System.Windows.Forms.Label();
            this.lblgSearch = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColFirstName,
            this.ColLastName,
            this.ColTelephone,
            this.ColCity,
            this.ColGander});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(774, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            this.ColId.Width = 59;
            // 
            // ColFirstName
            // 
            this.ColFirstName.HeaderText = "Ім\'я";
            this.ColFirstName.Name = "ColFirstName";
            this.ColFirstName.Width = 160;
            // 
            // ColLastName
            // 
            this.ColLastName.HeaderText = "Прізвище";
            this.ColLastName.Name = "ColLastName";
            this.ColLastName.Width = 160;
            // 
            // ColTelephone
            // 
            this.ColTelephone.HeaderText = "Телефон";
            this.ColTelephone.Name = "ColTelephone";
            this.ColTelephone.Width = 120;
            // 
            // ColCity
            // 
            this.ColCity.HeaderText = "Місто";
            this.ColCity.Name = "ColCity";
            this.ColCity.Width = 133;
            // 
            // ColGander
            // 
            this.ColGander.HeaderText = "Стать";
            this.ColGander.Name = "ColGander";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Linen;
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 70);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Видалити";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblCountt
            // 
            this.lblCountt.AutoSize = true;
            this.lblCountt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountt.Location = new System.Drawing.Point(12, 376);
            this.lblCountt.Name = "lblCountt";
            this.lblCountt.Size = new System.Drawing.Size(44, 19);
            this.lblCountt.TabIndex = 6;
            this.lblCountt.Text = "count";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(614, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 23);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(575, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(657, 379);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblDiapozonPage
            // 
            this.lblDiapozonPage.AutoSize = true;
            this.lblDiapozonPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiapozonPage.Location = new System.Drawing.Point(12, 395);
            this.lblDiapozonPage.Name = "lblDiapozonPage";
            this.lblDiapozonPage.Size = new System.Drawing.Size(65, 19);
            this.lblDiapozonPage.TabIndex = 14;
            this.lblDiapozonPage.Text = "diapozon";
            // 
            // lblPageNum
            // 
            this.lblPageNum.AutoSize = true;
            this.lblPageNum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPageNum.Location = new System.Drawing.Point(614, 382);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(37, 20);
            this.lblPageNum.TabIndex = 16;
            this.lblPageNum.Text = ".0/0.";
            // 
            // btnPage
            // 
            this.btnPage.Location = new System.Drawing.Point(575, 419);
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(132, 23);
            this.btnPage.TabIndex = 17;
            this.btnPage.Text = "Перейти на сторінку: ";
            this.btnPage.UseVisualStyleBackColor = true;
            this.btnPage.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // txtBoxPage
            // 
            this.txtBoxPage.Location = new System.Drawing.Point(713, 419);
            this.txtBoxPage.Name = "txtBoxPage";
            this.txtBoxPage.Size = new System.Drawing.Size(73, 23);
            this.txtBoxPage.TabIndex = 18;
            this.txtBoxPage.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblNotFOuND
            // 
            this.lblNotFOuND.AutoSize = true;
            this.lblNotFOuND.Location = new System.Drawing.Point(392, 418);
            this.lblNotFOuND.Name = "lblNotFOuND";
            this.lblNotFOuND.Size = new System.Drawing.Size(0, 15);
            this.lblNotFOuND.TabIndex = 19;
            // 
            // lblSearhc1
            // 
            this.lblSearhc1.AutoSize = true;
            this.lblSearhc1.Location = new System.Drawing.Point(562, 16);
            this.lblSearhc1.Name = "lblSearhc1";
            this.lblSearhc1.Size = new System.Drawing.Size(52, 15);
            this.lblSearhc1.TabIndex = 20;
            this.lblSearhc1.Text = "Пошук :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Іменні",
            "Прізвищу",
            "Телефону",
            "Місту",
            "Статі"});
            this.comboBox1.Location = new System.Drawing.Point(374, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // lblSearchBox
            // 
            this.lblSearchBox.AutoSize = true;
            this.lblSearchBox.Location = new System.Drawing.Point(297, 16);
            this.lblSearchBox.Name = "lblSearchBox";
            this.lblSearchBox.Size = new System.Drawing.Size(71, 15);
            this.lblSearchBox.TabIndex = 22;
            this.lblSearchBox.Text = "Шукати по :";
            // 
            // lblgSearch
            // 
            this.lblgSearch.AutoSize = true;
            this.lblgSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblgSearch.Location = new System.Drawing.Point(614, 39);
            this.lblgSearch.Name = "lblgSearch";
            this.lblgSearch.Size = new System.Drawing.Size(0, 19);
            this.lblgSearch.TabIndex = 23;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.Location = new System.Drawing.Point(1, 436);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(61, 12);
            this.lblAuthor.TabIndex = 24;
            this.lblAuthor.Text = "AuthorName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Linen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(753, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblgSearch);
            this.Controls.Add(this.lblSearchBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSearhc1);
            this.Controls.Add(this.lblNotFOuND);
            this.Controls.Add(this.txtBoxPage);
            this.Controls.Add(this.btnPage);
            this.Controls.Add(this.lblPageNum);
            this.Controls.Add(this.lblDiapozonPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCountt);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Directory";
            this.Load += new System.EventHandler(this.lblCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblCountt;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblDiapozonPage;
        private System.Windows.Forms.Label lblPageNum;
        private System.Windows.Forms.Button btnPage;
        private System.Windows.Forms.TextBox txtBoxPage;
        private System.Windows.Forms.Label lblNotFOuND;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGander;
        private System.Windows.Forms.Label lblSearhc1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSearchBox;
        private System.Windows.Forms.Label lblgSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


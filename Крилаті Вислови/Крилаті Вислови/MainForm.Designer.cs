namespace Крилаті_Вислови
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.historyList = new System.Windows.Forms.Button();
            this.likedList = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.nextRandomButton = new System.Windows.Forms.Button();
            this.curiosPanel = new System.Windows.Forms.Panel();
            this.curiosLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.favouriteButton = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.curiosPanel.SuspendLayout();
            this.curiosLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favouriteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // historyList
            // 
            this.historyList.BackColor = System.Drawing.Color.RoyalBlue;
            this.historyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.historyList.Location = new System.Drawing.Point(745, 12);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(122, 44);
            this.historyList.TabIndex = 0;
            this.historyList.Text = "Історія";
            this.historyList.UseVisualStyleBackColor = false;
            this.historyList.Click += new System.EventHandler(this.History_Click);
            this.historyList.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.historyList.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // likedList
            // 
            this.likedList.BackColor = System.Drawing.Color.RoyalBlue;
            this.likedList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.likedList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.likedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.likedList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.likedList.Location = new System.Drawing.Point(617, 12);
            this.likedList.Name = "likedList";
            this.likedList.Size = new System.Drawing.Size(122, 44);
            this.likedList.TabIndex = 1;
            this.likedList.Text = "Улюблені";
            this.likedList.UseVisualStyleBackColor = false;
            this.likedList.Click += new System.EventHandler(this.LikedHistory_Click);
            this.likedList.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.likedList.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(745, 446);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.Exit_Button);
            this.exitButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.searchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchBox.Location = new System.Drawing.Point(222, 26);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(388, 24);
            this.searchBox.TabIndex = 3;
            this.searchBox.Text = "Пошук...";
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // nextRandomButton
            // 
            this.nextRandomButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.nextRandomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextRandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nextRandomButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nextRandomButton.Location = new System.Drawing.Point(199, 340);
            this.nextRandomButton.Name = "nextRandomButton";
            this.nextRandomButton.Size = new System.Drawing.Size(111, 41);
            this.nextRandomButton.TabIndex = 6;
            this.nextRandomButton.Text = "Далі";
            this.nextRandomButton.UseVisualStyleBackColor = false;
            this.nextRandomButton.Click += new System.EventHandler(this.NextRandom_Click);
            this.nextRandomButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.nextRandomButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // curiosPanel
            // 
            this.curiosPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curiosPanel.Controls.Add(this.pictureBox2);
            this.curiosPanel.Controls.Add(this.curiosLayoutPanel);
            this.curiosPanel.Controls.Add(this.pictureBox1);
            this.curiosPanel.Controls.Add(this.labelAuthor);
            this.curiosPanel.Controls.Add(this.labelId);
            this.curiosPanel.Controls.Add(this.labelType);
            this.curiosPanel.Controls.Add(this.favouriteButton);
            this.curiosPanel.Cursor = System.Windows.Forms.Cursors.No;
            this.curiosPanel.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.curiosPanel.Location = new System.Drawing.Point(199, 102);
            this.curiosPanel.Name = "curiosPanel";
            this.curiosPanel.Size = new System.Drawing.Size(540, 232);
            this.curiosPanel.TabIndex = 11;
            // 
            // curiosLayoutPanel
            // 
            this.curiosLayoutPanel.AutoScroll = true;
            this.curiosLayoutPanel.Controls.Add(this.labelText);
            this.curiosLayoutPanel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.curiosLayoutPanel.Location = new System.Drawing.Point(-1, 55);
            this.curiosLayoutPanel.Name = "curiosLayoutPanel";
            this.curiosLayoutPanel.Size = new System.Drawing.Size(540, 119);
            this.curiosLayoutPanel.TabIndex = 16;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelText.Location = new System.Drawing.Point(3, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(50, 18);
            this.labelText.TabIndex = 12;
            this.labelText.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Крилаті_Вислови.Properties.Resources.print;
            this.pictureBox1.Location = new System.Drawing.Point(442, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Print_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelAuthor.Location = new System.Drawing.Point(203, 200);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(51, 20);
            this.labelAuthor.TabIndex = 14;
            this.labelAuthor.Text = "label4";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelId.Location = new System.Drawing.Point(442, 14);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(70, 25);
            this.labelId.TabIndex = 13;
            this.labelId.Text = "label3";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelType.Location = new System.Drawing.Point(16, 14);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(70, 25);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "label1";
            // 
            // favouriteButton
            // 
            this.favouriteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favouriteButton.Image = ((System.Drawing.Image)(resources.GetObject("favouriteButton.Image")));
            this.favouriteButton.Location = new System.Drawing.Point(488, 180);
            this.favouriteButton.Name = "favouriteButton";
            this.favouriteButton.Size = new System.Drawing.Size(40, 40);
            this.favouriteButton.TabIndex = 10;
            this.favouriteButton.TabStop = false;
            this.favouriteButton.Click += new System.EventHandler(this.Favourite_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(16, 382);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(135, 44);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.Add_Click);
            this.addButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.addButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeButton.Location = new System.Drawing.Point(16, 332);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(135, 44);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Видалити";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.remove_Click);
            this.removeButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.removeButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Cursor = System.Windows.Forms.Cursors.Help;
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Текст",
            "Автор",
            "Тип",
            "ID"});
            this.comboBoxFilter.Location = new System.Drawing.Point(12, 31);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(158, 21);
            this.comboBoxFilter.TabIndex = 14;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(16, 446);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 44);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.buttonSave_Click);
            this.saveButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.saveButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Обрати фільтрацію :";
            // 
            // searchButton
            // 
            this.searchButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchButton.InitialImage")));
            this.searchButton.Location = new System.Drawing.Point(176, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 40);
            this.searchButton.TabIndex = 8;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Крилаті_Вислови.Properties.Resources.edit;
            this.pictureBox2.Location = new System.Drawing.Point(396, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Крилаті_Вислови.Properties.Resources.Фон;
            this.ClientSize = new System.Drawing.Size(885, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.curiosPanel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nextRandomButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.likedList);
            this.Controls.Add(this.historyList);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = " Крилаті вислови";
            this.curiosPanel.ResumeLayout(false);
            this.curiosPanel.PerformLayout();
            this.curiosLayoutPanel.ResumeLayout(false);
            this.curiosLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favouriteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button historyList;
        private System.Windows.Forms.Button likedList;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button nextRandomButton;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox favouriteButton;
        private System.Windows.Forms.Panel curiosPanel;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel curiosLayoutPanel;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


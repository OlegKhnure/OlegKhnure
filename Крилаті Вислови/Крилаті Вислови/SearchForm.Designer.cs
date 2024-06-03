namespace Крилаті_Вислови
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.sortByAuthor = new System.Windows.Forms.PictureBox();
            this.sortByType = new System.Windows.Forms.PictureBox();
            this.sortByText = new System.Windows.Forms.PictureBox();
            this.sortById = new System.Windows.Forms.PictureBox();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.historyButton = new System.Windows.Forms.Button();
            this.likedButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.searchFormBox = new System.Windows.Forms.TextBox();
            this.againSearchButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonPrintAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sortByAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortByType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortByText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortById)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.againSearchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sortByAuthor
            // 
            this.sortByAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortByAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.sortByAuthor, "sortByAuthor");
            this.sortByAuthor.Name = "sortByAuthor";
            this.sortByAuthor.TabStop = false;
            this.sortByAuthor.Click += new System.EventHandler(this.sortByAuthor_Click);
            // 
            // sortByType
            // 
            this.sortByType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortByType.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.sortByType, "sortByType");
            this.sortByType.Name = "sortByType";
            this.sortByType.TabStop = false;
            this.sortByType.Click += new System.EventHandler(this.sortByType_Click);
            // 
            // sortByText
            // 
            this.sortByText.BackColor = System.Drawing.Color.White;
            this.sortByText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortByText.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.sortByText, "sortByText");
            this.sortByText.Name = "sortByText";
            this.sortByText.TabStop = false;
            this.sortByText.Click += new System.EventHandler(this.sortByText_Click);
            // 
            // sortById
            // 
            this.sortById.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortById.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.sortById, "sortById");
            this.sortById.Name = "sortById";
            this.sortById.TabStop = false;
            this.sortById.Click += new System.EventHandler(this.sortById_Click);
            // 
            // flowPanel
            // 
            resources.ApplyResources(this.flowPanel, "flowPanel");
            this.flowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanel.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.flowPanel.Name = "flowPanel";
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.historyButton, "historyButton");
            this.historyButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.historyButton.Name = "historyButton";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.history_Click);
            this.historyButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.historyButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // likedButton
            // 
            this.likedButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.likedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.likedButton, "likedButton");
            this.likedButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.likedButton.Name = "likedButton";
            this.likedButton.UseVisualStyleBackColor = false;
            this.likedButton.Click += new System.EventHandler(this.Liked_Click);
            this.likedButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.likedButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.returnButton, "returnButton");
            this.returnButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.returnButton.Name = "returnButton";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.returnButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.returnButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // searchFormBox
            // 
            resources.ApplyResources(this.searchFormBox, "searchFormBox");
            this.searchFormBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchFormBox.Name = "searchFormBox";
            this.searchFormBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.searchFormBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.searchFormBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // againSearchButton
            // 
            this.againSearchButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.againSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.againSearchButton, "againSearchButton");
            this.againSearchButton.Name = "againSearchButton";
            this.againSearchButton.TabStop = false;
            this.againSearchButton.Click += new System.EventHandler(this.againSearchButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Cursor = System.Windows.Forms.Cursors.Help;
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            resources.GetString("comboBoxFilter.Items"),
            resources.GetString("comboBoxFilter.Items1"),
            resources.GetString("comboBoxFilter.Items2"),
            resources.GetString("comboBoxFilter.Items3")});
            resources.ApplyResources(this.comboBoxFilter, "comboBoxFilter");
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // buttonPrintAll
            // 
            this.buttonPrintAll.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.buttonPrintAll, "buttonPrintAll");
            this.buttonPrintAll.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPrintAll.Name = "buttonPrintAll";
            this.buttonPrintAll.UseVisualStyleBackColor = false;
            this.buttonPrintAll.Click += new System.EventHandler(this.buttonPrintAll_Click);
            // 
            // SearchForm
            // 
            this.BackgroundImage = global::Крилаті_Вислови.Properties.Resources.Фон;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.buttonPrintAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.againSearchButton);
            this.Controls.Add(this.searchFormBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.likedButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.sortById);
            this.Controls.Add(this.sortByText);
            this.Controls.Add(this.sortByType);
            this.Controls.Add(this.sortByAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.sortByAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortByType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortByText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortById)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.againSearchButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button likedList;
        private System.Windows.Forms.Button historyList;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox sortByAuthor;
        private System.Windows.Forms.PictureBox sortByType;
        private System.Windows.Forms.PictureBox sortByText;
        private System.Windows.Forms.PictureBox sortById;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button likedButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox searchFormBox;
        private System.Windows.Forms.PictureBox againSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonPrintAll;
    }
}
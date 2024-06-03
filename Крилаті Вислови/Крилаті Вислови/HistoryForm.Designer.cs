namespace Крилаті_Вислови
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.historyListBox.Font = new System.Drawing.Font("Arial", 12F);
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.HorizontalScrollbar = true;
            this.historyListBox.ItemHeight = 18;
            this.historyListBox.Location = new System.Drawing.Point(11, 12);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(504, 328);
            this.historyListBox.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(388, 347);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(129, 44);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Скасувати";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.Close_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clearButton.Location = new System.Drawing.Point(11, 347);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(187, 44);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Очистити історію";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.buttonClear_Click);
            this.clearButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.clearButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(527, 407);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.historyListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.Text = "Історія дій";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button clearButton;
    }
}
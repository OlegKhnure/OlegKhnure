namespace Крилаті_Вислови
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.Cancel = new System.Windows.Forms.Button();
            this.Agree = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel.Location = new System.Drawing.Point(266, 447);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(121, 43);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Скасувати";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Agree
            // 
            this.Agree.BackColor = System.Drawing.Color.RoyalBlue;
            this.Agree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Agree.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Agree.Location = new System.Drawing.Point(266, 402);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(121, 43);
            this.Agree.TabIndex = 11;
            this.Agree.Text = "Додати";
            this.Agree.UseVisualStyleBackColor = false;
            this.Agree.Click += new System.EventHandler(this.Agree_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Афоризм",
            "Приказка",
            "Прислів\'я",
            "Каламбур",
            "Цитата",
            "Курйоз"});
            this.comboBoxType.Location = new System.Drawing.Point(14, 402);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(176, 33);
            this.comboBoxType.TabIndex = 10;
            // 
            // textAuthor
            // 
            this.textAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.textAuthor.Location = new System.Drawing.Point(12, 370);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(239, 26);
            this.textAuthor.TabIndex = 9;
            // 
            // textBoxText
            // 
            this.textBoxText.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxText.Location = new System.Drawing.Point(12, 38);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(375, 326);
            this.textBoxText.TabIndex = 8;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelId.Location = new System.Drawing.Point(9, 11);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(86, 25);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "ID : ???";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(406, 502);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "Додавання";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Agree;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label labelId;
    }
}
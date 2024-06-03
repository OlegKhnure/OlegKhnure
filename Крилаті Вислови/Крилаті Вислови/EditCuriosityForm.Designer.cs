namespace Крилаті_Вислови
{
    partial class EditCuriosityForm
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
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.Agree = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 20);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "label";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(16, 47);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(375, 326);
            this.textBoxText.TabIndex = 2;
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(16, 379);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(239, 20);
            this.textAuthor.TabIndex = 3;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(16, 405);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(176, 21);
            this.comboBoxType.TabIndex = 4;
            // 
            // Agree
            // 
            this.Agree.Location = new System.Drawing.Point(261, 447);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(121, 43);
            this.Agree.TabIndex = 5;
            this.Agree.Text = "Agree";
            this.Agree.UseVisualStyleBackColor = true;
            this.Agree.Click += new System.EventHandler(this.Agree_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(134, 447);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(121, 43);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // flowPanel
            // 
            this.flowPanel.Location = new System.Drawing.Point(415, 47);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(441, 443);
            this.flowPanel.TabIndex = 7;
            // 
            // EditCuriosityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 502);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelId);
            this.Name = "EditCuriosityForm";
            this.Text = "EditCuriosityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button Agree;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}
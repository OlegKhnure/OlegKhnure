namespace Крилаті_Вислови
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.printPreviewButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.labelType = new System.Windows.Forms.Label();
            this.curiosPrintPanel = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.curiosPrintFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelText = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.curiosPrintPanel.SuspendLayout();
            this.curiosPrintFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewButton
            // 
            this.printPreviewButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.printPreviewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printPreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.printPreviewButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printPreviewButton.Location = new System.Drawing.Point(47, 246);
            this.printPreviewButton.Name = "printPreviewButton";
            this.printPreviewButton.Size = new System.Drawing.Size(136, 92);
            this.printPreviewButton.TabIndex = 1;
            this.printPreviewButton.Text = "Перегляд роздруківки";
            this.printPreviewButton.UseVisualStyleBackColor = false;
            this.printPreviewButton.Click += new System.EventHandler(this.printPreview_Click);
            this.printPreviewButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.printPreviewButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.printButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printButton.Location = new System.Drawing.Point(189, 246);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(215, 45);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Роздрукувати";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.print_Click);
            this.printButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.printButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(189, 293);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(215, 45);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancel_Click);
            this.cancelButton.MouseEnter += new System.EventHandler(this.colorEnter_MouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.colorLeave_MouseLeave);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelType.Location = new System.Drawing.Point(16, 14);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(49, 25);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Тип";
            // 
            // curiosPrintPanel
            // 
            this.curiosPrintPanel.BackColor = System.Drawing.SystemColors.Control;
            this.curiosPrintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curiosPrintPanel.Controls.Add(this.labelId);
            this.curiosPrintPanel.Controls.Add(this.curiosPrintFlowLayoutPanel);
            this.curiosPrintPanel.Controls.Add(this.labelAuthor);
            this.curiosPrintPanel.Controls.Add(this.labelType);
            this.curiosPrintPanel.Location = new System.Drawing.Point(47, 12);
            this.curiosPrintPanel.Name = "curiosPrintPanel";
            this.curiosPrintPanel.Size = new System.Drawing.Size(550, 225);
            this.curiosPrintPanel.TabIndex = 5;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelId.Location = new System.Drawing.Point(451, 14);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(70, 25);
            this.labelId.TabIndex = 14;
            this.labelId.Text = "label3";
            // 
            // curiosPrintFlowLayoutPanel
            // 
            this.curiosPrintFlowLayoutPanel.AutoScroll = true;
            this.curiosPrintFlowLayoutPanel.Controls.Add(this.labelText);
            this.curiosPrintFlowLayoutPanel.Location = new System.Drawing.Point(-1, 61);
            this.curiosPrintFlowLayoutPanel.Name = "curiosPrintFlowLayoutPanel";
            this.curiosPrintFlowLayoutPanel.Size = new System.Drawing.Size(550, 100);
            this.curiosPrintFlowLayoutPanel.TabIndex = 4;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Arial", 12F);
            this.labelText.Location = new System.Drawing.Point(3, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(47, 18);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Текст";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.labelAuthor.Location = new System.Drawing.Point(208, 188);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(56, 20);
            this.labelAuthor.TabIndex = 3;
            this.labelAuthor.Text = "Автор";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(637, 350);
            this.Controls.Add(this.curiosPrintPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.printPreviewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrintForm";
            this.Text = "Роздруківка";
            this.curiosPrintPanel.ResumeLayout(false);
            this.curiosPrintPanel.PerformLayout();
            this.curiosPrintFlowLayoutPanel.ResumeLayout(false);
            this.curiosPrintFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button printPreviewButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Panel curiosPrintPanel;
        private System.Windows.Forms.FlowLayoutPanel curiosPrintFlowLayoutPanel;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelId;
    }
}
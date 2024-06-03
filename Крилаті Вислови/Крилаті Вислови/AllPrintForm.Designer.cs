namespace Крилаті_Вислови
{
    partial class AllPrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllPrintForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.printPreviewButton = new System.Windows.Forms.Button();
            this.flowLayoutPanelCurios = new System.Windows.Forms.FlowLayoutPanel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(151, 298);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(215, 45);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.printButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printButton.Location = new System.Drawing.Point(151, 251);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(215, 45);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Роздрукувати";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printPreviewButton
            // 
            this.printPreviewButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.printPreviewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printPreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.printPreviewButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printPreviewButton.Location = new System.Drawing.Point(9, 251);
            this.printPreviewButton.Name = "printPreviewButton";
            this.printPreviewButton.Size = new System.Drawing.Size(136, 92);
            this.printPreviewButton.TabIndex = 6;
            this.printPreviewButton.Text = "Перегляд роздруківки";
            this.printPreviewButton.UseVisualStyleBackColor = false;
            this.printPreviewButton.Click += new System.EventHandler(this.printPreviewButton_Click);
            // 
            // flowLayoutPanelCurios
            // 
            this.flowLayoutPanelCurios.AutoScroll = true;
            this.flowLayoutPanelCurios.Location = new System.Drawing.Point(9, 13);
            this.flowLayoutPanelCurios.Name = "flowLayoutPanelCurios";
            this.flowLayoutPanelCurios.Size = new System.Drawing.Size(616, 232);
            this.flowLayoutPanelCurios.TabIndex = 9;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // AllPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(637, 350);
            this.Controls.Add(this.flowLayoutPanelCurios);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.printPreviewButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AllPrintForm";
            this.Text = "Роздруківка усього";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button printPreviewButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCurios;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}
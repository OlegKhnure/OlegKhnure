namespace Крилаті_Вислови
{
    partial class RemoveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveForm));
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.curiosRemoveFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelText = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.curiosRemoveFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRemove.Location = new System.Drawing.Point(24, 306);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(132, 41);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Видалити";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.Location = new System.Drawing.Point(442, 306);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 41);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(65, 20);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(188, 20);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            this.idTextBox.Enter += new System.EventHandler(this.idTextBox_Enter);
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            this.idTextBox.Leave += new System.EventHandler(this.idTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.curiosRemoveFlowLayoutPanel);
            this.panel.Controls.Add(this.labelAuthor);
            this.panel.Controls.Add(this.labelType);
            this.panel.Location = new System.Drawing.Point(24, 57);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(550, 225);
            this.panel.TabIndex = 4;
            // 
            // curiosRemoveFlowLayoutPanel
            // 
            this.curiosRemoveFlowLayoutPanel.AutoScroll = true;
            this.curiosRemoveFlowLayoutPanel.Controls.Add(this.labelText);
            this.curiosRemoveFlowLayoutPanel.Location = new System.Drawing.Point(-1, 61);
            this.curiosRemoveFlowLayoutPanel.Name = "curiosRemoveFlowLayoutPanel";
            this.curiosRemoveFlowLayoutPanel.Size = new System.Drawing.Size(550, 100);
            this.curiosRemoveFlowLayoutPanel.TabIndex = 4;
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
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(591, 377);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RemoveForm";
            this.Text = "Виделення";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.curiosRemoveFlowLayoutPanel.ResumeLayout(false);
            this.curiosRemoveFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.FlowLayoutPanel curiosRemoveFlowLayoutPanel;
    }
}
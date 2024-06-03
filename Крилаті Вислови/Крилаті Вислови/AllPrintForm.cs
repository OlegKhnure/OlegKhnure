using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крилаті_Вислови
{
    public partial class AllPrintForm : Form
    {
        private int index = 0;
        private float yOffset = 100;
        private List<Curiosity> curiosities;
        private CuriositiesManager manager;
        public AllPrintForm(List<Curiosity> curiosities, CuriositiesManager manager)
        {
            InitializeComponent();
            EffectToButtons(this);
            this.curiosities = curiosities;
            this.manager = manager;
            UpdateCuriosities();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }
        private void UpdateCuriosities()
        {
            flowLayoutPanelCurios.Controls.Clear();
            int yOffset = 0;

            foreach (var curiosity in curiosities)
            {

                Panel curiosityPanel = new Panel
                {
                    Width = flowLayoutPanelCurios.Width - 25,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(0, yOffset),
                    AutoSize = true,
                    Tag = curiosity
                };

                Label labelId = new Label
                {
                    Text = $"ID: {curiosity.Id}",
                    Location = new Point(curiosityPanel.Width - 100, 10),
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold)
                };
                Label labelType = new Label
                {
                    Text = $"{curiosity.Type}",
                    Location = new Point(10, 10),
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold)
                };

                Label labelText = new Label
                {
                    Location = new Point(10, 50),
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    AutoSize = true,
                    MaximumSize = new Size(curiosityPanel.Width - 20, 0)
                };
                SetLabelText(labelText, curiosity.Text, curiosityPanel.Width - 20);
                curiosityPanel.Controls.Add(labelText);
                int bottomPadding = 10;
                int newBottomY = labelText.Bottom + bottomPadding;

                Label labelAuthor = new Label
                {
                    Text = $"{curiosity.Author}",
                    Location = new Point(curiosityPanel.Width - 400, newBottomY),
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Italic)
                };

                curiosityPanel.Controls.Add(labelId);
                curiosityPanel.Controls.Add(labelType);
                curiosityPanel.Controls.Add(labelAuthor);

                curiosityPanel.Height = Math.Max(labelText.Bottom, labelAuthor.Bottom + bottomPadding);
                flowLayoutPanelCurios.Controls.Add(curiosityPanel);

                yOffset += curiosityPanel.Height + 10;
            }
        }
        private void SetLabelText(Label label, string text, int maxWidth)
        {
            string[] words = text.Split(' ');
            StringBuilder line = new StringBuilder();
            StringBuilder paragraph = new StringBuilder();

            foreach (var word in words)
            {
                Size textSize = TextRenderer.MeasureText(line.ToString() + word + " ", label.Font);

                if (textSize.Width > maxWidth)
                {
                    paragraph.AppendLine(line.ToString());
                    line.Clear();
                }

                line.Append(word + " ");
            }

            paragraph.Append(line.ToString());
            label.Text = paragraph.ToString();
        }
        private void EffectToButtons(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Button button)
                {
                    button.MouseEnter += new EventHandler(colorEnter_MouseEnter);
                    button.MouseLeave += new EventHandler(colorLeave_MouseLeave);
                }
                else if (ctrl.HasChildren)
                {
                    EffectToButtons(ctrl);
                }
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            float totalWidth = 700;
            float pageHeight = e.PageSettings.PrintableArea.Height;

            while (index < curiosities.Count)
            {
                Curiosity curiosity = curiosities[index];
  
                SizeF textSize = MeasureSize(e.Graphics, curiosity.Text, new Font("Arial", 12, FontStyle.Regular), totalWidth - 20);
                SizeF authorSize = e.Graphics.MeasureString(curiosity.Author, new Font("Microsoft Sans Serif", 12, FontStyle.Italic));

                float totalHeight = textSize.Height + authorSize.Height + 100;

                if (yOffset + totalHeight > pageHeight)
                {
                    e.HasMorePages = true;
                    yOffset = 100;
                    return;
                }

                PointF topLeftPosition = new PointF(90, yOffset);
                RectangleF totalRect = new RectangleF(topLeftPosition.X, topLeftPosition.Y, totalWidth, totalHeight);

                PointF typePosition = new PointF(topLeftPosition.X + 10, topLeftPosition.Y + 10);
                PointF idPosition = new PointF(topLeftPosition.X + totalWidth - 100, topLeftPosition.Y + 10);
                PointF textPosition = new PointF(topLeftPosition.X + 10, typePosition.Y + 40);
                PointF authorPosition = new PointF(totalWidth - 300, textPosition.Y + textSize.Height + 10);

                e.Graphics.FillRectangle(Brushes.LightGray, totalRect);

                DrawText(e.Graphics, curiosity.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, textPosition, totalWidth - 20);
                e.Graphics.DrawString($"ID: {curiosity.Id}", new Font("Microsoft Sans Serif", 16, FontStyle.Bold), Brushes.Black, idPosition);
                e.Graphics.DrawString($"{curiosity.Author}", new Font("Microsoft Sans Serif", 12, FontStyle.Italic), Brushes.Black, authorPosition);
                e.Graphics.DrawString($"{curiosity.Type}", new Font("Microsoft Sans Serif", 16, FontStyle.Bold), Brushes.Black, typePosition);


                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(totalRect));
                yOffset += totalHeight + 10;
                index++;
            }
            if (index >= curiosities.Count)
            {
                e.HasMorePages = false;
                index = 0;
                yOffset = 100;
            }
        }
        private SizeF MeasureSize(Graphics gtext, string text, Font font, float maxWidth)
        {
            string[] words = text.Split(' ');
            StringBuilder currentLine = new StringBuilder();
            float currentWidth = 0;
            float totalHeight = 0;

            foreach (string word in words)
            {
                    SizeF wordSize = gtext.MeasureString(word, font);
                    if (currentWidth + wordSize.Width < maxWidth)
                {
                    currentLine.Append(word + " ");
                    currentWidth += wordSize.Width;
                }
                else
                {
                    totalHeight += gtext.MeasureString(currentLine.ToString(), font).Height;
                    currentLine = new StringBuilder(word + " ");
                    currentWidth = wordSize.Width;
                }
            }
            totalHeight += gtext.MeasureString(currentLine.ToString(), font).Height;
            return new SizeF(maxWidth, totalHeight);
        }
        private void DrawText(Graphics g, string text, Font font, Brush brush, PointF position, float maxWidth)
        {
            string[] words = text.Split(' ');
            StringBuilder currentLine = new StringBuilder();
            float currentWidth = 0;

            foreach (string word in words)
            {
                SizeF wordSize = g.MeasureString(word, font);
                if (currentWidth + wordSize.Width < maxWidth)
                {
                    currentLine.Append(word + " ");
                    currentWidth += wordSize.Width;
                }
                else
                {
                    g.DrawString(currentLine.ToString(), font, brush, position);
                    position.Y += font.GetHeight();
                    currentLine = new StringBuilder(word + " ");
                    currentWidth = wordSize.Width;
                }
            }

            g.DrawString(currentLine.ToString(), font, brush, position);
        }
        private string GetAllCuriosityIdsAsString()
        {
            StringBuilder idString = new StringBuilder();

            foreach (var curiosity in curiosities)
            {
                idString.Append(curiosity.Id);
                idString.Append(", "); 
            }

            if (idString.Length >= 2)
            {
                idString.Length -= 2;
            }

            return idString.ToString();
        }
        private void printPreviewButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            var allIds = GetAllCuriosityIdsAsString();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                AddToHistory($"Печать такої кількості {curiosities.Count}. Це: {allIds}");
                printDocument.Print();   
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void colorLeave_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.RoyalBlue;
            }

        }
        private void colorEnter_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.DarkBlue;
            }
        }
        private void AddToHistory(string action)
        {
            manager.ActionHistory.AddAction(action);
        }
    }
}

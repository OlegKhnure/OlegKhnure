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
    public partial class PrintForm : Form
    {
        private CuriositiesManager manager;
        private Curiosity curiosity;

        public PrintForm(Curiosity curiosity, CuriositiesManager manager)
        {
            this.manager = manager;
            this.curiosity = curiosity;
            InitializeComponent();
            EffectToButtons(this);
            DisplayCuriosity();
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
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
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PointF topLeftPosition = new PointF(90, 100);
            float totalWidth = 700;

            SizeF textSize = MeasureSize(e.Graphics, curiosity.Text, new Font("Arial", 12, FontStyle.Regular), totalWidth - 20);
            SizeF authorSize = e.Graphics.MeasureString(curiosity.Author, new Font("Microsoft Sans Serif", 12, FontStyle.Italic));

            float totalHeight = textSize.Height + authorSize.Height + 100;

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

        private void printPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void print_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                AddToHistory($"Печать {curiosity.Type} под {curiosity.Id}");
                printDocument1.Print();
            }
        }
        private void DisplayCuriosity()
        {
            labelId.Text = $"ID: {curiosity.Id}";
            labelType.Text = $"Тип: {curiosity.Type}";
            SetFlowPanelText(curiosPrintFlowLayoutPanel, curiosity.Text, curiosPrintFlowLayoutPanel.Width - 20);
            labelAuthor.Text = $"Автор: {curiosity.Author}";
        }
        private void SetFlowPanelText(FlowLayoutPanel flowPanel, string text, int maxWidth)
        {
            flowPanel.Controls.Clear();

            string[] words = text.Split(' ');
            StringBuilder line = new StringBuilder();

            foreach (var word in words)
            {
                Size textSize = TextRenderer.MeasureText(line.ToString() + word + " ", labelText.Font);

                if (textSize.Width > maxWidth)
                {
                    Label labelLine = new Label
                    {
                        Text = line.ToString(),
                        Font = labelText.Font,
                        AutoSize = true,
                        MaximumSize = new Size(maxWidth, 0)
                    };
                    flowPanel.Controls.Add(labelLine);
                    line.Clear();
                }

                line.Append(word + " ");
            }
            if (line.Length > 0)
            {
                Label labelLine = new Label
                {
                    Text = line.ToString(),
                    Font = labelText.Font,
                    AutoSize = true,
                    MaximumSize = new Size(maxWidth, 0)
                };
                flowPanel.Controls.Add(labelLine);
            }
        }
        private void AddToHistory(string action)
        {
            manager.ActionHistory.AddAction(action);
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
    }
}

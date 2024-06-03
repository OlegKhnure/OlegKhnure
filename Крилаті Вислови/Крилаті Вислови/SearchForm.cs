using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Крилаті_Вислови
{
    public partial class SearchForm : Form
    {
        private string searchCriteria = "";
        private string searchText = "";
        private bool filterByFavorites = false;
        private CuriositiesManager manager;
        private List<Curiosity> curiosities;
        public SearchForm(CuriositiesManager manager, List<Curiosity> searchResults)
        {
            InitializeComponent();
            this.FormClosing += SearchForm_FormClosing;
            EffectToButtons(this);
            this.manager = manager;
            this.curiosities = searchResults;
            UpdateCuriosities();

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

        private void UpdateCuriosities()
        {
            flowPanel.Controls.Clear();
            int yOffset = 0;

            foreach (var curiosity in curiosities)
            {

                Panel curiosityPanel = new Panel
                {
                    Width = flowPanel.Width - 25,
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

                CheckBox checkBoxSelect = new CheckBox
                {
                    Location = new Point(curiosityPanel.Width - 25, newBottomY - 25),
                    Size = new Size(20, 20),
                    Cursor = System.Windows.Forms.Cursors.Hand,
                    Tag = curiosity
                };

                PictureBox editButton = new PictureBox
                {
                    Size = new Size(40, 40),
                    Location = new Point(curiosityPanel.Width - 150, newBottomY),
                    Image = Properties.Resources.edit,
                    Cursor = System.Windows.Forms.Cursors.Hand
                };
                editButton.Click += (s, e) => Edit_Click(curiosity);

                PictureBox printButton = new PictureBox
                {
                    Size = new Size(40, 40),
                    Location = new Point(curiosityPanel.Width - 100, newBottomY),
                    Image = Properties.Resources.print,
                    Cursor = System.Windows.Forms.Cursors.Hand
                };
                printButton.Click += (s, e) => Print_Click(curiosity);

                PictureBox favouriteButton = new PictureBox
                {
                    Size = new Size(40, 40),
                    Location = new Point(curiosityPanel.Width - 50, newBottomY),
                    Image = curiosity.IsFavorite ? Properties.Resources.favourite : Properties.Resources.unfavourite,
                    Cursor = System.Windows.Forms.Cursors.Hand
                };
                favouriteButton.Click += (s, e) => ToggleFavorite_Click(curiosity);

                curiosityPanel.Controls.Add(labelId);
                curiosityPanel.Controls.Add(labelType);
                curiosityPanel.Controls.Add(labelAuthor);
                curiosityPanel.Controls.Add(checkBoxSelect);
                curiosityPanel.Controls.Add(editButton);
                curiosityPanel.Controls.Add(printButton);
                curiosityPanel.Controls.Add(favouriteButton);

                curiosityPanel.Height = Math.Max(labelText.Bottom, labelAuthor.Bottom + bottomPadding);
                flowPanel.Controls.Add(curiosityPanel);

                yOffset += curiosityPanel.Height + 10;
            }
        }
        private void ToggleFavorite_Click(Curiosity curiosity)
        {
            if (curiosity != null)
            {
                manager.SetFavorite(curiosity.Id, curiosity.IsFavorite);
                string action = curiosity.IsFavorite ? "добавлено до улюблених" : "видалено з улюблених";
                AddToHistory($"Курйоз з ID {curiosity.Id}, {action}");
                UpdateCuriosities();
            }
        }
        private void Edit_Click(Curiosity curiosity)
        {
            EditForm editForm = new EditForm(curiosity, manager);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                UpdateCuriosities();
            }
        }
        private void Print_Click(Curiosity curiosity)
        {    
            using (PrintForm printForm = new PrintForm(curiosity, manager))
            {
                printForm.ShowDialog();
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
        private void sortByType_Click(object sender, EventArgs e)
        {
            AddToHistory("Сортування по типу");
            curiosities = curiosities.OrderBy(c => c.Type).ToList();
            UpdateCuriosities();
        }

        private void sortByAuthor_Click(object sender, EventArgs e)
        {
            AddToHistory("Сортування по автору");
            curiosities = curiosities.OrderBy(c => c.Author).ToList();
            UpdateCuriosities();
        }

        private void sortByText_Click(object sender, EventArgs e)
        {
            AddToHistory("Сортування по тексту");
            curiosities = curiosities.OrderBy(c => c.Text).ToList();
            UpdateCuriosities();
        }

        private void sortById_Click(object sender, EventArgs e)
        {
            AddToHistory("Сортування по ID");
            curiosities = curiosities.OrderBy(c => c.Id).ToList();
            UpdateCuriosities();
        }
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (searchFormBox.Text == "Пошук...")
            {
                searchFormBox.Text = searchText;
                searchFormBox.ForeColor = Color.Black;
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchFormBox.Text))
            {
                searchFormBox.Text = "Пошук...";
                searchFormBox.ForeColor = Color.Gray;
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            if (mainForm != null)
            {
                mainForm.Show();
            }
        }
        private void againSearchButton_Click(object sender, EventArgs e)
        {
            if (searchFormBox.Text == "Пошук...")
            {
                searchFormBox.Text = "";
            }
            string searchText = searchFormBox.Text;
            string searchCriteria = comboBoxFilter.SelectedItem?.ToString() ?? "Текст";

            List<Curiosity> searchResults = manager.FilterCuriosities(searchText, searchCriteria, filterByFavorites);

            AddToHistory($"Пошук по '{searchText}' з критерієм '{searchCriteria}'.");

            this.curiosities = searchResults;
            UpdateCuriosities();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchText = searchFormBox.Text;
        }
        private void history_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(manager);
            historyForm.ShowDialog();
        }
        private void Liked_Click(object sender, EventArgs e)
        {
            filterByFavorites = !filterByFavorites;
            againSearchButton.Image = filterByFavorites ? Properties.Resources.searchFavourite : Properties.Resources.search;
        }
        private void AddToHistory(string action)
        {
            manager.ActionHistory.AddAction(action);
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                int index = comboBoxFilter.SelectedIndex;

                switch (index)
                {
                    case 0:
                        searchCriteria = "Текст";
                        searchFormBox.KeyPress -= searchBox_KeyPress;
                        break;
                    case 1:
                        searchCriteria = "Автор";
                        searchFormBox.KeyPress -= searchBox_KeyPress;
                        break;
                    case 2:
                        searchCriteria = "Тип";
                        searchFormBox.KeyPress -= searchBox_KeyPress;
                        break;
                    case 3:
                        searchCriteria = "ID";
                        searchFormBox.KeyPress += searchBox_KeyPress;
                        break;
                    default:
                        searchCriteria = "Текст";
                        searchFormBox.KeyPress -= searchBox_KeyPress;
                        break;
                }
            }
        }
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void buttonPrintAll_Click(object sender, EventArgs e)
        {
            var selectedCuriosities = flowPanel.Controls.OfType<Panel>().Where(panel => panel.Controls.OfType<CheckBox>().FirstOrDefault()?.Checked ?? false).Select(panel => panel.Tag as Curiosity).ToList();

            if (selectedCuriosities.Any())
            {
                using (AllPrintForm allPrintForm = new AllPrintForm(selectedCuriosities, manager))
                {
                    allPrintForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть курйози для друку.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace Крилаті_Вислови
{
    public partial class MainForm : Form
    {
        private string searchCriteria = "";
        private string searchText = "";
        private CuriositiesManager manager;
        private bool filterByFavorites = false;
        public MainForm(CuriositiesManager manager)
        {
            InitializeComponent();
            EffectToButtons(this);
            this.manager = manager;
            UpdateLabelsRandom();
            this.FormClosing += MainForm_FormClosing;
        }

        private void UpdateLabelsRandom()
        {
            Curiosity randomCuriosity = manager.GetRandom();
            if (randomCuriosity != null)
            {
                labelId.Text = $"ID: {randomCuriosity.Id}";
                labelText.Text = $"Текст: {randomCuriosity.Text}";
                labelType.Text = $"Тип: {randomCuriosity.Type}";
                labelAuthor.Text = $"Автор: {randomCuriosity.Author}";
                favouriteButton.Image = randomCuriosity.IsFavorite ? Properties.Resources.favourite : Properties.Resources.unfavourite;

                SetFlowPanelText(curiosLayoutPanel, randomCuriosity.Text, curiosLayoutPanel.Width - 20);
            }
            else
            {
                labelId.Text = "ID:";
                labelText.Text = "Текст:";
                labelType.Text = "Тип:";
                labelAuthor.Text = "Автор:";
            }
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
        private void Exit_Button(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NextRandom_Click(object sender, EventArgs e)
        {
            UpdateLabelsRandom();
        }
        private void LikedHistory_Click(object sender, EventArgs e)
        {
            filterByFavorites = !filterByFavorites;
            searchButton.Image = filterByFavorites ? Properties.Resources.searchFavourite : Properties.Resources.search;
        }
        private void History_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(manager);
            historyForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchText = searchBox.Text;
        }
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Пошук...")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }
        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Пошук...";
                searchBox.ForeColor = Color.Gray;
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (searchBox.Text == "Пошук...")
            {
                searchBox.Text = "";
            }
            string searchText = searchBox.Text;
            string searchCriteria = comboBoxFilter.SelectedItem?.ToString() ?? "Текст";

            List<Curiosity> searchResults = manager.FilterCuriosities(searchText, searchCriteria, filterByFavorites);

            AddToHistory($"Пошук по '{searchText}' з критерієм '{searchCriteria}'.");

            SearchForm searchForm = new SearchForm(manager, searchResults);
            searchForm.Show();
        }
        private void Favourite_Click(object sender, EventArgs e)
        {
            if (int.TryParse(labelId.Text.Replace("ID: ", ""), out int id))
            {
                var curiosity = manager.GetCuriosityById(id);
                if (curiosity != null)
                {
                    manager.SetFavorite(id, curiosity.IsFavorite);
                    favouriteButton.Image = curiosity.IsFavorite ? Properties.Resources.favourite : Properties.Resources.unfavourite;
                    string action = curiosity.IsFavorite ? "добавлено до улюблених" : "видалено з улюблених";
                    AddToHistory($"Курйоз з ID: {id}, {action}");

                }
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (manager.HasChanges())
            {
                DialogResult result = MessageBox.Show("Зберегти зміни перед вихідом?", "Збереження", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    AddToHistory("Зроблено збереження.");
                    manager.SaveAll();

                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string text = addForm.GetText();
                string author = addForm.GetAuthor();
                string type = addForm.GetType();
                manager.Add(new Curiosity(0, text, type, author, false));
                AddToHistory($"Добавлен {type} з '{text}'.");
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm = new RemoveForm(manager);
            removeForm.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            manager.SaveAll();
            MessageBox.Show("Збереження зроблено.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddToHistory("Зроблено збереження.");
        }
        private void AddToHistory(string action)
        {
            manager.ActionHistory.AddAction(action);
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxFilter.SelectedIndex;

            switch (index)
            {
                case 0:
                    searchCriteria = "Текст";
                    searchBox.KeyPress -= searchBox_KeyPress;
                    break;
                case 1:
                    searchCriteria = "Автор";
                    searchBox.KeyPress -= searchBox_KeyPress;
                    break;
                case 2:
                    searchCriteria = "Тип";
                    searchBox.KeyPress -= searchBox_KeyPress;
                    break;
                case 3:
                    searchCriteria = "ID";
                    searchBox.KeyPress += searchBox_KeyPress;
                    break;
                default:
                    searchCriteria = "Текст";
                    searchBox.KeyPress -= searchBox_KeyPress;
                    break;
            }
        }
        private void Print_Click(object sender, EventArgs e)
        {
            if (int.TryParse(labelId.Text.Replace("ID: ", ""), out int id))
            {
                var curiosity = manager.GetCuriosityById(id);
                using (PrintForm printForm = new PrintForm(curiosity, manager))
                {
                    printForm.ShowDialog();
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

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(labelId.Text.Replace("ID: ", ""), out int id))
            {
                var curiosity = manager.GetCuriosityById(id);
                EditForm editForm = new EditForm(curiosity, manager);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateLabelsRandom();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крилаті_Вислови
{
    public partial class EditCuriosityForm : Form
    {
        private Curiosity curiosity;
        private CuriositiesManager manager;
        public EditCuriosityForm(Curiosity curiosity, CuriositiesManager manager)
        {
            InitializeComponent();
            manager = new CuriositiesManager("C:\\Users\\OLEG\\Desktop\\TRUE FORM OF HOMEWORK\\ООПro\\Курсова\\Крилаті Вислови\\Крилаті Вислови\\Курйози.txt");
            textBoxText.Text = curiosity.Text;
            textAuthor.Text = curiosity.Author;
            labelId.Text = $"{curiosity.Id}";
            
            InitializeComboBox();

            DisplayCuriosity(curiosity);
        }
        private void DisplayCuriosity(Curiosity curiosity)
        {
            flowPanel.Controls.Clear();
            int yOffset = 0;

            Panel curiosityPanel = new Panel
            {
                Width = flowPanel.Width - 25,
                Height = 150,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(0, yOffset)
            };

            Label labelId = new Label
            {
                Text = $"ID: {curiosity.Id}",
                Location = new Point(curiosityPanel.Width - 70, 10),
                AutoSize = true
            };
            Label labelType = new Label
            {
                Text = $"Type: {curiosity.Type}",
                Location = new Point(10, 10),
                AutoSize = true
            };
            Label labelText = new Label
            {
                Text = $"Text: {curiosity.Text}",
                Location = new Point(10, 30),
                AutoSize = true
            };
            Label labelAuthor = new Label
            {
                Text = $"Author: {curiosity.Author}",
                Location = new Point(10, labelText.Height + 50),
                AutoSize = true
            };

            curiosityPanel.Controls.Add(labelId);
            curiosityPanel.Controls.Add(labelType);
            curiosityPanel.Controls.Add(labelText);
            curiosityPanel.Controls.Add(labelAuthor);

            flowPanel.Controls.Add(curiosityPanel);
        }
        private void InitializeComboBox()
        {
            comboBoxType.Items.Add("Афоризм");
            comboBoxType.Items.Add("Пословица");
            comboBoxType.Items.Add("Цитата");
            comboBoxType.SelectedIndex = 0;
        }
        public Curiosity GetCuriosity(Curiosity curiosity)
        {
            string text = textBoxText.Text;
            string author = textAuthor.Text;
            string type = comboBoxType.SelectedItem?.ToString();
            return curiosity;             
        }
        private void Agree_Click(object sender, EventArgs e)
        {
            string text = textBoxText.Text;
            string author = textAuthor.Text;
            string type = comboBoxType.SelectedItem?.ToString();
            int id = int.Parse(labelId.Text);
            bool favourite = false;
            Curiosity curiosity = new Curiosity(id, text, type, author, favourite);
            manager = new CuriositiesManager("C:\\Users\\OLEG\\Desktop\\TRUE FORM OF HOMEWORK\\ООПro\\Курсова\\Крилаті Вислови\\Крилаті Вислови\\Курйози.txt");
            DialogResult result = MessageBox.Show("Хотите перезаписать текущий курьез?", "Сохранить курьез", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                manager.SaveCuriosity(curiosity);
            }
            else if (result == DialogResult.No)
            {
                manager.SaveAll();
            }
            else if (result == DialogResult.Cancel)
            {
                Close();
            }

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}

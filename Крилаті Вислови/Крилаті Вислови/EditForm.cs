using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крилаті_Вислови
{
    public partial class EditForm : Form
    {
        private Curiosity curiosity;
        private CuriositiesManager manager;
        public EditForm(Curiosity curiosity, CuriositiesManager manager)
        {
            InitializeComponent();
            EffectToButtons(this);
            this.curiosity = curiosity;
            this.manager = manager;
            LoadCuriosityData();
        }

        private void LoadCuriosityData()
        {
            labelId.Text = $"ID: {curiosity.Id}";
            textBoxText.Text = curiosity.Text;
            comboBoxType.SelectedItem = curiosity.Type;
            textBoxAuthor.Text = curiosity.Author;
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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            curiosity.Text = textBoxText.Text;
            curiosity.Type = comboBoxType.SelectedItem.ToString();
            curiosity.Author = textBoxAuthor.Text;
            DialogResult = DialogResult.OK;
            manager.SaveAll();
            Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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

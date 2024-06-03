using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace Крилаті_Вислови
{
    public partial class RemoveForm : Form
    {
        private CuriositiesManager manager;
        public RemoveForm(CuriositiesManager manager)
        {  
            InitializeComponent();
            EffectToButtons(this);
            this.manager = manager;
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
        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(idTextBox.Text, out int id))
            {
                var curiosity = manager.GetCuriosityById(id);

                if (curiosity != null) 
                {
                    DisplayCuriosity(curiosity);
                }
                else 
                {
                    ClearCuriosityInfo();
                }
            }
            else 
            {
                ClearCuriosityInfo();
            }
        }
        private void DisplayCuriosity(Curiosity curiosity)
        {
            labelType.Text = $"Тип: {curiosity.Type}";
            SetFlowPanelText(curiosRemoveFlowLayoutPanel, curiosity.Text, curiosRemoveFlowLayoutPanel.Width - 20);
            labelAuthor.Text = $"Автор: {curiosity.Author}";
        }
        private void ClearCuriosityInfo()
        {
            labelType.Text = "Тип:";
            curiosRemoveFlowLayoutPanel.Controls.Clear();
            labelAuthor.Text = "Автор:";
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
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idTextBox.Text, out int id))
            {
                var curiosity = manager.GetCuriosityById(id);
                if (curiosity != null)
                {
                    var result = MessageBox.Show($"Ви впевнені, що хочете видалити \"{curiosity.Type}\" з ID: {curiosity.Id}?", "Підтвердити видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        manager.Remove(id);
                        AddToHistory($"Видален курйоз з ID: {id}.");
                        MessageBox.Show("Курйоз успішно видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Курйоз з указаним ID не знайден.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть дійсний ID.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idTextBox_Enter(object sender, EventArgs e)
        {
            if (idTextBox.Text == "Пошук...")
            {
                idTextBox.Text = "";
                idTextBox.ForeColor = Color.Black;
            }
        }

        private void idTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox.Text))
            {
                idTextBox.Text = "Пошук...";
                idTextBox.ForeColor = Color.Gray;
            }
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SelectableLayoutPanel : UserControl
    {
        private List<EntityItem> selected = new List<EntityItem>();

        private Color selectedColor = Color.Gray, unselectedColor = Color.White;

        public SelectableLayoutPanel()
        {
            InitializeComponent();
        }

        private void SelectableLayoutPanel_Load(object sender, EventArgs e)
        {
            
        }

        public void AddEntityItem(EntityItem item)
        {
            Controls.Find("EntityList", true)[0].Controls.Add(item);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void AddItem()
        {
            if (NameText.Text != "" && !((Form1)Form.ActiveForm).ContainsName(NameText.Text))
            {
                EntityItem entityItem = new EntityItem(this);
                ((Label)entityItem.Controls.Find("EntityName", true)[0]).Text = NameText.Text;
                AddEntityItem(entityItem);
                ((Form1)Form.ActiveForm).AddEntity(entityItem);
            }
        }

        public void SelectItem(EntityItem item)
        {
            if (ModifierKeys.HasFlag(Keys.Shift))
            {
                item.BackColor = selectedColor;
                selected.Add(item);
            }
            else
            {
                foreach (EntityItem i in selected.ToList())
                {
                    i.BackColor = unselectedColor;
                    selected.Remove(i);
                }
                selected.Add(item);
                selected[0].BackColor = selectedColor;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                DeletePressed();
            }
        }

        public void DeselectItems()
        {
            foreach (EntityItem item in selected)
            {
                item.BackColor = unselectedColor;
            }
            selected.Clear();
        }
    }
}

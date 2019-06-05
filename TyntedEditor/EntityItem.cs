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
    public partial class EntityItem : UserControl
    {
        public EntityItem(SelectableLayoutPanel panel)
        {
            InitializeComponent();

            myPanel = panel;
        }

        public SelectableLayoutPanel myPanel;

        private void EntityItem_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.Click += new EventHandler(ItemSelected);
            }
        }

        private void ItemSelected(object sender, EventArgs e)
        {
            myPanel.SelectItem(this);
        }

        private void EntityList_Clicked(object sender, PaintEventArgs e)
        {
            myPanel.DeselectItems();
        }
    }
}

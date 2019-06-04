using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class SelectableLayoutPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EntityList = new System.Windows.Forms.FlowLayoutPanel();
            this.NameText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntityList.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntityList
            // 
            this.EntityList.Controls.Add(this.NameText);
            this.EntityList.Controls.Add(this.menuStrip1);
            this.EntityList.Location = new System.Drawing.Point(0, 0);
            this.EntityList.Name = "EntityList";
            this.EntityList.Size = new System.Drawing.Size(231, 423);
            this.EntityList.TabIndex = 0;
            this.EntityList.Click += new System.EventHandler(this.EntityList_Clicked);
            this.EntityList.HorizontalScroll.Maximum = 0;
            this.EntityList.AutoScroll = false;
            this.EntityList.VerticalScroll.Visible = false;
            this.EntityList.AutoScroll = true;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(3, 3);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 2;
            this.NameText.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(106, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(111, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // SelectableLayoutPanel
            // 
            this.Controls.Add(this.EntityList);
            this.Name = "SelectableLayoutPanel";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(231, 423);
            this.EntityList.ResumeLayout(false);
            this.EntityList.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Delete:
                    {
                        DeletePressed();
                        break;
                    }
                case Keys.Enter:
                    {
                        AddItem();
                        break;
                    }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void DeletePressed()
        {
            //Deletes all the selected items.
            foreach (EntityItem item in selected)
            {
                Controls.Remove(item);
                ((Form1)Form.ActiveForm).RemoveEntity(item);
                item.Dispose();
            }
            selected.Clear();
        }

        private void EntityList_Clicked(object sender, EventArgs e)
        {
            DeselectItems();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel EntityList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private TextBox NameText;
    }
}

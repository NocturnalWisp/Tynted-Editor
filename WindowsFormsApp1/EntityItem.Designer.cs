namespace WindowsFormsApp1
{
    partial class EntityItem
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
            this.EntityName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntityName
            // 
            this.EntityName.AutoSize = true;
            this.EntityName.Location = new System.Drawing.Point(5, 5);
            this.EntityName.Margin = new System.Windows.Forms.Padding(5);
            this.EntityName.Name = "EntityName";
            this.EntityName.Size = new System.Drawing.Size(64, 13);
            this.EntityName.TabIndex = 0;
            this.EntityName.Text = "Entity Name";
            this.EntityName.Click += new System.EventHandler(this.ItemSelected);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EntityName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 23);
            this.panel1.TabIndex = 1;
            // 
            // EntityItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "EntityItem";
            this.Size = new System.Drawing.Size(213, 23);
            this.Load += new System.EventHandler(this.EntityItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EntityName;
        private System.Windows.Forms.Panel panel1;
    }
}

namespace UiGraf
{
    partial class StartMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.стартоваяВершинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxWithStartVertex = new System.Windows.Forms.ToolStripComboBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.стартоваяВершинаToolStripMenuItem,
            this.comboBoxWithStartVertex});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStrip,
            this.saveToolStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openFileToolStrip
            // 
            this.openFileToolStrip.Name = "openFileToolStrip";
            this.openFileToolStrip.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStrip.Text = "Открыть файл";
            this.openFileToolStrip.Click += new System.EventHandler(this.openFileToolStrip_Click);
            // 
            // saveToolStrip
            // 
            this.saveToolStrip.Name = "saveToolStrip";
            this.saveToolStrip.Size = new System.Drawing.Size(180, 22);
            this.saveToolStrip.Text = "Сохранить в файл";
            this.saveToolStrip.Click += new System.EventHandler(this.saveToolStrip_Click);
            // 
            // стартоваяВершинаToolStripMenuItem
            // 
            this.стартоваяВершинаToolStripMenuItem.Name = "стартоваяВершинаToolStripMenuItem";
            this.стартоваяВершинаToolStripMenuItem.Size = new System.Drawing.Size(128, 23);
            this.стартоваяВершинаToolStripMenuItem.Text = "Стартовая вершина";
            // 
            // comboBoxWithStartVertex
            // 
            this.comboBoxWithStartVertex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWithStartVertex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWithStartVertex.Name = "comboBoxWithStartVertex";
            this.comboBoxWithStartVertex.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWithStartVertex.Sorted = true;
            this.comboBoxWithStartVertex.SelectedIndexChanged += new System.EventHandler(this.comboBoxWithStartVertex_SelectedIndexChanged);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DimGray;
            this.panelMain.Controls.Add(this.labelAnswer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1230, 276);
            this.panelMain.TabIndex = 1;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoEllipsis = true;
            this.labelAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAnswer.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.ForeColor = System.Drawing.Color.White;
            this.labelAnswer.Location = new System.Drawing.Point(0, 0);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(1230, 276);
            this.labelAnswer.TabIndex = 0;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 303);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStrip;
        private System.Windows.Forms.ToolStripComboBox comboBoxWithStartVertex;
        private System.Windows.Forms.ToolStripMenuItem стартоваяВершинаToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelAnswer;
    }
}


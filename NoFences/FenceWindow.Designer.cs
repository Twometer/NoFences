namespace NoFences
{
    partial class FenceWindow
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItemToolStripMenuItem,
            this.lockedToolStripMenuItem,
            this.minifyToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripSeparator1,
            this.newFenceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 142);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // lockedToolStripMenuItem
            // 
            this.lockedToolStripMenuItem.CheckOnClick = true;
            this.lockedToolStripMenuItem.Name = "lockedToolStripMenuItem";
            this.lockedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lockedToolStripMenuItem.Text = "Lock";
            // 
            // minifyToolStripMenuItem
            // 
            this.minifyToolStripMenuItem.CheckOnClick = true;
            this.minifyToolStripMenuItem.Name = "minifyToolStripMenuItem";
            this.minifyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minifyToolStripMenuItem.Text = "Minify";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Close Fence";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // newFenceToolStripMenuItem
            // 
            this.newFenceToolStripMenuItem.Name = "newFenceToolStripMenuItem";
            this.newFenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFenceToolStripMenuItem.Text = "New Fence";
            this.newFenceToolStripMenuItem.Click += new System.EventHandler(this.newFenceToolStripMenuItem_Click);
            // 
            // FenceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(465, 540);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FenceWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Fence";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FenceWindow_FormClosed);
            this.Click += new System.EventHandler(this.FenceWindow_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FenceWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FenceWindow_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FenceWindow_Paint);
            this.DoubleClick += new System.EventHandler(this.FenceWindow_DoubleClick);
            this.MouseLeave += new System.EventHandler(this.FenceWindow_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FenceWindow_MouseMove);
            this.Resize += new System.EventHandler(this.FenceWindow_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lockedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFenceToolStripMenuItem;
    }
}


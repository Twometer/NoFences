
namespace NoFences
{
    partial class HeightDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeightDialog));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.trackBarTitleHeight = new System.Windows.Forms.TrackBar();
            this.labelTitleHeight = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTitleHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // trackBarTitleHeight
            // 
            resources.ApplyResources(this.trackBarTitleHeight, "trackBarTitleHeight");
            this.trackBarTitleHeight.Maximum = 100;
            this.trackBarTitleHeight.Minimum = 20;
            this.trackBarTitleHeight.Name = "trackBarTitleHeight";
            this.trackBarTitleHeight.Value = 20;
            this.trackBarTitleHeight.Scroll += new System.EventHandler(this.trackBarTitleHeight_Scroll);
            // 
            // labelTitleHeight
            // 
            resources.ApplyResources(this.labelTitleHeight, "labelTitleHeight");
            this.labelTitleHeight.Name = "labelTitleHeight";
            // 
            // btnRestore
            // 
            resources.ApplyResources(this.btnRestore, "btnRestore");
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // HeightDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.labelTitleHeight);
            this.Controls.Add(this.trackBarTitleHeight);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HeightDialog";
            this.Load += new System.EventHandler(this.HeightDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTitleHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TrackBar trackBarTitleHeight;
        private System.Windows.Forms.Label labelTitleHeight;
        private System.Windows.Forms.Button btnRestore;
    }
}
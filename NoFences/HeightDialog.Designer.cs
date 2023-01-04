
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
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(308, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(246, 80);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // trackBarTitleHeight
            // 
            this.trackBarTitleHeight.Location = new System.Drawing.Point(12, 20);
            this.trackBarTitleHeight.Maximum = 100;
            this.trackBarTitleHeight.Minimum = 20;
            this.trackBarTitleHeight.Name = "trackBarTitleHeight";
            this.trackBarTitleHeight.Size = new System.Drawing.Size(315, 45);
            this.trackBarTitleHeight.TabIndex = 6;
            this.trackBarTitleHeight.Value = 20;
            this.trackBarTitleHeight.Scroll += new System.EventHandler(this.trackBarTitleHeight_Scroll);
            // 
            // labelTitleHeight
            // 
            this.labelTitleHeight.AutoSize = true;
            this.labelTitleHeight.Location = new System.Drawing.Point(333, 23);
            this.labelTitleHeight.Name = "labelTitleHeight";
            this.labelTitleHeight.Size = new System.Drawing.Size(30, 13);
            this.labelTitleHeight.TabIndex = 7;
            this.labelTitleHeight.Text = "20px";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(12, 80);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(91, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restore default";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // HeightDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 117);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.labelTitleHeight);
            this.Controls.Add(this.trackBarTitleHeight);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HeightDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change title height";
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
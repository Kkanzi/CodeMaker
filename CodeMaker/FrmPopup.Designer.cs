namespace CodeMaker
{
    partial class FrmPopup
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
            this.txtBOX = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtBOX
            // 
            this.txtBOX.AnimateReadOnly = false;
            this.txtBOX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBOX.Depth = 0;
            this.txtBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBOX.HideSelection = true;
            this.txtBOX.LeadingIcon = null;
            this.txtBOX.Location = new System.Drawing.Point(12, 12);
            this.txtBOX.MaxLength = 32767;
            this.txtBOX.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBOX.Name = "txtBOX";
            this.txtBOX.PasswordChar = '\0';
            this.txtBOX.PrefixSuffixText = null;
            this.txtBOX.ReadOnly = false;
            this.txtBOX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBOX.SelectedText = "";
            this.txtBOX.SelectionLength = 0;
            this.txtBOX.SelectionStart = 0;
            this.txtBOX.ShortcutsEnabled = true;
            this.txtBOX.Size = new System.Drawing.Size(426, 48);
            this.txtBOX.TabIndex = 1;
            this.txtBOX.TabStop = false;
            this.txtBOX.Text = "materialTextBox21";
            this.txtBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBOX.TrailingIcon = null;
            this.txtBOX.UseSystemPasswordChar = false;
            this.txtBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBOX_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(300, 69);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(372, 69);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(66, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 113);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBOX);
            this.Name = "FrmPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "수정";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtBOX;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnClose;
    }
}
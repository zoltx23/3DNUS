﻿namespace _3DNUS.Core
{
    partial class dev_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_settings));
            this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.chck_dump_info = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_auto_upd = new MaterialSkin.Controls.MaterialCheckBox();
            this.new_3ds = new MaterialSkin.Controls.MaterialRadioButton();
            this.old_3ds = new MaterialSkin.Controls.MaterialRadioButton();
            this.lbl_sys_type = new MaterialSkin.Controls.MaterialLabel();
            this.btn_reset_settings = new MaterialSkin.Controls.MaterialFlatButton();
            this.chck_darktheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.chck_auto_dump = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.Depth = 0;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(287, 325);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = false;
            this.btn_save.Size = new System.Drawing.Size(113, 36);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save & Close";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chck_dump_info
            // 
            this.chck_dump_info.AutoSize = true;
            this.chck_dump_info.BackColor = System.Drawing.Color.Transparent;
            this.chck_dump_info.Depth = 0;
            this.chck_dump_info.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_dump_info.Location = new System.Drawing.Point(9, 84);
            this.chck_dump_info.Margin = new System.Windows.Forms.Padding(0);
            this.chck_dump_info.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_dump_info.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_dump_info.Name = "chck_dump_info";
            this.chck_dump_info.Ripple = true;
            this.chck_dump_info.Size = new System.Drawing.Size(271, 30);
            this.chck_dump_info.TabIndex = 1;
            this.chck_dump_info.Text = "When dumping log, Dump System Info? ";
            this.chck_dump_info.UseVisualStyleBackColor = false;
            // 
            // chck_auto_upd
            // 
            this.chck_auto_upd.AutoSize = true;
            this.chck_auto_upd.BackColor = System.Drawing.Color.Transparent;
            this.chck_auto_upd.Depth = 0;
            this.chck_auto_upd.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_auto_upd.Location = new System.Drawing.Point(9, 140);
            this.chck_auto_upd.Margin = new System.Windows.Forms.Padding(0);
            this.chck_auto_upd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_auto_upd.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_auto_upd.Name = "chck_auto_upd";
            this.chck_auto_upd.Ripple = true;
            this.chck_auto_upd.Size = new System.Drawing.Size(166, 30);
            this.chck_auto_upd.TabIndex = 2;
            this.chck_auto_upd.Text = "Enable Auto-Updates? ";
            this.chck_auto_upd.UseVisualStyleBackColor = false;
            // 
            // new_3ds
            // 
            this.new_3ds.AutoSize = true;
            this.new_3ds.BackColor = System.Drawing.Color.Transparent;
            this.new_3ds.Depth = 0;
            this.new_3ds.Font = new System.Drawing.Font("Roboto", 10F);
            this.new_3ds.Location = new System.Drawing.Point(9, 244);
            this.new_3ds.Margin = new System.Windows.Forms.Padding(0);
            this.new_3ds.MouseLocation = new System.Drawing.Point(-1, -1);
            this.new_3ds.MouseState = MaterialSkin.MouseState.HOVER;
            this.new_3ds.Name = "new_3ds";
            this.new_3ds.Ripple = true;
            this.new_3ds.Size = new System.Drawing.Size(85, 30);
            this.new_3ds.TabIndex = 3;
            this.new_3ds.Text = "New 3DS";
            this.new_3ds.UseVisualStyleBackColor = false;
            // 
            // old_3ds
            // 
            this.old_3ds.AutoSize = true;
            this.old_3ds.BackColor = System.Drawing.Color.Transparent;
            this.old_3ds.Depth = 0;
            this.old_3ds.Font = new System.Drawing.Font("Roboto", 10F);
            this.old_3ds.Location = new System.Drawing.Point(9, 274);
            this.old_3ds.Margin = new System.Windows.Forms.Padding(0);
            this.old_3ds.MouseLocation = new System.Drawing.Point(-1, -1);
            this.old_3ds.MouseState = MaterialSkin.MouseState.HOVER;
            this.old_3ds.Name = "old_3ds";
            this.old_3ds.Ripple = true;
            this.old_3ds.Size = new System.Drawing.Size(78, 30);
            this.old_3ds.TabIndex = 4;
            this.old_3ds.Text = "Old 3DS";
            this.old_3ds.UseVisualStyleBackColor = false;
            // 
            // lbl_sys_type
            // 
            this.lbl_sys_type.AutoSize = true;
            this.lbl_sys_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sys_type.Depth = 0;
            this.lbl_sys_type.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_sys_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_sys_type.Location = new System.Drawing.Point(5, 216);
            this.lbl_sys_type.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_sys_type.Name = "lbl_sys_type";
            this.lbl_sys_type.Size = new System.Drawing.Size(120, 19);
            this.lbl_sys_type.TabIndex = 5;
            this.lbl_sys_type.Text = "Default Titlelist: ";
            // 
            // btn_reset_settings
            // 
            this.btn_reset_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset_settings.AutoSize = true;
            this.btn_reset_settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reset_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset_settings.Depth = 0;
            this.btn_reset_settings.Icon = null;
            this.btn_reset_settings.Location = new System.Drawing.Point(3, 325);
            this.btn_reset_settings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_reset_settings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reset_settings.Name = "btn_reset_settings";
            this.btn_reset_settings.Primary = false;
            this.btn_reset_settings.Size = new System.Drawing.Size(129, 36);
            this.btn_reset_settings.TabIndex = 17;
            this.btn_reset_settings.Text = "Reset settings";
            this.btn_reset_settings.UseVisualStyleBackColor = false;
            this.btn_reset_settings.Click += new System.EventHandler(this.btn_reset_settings_Click);
            // 
            // chck_darktheme
            // 
            this.chck_darktheme.AutoSize = true;
            this.chck_darktheme.BackColor = System.Drawing.Color.Transparent;
            this.chck_darktheme.Depth = 0;
            this.chck_darktheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_darktheme.Location = new System.Drawing.Point(9, 112);
            this.chck_darktheme.Margin = new System.Windows.Forms.Padding(0);
            this.chck_darktheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_darktheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_darktheme.Name = "chck_darktheme";
            this.chck_darktheme.Ripple = true;
            this.chck_darktheme.Size = new System.Drawing.Size(300, 30);
            this.chck_darktheme.TabIndex = 18;
            this.chck_darktheme.Text = "Use the Dark theme? (Requires App Restart)";
            this.chck_darktheme.UseVisualStyleBackColor = false;
            this.chck_darktheme.CheckedChanged += new System.EventHandler(this.chck_darktheme_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(217, 325);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = false;
            this.btn_cancel.Size = new System.Drawing.Size(73, 36);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // chck_auto_dump
            // 
            this.chck_auto_dump.AutoSize = true;
            this.chck_auto_dump.BackColor = System.Drawing.Color.Transparent;
            this.chck_auto_dump.Depth = 0;
            this.chck_auto_dump.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_auto_dump.Location = new System.Drawing.Point(9, 170);
            this.chck_auto_dump.Margin = new System.Windows.Forms.Padding(0);
            this.chck_auto_dump.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_auto_dump.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_auto_dump.Name = "chck_auto_dump";
            this.chck_auto_dump.Ripple = true;
            this.chck_auto_dump.Size = new System.Drawing.Size(207, 30);
            this.chck_auto_dump.TabIndex = 20;
            this.chck_auto_dump.Text = "Automatically Dump the log?";
            this.chck_auto_dump.UseVisualStyleBackColor = false;
            // 
            // dev_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(413, 363);
            this.Controls.Add(this.chck_auto_dump);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.chck_darktheme);
            this.Controls.Add(this.btn_reset_settings);
            this.Controls.Add(this.lbl_sys_type);
            this.Controls.Add(this.old_3ds);
            this.Controls.Add(this.new_3ds);
            this.Controls.Add(this.chck_auto_upd);
            this.Controls.Add(this.chck_dump_info);
            this.Controls.Add(this.btn_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings: ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dev_settings_FormClosing);
            this.Load += new System.EventHandler(this.dev_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btn_save;
        private MaterialSkin.Controls.MaterialCheckBox chck_dump_info;
        private MaterialSkin.Controls.MaterialCheckBox chck_auto_upd;
        private MaterialSkin.Controls.MaterialRadioButton new_3ds;
        private MaterialSkin.Controls.MaterialRadioButton old_3ds;
        private MaterialSkin.Controls.MaterialLabel lbl_sys_type;
        private MaterialSkin.Controls.MaterialFlatButton btn_reset_settings;
        private MaterialSkin.Controls.MaterialCheckBox chck_darktheme;
        private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
        private MaterialSkin.Controls.MaterialCheckBox chck_auto_dump;
    }
}
﻿namespace FacebookApp
{
    partial class LeftPanel
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
            this.userInfo = new FacebookApp.UserInfo();
            this.SuspendLayout();
            // 
            // userInfo
            // 
            this.userInfo.BackColor = System.Drawing.Color.White;
            this.userInfo.Location = new System.Drawing.Point(3, 0);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(487, 439);
            this.userInfo.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userInfo);
            this.Name = "LeftPanel";
            this.Size = new System.Drawing.Size(492, 1120);
            this.ResumeLayout(false);

        }

        #endregion

        private UserInfo userInfo;
    }
}

namespace XenonLauncher
{
    partial class XenonLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XenonLauncher));
            this.XenonLauncherTitle = new System.Windows.Forms.Label();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.StopRuntime = new System.Windows.Forms.Button();
            this.RGBon = new System.Windows.Forms.CheckBox();
            this.RGBtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // XenonLauncherTitle
            // 
            this.XenonLauncherTitle.AutoSize = true;
            this.XenonLauncherTitle.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XenonLauncherTitle.ForeColor = System.Drawing.Color.NavajoWhite;
            this.XenonLauncherTitle.Location = new System.Drawing.Point(100, 25);
            this.XenonLauncherTitle.Name = "XenonLauncherTitle";
            this.XenonLauncherTitle.Size = new System.Drawing.Size(590, 49);
            this.XenonLauncherTitle.TabIndex = 0;
            this.XenonLauncherTitle.Text = "Welcome to Xenon Launcher";
            this.XenonLauncherTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LaunchButton
            // 
            this.LaunchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LaunchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.LaunchButton.Location = new System.Drawing.Point(260, 202);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(264, 51);
            this.LaunchButton.TabIndex = 1;
            this.LaunchButton.Text = "Launch Minecraft";
            this.LaunchButton.UseVisualStyleBackColor = false;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // StopRuntime
            // 
            this.StopRuntime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StopRuntime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopRuntime.ForeColor = System.Drawing.Color.NavajoWhite;
            this.StopRuntime.Location = new System.Drawing.Point(260, 304);
            this.StopRuntime.Name = "StopRuntime";
            this.StopRuntime.Size = new System.Drawing.Size(264, 51);
            this.StopRuntime.TabIndex = 2;
            this.StopRuntime.Text = "Stop Runtime";
            this.StopRuntime.UseVisualStyleBackColor = false;
            this.StopRuntime.Click += new System.EventHandler(this.StopRuntime_Click);
            // 
            // RGBon
            // 
            this.RGBon.AutoSize = true;
            this.RGBon.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGBon.ForeColor = System.Drawing.Color.NavajoWhite;
            this.RGBon.Location = new System.Drawing.Point(12, 413);
            this.RGBon.Name = "RGBon";
            this.RGBon.Size = new System.Drawing.Size(69, 25);
            this.RGBon.TabIndex = 3;
            this.RGBon.Text = "RGB";
            this.RGBon.UseVisualStyleBackColor = true;
            this.RGBon.CheckedChanged += new System.EventHandler(this.RGBon_CheckedChanged);
            // 
            // RGBtimer
            // 
            this.RGBtimer.Interval = 1;
            this.RGBtimer.Tick += new System.EventHandler(this.RGBtimer_Tick);
            // 
            // XenonLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RGBon);
            this.Controls.Add(this.StopRuntime);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.XenonLauncherTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XenonLauncher";
            this.Text = "XenonLauncher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XenonLauncher_FormClosing);
            this.Load += new System.EventHandler(this.XenonLauncher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XenonLauncherTitle;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button StopRuntime;
        private System.Windows.Forms.CheckBox RGBon;
        private System.Windows.Forms.Timer RGBtimer;
    }
}


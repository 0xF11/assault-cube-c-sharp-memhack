namespace csharpassault
{
    partial class cheat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ammo = new CheckBox();
            health = new CheckBox();
            SuspendLayout();
            // 
            // ammo
            // 
            ammo.AutoSize = true;
            ammo.Location = new Point(51, 47);
            ammo.Name = "ammo";
            ammo.Size = new Size(89, 19);
            ammo.TabIndex = 0;
            ammo.Text = "ammo hack";
            ammo.UseVisualStyleBackColor = true;
            ammo.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // health
            // 
            health.AutoSize = true;
            health.Location = new Point(52, 69);
            health.Name = "health";
            health.Size = new Size(87, 19);
            health.TabIndex = 1;
            health.Text = "health hack";
            health.UseVisualStyleBackColor = true;
            health.CheckedChanged += health_CheckedChanged;
            // 
            // cheat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(health);
            Controls.Add(ammo);
            Name = "cheat";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ammo;
        private CheckBox health;
    }
}
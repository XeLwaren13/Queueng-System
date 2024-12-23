
namespace QueuengForm
{
    partial class QueuingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueuingForm));
            this.label_PositionInQueue = new System.Windows.Forms.Label();
            this.label_P10007 = new System.Windows.Forms.Label();
            this.button_Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_PositionInQueue
            // 
            this.label_PositionInQueue.AutoSize = true;
            this.label_PositionInQueue.BackColor = System.Drawing.Color.Transparent;
            this.label_PositionInQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_PositionInQueue.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label_PositionInQueue.Location = new System.Drawing.Point(272, 37);
            this.label_PositionInQueue.Name = "label_PositionInQueue";
            this.label_PositionInQueue.Size = new System.Drawing.Size(266, 41);
            this.label_PositionInQueue.TabIndex = 1;
            this.label_PositionInQueue.Text = "Position in Queue";
            this.label_PositionInQueue.Click += new System.EventHandler(this.label_PositionInQueue_Click);
            // 
            // label_P10007
            // 
            this.label_P10007.AutoSize = true;
            this.label_P10007.BackColor = System.Drawing.Color.Transparent;
            this.label_P10007.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_P10007.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold);
            this.label_P10007.Location = new System.Drawing.Point(221, 116);
            this.label_P10007.Name = "label_P10007";
            this.label_P10007.Size = new System.Drawing.Size(368, 103);
            this.label_P10007.TabIndex = 3;
            this.label_P10007.Text = "P - 10000";
            this.label_P10007.Click += new System.EventHandler(this.label_P10007_Click);
            // 
            // button_Settings
            // 
            this.button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.button_Settings.FlatAppearance.BorderSize = 0;
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.ForeColor = System.Drawing.Color.Transparent;
            this.button_Settings.Image = global::QueuengForm.Properties.Resources.settings_cogwheel_button_icon_icons_com_72559_32inch;
            this.button_Settings.Location = new System.Drawing.Point(711, 30);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(58, 59);
            this.button_Settings.TabIndex = 4;
            this.button_Settings.UseVisualStyleBackColor = false;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(811, 367);
            this.Controls.Add(this.button_Settings);
            this.Controls.Add(this.label_P10007);
            this.Controls.Add(this.label_PositionInQueue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QueuingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queuing Form";
            this.Load += new System.EventHandler(this.QueuingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_PositionInQueue;
        private System.Windows.Forms.Label label_P10007;
        private System.Windows.Forms.Button button_Settings;
    }
}


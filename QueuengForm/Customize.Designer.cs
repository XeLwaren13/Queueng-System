
namespace QueuengForm
{
    partial class Customize
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
            this.textBox_Custom_P = new System.Windows.Forms.TextBox();
            this.label_PositionInQueue = new System.Windows.Forms.Label();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Custom_P
            // 
            this.textBox_Custom_P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Custom_P.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Custom_P.Location = new System.Drawing.Point(233, 164);
            this.textBox_Custom_P.Name = "textBox_Custom_P";
            this.textBox_Custom_P.Size = new System.Drawing.Size(362, 51);
            this.textBox_Custom_P.TabIndex = 0;
            this.textBox_Custom_P.TextChanged += new System.EventHandler(this.textBox_Custom_P_TextChanged);
            // 
            // label_PositionInQueue
            // 
            this.label_PositionInQueue.AutoSize = true;
            this.label_PositionInQueue.BackColor = System.Drawing.Color.Transparent;
            this.label_PositionInQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_PositionInQueue.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label_PositionInQueue.Location = new System.Drawing.Point(214, 67);
            this.label_PositionInQueue.Name = "label_PositionInQueue";
            this.label_PositionInQueue.Size = new System.Drawing.Size(402, 49);
            this.label_PositionInQueue.TabIndex = 2;
            this.label_PositionInQueue.Text = "Enter the customize P :";
            // 
            // button_Apply
            // 
            this.button_Apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Apply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Apply.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold);
            this.button_Apply.Location = new System.Drawing.Point(171, 280);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(236, 74);
            this.button_Apply.TabIndex = 3;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold);
            this.button_Reset.Location = new System.Drawing.Point(444, 280);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(236, 74);
            this.button_Reset.TabIndex = 4;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Back
            // 
            this.button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Back.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold);
            this.button_Back.Location = new System.Drawing.Point(299, 371);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(236, 74);
            this.button_Back.TabIndex = 5;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Customize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 469);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.label_PositionInQueue);
            this.Controls.Add(this.textBox_Custom_P);
            this.Name = "Customize";
            this.Text = "Customize";
            this.Load += new System.EventHandler(this.Customize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Custom_P;
        private System.Windows.Forms.Label label_PositionInQueue;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Back;
    }
}
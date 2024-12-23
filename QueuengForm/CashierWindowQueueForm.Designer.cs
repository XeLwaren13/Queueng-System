
namespace QueuengForm
{
    partial class CashierWindowQueueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierWindowQueueForm));
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.listView_List = new System.Windows.Forms.ListView();
            this.button_NewNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Refresh
            // 
            this.button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold);
            this.button_Refresh.Location = new System.Drawing.Point(20, 22);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(210, 51);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Next
            // 
            this.button_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Next.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold);
            this.button_Next.Location = new System.Drawing.Point(20, 94);
            this.button_Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(210, 51);
            this.button_Next.TabIndex = 2;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // listView_List
            // 
            this.listView_List.AllowColumnReorder = true;
            this.listView_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_List.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_List.HideSelection = false;
            this.listView_List.Location = new System.Drawing.Point(251, 22);
            this.listView_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_List.Name = "listView_List";
            this.listView_List.Size = new System.Drawing.Size(463, 431);
            this.listView_List.TabIndex = 3;
            this.listView_List.UseCompatibleStateImageBehavior = false;
            this.listView_List.View = System.Windows.Forms.View.List;
            this.listView_List.SelectedIndexChanged += new System.EventHandler(this.listView_List_SelectedIndexChanged);
            // 
            // button_NewNumber
            // 
            this.button_NewNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_NewNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_NewNumber.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold);
            this.button_NewNumber.Location = new System.Drawing.Point(20, 166);
            this.button_NewNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_NewNumber.Name = "button_NewNumber";
            this.button_NewNumber.Size = new System.Drawing.Size(210, 51);
            this.button_NewNumber.TabIndex = 4;
            this.button_NewNumber.Text = "New number";
            this.button_NewNumber.UseVisualStyleBackColor = true;
            this.button_NewNumber.Click += new System.EventHandler(this.button_NewNumber_Click);
            // 
            // CashierWindowQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(749, 478);
            this.Controls.Add(this.button_NewNumber);
            this.Controls.Add(this.listView_List);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Refresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CashierWindowQueueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue List";
            this.Load += new System.EventHandler(this.CashierWindowQueueForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.ListView listView_List;
        private System.Windows.Forms.Button button_NewNumber;
    }
}
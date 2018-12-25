﻿namespace RailwayTicketOffice
{
    partial class Schedule
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TrainsListView = new System.Windows.Forms.ListView();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DatePromptLabel = new System.Windows.Forms.Label();
            this.ClearRouteButton = new System.Windows.Forms.Button();
            this.ClearDateButton = new System.Windows.Forms.Button();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToPromptLabel = new System.Windows.Forms.Label();
            this.FromPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogoutButton.Location = new System.Drawing.Point(648, 13);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(140, 34);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 15);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(236, 25);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "You are now logged in as ";
            // 
            // TrainsListView
            // 
            this.TrainsListView.Location = new System.Drawing.Point(12, 122);
            this.TrainsListView.Name = "TrainsListView";
            this.TrainsListView.Size = new System.Drawing.Size(771, 283);
            this.TrainsListView.TabIndex = 2;
            this.TrainsListView.UseCompatibleStateImageBehavior = false;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(230, 56);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 22);
            this.DatePicker.TabIndex = 3;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // DatePromptLabel
            // 
            this.DatePromptLabel.AutoSize = true;
            this.DatePromptLabel.Location = new System.Drawing.Point(40, 61);
            this.DatePromptLabel.Name = "DatePromptLabel";
            this.DatePromptLabel.Size = new System.Drawing.Size(92, 17);
            this.DatePromptLabel.TabIndex = 4;
            this.DatePromptLabel.Text = "Choose date:";
            // 
            // ClearRouteButton
            // 
            this.ClearRouteButton.Location = new System.Drawing.Point(466, 93);
            this.ClearRouteButton.Name = "ClearRouteButton";
            this.ClearRouteButton.Size = new System.Drawing.Size(75, 23);
            this.ClearRouteButton.TabIndex = 5;
            this.ClearRouteButton.Text = "Clear";
            this.ClearRouteButton.UseVisualStyleBackColor = true;
            this.ClearRouteButton.Click += new System.EventHandler(this.ClearRouteButton_Click);
            // 
            // ClearDateButton
            // 
            this.ClearDateButton.Location = new System.Drawing.Point(466, 56);
            this.ClearDateButton.Name = "ClearDateButton";
            this.ClearDateButton.Size = new System.Drawing.Size(75, 23);
            this.ClearDateButton.TabIndex = 6;
            this.ClearDateButton.Text = "Clear";
            this.ClearDateButton.UseVisualStyleBackColor = true;
            this.ClearDateButton.Click += new System.EventHandler(this.ClearDateButton_Click);
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(355, 93);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(75, 23);
            this.ReverseButton.TabIndex = 7;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(230, 93);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(100, 22);
            this.ToTextBox.TabIndex = 8;
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(98, 94);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(100, 22);
            this.FromTextBox.TabIndex = 9;
            // 
            // ToPromptLabel
            // 
            this.ToPromptLabel.AutoSize = true;
            this.ToPromptLabel.Location = new System.Drawing.Point(204, 96);
            this.ToPromptLabel.Name = "ToPromptLabel";
            this.ToPromptLabel.Size = new System.Drawing.Size(20, 17);
            this.ToPromptLabel.TabIndex = 10;
            this.ToPromptLabel.Text = "to";
            // 
            // FromPromptLabel
            // 
            this.FromPromptLabel.AutoSize = true;
            this.FromPromptLabel.Location = new System.Drawing.Point(40, 96);
            this.FromPromptLabel.Name = "FromPromptLabel";
            this.FromPromptLabel.Size = new System.Drawing.Size(40, 17);
            this.FromPromptLabel.TabIndex = 11;
            this.FromPromptLabel.Text = "From";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FromPromptLabel);
            this.Controls.Add(this.ToPromptLabel);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.ClearDateButton);
            this.Controls.Add(this.ClearRouteButton);
            this.Controls.Add(this.DatePromptLabel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.TrainsListView);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LogoutButton);
            this.Name = "Schedule";
            this.Text = "Train Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ListView TrainsListView;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label DatePromptLabel;
        private System.Windows.Forms.Button ClearRouteButton;
        private System.Windows.Forms.Button ClearDateButton;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.Label ToPromptLabel;
        private System.Windows.Forms.Label FromPromptLabel;
    }
}
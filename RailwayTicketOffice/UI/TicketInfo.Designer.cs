namespace RailwayTicketOffice
{
    partial class TicketInfo
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
            this.OkButton = new System.Windows.Forms.Button();
            this.TicketComboBox = new System.Windows.Forms.ComboBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.EmptyListLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DepTimeLabel = new System.Windows.Forms.Label();
            this.ArrTimeLabel = new System.Windows.Forms.Label();
            this.CarriageTypeLabel = new System.Windows.Forms.Label();
            this.SeatNumLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OkButton.Location = new System.Drawing.Point(186, 458);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(139, 58);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // TicketComboBox
            // 
            this.TicketComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TicketComboBox.FormattingEnabled = true;
            this.TicketComboBox.Location = new System.Drawing.Point(95, 88);
            this.TicketComboBox.Name = "TicketComboBox";
            this.TicketComboBox.Size = new System.Drawing.Size(311, 28);
            this.TicketComboBox.TabIndex = 1;
            this.TicketComboBox.SelectedIndexChanged += new System.EventHandler(this.TicketComboBox_SelectedIndexChanged);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InfoLabel.Location = new System.Drawing.Point(139, 21);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(229, 25);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "All of your bought tickets:";
            // 
            // EmptyListLabel
            // 
            this.EmptyListLabel.AutoSize = true;
            this.EmptyListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmptyListLabel.Location = new System.Drawing.Point(105, 132);
            this.EmptyListLabel.Name = "EmptyListLabel";
            this.EmptyListLabel.Size = new System.Drawing.Size(290, 25);
            this.EmptyListLabel.TabIndex = 3;
            this.EmptyListLabel.Text = "You haven\'t bought anything yet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(46, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(46, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(46, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Departure Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(46, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Arrival Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(46, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Carriage Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(46, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "# Of The Seat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(46, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Price";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(205, 16);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(0, 17);
            this.FromLabel.TabIndex = 12;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(205, 48);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(0, 17);
            this.ToLabel.TabIndex = 13;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(205, 79);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(0, 17);
            this.DateLabel.TabIndex = 14;
            // 
            // DepTimeLabel
            // 
            this.DepTimeLabel.AutoSize = true;
            this.DepTimeLabel.Location = new System.Drawing.Point(205, 110);
            this.DepTimeLabel.Name = "DepTimeLabel";
            this.DepTimeLabel.Size = new System.Drawing.Size(0, 17);
            this.DepTimeLabel.TabIndex = 15;
            // 
            // ArrTimeLabel
            // 
            this.ArrTimeLabel.AutoSize = true;
            this.ArrTimeLabel.Location = new System.Drawing.Point(205, 144);
            this.ArrTimeLabel.Name = "ArrTimeLabel";
            this.ArrTimeLabel.Size = new System.Drawing.Size(0, 17);
            this.ArrTimeLabel.TabIndex = 16;
            // 
            // CarriageTypeLabel
            // 
            this.CarriageTypeLabel.AutoSize = true;
            this.CarriageTypeLabel.Location = new System.Drawing.Point(205, 177);
            this.CarriageTypeLabel.Name = "CarriageTypeLabel";
            this.CarriageTypeLabel.Size = new System.Drawing.Size(0, 17);
            this.CarriageTypeLabel.TabIndex = 17;
            // 
            // SeatNumLabel
            // 
            this.SeatNumLabel.AutoSize = true;
            this.SeatNumLabel.Location = new System.Drawing.Point(205, 208);
            this.SeatNumLabel.Name = "SeatNumLabel";
            this.SeatNumLabel.Size = new System.Drawing.Size(0, 17);
            this.SeatNumLabel.TabIndex = 18;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(205, 234);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 17);
            this.PriceLabel.TabIndex = 19;
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.label1);
            this.DataPanel.Controls.Add(this.PriceLabel);
            this.DataPanel.Controls.Add(this.label2);
            this.DataPanel.Controls.Add(this.SeatNumLabel);
            this.DataPanel.Controls.Add(this.label3);
            this.DataPanel.Controls.Add(this.CarriageTypeLabel);
            this.DataPanel.Controls.Add(this.label4);
            this.DataPanel.Controls.Add(this.ArrTimeLabel);
            this.DataPanel.Controls.Add(this.label5);
            this.DataPanel.Controls.Add(this.DepTimeLabel);
            this.DataPanel.Controls.Add(this.label6);
            this.DataPanel.Controls.Add(this.DateLabel);
            this.DataPanel.Controls.Add(this.label7);
            this.DataPanel.Controls.Add(this.ToLabel);
            this.DataPanel.Controls.Add(this.label8);
            this.DataPanel.Controls.Add(this.FromLabel);
            this.DataPanel.Location = new System.Drawing.Point(45, 182);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(446, 257);
            this.DataPanel.TabIndex = 20;
            // 
            // TicketInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 528);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.EmptyListLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.TicketComboBox);
            this.Controls.Add(this.OkButton);
            this.Name = "TicketInfo";
            this.Text = "My tickets";
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ComboBox TicketComboBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label EmptyListLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DepTimeLabel;
        private System.Windows.Forms.Label ArrTimeLabel;
        private System.Windows.Forms.Label CarriageTypeLabel;
        private System.Windows.Forms.Label SeatNumLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Panel DataPanel;
    }
}
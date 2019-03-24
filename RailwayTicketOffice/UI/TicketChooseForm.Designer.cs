namespace RailwayTicketOffice
{
    partial class TicketChooseForm
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
            this.CarriageBox = new System.Windows.Forms.ComboBox();
            this.SeatBox = new System.Windows.Forms.ComboBox();
            this.BuyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CarriageBox
            // 
            this.CarriageBox.FormattingEnabled = true;
            this.CarriageBox.Location = new System.Drawing.Point(246, 12);
            this.CarriageBox.Name = "CarriageBox";
            this.CarriageBox.Size = new System.Drawing.Size(201, 24);
            this.CarriageBox.TabIndex = 0;
            this.CarriageBox.SelectedIndexChanged += new System.EventHandler(this.CarriageBox_SelectedIndexChanged);
            // 
            // SeatBox
            // 
            this.SeatBox.FormattingEnabled = true;
            this.SeatBox.Location = new System.Drawing.Point(246, 78);
            this.SeatBox.Name = "SeatBox";
            this.SeatBox.Size = new System.Drawing.Size(201, 24);
            this.SeatBox.TabIndex = 1;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(158, 185);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(104, 41);
            this.BuyButton.TabIndex = 2;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(343, 185);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 41);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(158, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your price:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PriceLabel.Location = new System.Drawing.Point(255, 134);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 20);
            this.PriceLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose carriage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose seat:";
            // 
            // TicketChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 248);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.SeatBox);
            this.Controls.Add(this.CarriageBox);
            this.Name = "TicketChooseForm";
            this.Text = "TicketChooseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CarriageBox;
        private System.Windows.Forms.ComboBox SeatBox;
        private System.Windows.Forms.Button BuyButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
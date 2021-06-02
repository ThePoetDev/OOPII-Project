
namespace OopII_Project.OrderScreen
{
    partial class OrderScreen
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
            this.backButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.orderNoLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.deliveryInformationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancellationLabel = new System.Windows.Forms.Label();
            this.cancelButton1 = new System.Windows.Forms.Button();
            this.cancelButton2 = new System.Windows.Forms.Button();
            this.orderNoLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(116, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(561, 23);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(703, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // orderNoLabel
            // 
            this.orderNoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderNoLabel.AutoSize = true;
            this.orderNoLabel.Location = new System.Drawing.Point(52, 13);
            this.orderNoLabel.Name = "orderNoLabel";
            this.orderNoLabel.Size = new System.Drawing.Size(37, 15);
            this.orderNoLabel.TabIndex = 3;
            this.orderNoLabel.Text = "Order";
            // 
            // contentLabel
            // 
            this.contentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(191, 13);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(50, 15);
            this.contentLabel.TabIndex = 4;
            this.contentLabel.Text = "Content";
            // 
            // costLabel
            // 
            this.costLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(377, 13);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 15);
            this.costLabel.TabIndex = 5;
            this.costLabel.Text = "Cost";
            // 
            // deliveryInformationLabel
            // 
            this.deliveryInformationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deliveryInformationLabel.AutoSize = true;
            this.deliveryInformationLabel.Location = new System.Drawing.Point(509, 13);
            this.deliveryInformationLabel.Name = "deliveryInformationLabel";
            this.deliveryInformationLabel.Size = new System.Drawing.Size(115, 15);
            this.deliveryInformationLabel.TabIndex = 6;
            this.deliveryInformationLabel.Text = "Delivery Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.45361F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.54639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Controls.Add(this.costLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderNoLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.contentLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.deliveryInformationLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancellationLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.orderNoLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.72131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.27869F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 356);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // cancellationLabel
            // 
            this.cancellationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancellationLabel.AutoSize = true;
            this.cancellationLabel.Location = new System.Drawing.Point(681, 13);
            this.cancellationLabel.Name = "cancellationLabel";
            this.cancellationLabel.Size = new System.Drawing.Size(73, 15);
            this.cancellationLabel.TabIndex = 7;
            this.cancellationLabel.Text = "Cancellation";
            // 
            // cancelButton1
            // 
            this.cancelButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton1.Location = new System.Drawing.Point(680, 104);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(75, 23);
            this.cancelButton1.TabIndex = 8;
            this.cancelButton1.Text = "Cancel";
            this.cancelButton1.UseVisualStyleBackColor = true;
            // 
            // cancelButton2
            // 
            this.cancelButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton2.Location = new System.Drawing.Point(680, 261);
            this.cancelButton2.Name = "cancelButton2";
            this.cancelButton2.Size = new System.Drawing.Size(75, 23);
            this.cancelButton2.TabIndex = 9;
            this.cancelButton2.Text = "Cancel";
            this.cancelButton2.UseVisualStyleBackColor = true;
            // 
            // orderNoLabel1
            // 
            this.orderNoLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderNoLabel1.AutoSize = true;
            this.orderNoLabel1.Location = new System.Drawing.Point(55, 108);
            this.orderNoLabel1.Name = "orderNoLabel1";
            this.orderNoLabel1.Size = new System.Drawing.Size(31, 15);
            this.orderNoLabel1.TabIndex = 10;
            this.orderNoLabel1.Text = "        ";
            this.orderNoLabel1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "label8";
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.backButton);
            this.Name = "OrderScreen";
            this.Text = "OrderScreen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label orderNoLabel;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label deliveryInformationLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cancellationLabel;
        private System.Windows.Forms.Button cancelButton1;
        private System.Windows.Forms.Button cancelButton2;
        private System.Windows.Forms.Label orderNoLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
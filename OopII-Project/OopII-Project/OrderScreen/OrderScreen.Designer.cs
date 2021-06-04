
namespace OopII_Project {
    partial class OrderScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
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
            this.orderNameLabel1 = new System.Windows.Forms.Label();
            this.contentLabel1 = new System.Windows.Forms.Label();
            this.costLabel1 = new System.Windows.Forms.Label();
            this.deliveryInformationLabel1 = new System.Windows.Forms.Label();
            this.orderNameLabel2 = new System.Windows.Forms.Label();
            this.contentLabel2 = new System.Windows.Forms.Label();
            this.costLabel2 = new System.Windows.Forms.Label();
            this.deliveryInformationLabel2 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.orderNameLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.contentLabel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.costLabel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.deliveryInformationLabel1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.orderNameLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.contentLabel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.costLabel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.deliveryInformationLabel2, 3, 2);
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
            this.cancelButton1.Click += new System.EventHandler(this.cancelButton1_Click);
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
            this.cancelButton2.Click += new System.EventHandler(this.cancelButton2_Click);
            // 
            // orderNameLabel1
            // 
            this.orderNameLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderNameLabel1.AutoSize = true;
            this.orderNameLabel1.Location = new System.Drawing.Point(20, 103);
            this.orderNameLabel1.MinimumSize = new System.Drawing.Size(100, 25);
            this.orderNameLabel1.Name = "orderNameLabel1";
            this.orderNameLabel1.Size = new System.Drawing.Size(100, 25);
            this.orderNameLabel1.TabIndex = 10;
            this.orderNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentLabel1
            // 
            this.contentLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentLabel1.AutoSize = true;
            this.contentLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.contentLabel1.Location = new System.Drawing.Point(166, 103);
            this.contentLabel1.MinimumSize = new System.Drawing.Size(100, 25);
            this.contentLabel1.Name = "contentLabel1";
            this.contentLabel1.Size = new System.Drawing.Size(100, 25);
            this.contentLabel1.TabIndex = 11;
            this.contentLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLabel1
            // 
            this.costLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costLabel1.AutoSize = true;
            this.costLabel1.Location = new System.Drawing.Point(342, 103);
            this.costLabel1.MinimumSize = new System.Drawing.Size(100, 25);
            this.costLabel1.Name = "costLabel1";
            this.costLabel1.Size = new System.Drawing.Size(100, 25);
            this.costLabel1.TabIndex = 12;
            this.costLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deliveryInformationLabel1
            // 
            this.deliveryInformationLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deliveryInformationLabel1.AutoSize = true;
            this.deliveryInformationLabel1.Location = new System.Drawing.Point(516, 103);
            this.deliveryInformationLabel1.MinimumSize = new System.Drawing.Size(100, 25);
            this.deliveryInformationLabel1.Name = "deliveryInformationLabel1";
            this.deliveryInformationLabel1.Size = new System.Drawing.Size(100, 25);
            this.deliveryInformationLabel1.TabIndex = 13;
            this.deliveryInformationLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderNameLabel2
            // 
            this.orderNameLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderNameLabel2.AutoSize = true;
            this.orderNameLabel2.Location = new System.Drawing.Point(20, 260);
            this.orderNameLabel2.MinimumSize = new System.Drawing.Size(100, 25);
            this.orderNameLabel2.Name = "orderNameLabel2";
            this.orderNameLabel2.Size = new System.Drawing.Size(100, 25);
            this.orderNameLabel2.TabIndex = 14;
            this.orderNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentLabel2
            // 
            this.contentLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentLabel2.AutoSize = true;
            this.contentLabel2.Location = new System.Drawing.Point(166, 260);
            this.contentLabel2.MinimumSize = new System.Drawing.Size(100, 25);
            this.contentLabel2.Name = "contentLabel2";
            this.contentLabel2.Size = new System.Drawing.Size(100, 25);
            this.contentLabel2.TabIndex = 15;
            this.contentLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLabel2
            // 
            this.costLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costLabel2.AutoSize = true;
            this.costLabel2.Location = new System.Drawing.Point(342, 260);
            this.costLabel2.MinimumSize = new System.Drawing.Size(100, 25);
            this.costLabel2.Name = "costLabel2";
            this.costLabel2.Size = new System.Drawing.Size(100, 25);
            this.costLabel2.TabIndex = 16;
            this.costLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deliveryInformationLabel2
            // 
            this.deliveryInformationLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deliveryInformationLabel2.AutoSize = true;
            this.deliveryInformationLabel2.Location = new System.Drawing.Point(516, 260);
            this.deliveryInformationLabel2.MinimumSize = new System.Drawing.Size(100, 25);
            this.deliveryInformationLabel2.Name = "deliveryInformationLabel2";
            this.deliveryInformationLabel2.Size = new System.Drawing.Size(100, 25);
            this.deliveryInformationLabel2.TabIndex = 17;
            this.deliveryInformationLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Load += new System.EventHandler(this.OrderScreen_Load);
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
        private System.Windows.Forms.Label orderNameLabel1;
        private System.Windows.Forms.Label orderNameLabel2;
        private System.Windows.Forms.Label contentLabel1;
        private System.Windows.Forms.Label contentLabel2;
        private System.Windows.Forms.Label costLabel1;
        private System.Windows.Forms.Label costLabel2;
        private System.Windows.Forms.Label deliveryInformationLabel1;
        private System.Windows.Forms.Label deliveryInformationLabel2;
        private System.Windows.Forms.Button cancelButton1;
        private System.Windows.Forms.Button cancelButton2;
    }
}
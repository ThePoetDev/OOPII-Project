
namespace OopII_Project {
    partial class LoginScreen {
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.picBook3 = new System.Windows.Forms.PictureBox();
            this.picBook2 = new System.Windows.Forms.PictureBox();
            this.picBook1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picCd3 = new System.Windows.Forms.PictureBox();
            this.picCd2 = new System.Windows.Forms.PictureBox();
            this.picCd1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.picMag3 = new System.Windows.Forms.PictureBox();
            this.picMag2 = new System.Windows.Forms.PictureBox();
            this.picMag1 = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogInOut = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCd = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.btnBasket = new System.Windows.Forms.Button();
            this.tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBook3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCd1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMag3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(389, 21);
            this.txtSearch.MaxLength = 150;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = global::OopII_Project.Properties.Resources.search_icon;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(665, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBook.ForeColor = System.Drawing.Color.Blue;
            this.lblBook.Location = new System.Drawing.Point(483, 66);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(59, 25);
            this.lblBook.TabIndex = 2;
            this.lblBook.Text = "Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(467, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Music CD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(467, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Magazine";
            // 
            // tlp1
            // 
            this.tlp1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlp1.ColumnCount = 6;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.46062F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.53938F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp1.Controls.Add(this.picBook3, 4, 0);
            this.tlp1.Controls.Add(this.picBook2, 2, 0);
            this.tlp1.Controls.Add(this.picBook1, 0, 0);
            this.tlp1.Location = new System.Drawing.Point(1, 94);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 1;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.Size = new System.Drawing.Size(1062, 150);
            this.tlp1.TabIndex = 5;
            // 
            // picBook3
            // 
            this.picBook3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBook3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBook3.Location = new System.Drawing.Point(821, 5);
            this.picBook3.Name = "picBook3";
            this.picBook3.Size = new System.Drawing.Size(203, 140);
            this.picBook3.TabIndex = 5;
            this.picBook3.TabStop = false;
            this.picBook3.Click += new System.EventHandler(this.picBook3_Click);
            // 
            // picBook2
            // 
            this.picBook2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBook2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBook2.Location = new System.Drawing.Point(388, 5);
            this.picBook2.Name = "picBook2";
            this.picBook2.Size = new System.Drawing.Size(237, 140);
            this.picBook2.TabIndex = 2;
            this.picBook2.TabStop = false;
            this.picBook2.Click += new System.EventHandler(this.picBook2_Click);
            // 
            // picBook1
            // 
            this.picBook1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBook1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBook1.Location = new System.Drawing.Point(5, 5);
            this.picBook1.Name = "picBook1";
            this.picBook1.Size = new System.Drawing.Size(197, 140);
            this.picBook1.TabIndex = 0;
            this.picBook1.TabStop = false;
            this.picBook1.Click += new System.EventHandler(this.picBook1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.46062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.53938F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.picCd3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.picCd2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picCd1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 275);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1062, 150);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // picCd3
            // 
            this.picCd3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCd3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCd3.Location = new System.Drawing.Point(821, 5);
            this.picCd3.Name = "picCd3";
            this.picCd3.Size = new System.Drawing.Size(203, 140);
            this.picCd3.TabIndex = 5;
            this.picCd3.TabStop = false;
            this.picCd3.Click += new System.EventHandler(this.picCd3_Click);
            // 
            // picCd2
            // 
            this.picCd2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCd2.Location = new System.Drawing.Point(388, 5);
            this.picCd2.Name = "picCd2";
            this.picCd2.Size = new System.Drawing.Size(237, 140);
            this.picCd2.TabIndex = 2;
            this.picCd2.TabStop = false;
            this.picCd2.Click += new System.EventHandler(this.picCd2_Click);
            // 
            // picCd1
            // 
            this.picCd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCd1.Location = new System.Drawing.Point(5, 5);
            this.picCd1.Name = "picCd1";
            this.picCd1.Size = new System.Drawing.Size(197, 140);
            this.picCd1.TabIndex = 0;
            this.picCd1.TabStop = false;
            this.picCd1.Click += new System.EventHandler(this.picCd1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.46062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.53938F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.picMag3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.picMag2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.picMag1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 461);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1062, 150);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // picMag3
            // 
            this.picMag3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMag3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMag3.Location = new System.Drawing.Point(821, 5);
            this.picMag3.Name = "picMag3";
            this.picMag3.Size = new System.Drawing.Size(203, 140);
            this.picMag3.TabIndex = 5;
            this.picMag3.TabStop = false;
            this.picMag3.Click += new System.EventHandler(this.picMag3_Click);
            // 
            // picMag2
            // 
            this.picMag2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMag2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMag2.Location = new System.Drawing.Point(388, 5);
            this.picMag2.Name = "picMag2";
            this.picMag2.Size = new System.Drawing.Size(237, 140);
            this.picMag2.TabIndex = 2;
            this.picMag2.TabStop = false;
            this.picMag2.Click += new System.EventHandler(this.picMag2_Click);
            // 
            // picMag1
            // 
            this.picMag1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMag1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMag1.Location = new System.Drawing.Point(5, 5);
            this.picMag1.Name = "picMag1";
            this.picMag1.Size = new System.Drawing.Size(197, 140);
            this.picMag1.TabIndex = 0;
            this.picMag1.TabStop = false;
            this.picMag1.Click += new System.EventHandler(this.picMag1_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Enabled = false;
            this.picLogo.Image = global::OopII_Project.Properties.Resources._1;
            this.picLogo.Location = new System.Drawing.Point(6, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(95, 76);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // btnLogInOut
            // 
            this.btnLogInOut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLogInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInOut.ForeColor = System.Drawing.Color.Red;
            this.btnLogInOut.Image = global::OopII_Project.Properties.Resources.login;
            this.btnLogInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogInOut.Location = new System.Drawing.Point(905, 11);
            this.btnLogInOut.Name = "btnLogInOut";
            this.btnLogInOut.Size = new System.Drawing.Size(147, 41);
            this.btnLogInOut.TabIndex = 15;
            this.btnLogInOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogInOut.UseVisualStyleBackColor = true;
            this.btnLogInOut.Click += new System.EventHandler(this.btnLogInOut_Click);
            // 
            // btnBook
            // 
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.ForeColor = System.Drawing.Color.Blue;
            this.btnBook.Image = global::OopII_Project.Properties.Resources.book;
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(121, 11);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(67, 41);
            this.btnBook.TabIndex = 16;
            this.btnBook.Text = "Book";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCd
            // 
            this.btnCd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCd.ForeColor = System.Drawing.Color.Blue;
            this.btnCd.Image = global::OopII_Project.Properties.Resources.disc;
            this.btnCd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCd.Location = new System.Drawing.Point(194, 11);
            this.btnCd.Name = "btnCd";
            this.btnCd.Size = new System.Drawing.Size(88, 41);
            this.btnCd.TabIndex = 17;
            this.btnCd.Text = "Music CD";
            this.btnCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCd.UseVisualStyleBackColor = true;
            this.btnCd.Click += new System.EventHandler(this.btnCd_Click);
            // 
            // btnMagazine
            // 
            this.btnMagazine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagazine.ForeColor = System.Drawing.Color.Blue;
            this.btnMagazine.Image = global::OopII_Project.Properties.Resources.magazine;
            this.btnMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMagazine.Location = new System.Drawing.Point(288, 11);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(95, 41);
            this.btnMagazine.TabIndex = 18;
            this.btnMagazine.Text = "Magazine";
            this.btnMagazine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMagazine.UseVisualStyleBackColor = true;
            this.btnMagazine.Click += new System.EventHandler(this.btnMagazine_Click);
            // 
            // btnBasket
            // 
            this.btnBasket.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBasket.Image = global::OopII_Project.Properties.Resources.add_to_cart;
            this.btnBasket.Location = new System.Drawing.Point(822, 11);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(77, 41);
            this.btnBasket.TabIndex = 19;
            this.btnBasket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBasket.UseVisualStyleBackColor = true;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 663);
            this.Controls.Add(this.btnBasket);
            this.Controls.Add(this.btnMagazine);
            this.Controls.Add(this.btnCd);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnLogInOut);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlp1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.tlp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBook3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCd1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMag3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.PictureBox picBook3;
        private System.Windows.Forms.PictureBox picBook2;
        private System.Windows.Forms.PictureBox picBook1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picCd3;
        private System.Windows.Forms.PictureBox picCd2;
        private System.Windows.Forms.PictureBox picCd1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox picMag3;
        private System.Windows.Forms.PictureBox picMag2;
        private System.Windows.Forms.PictureBox picMag1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnLogInOut;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCd;
        private System.Windows.Forms.Button btnMagazine;
        private System.Windows.Forms.Button btnBasket;
    }
}

namespace OopII_Project {
    partial class HomePageScreen {
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogInOut = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCd = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.btnBasket = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(389, 18);
            this.txtSearch.MaxLength = 150;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(381, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = global::OopII_Project.Properties.Resources.search_icon;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(791, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // btnLogInOut
            // 
            this.btnLogInOut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLogInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInOut.ForeColor = System.Drawing.Color.Red;
            this.btnLogInOut.Image = global::OopII_Project.Properties.Resources.login;
            this.btnLogInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogInOut.Location = new System.Drawing.Point(1016, 8);
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
            this.btnBasket.Location = new System.Drawing.Point(924, 8);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(77, 41);
            this.btnBasket.TabIndex = 19;
            this.btnBasket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBasket.UseVisualStyleBackColor = true;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(1031, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 34);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add to Basket";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 484);
            this.dataGridView1.TabIndex = 21;
            // 
            // HomePageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 656);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBasket);
            this.Controls.Add(this.btnMagazine);
            this.Controls.Add(this.btnCd);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnLogInOut);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HomePageScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnLogInOut;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCd;
        private System.Windows.Forms.Button btnMagazine;
        private System.Windows.Forms.Button btnBasket;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
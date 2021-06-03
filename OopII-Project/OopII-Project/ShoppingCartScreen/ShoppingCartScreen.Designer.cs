
namespace OopII_Project.ShoppingCartScreen
{
    partial class ShoppingCartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartScreen));
            this.lwShoppingCart = new System.Windows.Forms.ListView();
            this.ProductName = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.Remove = new System.Windows.Forms.ColumnHeader();
            this.TotalPrice = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lwShoppingCart
            // 
            this.lwShoppingCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.Price,
            this.Amount,
            this.Remove,
            this.TotalPrice});
            this.lwShoppingCart.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lwShoppingCart.GridLines = true;
            this.lwShoppingCart.HideSelection = false;
            this.lwShoppingCart.Location = new System.Drawing.Point(12, 12);
            this.lwShoppingCart.Name = "lwShoppingCart";
            this.lwShoppingCart.Size = new System.Drawing.Size(1107, 386);
            this.lwShoppingCart.TabIndex = 0;
            this.lwShoppingCart.TileSize = new System.Drawing.Size(50, 50);
            this.lwShoppingCart.UseCompatibleStateImageBehavior = false;
            this.lwShoppingCart.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "ProductName";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Remove
            // 
            this.Remove.Text = "Remove";
            this.Remove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Total Price";
            this.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShoppingCartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 585);
            this.Controls.Add(this.lwShoppingCart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShoppingCartScreen";
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.ShoppingCartScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwShoppingCart;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Remove;
        private System.Windows.Forms.ColumnHeader TotalPrice;
    }
}
namespace SingleResponsibilty
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxProductName = new TextBox();
            textBoxPrice = new TextBox();
            buttonAddProduct = new Button();
            buttonBackolor = new Button();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(61, 50);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(100, 23);
            textBoxProductName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(61, 79);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(86, 108);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(75, 23);
            buttonAddProduct.TabIndex = 2;
            buttonAddProduct.Text = "Ürün Ekle";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonBackolor
            // 
            buttonBackolor.Location = new Point(130, 232);
            buttonBackolor.Name = "buttonBackolor";
            buttonBackolor.Size = new Size(189, 23);
            buttonBackolor.TabIndex = 3;
            buttonBackolor.Text = "Arka plan rengini değiştir";
            buttonBackolor.UseVisualStyleBackColor = true;
            buttonBackolor.Click += buttonBackolor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 267);
            Controls.Add(buttonBackolor);
            Controls.Add(buttonAddProduct);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxProductName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProductName;
        private TextBox textBoxPrice;
        private Button buttonAddProduct;
        private Button buttonBackolor;
    }
}

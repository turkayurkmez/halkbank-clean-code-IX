namespace SingleResponsibilty
{
    public partial class Form1 : Form
    {
        /*
         * SRP: Her nesnenin bir sorumluluğu olmalı!
         * 
         * Bir nesnede değişiklik yapmak (task eklemek) için birden fazla sebebiniz versa prensibi ihlal ediyorsunuz demektir.
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var name = textBoxProductName.Text;
            var price = decimal.Parse(textBoxPrice.Text);

            ProductService productService = new ProductService();
            productService.CreateProduct(name, price);

            EmailService emailService = new EmailService();
            emailService.SendEmail();


        }

      

        private void buttonBackolor_Click(object sender, EventArgs e)
        {
            changeBackColor(Color.Red);
        }


       

    
        private void changeBackColor(Color red)
        {
            throw new NotImplementedException();
        }

    }
}

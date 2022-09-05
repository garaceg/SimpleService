using SimpleService;

namespace Client
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }
        
        private void txtProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGetID_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProductID.Text.Trim()))
            {
                ProductService productService = new ProductService();

                int productId = int.Parse(txtProductID.Text);

                ProductResponse productResponse = productService.GetProductInformation(productId);

                if (!productResponse.sucess)
                {
                    MessageBox.Show(productResponse.errorMessage);
                }
                else
                {
                    txtCodeName.Text = productResponse.product.CodeName;
                    txtDescription.Text = productResponse.product.Description;
                    txtCategory.Text = productResponse.product.Category.ToString();
                    txtColor.Text = productResponse.product.Color;
                    txtProductionDate.Text = productResponse.product.ProductionDate.ToShortDateString();
                }
            }
            else
            {
                MessageBox.Show("Please enter Product ID");
            }
        }
    }
}
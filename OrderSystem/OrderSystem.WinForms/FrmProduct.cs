using OrderSystem.Services;
using OrderSystem.BusinessObjects.Entities;
namespace OrderSystem.WinForms
{
    public partial class FrmProduct : Form
    {
        ProductService productService = new ProductService();
        public FrmProduct()
        {
            InitializeComponent();
          
        }

        private void ValoresDefault()
        {
            int Entero;
            double Doble;

            if (int.TryParse(TxtId.Text, out Entero ) == false)
                TxtId.Text = "0";

            if (double.TryParse(TxtPrecio.Text, out Doble) == false)
                TxtPrecio.Text = "0";

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ValoresDefault();
            Product product = new Product(){ 
                ProductId =  int.Parse(TxtId.Text),
                Name = TxtNombre.Text,
                UnitPrice = double.Parse(TxtPrecio.Text),
                Category = TxtCategoria.Text,
                Description = TxtDescripcion.Text
            };

            string ResultValidation = productService.AddProduct(product);

            if (!string.IsNullOrEmpty(ResultValidation))
            {
                MessageBox.Show(ResultValidation);
            }
            else
            {
                MessageBox.Show("Todo fino");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = productService.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Prod1 = new ProductoOrden() { ProductId=1, Name= "Pan", UnitPrice= 1200 };
            var Prod2 = new ProductoOrden() { ProductId = 2, Name = "Jamon", UnitPrice = 1500 };
            var Prod3 = new ProductoOrden() { ProductId = 3, Name = "Queso", UnitPrice = 1200 };

            
            Orden newOrden = new Orden();
            newOrden.OrdenId = 1;
            newOrden.FechaOrden = DateTime.Now;
            newOrden.OrdenDetalle = new();
            OrdenItem ordenItem = new OrdenItem() { Producto = Prod1, Cantidad = 4, TotalItem = 4800 };

            newOrden.OrdenDetalle.Producto.Add(ordenItem);
            ordenItem = new OrdenItem() { Producto = Prod2, Cantidad = 1, TotalItem = 1500 };
            newOrden.OrdenDetalle.Producto.Add(ordenItem);
            ordenItem = new OrdenItem() { Producto = Prod3, Cantidad = 1, TotalItem = 1200 };
            newOrden.OrdenDetalle.Producto.Add(ordenItem);




        }
    }
}

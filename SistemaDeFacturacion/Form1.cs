namespace SistemaDeFacturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SistemaDeFact conexion = new SistemaDeFact();
        private int n = 0;
        private void btn_agregar_Click(object sender, EventArgs e)
        { 
            try
            {
                // Se agrega el producto a la base de datos
                int idProd = cmb_productos.SelectedIndex + 1;
                int cant = Convert.ToInt32(nup_cantidad.Value);

                conexion.AgregarProducto(idProd, cant, conexion.GetPrecio(idProd) * cant);

                // Se adiciona un renglon al datagridView
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = cant.ToString();
                dataGridView1.Rows[n].Cells[1].Value = conexion.GetNombre(idProd);
                dataGridView1.Rows[n].Cells[2].Value = conexion.GetPrecio(idProd);
            }
            catch
            {
                MessageBox.Show("Algo ha ocurrido :c");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        //Botón borrar
        private void button1_Click(object sender, EventArgs e)
        {
            if(n != 1)
            {
                int cant = Convert.ToInt32(dataGridView1.Rows[n].Cells[0].Value);
                string nombre = (string)dataGridView1.Rows[n].Cells[1].Value;

                conexion.EliminarProducto(cant, conexion.GetIdProd(nombre));

                dataGridView1.Rows.RemoveAt(n);
            }
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            try
            {
                double iva = Convert.ToDouble(txtBox_iva.Text);
                double descuento = Convert.ToDouble(txtBox_descuento.Text);

                txtBox_total.Text = Convert.ToString(conexion.Pagar(iva, descuento));
                conexion.SetFactura(iva, descuento);
            }
            catch
            {
                MessageBox.Show("Ingrese correctamente los datos de IVA o el descuento");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int nit = Convert.ToInt32(txtBox_nit.Text);

                conexion.login(nit);
            }
            catch
            {
                MessageBox.Show("Ingrese bien los datos");
            }
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            try
            {
                int nit = Convert.ToInt32(txtBox_nitC.Text);
                string nombre = txtBox_nombreC.Text;
                string apellido = txtBox_ApellidoC.Text;

                conexion.register(nit, nombre, apellido);
            }
            catch
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            
        }
    }
}
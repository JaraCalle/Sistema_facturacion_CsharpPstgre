using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SistemaDeFacturacion
{
    internal class SistemaDeFact
    {
        public int numFactura = NFactura();
        int nitCliente;
        int numProd = 0;

        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = db204112; Database = prueba");

        public static int NFactura()
        {
            Random random = new Random();
            int numFactura = random.Next(1, 1000);
            return numFactura;
        }

        public void AgregarProducto(int id_prod, int cant, double precio)
        {
            numProd++;
            conn.Close();

            string query = "insert into sistema.detalle(id_factura, id_producto, num_producto, cantidad,  precio) values(" 
                + numFactura + ", " + id_prod + ", " + numProd + ", " 
                + cant + ", " + precio +")";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, conn);
            conn.Open();
            npgsqlCommand.ExecuteNonQuery();

            MessageBox.Show("Añadido correctamente");
            conn.Close();
        }

        public void EliminarProducto(int cant, int id_prod)
        {
            conn.Close();
            string query = "delete from sistema.detalle where cantidad = " + cant + "and id_producto = " + id_prod;
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            conn.Open();
            command.ExecuteNonQuery();

            MessageBox.Show("Se ha elimando correctamente");
            conn.Close();

            numProd--;
        }

        public double Pagar(double iva, double descuento)
        {
            double subtotal = GetSubtotal();
            subtotal = subtotal + (subtotal * (iva / 100));
            subtotal = subtotal - (subtotal * (descuento / 100));

            return subtotal;
        }

        public void login(int nit)
        {
            conn.Close();
            string query = "Select nit from sistema.cliente where nit = " + nit;
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            conn.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Bienvenido señor@ " + GetNombreApellido(nit));
                nitCliente = nit;
            }
            else
            {
                MessageBox.Show("No se encuentra registrado");
            }
        }

        public void register(int nit, string nombre, string apellido)
        {
            conn.Close();
            string query = "Select nit from sistema.cliente where nit = " + nit;
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            conn.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Ya se encuentra registrado");
            }
            else
            {
                conn.Close();

                string queryInsert = "Insert into sistema.cliente values(" 
                    + nit + ", '" + nombre + "', '" + apellido + "')";
                NpgsqlCommand commandInsert = new NpgsqlCommand(queryInsert, conn);

                conn.Open();
                commandInsert.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Se ha registrado correctamente");
            }
        }

        public void SetFactura(double iva, double descuento)
        {
            if(nitCliente == 0)
            {
                MessageBox.Show("Debe ingresar su nit primero");
            }
            else
            {
                conn.Close();
                string query = "Insert into sistema.factura values("
                    + numFactura + ", " + nitCliente + ", " + iva + ", " + descuento + ")";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, conn);
                conn.Open();
                npgsqlCommand.ExecuteNonQuery();

                MessageBox.Show("Factura creada con éxito");
                conn.Close();

                numFactura = NFactura();
            }            
        }

        public double GetPrecio(int id_prod)
        {
            conn.Close();
            string query = "Select valoru from sistema.productos where id = " + id_prod;
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            conn.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

            reader.Read();
            double precio = reader.GetDouble(0);

            return precio;
        }

        public string GetNombre(int id_prod)
        {
            conn.Close();
            string query = "Select nombre from sistema.productos where id = " + id_prod;
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            conn.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

            reader.Read();
            string nombre = reader.GetString(0);

            return nombre;
        }

        public int GetIdProd(string nombre)
        {
            conn.Close();
            string query = "Select id from sistema.productos where nombre = '" + nombre + "'";
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            conn.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

            reader.Read();
            int idprod = reader.GetInt32(0);

            return idprod;
        }
        public double GetSubtotal()
        {
            conn.Close();
            string query = "select sum(precio) from sistema.detalle";
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            conn.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

            reader.Read();
            return reader.GetDouble(0);
        }
        public string GetNombreApellido(int nit)
        {
            conn.Close();
            string query = "select nombre, apellido from sistema.cliente where nit = " + nit;
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            conn.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

            reader.Read();
            string nombreApellido = reader.GetString(0) + " " + reader.GetString(1);
            return nombreApellido;
        }
    }
}

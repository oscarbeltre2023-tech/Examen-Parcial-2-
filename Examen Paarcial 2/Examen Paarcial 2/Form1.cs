using System;
using System.Globalization;
using System.Windows.Forms;

namespace Examen_Paarcial_2
{
    public partial class Form1 : Form
    {
        private decimal subtotal = 0m;
        private readonly CultureInfo culturaRD =
            CultureInfo.GetCultureInfo("es-DO");

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;

            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 20;
            nudCantidad.Value = 1;

            rbtNormal.Checked = true;
            rbtLocal.Checked = true;

            lblEncabezado.Text =
                "Cant.     Producto                 Precio      Total";

            LimpiarResultados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text.Trim();

            if (producto == "")
            {
                MessageBox.Show("Escribe el nombre del producto.");
                txtProducto.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("Escribe un precio válido.");
                txtPrecio.Focus();
                return;
            }

            decimal precioUnitario = precio;

            if (rbtGrande.Checked)
                precioUnitario += 25m;

            if (chkPorcionExtra.Checked)
                precioUnitario += 30m;

            int cantidad = (int)nudCantidad.Value;
            decimal totalLinea = precioUnitario * cantidad;

            string nombreProducto = producto;

            if (rbtGrande.Checked)
                nombreProducto += " (Grande)";

            string linea =
                cantidad.ToString().PadRight(6) +
                nombreProducto.PadRight(24) +
                precioUnitario.ToString("N2", culturaRD).PadLeft(10) +
                totalLinea.ToString("N2", culturaRD).PadLeft(12);

            lstPedido.Items.Add(linea);
            subtotal += totalLinea;

            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            rbtNormal.Checked = true;
            chkPorcionExtra.Checked = false;
            txtProducto.Focus();

            lblSubtotal.Text = subtotal.ToString("C2", culturaRD);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstPedido.Items.Count == 0)
            {
                MessageBox.Show("Agrega al menos un producto antes de calcular.");
                return;
            }

            decimal descuento = chkFrecuente.Checked
                ? subtotal * 0.10m
                : 0m;

            decimal empaque = rbtLlevar.Checked ? 20m : 0m;
            decimal baseImponible = subtotal - descuento + empaque;
            decimal itbis = baseImponible * 0.18m;
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = subtotal.ToString("C2", culturaRD);
            lblDescuento.Text = descuento.ToString("C2", culturaRD);
            lblEmpaque.Text = empaque.ToString("C2", culturaRD);
            lblItbis.Text = itbis.ToString("C2", culturaRD);
            lblTotal.Text = total.ToString("C2", culturaRD);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();

            dtpFecha.Value = DateTime.Today;
            chkFrecuente.Checked = false;
            chkPorcionExtra.Checked = false;
            rbtNormal.Checked = true;
            rbtLocal.Checked = true;
            nudCantidad.Value = 1;

            lstPedido.Items.Clear();
            subtotal = 0m;

            LimpiarResultados();
            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarResultados()
        {
            lblSubtotal.Text = 0m.ToString("C2", culturaRD);
            lblDescuento.Text = 0m.ToString("C2", culturaRD);
            lblEmpaque.Text = 0m.ToString("C2", culturaRD);
            lblItbis.Text = 0m.ToString("C2", culturaRD);
            lblTotal.Text = 0m.ToString("C2", culturaRD);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void lstPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

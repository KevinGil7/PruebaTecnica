using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Text;
namespace PruebaTecnica
{
    public partial class Compra : Form
    {
        int posicion;
        public Compra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvproductos.Columns.Add("Nombre", "Nombre");
            dgvproductos.Columns.Add("Descripcion", "Descripcion");
            dgvproductos.Columns.Add("Precio", "Precio");
            dgvproductos.Columns.Add("Cantidad", "Cantidad");
            dgvproductos.Columns.Add("Subtotal", "Subtotal");
            btnactualizar.Enabled = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcantidad.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese un número entero en la cantidad. :D", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que txtPrecio solo tenga números decimales válidos
            if (!decimal.TryParse(txtprecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio válido (numeral). :D", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int indice_fila = dgvproductos.Rows.Add();
            DataGridViewRow row = dgvproductos.Rows[indice_fila];

            row.Cells["Nombre"].Value = txtnombre.Text;
            row.Cells["Descripcion"].Value = txtdescripcion.Text;
            row.Cells["Precio"].Value = txtprecio.Text;
            row.Cells["Cantidad"].Value = txtcantidad.Text;
            row.Cells["Subtotal"].Value = decimal.Parse(txtprecio.Text) * decimal.Parse(txtcantidad.Text);

            ActualizarTotalFinal();
            limpiar();
        }

        private void ActualizarTotalFinal()
        {
            decimal totalFinal = 0;

            // Sumar el subtotal de cada fila en el DataGridView
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                {
                    totalFinal += Convert.ToDecimal(row.Cells["subtotal"].Value);
                }
            }

            // Mostrar el total en el TextBox
            txttotalfinal.Text = totalFinal.ToString("N2");
        }

        private void limpiar()
        {
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtcantidad.Text = "";
            txtnombre.Focus();
        }


        private void btndescargar_Click(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            SaveFileDialog guardarpdf = new SaveFileDialog();
            guardarpdf.FileName = ("factura.pdf");

            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "plantilla.html");

            // Manejo de errores al leer el archivo HTML
            string paginahtml;
            try
            {
                paginahtml = File.ReadAllText(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la plantilla HTML: " + ex.Message);
                return;
            }

            paginahtml = paginahtml.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            string filas = string.Empty;

            decimal total = 0;
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                if (row.Cells["Nombre"].Value != null &&
                    row.Cells["Descripcion"].Value != null &&
                    row.Cells["Precio"].Value != null &&
                    row.Cells["Cantidad"].Value != null &&
                    row.Cells["Subtotal"].Value != null)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                total += decimal.Parse(row.Cells["Subtotal"].Value.ToString());
            }

            paginahtml = paginahtml.Replace("@FILAS", filas);
            paginahtml = paginahtml.Replace("@TOTAL", total.ToString());


            if (guardarpdf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardarpdf.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Logo_azul_SM_1024x269, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(100, 100);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);
                    //using (StringReader sr = new StringReader(paginahtml))
                    try
                    {
                        using (StringReader sr = new StringReader(paginahtml))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    pdfDoc.Close();
                    stream.Close();

                }
            }

        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Validar que no sea el encabezado
            {
                DataGridViewRow row = dgvproductos.Rows[e.RowIndex];
                posicion = dgvproductos.CurrentRow.Index;
                txtnombre.Text = dgvproductos[0, posicion].Value.ToString();
                txtdescripcion.Text = dgvproductos[1, posicion].Value.ToString();
                txtprecio.Text = dgvproductos[2, posicion].Value.ToString();
                txtcantidad.Text = dgvproductos[3, posicion].Value.ToString();
                btnagregar.Enabled = false;
                btnactualizar.Enabled = true;
                txtnombre.Focus();
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string nombre, descripcion, precioo, cantidadd;
            nombre = txtnombre.Text;
            descripcion = txtdescripcion.Text;
            precioo = txtprecio.Text;
            cantidadd = txtcantidad.Text;
            if (dgvproductos.SelectedRows.Count > 0) // Verificar que haya una fila seleccionada
            {
                DataGridViewRow selectedRow = dgvproductos.SelectedRows[0];

                // Validar la entrada de cantidad y precio antes de modificar
                if (!int.TryParse(txtcantidad.Text, out int cantidad))
                {
                    MessageBox.Show("Ingrese un número entero válido en la cantidad.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtprecio.Text, out decimal precio))
                {
                    MessageBox.Show("Ingrese un precio válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calcular el subtotal
                decimal subtotal = precio * cantidad;

                // Modificar la fila seleccionada con los nuevos valores
                nombre = txtnombre.Text;
                descripcion = txtdescripcion.Text;
                precioo = txtprecio.Text;
                cantidadd = txtcantidad.Text;
                dgvproductos[0, posicion].Value = txtnombre.Text;
                dgvproductos[1, posicion].Value = txtdescripcion.Text;
                dgvproductos[2, posicion].Value = txtprecio.Text;
                dgvproductos[3, posicion].Value = txtcantidad.Text;

                // Actualizar el total final
                ActualizarTotalFinal();

                // Limpiar los TextBox y restaurar el estado de los botones
                limpiar();
                //btnagregar.Enabled = true;
                //btnactualizar.Enabled = false;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dgvproductos.Rows.RemoveAt(posicion);
            txtnombre.Focus();
            limpiar();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

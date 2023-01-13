using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibPOO.Models;

namespace AppPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Categoria panaderia = new Categoria();
            panaderia.Nombre = "Panaderia";

            Producto producto1= new Producto("Pan", 600.46);
            producto1.Categoria= panaderia;

            Producto producto2 = new Producto("Agua", 300.38);
            producto2.Categoria= panaderia;

  
            List<Producto> productos = new List<Producto>();
            productos.Add(producto1);
            productos.Add(producto2);
            gridProductos.DataSource= productos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Repaso_1_Laboratorio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1CargarDatos_Click(object sender, EventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();
            //Cargar Lista Txt
            String filename = "Empleado.txt";
            FileStream stream = new FileStream("Personas.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter reader = new StreamWriter(stream);

            while (reader.Peek() > -1)
            {
                Empleado empleado = new Empleado();

                empleado.NoEmpleado = Convert.ToInt32(reader.ReadLine));
                empleado.Nombres = reader.ReadLine();
                empleado.SueldoHora = Convert.ToDecimal(reader.ReadLine());


                empleado.Add(empleado);
            }
            reader.Close();
        }

    }
    }
}

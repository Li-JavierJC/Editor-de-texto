using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_1
{
    public partial class Form1 : Form
    {
        System.Drawing.FontStyle estilo;
        int tamaño_fuente;
        string tipo_fuente;
        String texto;
        String ruta_archivo;
        public Form1()
        {
            InitializeComponent();
        }

        //----------------------funcion para abrir archivo de texto----------------------------------------------
        private void abrir_Click(object sender, EventArgs e)
        {
            //Filtar tipo de archivo
            openFileDialog1.Filter = " Archivos de texto|*.txt";
            //nombre del programa
            openFileDialog1.Title = " My Editor-Abrir archivo";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //coloaca la direccion del archivo
                ruta_archivo = openFileDialog1.FileName;
                System.IO.StreamReader Fp = new System.IO.StreamReader(ruta_archivo, System.Text.Encoding.Default);
                texto = Fp.ReadToEnd();
                Contenedor_txt.Text = texto;
                Fp.Close();
            }
        }

        //----------------funcion para gurada como, del archivo-----------------------------------------------------------
        private void guardar_boton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = " Abrir archivo";
            saveFileDialog1.Filter = "Archivos de texto|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter escrito = System.IO.File.CreateText(saveFileDialog1.FileName);
                string contenido = Contenedor_txt.Text;
                escrito.Write(contenido.ToString());
                escrito.Flush();
                escrito.Close();
            }
        }

        //----------------funcion para gurada del archivo-----------------------------------------------------------
        private void B_guardar_Click(object sender, EventArgs e)
        {
            if (ruta_archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(ruta_archivo))
                {
                    sw.Write(Contenedor_txt.Text);
                }
            }
            else
            {
                saveFileDialog1.Title = " Abrir archivo";
                saveFileDialog1.Filter = "Archivos de texto|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter escrito = System.IO.File.CreateText(saveFileDialog1.FileName);
                    string contenido = Contenedor_txt.Text;
                    escrito.Write(contenido.ToString());
                    escrito.Flush();
                    escrito.Close();
                }
            }
        }

       //----------------funcion para crear nuevo archivo del archivo-----------------------------------------------------------
       private void b_nuevo_archivo_Click(object sender, EventArgs e)
       {
            if (ruta_archivo != null)
            {
                DialogResult rs = MessageBox.Show("Modificaste el archivo. ¿Desea guardarlo?", "Mensaje", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    using (StreamWriter sw = new StreamWriter(ruta_archivo))
                    {
                        sw.Write(Contenedor_txt.Text);
                    }
                    MessageBox.Show("Se guardo el archivo: " + saveFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Has cancelado");
                }
                Contenedor_txt.Text = "";
                ruta_archivo = null;
            }
            else
            {
                saveFileDialog1.Title = " Abrir archivo";
                saveFileDialog1.Filter = "Archivos de texto|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter escrito = System.IO.File.CreateText(saveFileDialog1.FileName);
                    string contenido = Contenedor_txt.Text;
                    escrito.Write(contenido.ToString());
                    escrito.Flush();
                    escrito.Close();
                }
                Contenedor_txt.Text = "";
            }
        }

      //----------------funcion para la letra en negrita-----------------------------------------------------------
       private void b_negrita_Click(object sender, EventArgs e)
       {
           System.Drawing.Font fuente = Contenedor_txt.SelectionFont;
           if (Contenedor_txt.SelectionFont.Bold == true)
               estilo = FontStyle.Regular;
           else estilo = estilo | FontStyle.Bold;
           Contenedor_txt.SelectionFont = new Font(fuente.FontFamily, fuente.Size, estilo);
       }

       //----------------funcion para la fuente del texto-----------------------------------------------------------
       private void Fuente_Click(object sender, EventArgs e)
       {
           //FontDialog fontD=new FontDialog();
           //fontD.Font= Contenedor_txt.Font;
           if (fontDialog1.ShowDialog() == DialogResult.OK)
           {
               Contenedor_txt.Font = fontDialog1.Font;
           }
       }

       //----------------funcion la letra en cursiva---------------------------------------------------------------
       private void Cursiva_Click(object sender, EventArgs e)
       {
           System.Drawing.Font fuente = Contenedor_txt.SelectionFont;
           if (Contenedor_txt.SelectionFont.Italic == true)
               estilo = FontStyle.Regular;
           else estilo = estilo | FontStyle.Italic;
           Contenedor_txt.SelectionFont = new Font(fuente.FontFamily, fuente.Size, estilo);
       }

       //----------------funcion para la letra subrayada---------------------------------------------------------------
       private void Subrayar_Click(object sender, EventArgs e)
       {
           System.Drawing.Font fuente = Contenedor_txt.SelectionFont;
           if (Contenedor_txt.SelectionFont.Underline == true)
               estilo = FontStyle.Regular;
           else estilo = estilo | FontStyle.Underline;
           Contenedor_txt.SelectionFont = new Font(fuente.FontFamily, fuente.Size, estilo);
       }

       //----------------funcion para el color de texto---------------------------------------------------------------
       private void Color_Click(object sender, EventArgs e)
       {
           ColorDialog colorD = new ColorDialog();
           if (colorD.ShowDialog() == DialogResult.OK)
           {
               Contenedor_txt.ForeColor = colorD.Color;
           }
       }

       //----------------funcion para el combox del editor desde el form load---------------------------------------------------------------
       private void Form1_Load(object sender, EventArgs e)
       {
           combox_tamf.Items.Clear();
           for (int i = 2; i <= 16; ++i)
               combox_tamf.Items.Add(Convert.ToString(i * 4));

           combox_tamf.SelectedItem = "12";
           tamaño_fuente = 12;
           Contenedor_txt.Font = new Font(tipo_fuente, tamaño_fuente);


           cb_fuente.Items.Clear();
           foreach (FontFamily font_family in FontFamily.Families) cb_fuente.Items.Add(font_family.Name);
           cb_fuente.SelectedItem = "Arial";

           Contenedor_txt.Font = new Font(tipo_fuente, tamaño_fuente);
       }

       //----------------funcion para el tamaño de la fuente del combobox--------------------------------------------------------
       private void combox_tamf_SelectedIndexChanged(object sender, EventArgs e)
       {
           tamaño_fuente = Convert.ToInt16(combox_tamf.SelectedItem.ToString());
           Contenedor_txt.SelectionFont = new Font(tipo_fuente, tamaño_fuente, estilo);
       }

       //----------------funcion para el tipo de fuente del combobox--------------------------------------------------------
       private void cb_fuente_SelectedIndexChanged(object sender, EventArgs e)
       {
           tipo_fuente = cb_fuente.SelectedItem.ToString();
           Contenedor_txt.SelectionFont = new Font(tipo_fuente, tamaño_fuente, estilo);
       }

       //----------------funcion para copiar texto------------------------------------------------------------------------

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor_txt.Copy();
        }

        //----------------funcion para pegar texto------------------------------------------------------------------------
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor_txt.Paste();
        }

        //----------------funcion para cortar texto------------------------------------------------------------------------
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor_txt.Cut();
        }

        //----------------funcion para deshacer texto------------------------------------------------------------------------
        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor_txt.Undo();
        }

        //----------------funcion para reahacer texto------------------------------------------------------------------------
        private void reahacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedor_txt.Redo();
        }

        //----------------funcion para salir del editor------------------------------------------------------------------------
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //----------------funcion para activar un segundo form load, donde muestre la informacion acerca de...------------------
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Show();
        }
      }
   }



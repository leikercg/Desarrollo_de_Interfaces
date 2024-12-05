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

namespace WF_ArchivoTexto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            StreamWriter archivo = new StreamWriter(Directory.GetCurrentDirectory() + "\\Compra.txt");
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if(checkedListBox1.GetItemChecked(i) == true)
                {
                    archivo.WriteLine(checkedListBox1.Items[i].ToString());
                }
                
            }
            archivo.Close();
            archivo.Dispose();
            MessageBox.Show("Se ha guardado la compra");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader archivo = new StreamReader(Directory.GetCurrentDirectory() + "\\Frutas.txt");
            while (!archivo.EndOfStream)
            {
                string line = archivo.ReadLine();
                checkedListBox1.Items.Add(line);
            }
            archivo.Close();
            archivo.Dispose();
            StreamReader archivo1 = new StreamReader(Directory.GetCurrentDirectory() + "\\Frutas.txt");
            while (!archivo1.EndOfStream)
            {
                string line = archivo1.ReadLine();
                checkedListBox2.Items.Add(line);
            }
            archivo1.Close();
            archivo1.Dispose();
        }
    }
}

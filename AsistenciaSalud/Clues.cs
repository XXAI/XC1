using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace AsistenciaSalud
{
    public partial class Clues : MetroForm
    {
        public Clues()
        {
            InitializeComponent();
        }

        private void Clues_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'checadorMaestraDataSetClues.Clues' Puede moverla o quitarla según sea necesario.
            this.cluesTableAdapter.Fill(this.checadorMaestraDataSetClues.Clues);

        }
    }
}

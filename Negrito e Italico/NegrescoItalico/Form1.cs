using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegrescoItalico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // "Nome do Label".Font = new Font("Arial", 16, FontStyle.Bold)

        private void modificaItalico_CheckedChanged(object sender, EventArgs e)
        {
            mensagemModificada.Font = new Font(mensagemModificada.Font.Name, mensagemModificada.Font.Size,
                mensagemModificada.Font.Style ^ FontStyle.Italic);
        }

        private void modificaNegrito_CheckedChanged(object sender, EventArgs e)
        {
            mensagemModificada.Font = new Font(mensagemModificada.Font.Name, mensagemModificada.Font.Size,
                mensagemModificada.Font.Style ^ FontStyle.Bold);
        }
    }
}

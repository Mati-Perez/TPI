using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI.Validaciones
{
    internal class Validacion
    {
        private static void Textentres( KeyPressEventArgs v)
        {
            if(char.IsLetter(v.KeyChar) || char.IsControl(v.KeyChar) || char.IsWhiteSpace(v.KeyChar))
            {
                v.Handled = false; // Permitir letras y espacios
            }
            else
            {
                v.Handled = true; // Bloquear otros caracteres
            }
        }
    }
}

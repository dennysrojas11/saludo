using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSaludo
{
    class Validar
    {
        public static void validarletras(KeyPressEventArgs n) {
            int codigo = Convert.ToInt32(n.KeyChar);
            if (codigo == 08)
            {
                n.Handled = false;
            }
            else if (Char.IsLetter(n.KeyChar))
            {
                n.Handled = false;
            }
            else {
                n.Handled = true;
            }
        }

        public static void validaredad(KeyPressEventArgs n) {
            int codigo = Convert.ToInt32(n.KeyChar);
            if (codigo == 08)
            {
                n.Handled = false;
            }
            else if (Char.IsDigit(n.KeyChar))
            {
                n.Handled = false;
            }
            else
            {
                n.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_sistema.Class
{
    internal class methods
    {
        private object errorProvider1;

        public methods() { }

        public Boolean check_box(ErrorProvider errorProvider1, Control[] arr_control, String[] name_box, String[] valor, String[] words, String text_box)
        {
            Boolean verify = true;
            for (int i = 0; i < valor.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(valor[i]))
                {
                    errorProvider1.SetError(arr_control[i], "Please, fill in the following information: " + words[i]);
                    text_box = text_box + "\n" + "- " + words[i];
                    verify = false;
                }
                else
                {
                    errorProvider1.SetError(arr_control[i], "");
                }
            }

            if (verify == false)
            {
                MessageBox.Show(text_box, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        /*
         * 
         * Boolean verify = true;
            for (int i = 0; i < valor.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(valor[i]))
                {
                    if (diccionarioControles.TryGetValue(name_box[i], out var controlEncontrado))
                    {
                        errorProvider1.SetError(controlEncontrado, "Please, fill in the following information: " + words[i]);

                    }

                    text_box = text_box + "\n" + "- " + words[i];
                    verify = false;
                }
                else
                {
                    if (diccionarioControles.TryGetValue(name_box[i], out var controlEncontrado))
                    {
                        errorProvider1.SetError(controlEncontrado, "");

                    }
                }
            }

            if (verify == false)
            {
                MessageBox.Show(text_box, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
         * 
         */
    }
}

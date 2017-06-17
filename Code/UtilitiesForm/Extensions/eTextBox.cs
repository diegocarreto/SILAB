using MetroFramework.Controls;
using System.Windows.Forms;

namespace UtilitiesForm.Extensions
{
    public static class eTextBox
    {
        public static MetroTextBox Val(this MetroTextBox txt, string Value = "", bool Focus = false)
        {
            txt.Text = Value.Trim();

            if (Focus)
            {
                txt.Focus();
            }

            return txt;
        }
    }
}

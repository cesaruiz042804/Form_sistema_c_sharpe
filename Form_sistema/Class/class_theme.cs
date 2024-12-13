using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_sistema.Class
{
    internal class class_theme
    {
        public static Color PanelMenuTotal;
        public static Color PanelLogin;
        public static Color PanelGuna;
        public static Color FontColorA;
        public static Color FontColorB;
        public static Color ColorAlternative;

        public static Color Btn;
        public static Color Background1;
        public static Color Background2;
        public static Color LetterBtn;
        public static Color LetterBack;
        public static Color LetterTextBox;


        // Theme dark
        /*
        private static readonly Color PanelMenuTotalD = Color.FromArgb(10, 10, 40);
        private static readonly Color panelLoginD = Color.FromArgb(5, 5, 20);
        private static readonly Color PanelGunaD = Color.FromArgb(5, 5, 20);
        private static readonly Color FontColorAD = Color.FromArgb(220, 220, 250);
        private static readonly Color FontColorBD = Color.FromArgb(220, 220, 250);
        private static readonly Color ColorAlternativeD = Color.FromArgb(10, 10, 40);
        */

        private static readonly Color BtnD = Color.FromArgb(10, 10, 40);
        private static readonly Color Background1D = Color.FromArgb(10, 10, 40);
        private static readonly Color Background2D = Color.FromArgb(5, 5, 20);
        private static readonly Color LetterBackD = Color.FromArgb(220, 220, 250);
        private static readonly Color LetterBtnD = Color.FromArgb(220, 220, 250);
        private static readonly Color LetterTextBoxD = Color.FromArgb(10, 10, 40);
        // Theme light

        /*
        private static readonly Color PanelMenuTotalL = Color.FromArgb(70, 130, 180);
        private static readonly Color PanelLoginL = Color.White;
        private static readonly Color PanelGunaL = Color.White;
        private static readonly Color FontColorAL = Color.FromArgb(250, 250, 250);
        private static readonly Color FontColorBL = Color.DarkGray;
        private static readonly Color ColorAlternativeL = Color.FromArgb(250, 250, 250);
        */
        private static readonly Color BtnL = Color.FromArgb(70, 130, 180);
        private static readonly Color Background1L = Color.FromArgb(70, 130, 180);
        private static readonly Color Background2L = Color.FromArgb(250, 250, 250);
        private static readonly Color LetterBackL = Color.DarkGray;
        private static readonly Color LetterBtnL = Color.FromArgb(250, 250, 250);
        private static readonly Color LetterTextBoxL = Color.FromArgb(70, 130, 180);



        public static void option_theme(String theme)
        {
            if (theme == "dark")
            {
                Btn = BtnD;
                Background1 = Background1D;
                Background2 = Background2D;
                LetterBtn = LetterBtnD;
                LetterBack = LetterBackD;
                LetterTextBox = LetterTextBoxD;

                /*
                PanelLogin = panelLoginD;
                PanelMenuTotal = PanelMenuTotalD;
                PanelGuna = PanelGunaD;
                FontColorA = FontColorAD;
                FontColorB = FontColorBD;
                ColorAlternative = ColorAlternativeD;
                */
            }

            if (theme == "light")
            {
                Btn = BtnL;
                Background1 = Background1L;
                Background2 = Background2L;
                LetterBtn = LetterBtnL;
                LetterBack = LetterBackL;
                LetterTextBox = LetterTextBoxL;
                /*
                PanelLogin = PanelLoginL;
                PanelMenuTotal = PanelMenuTotalL;
                PanelGuna = PanelGunaL;
                FontColorA = FontColorAL;
                FontColorB = FontColorBL;
                ColorAlternative = ColorAlternativeL;
                */
            }
        }
    }

    internal class class_color
    {
        public static void ChangeControlsBackColor(Control parent, Color color)
        {
            foreach (Control control in parent.Controls)
            {
                control.BackColor = color;

                if (control.HasChildren)
                {
                    ChangeControlsBackColor(control, color);
                }
            }
        }

        public static void ChangeForeColorsBackColor(Control parent, Color color)
        {
            foreach (Control control in parent.Controls)
            {
                control.ForeColor = color;

                if (control.HasChildren)
                {
                    ChangeForeColorsBackColor(control, color);
                }
            }
        }

        public static void ChangeButtonColorsBackColor(Control parent, Color color)
        {
            foreach (Control control in parent.Controls)
            {

                if (control is Button)
                {
                    control.BackColor = color;
                }
                else if(control.HasChildren)
                {
                    ChangeForeColorsBackColor(control, color);
                }
            }
        }

        public static void ChangeButtonColorsForeColor(Control parent, Color color)
        {
            foreach (Control control in parent.Controls)
            {

                if (control is Button)
                {
                    control.ForeColor = color;
                }
                else if (control.HasChildren)
                {
                    ChangeForeColorsBackColor(control, color);
                }
            }
        }
    }
}

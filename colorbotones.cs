using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMPORTADORAPOO
{
    internal class colorbotones
    {

       
            // Definimos los colores corporativos de la aplicación
            public static Color ColorBotonPrincipal = Color.FromArgb(0, 122, 204); // Azul corporativo
            public static Color ColorTextoBoton = Color.White;

            // Método para personalizar un botón individual
            public static void EstilarBoton(Button btn)
            {
                btn.BackColor = ColorBotonPrincipal;
                btn.ForeColor = ColorTextoBoton;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }

            // Método para estilar TODOS los botones de un Formulario de golpe
            public static void EstilarTodosLosBotones(Control contenedor)
            {
                foreach (Control ctrl in contenedor.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        EstilarBoton(btn);
                    }
                    else if (ctrl.HasChildren) // Si los botones están dentro de un Panel o GroupBox
                    {
                        EstilarTodosLosBotones(ctrl);
                    }
                }
            }
        }
    }



using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace IMPORTADORAPOO
{
    // Panel personalizado que pinta un fondo semitransparente.
    [ToolboxItem(true)]
    [DefaultProperty("Alpha")]
    public class TransparentPanel : Panel
    {
        private int _alpha = 128;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Opacidad del fondo (0-255). 0 = totalmente transparente, 255 = opaco.")]
        [DefaultValue(128)]
        public int Alpha
        {
            get => _alpha;
            set
            {
                _alpha = Math.Max(0, Math.Min(255, value));
                Invalidate();
            }
        }

        private Color _fillColor = Color.Black;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Color de relleno del panel.")]
        [DefaultValue(typeof(Color), "Black")]
        public Color FillColor
        {
            get => _fillColor;
            set
            {
                _fillColor = value;
                Invalidate();
            }
        }

        public TransparentPanel()
        {
            // Permitir pintura personalizada y soporte para BackColor transparente
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Pintar fondo semitransparente antes de que se pinten los hijos
            using (var brush = new SolidBrush(Color.FromArgb(_alpha, _fillColor)))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }

            base.OnPaint(e);
        }
    }
}

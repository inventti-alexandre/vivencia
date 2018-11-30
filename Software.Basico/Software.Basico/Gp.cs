using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico
{
    class Gp
    {
        public GraphicsPath graphicsPath(Form form)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddRectangle(new System.Drawing.Rectangle(1, 1, form.Size.Width, form.Size.Height));

            //Arredondar canto superior esquerdo        
            gp.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            gp.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            gp.AddRectangle(new System.Drawing.Rectangle(form.Width - 12, 1, 12, 13));
            gp.AddPie(form.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            gp.AddRectangle(new System.Drawing.Rectangle(1, form.Height - 10, 10, 10));
            gp.AddPie(1, form.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            gp.AddRectangle(new System.Drawing.Rectangle(form.Width - 12, form.Height - 13, 13, 13));
            gp.AddPie(form.Width - 24, form.Height - 26, 24, 26, 0, 90);

            gp.SetMarkers();

            return gp;
        }

        public GraphicsPath graphicsPath(Button btn)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddRectangle(new System.Drawing.Rectangle(1, 1, btn.Size.Width, btn.Size.Height));

            //Arredondar canto superior esquerdo        
            gp.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            gp.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            gp.AddRectangle(new System.Drawing.Rectangle(btn.Width - 12, 1, 12, 13));
            gp.AddPie(btn.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            gp.AddRectangle(new System.Drawing.Rectangle(1, btn.Height - 10, 10, 10));
            gp.AddPie(1, btn.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            gp.AddRectangle(new System.Drawing.Rectangle(btn.Width - 12, btn.Height - 13, 13, 13));
            gp.AddPie(btn.Width - 24, btn.Height - 26, 24, 26, 0, 90);

            gp.SetMarkers();

            return gp;
        }

        public GraphicsPath graphicsPath(TextBox txt)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddRectangle(new System.Drawing.Rectangle(1, 1, txt.Size.Width, txt.Size.Height));

            //Arredondar canto superior esquerdo        
            gp.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            gp.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            gp.AddRectangle(new System.Drawing.Rectangle(txt.Width - 12, 1, 12, 13));
            gp.AddPie(txt.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            gp.AddRectangle(new System.Drawing.Rectangle(1, txt.Height - 10, 10, 10));
            gp.AddPie(1, txt.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            gp.AddRectangle(new System.Drawing.Rectangle(txt.Width - 12, txt.Height - 13, 13, 13));
            gp.AddPie(txt.Width - 24, txt.Height - 26, 24, 26, 0, 90);

            gp.SetMarkers();

            return gp;
        }
    }
}

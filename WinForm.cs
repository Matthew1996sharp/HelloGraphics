// Программа демонстрирует вывод текста на поверхность формы 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloGraphics
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        //обработка события Paint
        private void WinForm_Paint(object sender, PaintEventArgs e)
        {
            //вывод текста шрифтом, заданным значением свойства Font формы
            e.Graphics.DrawString("Microsoft Visual C#", this.Font, Brushes.DarkGreen, 10, 10);

            //вывод текста шрифтом, созданным программистом
            Font aFont = new Font("Tahoma", 12, FontStyle.Regular);
            e.Graphics.DrawString("Microsoft Visual C#", aFont, Brushes.Black, 10, 30);

            //вывод текста в центре формы
            Font hFont = new Font("Tahoma", 14, FontStyle.Underline);
            string header = "Microsoft Visual Studio C# 2022 Community Edition";

            //размер области отображения текста зависит от
            //характеристик шрифта, которым он отображается

            //определить размер области отображения текста
            int width = (int)e.Graphics.MeasureString(header, hFont).Width;
            int height = (int)e.Graphics.MeasureString(header, hFont).Height;

            //вычислить координаты левого верхнего угла области отображения текста,
            //так чтобы текст был размещен в центре формы по горизонтали и вертикали.
            //ClientSize.Width - размер внутренней области формы
            int x = (this.ClientSize.Width - width) / 2;
            int y = (this.ClientSize.Height - height) / 2;

            //вывести текст в центре формы
            e.Graphics.DrawString(header, hFont, Brushes.DarkGreen, x, y);
            e.Graphics.DrawString(header, hFont, Brushes.DarkGreen, x, y + height);
        }

        private void WinForm_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}

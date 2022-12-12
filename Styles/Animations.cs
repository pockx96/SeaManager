using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MarDeCortezDsk.Styles
{
    public class Animations
    {
        public void ButtonActive(Button button)
        {
            button.BackColor = Color.FromArgb(1,76,76,76);
            button.TextImageRelation = TextImageRelation.TextBeforeImage;

        }
        public void ButtonDesactive(Button button)
        {
            button.BackColor = Color.FromArgb(82, 122, 242);
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        public Point BtnlocationDatagrid(DataGridView dataGrid,int cusorPointStart,int cursorPosition,Point incialPocition,int contCells)
        {
            int height = dataGrid.RowTemplate.Height;
            List<Point> RangeY = new List<Point>();
            int FirstRange;
            int LastRange;
            Point point = new Point(0,0);
            for (int i = 0;i<contCells;i++)
            {

                FirstRange = cusorPointStart + (height*i);
                LastRange = FirstRange + height;
                RangeY.Add(new Point(FirstRange, LastRange));
                
            }

            int j = 0;
            foreach (Point element in RangeY)
            {
                if (cursorPosition>=element.X && cursorPosition<= element.Y)
                {

                    int Y = (height*j)+ incialPocition.Y;
                    point = new Point(incialPocition.X,Y);

         
                }
                j++;
            }

            

            return point;
        }
    }
}

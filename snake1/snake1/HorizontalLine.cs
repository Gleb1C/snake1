
using System.Collections.Generic;

/*горизонтальные линии, припятствие для змейки*/
namespace snake1
{
    internal class HorizontalLine
    {
        /*лист-список точек выстраивается в одну линию*/
        List<Point> pList;
        /*содаеи констрктор, т.е. метод при который будет вызываться
         * при содании линии*/
        public HorizontalLine()
        {
            pList = new List<Point>();
            Point p1=new Point(4, 4, '*');
            Point p2 = new Point(5, 4, '*');
            Point p3 = new Point(6, 4, '*');
            /*добавляю все три точки в список List<Point>()*/
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

        }

        /*теперь вывод на экран*/

        public void Drow()
        {
            /*используем цыкл foreach*/

            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}

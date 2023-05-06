using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary_lub1
{
    public class Room
    {
        double roomLengtc; // длина комнаты
        double roomWidth;  //ширина комнаты
        public double RoomLength
        {
            get { return RoomLength; }
            set { RoomLength = value; }
        }
        /// <summary>
        /// Мутод вычесления периметр комнаты
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimetr()
        {
            return 2 * (RoomLength + roomWidth);
        }
        /// <summary>
        /// Мутод вычесления площадь комнаты
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double RoomArea()
        {
            return RoomLength * roomWidth;
        }
        /// <summary>
        /// Мутод вычесляет число квадратных метров на одного человека
        /// </summary>
        /// <param name="=np">Число человек</param>
        /// <returns>Возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
    }
}

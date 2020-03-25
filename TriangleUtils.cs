using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightTriangle
{
    public class TriangleUtils
    {
        public static bool IsRightTriangleExist(int[] Sides)
        {
            for (int _firstSideNumber = 0; _firstSideNumber < Sides.Length; _firstSideNumber++)
            {
                for (int _secondSideNumber = 0; _secondSideNumber < Sides.Length; _secondSideNumber++)
                {
                    if(_firstSideNumber == _secondSideNumber)
                    {
                        continue;
                    }

                    if (Sides[_firstSideNumber] == Sides[_secondSideNumber])
                    {
                        return false;
                    }

                    for (int _thirdSideNumber = 0; _thirdSideNumber < Sides.Length; _thirdSideNumber++)
                    {
                        if (_thirdSideNumber == _firstSideNumber || _thirdSideNumber == _secondSideNumber)
                        {
                            continue;
                        }

                        if (Sides[_firstSideNumber] + Sides[_secondSideNumber] < Sides[_thirdSideNumber])
                        {
                            return false;
                        }
                    }

                    
                }

            }

            return true;
        }

        public static int GetHypotenuse(int[] Sides)
        {
            return Sides.Max();
        }

        public static int GetTriangleSquare(int[] Sides)
        {
            int[] _cathetus = new int[2];
            int Hupotenuse = GetHypotenuse(Sides);

            int _filledCathetus = 0;
            for (int _sideNumber = 0; _sideNumber < Sides.Length; _sideNumber++)
            {
                if (Sides[_sideNumber] == Hupotenuse)
                {
                    continue;
                }

                _cathetus[_filledCathetus] = Sides[_sideNumber];
                _filledCathetus++;

            }

            return (_cathetus[0] * _cathetus[1]) / 2;
        }
    }
}

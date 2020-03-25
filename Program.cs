using System;
using static RightTriangle.ConsoleUtilites;

namespace RightTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] _sides = new int[3];

                for (int _sideNumber = 0; _sideNumber < _sides.Length; _sideNumber++)
                {
                    while (true)
                    {
                        Write(String.Format("{0} side, value = ", _sideNumber + 1), MessageType.Any);
                        var _userInput = Console.ReadLine();
                        bool _isInteger = Int32.TryParse(_userInput, out int _sideValue);

                        if (_isInteger == false)
                        {
                            Write("Error, input is not integer", MessageType.Error);
                            continue;
                        }

                        if (_sideValue <= 0)
                        {
                            Write("Triangle does'nt exist, rewrite side", MessageType.Error);
                            continue;
                        }

                        _sides[_sideNumber] = _sideValue;
                        break;
                    }
                }

                bool _isExist = TriangleUtils.IsRightTriangleExist(_sides);

                Write(String.Format("This right triangle exist: {0}", _isExist.ToString()), MessageType.Error);

                if (_isExist == false)
                {
                    Console.ReadKey();
                    break;
                }
                
                
                Write(String.Format("Hypotenuse in this triangle equal: {0}",TriangleUtils.GetHypotenuse(_sides).ToString()), MessageType.Error);
                Write(String.Format("Square in this triangle equal: {0}", TriangleUtils.GetTriangleSquare(_sides).ToString()), MessageType.Error);
                
                Console.ReadKey();
                break;
            }
        }

    }
}

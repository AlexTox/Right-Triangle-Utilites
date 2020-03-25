using System;
using System.Collections.Generic;
using System.Text;

namespace RightTriangle
{
    public class ConsoleUtilites
    {
        public static void Write(string Message, MessageType TypeOfMessage)
        {
            switch (TypeOfMessage)
            {
                case MessageType.Any:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case MessageType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
            }

            Console.WriteLine(Message);
        }

        public enum MessageType
        {
            Any,
            Error
        }
    }
}

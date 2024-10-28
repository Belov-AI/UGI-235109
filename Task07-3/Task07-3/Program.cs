using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Task07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой пешки");
            var whitePawnPosition = Console.ReadLine();

            if (IsPownPositionIncorrect(whitePawnPosition))
            {
                Console.WriteLine("Пешка не может стоять на 1-й или 8-й горизонтали");

                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию черной пешки");
            var blackPawnPosition = Console.ReadLine();

            if (IsPownPositionIncorrect(blackPawnPosition) || 
                IsWhitePownCanStrike(whitePawnPosition, blackPawnPosition))
            {
                Console.WriteLine("Пешка не может стоять на 1-й или 8-й горизонтали " +
                    "или находиться под боем");

                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию хода белой пешки");
            var move = Console.ReadLine();

            Console.WriteLine(IsWhitePownMoveCorrect(whitePawnPosition, move, blackPawnPosition));



            Console.ReadKey();
        }

        static bool IsPownPositionIncorrect(string pawnPosition)
        {
            int column, row;
            DecodePosition(pawnPosition, out column, out row);

            return row == 1 || row == 8;
        }

        static bool IsWhitePownCanStrike(string whitePawnPosition, string position) 
        {
            int wpRow, wpColumn, pRow, pColumn;

            DecodePosition(whitePawnPosition, out wpColumn, out wpRow);
            DecodePosition(position, out pColumn, out pRow);

            return wpRow == pRow - 1 && Math.Abs(wpColumn - pColumn) == 1;
        }

        static bool IsBlackPownCanStrike(string blackPawnPosition, string position)
        {
            int bpRow, bpColumn, pRow, pColumn;

            DecodePosition(blackPawnPosition, out bpColumn, out bpRow);
            DecodePosition(position, out pColumn, out pRow);

            return bpRow == pRow + 1 && Math.Abs(bpColumn - pColumn) == 1;
        }

        static bool IsWhitePawnCanMove(
            string whitePawnPosition, string move, string blackPawnPosition)
        {
            int wr, wc, br, bc, mr, mc;

            DecodePosition(whitePawnPosition, out wc, out wr);
            DecodePosition(blackPawnPosition, out bc, out br);
            DecodePosition(move, out mc, out mr);

            var middlePosition = whitePawnPosition[0] + 
                (int.Parse(whitePawnPosition[1].ToString()) + 1).ToString();

            return IsWhitePownMoveCorrect(whitePawnPosition, move, blackPawnPosition) &&
                IsBlackPownCanStrike(blackPawnPosition, move) &&
                (wr != 2 || mr - wr != 2 ||
                !IsBlackPownCanStrike(blackPawnPosition, middlePosition));
        }

        static bool IsWhitePownMoveCorrect(
            string whitePawnPosition, string move, string blackPawnPosition)
        {
            int wr, wc, br, bc, mr, mc;

            DecodePosition(whitePawnPosition, out wc, out wr);
            DecodePosition(blackPawnPosition, out bc, out br);
            DecodePosition(move, out mc, out mr);

            return wc == mc && (wr == mr - 1 || wr == 2 && wr == mr - 2) && !(br == wr + 1 && wc == bc);
        }
        


        static void DecodePosition(string position, out int column, out int row)
        {
            column = (int)position[0] - 0x60;
            row = int.Parse(position[1].ToString());
        }
    }
}

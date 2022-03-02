using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Console_Application.Models
{
    class Seat
    {
        public int Row;
        public int Column;
        public bool isFull;

        public Seat(int row,int column)
        {
            Row = row;
            Column = column;
            isFull = false;
        }
        public override string ToString()
        {
            string status = isFull ? "Full" : "Empty";
            return $"Row:{Row}, Column:{Column}, Status: {status}";
        }
    }
}

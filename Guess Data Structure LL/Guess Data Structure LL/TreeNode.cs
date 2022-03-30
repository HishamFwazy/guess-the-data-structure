using System;
using System.Collections.Generic;
using System.Text;

namespace Guess_Data_Structure_LL
{
    class BSTNode
    {
        public BSTNode(int value)
        {
            Value = value;

        }
        public BSTNode Left;
        public BSTNode Right;
        public int Value;
        public int CompareTo(int other)
        {
            if (Value > other)
                return 1;
            else if
                (Value < other)
                return -1;
            else
                return 0;
        }

    }
    }

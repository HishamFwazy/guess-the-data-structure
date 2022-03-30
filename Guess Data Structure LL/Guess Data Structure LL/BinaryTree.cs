using System;
using System.Collections.Generic;
using System.Text;

namespace Guess_Data_Structure_LL
{
    class BST
    {
        public BSTNode _head;
        public int _count;

        public void Add(int value)
        {             // Case 1: The tree is empty - allocate the head    
            if (_head == null)
            {
                _head = new BSTNode(value);
            }             // Case 2: The tree is not empty so recursively          
            // find the right location to insert           
            else
            {
                AddTo(_head, value);
            }

            _count++;
        }


        private void AddTo(BSTNode node, int value)
        {             
            if (value < node.Value)
            {
               
                if (node.Left == null)
                {
                    node.Left = new BSTNode(value);
                }
                else
                {                       
                    AddTo(node.Left, value);
                }

            }

           
            else
            {
               
                if (node.Right == null)
                {
                    node.Right = new BSTNode(value);
                }
                else
                {                     
                    AddTo(node.Right, value);
                }
            }
        }


    }
}

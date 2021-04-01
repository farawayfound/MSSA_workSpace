using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17Stack
{
    public class CharStack
    {
        // F i e l d s  &  P r o p e r t i e s
        private int _size;
        private char[] _stack;
        private int _topOfStack;

        // C o n s t r u c t o r s
        public CharStack(int size)
        {
            _size = size;
            _stack = new char[size];
        }

        // M e t h o d s
        public bool IsEmpty()
        {
            if (_topOfStack > 0)
                return false;
            else return true;
        }

        public bool IsFull()
        {
            if (_topOfStack >= _stack.Length)
                return true;
            else return false;
        }

        public void Push(char valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack] = valueToPush;
                _topOfStack++;
            }
        }

        public char Pop()
        {
            if (_topOfStack > 0)
            {
                _topOfStack--;
                return _stack[_topOfStack];
            }
            else return (char)0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17Stack
{
    public class StringStack
    {
        // F i e l d s  &  P r o p e r t i e s
        private int _size;
        private string[] _stack;
        private int _topOfStack;

        // C o n s t r u c t o r s
        public StringStack(int size)
        {
            _size = size;
            _stack = new string[size];
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

        public void Push(string valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack] = valueToPush;
                _topOfStack++;
            }
        }

        public string Pop()
        {
            if (_topOfStack > 0)
            {
                _topOfStack--;
                return _stack[_topOfStack];
            }
            else return "0";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17Stack
{
    public class IntStack
    {
        // F i e l d s  &  P r o p e r t i e s
        private int _size;
        private int[] _stack;
        private int _topOfStack;

        // C o n s t r u c t o r s
        public IntStack(int size)
        {
            _size = size;
            _stack = new int[size];
        }

        // M e t h o d s
        public bool IsEmpty()
        {
            return _topOfStack > 0;
        }

        public bool IsFull()
        {
            return _topOfStack >= _size;
        }

        public void Push(int valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack++] = valueToPush;
            }
        }

        public int Pop()
        {
            if (_topOfStack > 0)
            {
                return _stack[--_topOfStack];
            }
            else return 0;
        }
    }
}

using System;
using System.Collections.Generic;


public class Mystack<T>
{
        private List<T> elements;

        public Mystack()
        {
            elements = new List<T>();
        }

        public int Count()
        {
            return elements.Count;
        }

        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T topElement = elements[^1];
            elements.RemoveAt(elements.Count - 1);
            return topElement;
        }

        public void Push(T element)
        {
            elements.Add(element);
        }
}
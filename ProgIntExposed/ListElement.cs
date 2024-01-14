// -----------------------------------------------------------------------
// <copyright file="ListElement.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ProgQues.ProgIntExposed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ListElement<T>
    {
        private T data;
        private ListElement<T> next;

        public ListElement(T value)
        {
            data = value;
        }
        
        public void SetNext(ListElement<T> ele)
        {
            next = ele;
        }

        public void SetValue(T val)
        {
            data = val;
        }

        public ListElement<T> Next()
        {
            return next;
        }

        public T Value()
        {
            return data;
        }

        public ListElement<T> InsertInFront(ListElement<T> currHead, T data)
        {
            ListElement<T> newHead = new ListElement<T>(data);
            newHead.SetNext(currHead);
            return newHead;
        }

        public ListElement<T> Find(ListElement<T> head, T data)
        {
            ListElement<T> temp = head;
            while ((temp != null) && (!temp.Value().Equals(data)))
            {
                temp = temp.Next();

                if (temp == null)
                {
                    throw new NullReferenceException("Element not found");
                }                
            }
            return temp;
        }
    }
}

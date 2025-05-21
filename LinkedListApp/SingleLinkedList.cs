using System;
using System.Windows.Forms;

namespace LinkedListApp
{
    public class SingleLinkedList
    {
        private Node first;

        public SingleLinkedList()
        {
            first = null;
        }

        public void AddToStart(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = first;
            first = newNode;
        }

        public void AddToEnd(int data)
        {
            Node newNode = new Node(data);
            if (first == null)
            {
                first = newNode;
            }
            else
            {
                Node current = first;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void AddAtPosition(int data, int position)
        {
            if (position < 1)
                throw new ArgumentException("Позиция должна быть больше 0");

            if (position == 1)
            {
                AddToStart(data);
            }
            else
            {
                Node newNode = new Node(data);
                Node current = first;
                int currentPos = 1;
                while (current != null && currentPos < position - 1)
                {
                    current = current.Next;
                    currentPos++;
                }
                if (current == null)
                    throw new ArgumentException("Указанная позиция вне пределов списка"); 

                newNode.Next = current.Next;
                current.Next = newNode; 
            }
        }

        public void DeleteFromStart()
        {
            if (first == null)
                throw new InvalidOperationException("Список пуст");

            first = first.Next;
        }

        public void DeleteFromEnd()
        {
            if (first == null)
                throw new InvalidOperationException("Список пуст");

            if (first.Next == null)
            {
                first = null;
            }
            else
            {
                Node current = first;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
        }

        public void DeleteAtPosition(int position)
        {
            if (first == null)
                throw new InvalidOperationException("Список пуст");
            if (position < 1)
                throw new ArgumentException("Позиция должна быть больше 0");

            if (position == 1)
            {
                DeleteFromStart();
            }
            else
            {
                Node current = first;
                int currentPos = 1;
                while (current != null && currentPos < position - 1)
                {
                    current = current.Next;
                    currentPos++;
                }
                if (current == null || current.Next == null)
                    throw new ArgumentException("Указанная позиция вне пределов списка");

                current.Next = current.Next.Next;
            }
        }

        public void Display(ListBox listBox)
        {
            listBox.Items.Clear();
            Node current = first;
            while (current != null)
            {
                listBox.Items.Add(current.Data);
                current = current.Next;
            }
        }

        public void Destroy()
        {
            first = null;
        }

        public static SingleLinkedList MergeAlternating(SingleLinkedList list1, SingleLinkedList list2)
        {
            if (list1 == null || list2 == null)
                throw new ArgumentNullException("Один из входных списков не инициализирован");

            SingleLinkedList result = new SingleLinkedList();  
            Node current1 = list1.first;
            Node current2 = list2.first;
            Node currentResult = null;

            while (current1 != null || current2 != null)
            {
                if (current1 != null)
                {
                    if (result.first == null)
                    {
                        result.first = current1;
                        currentResult = result.first;
                    }
                    else
                    {
                        currentResult.Next = current1;
                        currentResult = currentResult.Next;
                    }
                    list1.first = current1.Next;
                    current1 = list1.first;
                }
                if (current2 != null)
                {
                    if (result.first == null)
                    {
                        result.first = current2;
                        currentResult = current2;
                    }
                    else
                    {
                        currentResult.Next = current2;
                        currentResult = currentResult.Next;
                    }
                    list2.first = current2.Next;
                    current2 = list2.first;
                }
            }

            list1.first = null;
            list2.first = null;
            return result; 
        }
    }
}
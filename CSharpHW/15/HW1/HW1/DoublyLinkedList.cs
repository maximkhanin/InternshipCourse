using System;

namespace HW1
{
    class DoublyLinkedList<T>
    {
        private Node<T> _header;
        private Node<T> _footer;
        private int _size;
        public DoublyLinkedList()
        {
            _size = 0;
        }
        public void AddFirst(T value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }

            if (_header == null)
            {
                _header = _footer = new Node<T>(value);
            }
            else
            {
                var tmp = _header;
                _header = new Node<T>(value);
                tmp.Prev = _header;
                _header.Next = tmp;
            }

            _size += 1;
        }

        public void AddFirst(Node<T> value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }
            if (_header == null)
            {
                _header = _footer = value;
            }
            else
            {
                var tmp = _header;
                _header = value;
                tmp.Prev = _header;
                _header.Next = tmp;
            }
            _size += 1;
        }

        public void AddEnd(T value)
        {
            var tmp = new Node<T>(value);
            if (_header == null)
            {
                _header = tmp;
                _footer = _header;
            }
            else
            {
                tmp.Prev =_footer;
                _footer.Next = tmp;
                _footer = tmp;
            }
            _size++;
        }

        public void AddEnd(Node<T> value)
        {
            if (_header == null)
            {
                _header = value;
                _footer = _header;
            }
            else
            {
                value.Prev = _footer;
                _footer.Next = value;
                _footer = value;
            }
            _size++;
        }

        public void Print()
        {
            if (_header != null)
            {
                var tmp = _header;
                while (tmp != null)
                {
                    tmp.Print();
                    tmp = tmp.Next;
                }
            }
        }

        public void PrintReverse()
        {
            if (_footer != null)
            {
                var tmp = _footer;
                while (tmp != null)
                {
                    tmp.Print();
                    tmp = tmp.Prev;
                }
            }
        }
        public Node<T>[] ToNodesArray()
        {
            var nodes = new Node<T>[_size];
            var i = 0;
            if (_header != null)
            {
                var tmp = _header;
                while (tmp != null)
                {
                    nodes[i] = tmp;
                    i += 1;
                    tmp = tmp.Next;
                }
            }
            return nodes;
        }
        public T[] ToArray()
        {
            var nodes = new T[_size];
            var i = 0;
            if (_header != null)
            {
                var tmp = _header;
                while (tmp != null)
                {
                    nodes[i] = tmp.Value;
                    i += 1;
                    tmp = tmp.Next;
                }
            }
            return nodes;
        }

        public int Size()
        {
            return _size;
        }

        public bool IsExist(Node<T> value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }

            if (_header != null)
            {
                var tmp = _header;
                while (tmp != null)
                {
                    if (tmp == value)
                    {
                        return true;
                    }
                    tmp = tmp.Next;
                }
            }
            return false;
        }


        public void Remove(T value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }

            if (_header != null)
            {
                var tmp = _header;
                while (tmp != null)
                {
                    if (tmp == new Node<T>(value))
                    {
                        if (tmp.Prev == null)
                        {
                            _header = tmp.Next;
                        }
                        else
                        {
                            tmp.Prev.Next = tmp.Next;
                        }

                        if (tmp.Next == null)
                        {
                            _footer = tmp.Prev;
                        }

                        else
                        {
                            tmp.Next.Prev = tmp.Prev;
                        }
                        _size -= 1;
                    }
                    tmp = tmp.Next;
                }
            }

        }


        public void Remove(Node<T> value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }

            if (_header != null)
            {
                var tmp = _header;
                while (tmp != null)
                {
                    if (tmp == value)
                    {
                        if (tmp.Prev == null)
                        {
                            _header = tmp.Next;
                        }
                        else
                        {
                            tmp.Prev.Next = tmp.Next;
                        }

                        if (tmp.Next == null)
                        {
                            _footer = tmp.Prev;
                        }

                        else
                        {
                            tmp.Next.Prev = tmp.Prev;
                        }
                        _size -= 1;
                    }
                    tmp = tmp.Next;
                }
            }
        }
    }

}


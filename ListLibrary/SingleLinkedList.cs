namespace ListLibrary
{
    public class SingleLinkedList
    {
        private int count;

        public SingleLinkedList()
        {
            count = 0;
        }

        public SingleLinkListItem? First { get; private set; }
        private SingleLinkListItem? Last { get; set; }

        public void Add(string data)
        {
            var newItem = new SingleLinkListItem(data);
            if (First == null)
            {
                First = newItem;
                Last = newItem;
            }
            else
            {
                Last.Next = newItem;
                Last = newItem;
            }
            count++;
        }

        public SingleLinkListItem? Find(string data)
        {
            SingleLinkListItem? iterator = First;
            while (iterator != null)
            {
                if (iterator.Data == data)
                {
                    return iterator;
                }
                iterator = iterator.Next;
            }
            return null;
        }

        public void Delete(string data)
        {
            SingleLinkListItem? iterator = First;
            SingleLinkListItem? previous = null;
            while (iterator != null)
            {
                if (iterator.Data == data)
                {
                    if (previous == null)
                    {
                        First = iterator.Next;
                    }
                    else
                    {
                        previous.Next = iterator.Next;
                    }
                    count--;
                    return;
                }
                else
                {
                    previous = iterator;
                    iterator = iterator.Next;
                }
            }
        }

        public void Delete(SingleLinkListItem item)
        {
            Delete(item.Data);
        }

        public SingleLinkListItem[] ToArray()
        {
            var array = new SingleLinkListItem[count];
            var iterator = First;
            for (int i = 0; i < count; i++)
            {
                array[i] = iterator;
                iterator = iterator.Next;
            }
            return array;
        }
    }
}

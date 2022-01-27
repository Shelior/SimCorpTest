namespace ListLibrary
{
    public class DoubleLinkedList
    {
        private int count;
        public DoubleLinkedList()
        {
            count = 0;
        }
        public DoubleLinkListItem? First { get; private set; }
        private DoubleLinkListItem? Last { get; set; }

        public void Add(string data)
        {
            var newItem = new DoubleLinkListItem(data);
            if (First == null)
            {
                First = newItem;
                Last = newItem;
            }
            else
            {
                newItem.Previous = Last;
                Last.Next = newItem;
                Last = newItem;
            }
            count++;
        }

        public DoubleLinkListItem? Find(string data)
        {
            DoubleLinkListItem? iterator = First;
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
            var item = Find(data);
            if (item != null)
            {
                if (item.Previous != null)
                {
                    item.Previous.Next = item.Next;
                }
                else
                {
                    First = item.Next;
                }
                if (item.Next != null)
                {
                    item.Next.Previous = item.Previous;
                }
                else
                {
                    Last = item.Previous;
                }
                count--;
            }
        }

        public void Delete(DoubleLinkListItem item)
        {
            Delete(item.Data);
        }

        public DoubleLinkListItem[] ToArray()
        {
            var array = new DoubleLinkListItem[count];
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

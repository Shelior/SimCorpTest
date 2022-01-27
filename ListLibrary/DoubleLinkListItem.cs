namespace ListLibrary
{
    public class DoubleLinkListItem
    {
        public DoubleLinkListItem(string? data)
        {
            Data = data;
        }

        public string? Data { get; set; }
        public DoubleLinkListItem? Next { get; internal set; }
        public DoubleLinkListItem? Previous { get; internal set; }
    }
}

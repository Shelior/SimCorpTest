namespace ListLibrary
{
    public class SingleLinkListItem
    {
        public SingleLinkListItem(string? data)
        {
            Data = data;
        }

        public string? Data { get; set; }
        public SingleLinkListItem? Next { get; internal set; }
    }
}

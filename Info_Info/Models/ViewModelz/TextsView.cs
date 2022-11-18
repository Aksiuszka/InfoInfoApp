namespace Info_Info.Models.ViewModelz
{
    public class TextsView
    {
        public TextsView(int pageSize = 5)
        {
            PageSize = pageSize;
        }
        public int TextCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}

namespace Blaz_CascadeDropdown.Models
{
    public class Pagination
    {
        public int CurrentPage { get; set; } = 1;
        public int PageCount(int recCount, int recPerPage)
        {
            return Convert.ToInt32(Math.Ceiling(recCount / (double)recPerPage));
        }
    }

    public class Paging
    {
        public string LinkText { get; set; }
        public int PageId { get; set; }
        
        public Paging(int page, string text)
        {
            PageId = page;
            LinkText = text;
        }
    }
}

namespace API.Helpers
{
    public class Pagination<T> where T : class
    {
        public Pagination(int PageIndes, int pageSize, int count, IReadOnlyList<T> data)
        {
            PageIndex = PageIndex;
            PageSize = pageSize;
            Count = count;
            Data = data;
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public IReadOnlyList<T> Data { get; set; }

    }
}
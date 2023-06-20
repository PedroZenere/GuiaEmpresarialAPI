namespace GuiaEmpresarialAPI.Shared.Core.Utils.PagedList
{
    public interface IPaginatedList<out T>
    {
        public int TotalCount { get; }
        public int PageCount { get; }
        public int PageSize { get; }
        public int Page { get; }
        public T[] Items { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Shared.Core.Utils.PagedList
{
    public class PaginatedList <T> : IPaginatedList<T>
    {
        public int TotalCount { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
        public T[] Items { get; set; }

        public PaginatedList() => Items = Array.Empty<T>();

        public PaginatedList(T[] items, int totalCount, int page, int pageSize)
        {
            TotalCount = totalCount;
            Page = page < 1 ? 1 : page;
            PageSize = pageSize;
            PageCount = GetPageCount(pageSize, totalCount);
            Items = items;
        }

        private static int GetPageCount(int pageSize, int totalCount)
        {
            if (pageSize == 0 || totalCount == 0)
                return 0;

            int remainder = totalCount % pageSize;
            return totalCount / pageSize + (remainder == 0 ? 0 : 1);
        }
    }
}

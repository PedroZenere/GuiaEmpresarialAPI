using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Shared.Core.Utils.PagedList
{
    public static class PaginatedListExtension
    {
        //public static async Task<IPaginatedList<T>> ToPagedListAsync<T>(this IQueryable<T> source, int page, int pageSize,
        //    CancellationToken cToken = default)
        //{
        //    int totalCount = await source.CountAsync(cToken);
        //    page = page < 1 ? 1 : page;
        //    int normalizedPage = page - 1;

        //    if (pageSize <= 0)
        //        pageSize = totalCount;

        //    var result = totalCount > 0
        //        ? await source.Skip(normalizedPage * pageSize).Take(pageSize).ToArrayAsync(cToken)
        //        : Array.Empty<T>();

        //    return new PaginatedList<T>(result, totalCount, page, pageSize);
        //}

        public static IPaginatedList<T> ToPaginatedList<T>(this IQueryable<T> source, int page, int pageSize)
        {
            int totalCount = source.Count();
            page = page < 1 ? 1 : page;
            int normalizedPage = page - 1;

            if (pageSize <= 0)
                pageSize = totalCount;

            var result = totalCount > 0
                ? source.Skip(normalizedPage * pageSize).Take(pageSize).ToArray()
                : Array.Empty<T>();

            return new PaginatedList<T>(result, totalCount, page, pageSize);
        }
    }
}

using System;

namespace GuiaEmpresarialAPI.Application.Core.Queries
{
    public abstract class GetByFilterQueryBase
    {
        public int Page { get; set; }
        public int PageSize { get; set; }

        public string[] OrderBy { get; set; }

        protected GetByFilterQueryBase()
        {
            Page = 1;
            PageSize = 10;

            OrderBy = Array.Empty<string>();
        }
    }
}

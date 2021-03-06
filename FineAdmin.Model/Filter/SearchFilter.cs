﻿using System.Data;

namespace FineAdmin.Model
{
    public class SearchFilter
    {
        public string prefix { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public string returnFields { get; set; }
        public string where { get; set; }
        public string orderBy { get; set; }
        public object param { get; set; }
        public IDbTransaction transaction { get; set; }
        public int? commandTimeout { get; set; }
    }
}

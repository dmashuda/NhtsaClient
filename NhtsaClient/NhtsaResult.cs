using System.Collections.Generic;

namespace Nhtsa
{
    public class NhtsaResult<T>
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public IEnumerable<T> Results { get; set; }
    }
}
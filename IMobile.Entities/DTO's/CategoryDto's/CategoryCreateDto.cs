using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Entities.DTO_s.CategoryDto_s
{
    public class CategoryCreateDto
    {
        public List<string> CategoryName { get; set; }
        public List<string> LangCode { get; set; }
    }
}

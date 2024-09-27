using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhetitance
{
    // Sealed class 
    public sealed class Author : Admin
    {
        public int ArticleCount { get; set; }
        public Author(string role, string organization, string name, string biography, int articleCount) : base(role, organization, name, biography)
        {
            ArticleCount = articleCount;
        }
    }
}

using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Core3Api
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_WareHouse.ViewModels;

internal class ArticleViewModel
{
    int id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime DatePublication { get; set; }
}

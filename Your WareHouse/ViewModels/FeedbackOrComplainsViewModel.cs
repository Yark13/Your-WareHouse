using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_WareHouse.ViewModels;

internal class FeedbackOrComplainsViewModel
{
    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime DatePublication { get; set; }

    public int CustomerId { get; set; }

    public Customer? Customer { get; set; }
}

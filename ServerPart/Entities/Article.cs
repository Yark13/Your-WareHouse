using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities;

public class Article : Entity
{
    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime DatePublication { get; set; }

    public override string GetAllValues()
    {
        return $"'{Title}', '{Content}', '{DatePublication.ToString("yyyy-MM--dd")}'";
    }

    public override string GetAllDefindedValues()
    {
        return $"Title = '{Title}', Content =  '{Content}', DatePublication = '{DatePublication.ToString("yyyy-MM--dd")}'";
    }

    public override void FillFromReader(SqlDataReader reader)
    {
        this.Id = (int)reader["Id"];
        this.Title = reader["Title"].ToString();
        this.Content = reader["Content"].ToString();
        this.DatePublication = (DateTime)reader["DatePublication"];
    }

}

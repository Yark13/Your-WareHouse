using System.Data.SqlClient;

namespace DataLayer.Entities;

public class FeedbackOrComplains :Entity
{
    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime DatePublication { get; set; }

    public int CustomerId { get; set; }

    public Customer? Customer { get; set; }

    public override string GetAllValues()
    {
        return $"'{Title}', '{Content}', '{DatePublication.ToString("yyyy-MM-dd")}', '{CustomerId}'";
    }

    public override string GetAllDefindedValues()
    {
        return $"Title = '{Title}', Content = '{Content}',DatePublication =  '{DatePublication.ToString("yyyy-MM-dd")}', CustomerId = '{CustomerId}'";
    }

    public override void FillFromReader(SqlDataReader reader)
    {
        this.Id = (int)reader["Id"];
        this.Title = reader["Title"].ToString();
        this.Content = reader["Content"].ToString();
        this.DatePublication = (DateTime)reader["DatePublication"];
        this.CustomerId = (int)reader["CustomerId"];
    }

}

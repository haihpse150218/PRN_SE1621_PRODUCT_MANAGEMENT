namespace Prn.Se1621;
public class Product
{
    /*fields/data*/
    private int _id;
    private string _productName;

    /*properties*/

    /*Expression-Bodied*/
    public int Id { get => _id; set => _id = value; }
    public string ProductName { get => _productName; set => _productName = value; }

    public string Desc { get; set; } //.NET 5
    public double UnitPrice { get; set; }
    public DateTime StartDate { get; set; }
    /*Constructors*/
    public Product() { }

    public Product(int id, string productName, string desc, double unitPrice, DateTime startDate)
    {
        Id = id;
        ProductName = productName;
        Desc = desc;
        UnitPrice = unitPrice;
        StartDate = startDate;
    }



    /*override ToString => hien thi doi tuong ra man hinh*/
    public override string? ToString() => ShowData();

    private string ShowData()
    {
        return $"[Id = {Id}, Product Name = {ProductName}, Desc = {Desc}, Unit Price = {UnitPrice}, Start Date = {StartDate}]";
    }


}
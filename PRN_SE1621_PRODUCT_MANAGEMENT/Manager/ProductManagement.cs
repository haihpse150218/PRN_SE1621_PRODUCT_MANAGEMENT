namespace Prn.Se1621;
public class ProductManagement : AbsProduct, IProduct
{
    public void Add(Product p)
    {
        //1. Check for length
        if(Size >= this.Products.Length)
        {
            //Increase Products
            Product[] tmp = new Product[this.Products.Length * 2];
            for(int i = 0; i < this.Products.Length; i++)
            {
                tmp[i] = this.Products[i];

            }
            this.Products = tmp;
        }
        this.Products[Size++] = p;
    }

    public bool Delete(Product p)
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        foreach(Product p in this.Products)
        {
            Console.WriteLine(p);
        }
    }

    public Product Get(Product p)
    {
        throw new NotImplementedException();
    }

    public Product[] GetAllProductByUnitPrice(double price)
    {
        throw new NotImplementedException();
    }

    public void Update(Product p)
    {
        throw new NotImplementedException();
    }
}
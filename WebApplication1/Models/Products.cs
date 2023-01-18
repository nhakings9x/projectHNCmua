namespace WebApplication1.Models
{
    public class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NewPrice { get; set; }
        public int OldPrice { get; set; }
        public string Origin { get; set; }
        public float Discount { get; set; }
        public bool Liked { get; set; }

        public bool SmaillItem { get; set; }


    }

    public class ItemsOng
    {

        public List<ItemsCha> Chas {get;set;}
    }
    public class ItemsCha
    {

        public List<Products> Con { get; set; }
    }




}

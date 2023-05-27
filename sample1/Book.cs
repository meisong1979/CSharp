
namespace test
{
    public class Book : IComparable
    {
        private int _price;
        private string _title;
   
        public Book() { }

        public Book(int v)
        {
        }

        public Book (int price, string title){
            _price = price;
            _title = title;
        }

        public int getPrice() { return _price;}
        public string getTitle() { return _title;}
        public int CompareTo(object obj)
        {
            Book book2 = (Book) obj;
            return _price.CompareTo(book2._price);
        }
    }
}

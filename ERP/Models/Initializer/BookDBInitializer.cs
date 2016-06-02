using ERP.Models.DAL;

namespace ERP.Models.Initializer
{
    public class BookDBInitializer : System.Data.Entity.DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            context.Books.Add(new Book { name = "ASP.NET MVC 5：網站開發美學" });
            context.Books.Add(new Book { name = "ASP.NET MVC 5實務專題範例教學" });
            context.Books.Add(new Book { name = "ASP.NET MVC 5 完全攻略" });
            context.Books.Add(new Book { name = "ASP.NET MVC4 全方位專業網站開發實戰演練(附DVD)" });
            context.Books.Add(new Book { name = "Visual C# 2015程式設計經典(附範例光碟)" });
            context.Books.Add(new Book { name = "設計模式：Android原始碼解析與應用" });
            base.Seed(context);
        }
    }
}
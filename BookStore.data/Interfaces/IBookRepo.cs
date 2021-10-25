using BookStore.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.data.Interfaces
{
    public interface IBookRepo
    {
        List<Book> GetAllBooks();
        Book GetBook(int id);
    }
}

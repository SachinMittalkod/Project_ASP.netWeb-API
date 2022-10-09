﻿using AutoMapper;
using E_Library.API.Services.Interface;
using E_Library.DataModels.entities;
using E_Library.DataModels.Repository.Interface;

namespace E_Library.API.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        
        public BookService(IBookRepository bookRepository  )
        {
            _bookRepository = bookRepository;
           
        }
        public int AddBook(BookDetail bookDetail)
        {
         return _bookRepository.AddBook(bookDetail);
        }

       

        public bool UpdateBook(BookDetail bookDetail)
        {
            return _bookRepository.UpdateBook(bookDetail);
        }
        public bool DeleteBook(int id)
        {
            return _bookRepository.DeleteBook(id);
        }

        public List<BookDetail> GetAllBookDetails()
        {
            return _bookRepository.GetAllBookDetails();
        }

        public BookDetail GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }
    }
}

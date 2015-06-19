// Task Description
// *	Create a module for working with books
// 	*	The module must provide the following functionalities:
// 		*	Add a new book to category
// 			*	Each book has unique title, author and ISBN
// 			*	It must return the newly created book with assigned ID
// 			*	If the category is missing, it must be automatically created
// 		*	List all books
// 			*	Books are sorted by ID
// 			*	This can be done by author, by category or all
// 		*	List all categories
// 			*	Categories are sorted by ID
// 	*	Each book/catagory has a unique identifier (ID) that is a number greater than 1
// 		*	When adding a book/category, the ID is generated automatically
// 	*	Add validation everywhere, where possible
// 		*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
// 		*	Author is any non-empty string
// 		*	Unique params are Book title and Book ISBN
// 		*	Book ISBN is an unique code that contains either 10 or 13 digits
// 		*	If something is not valid - throw Error

function solve() {
  'use strict';

  var library = (function () {
    var books = [],
      CONSTS = {
        TITLE_MIN_LENGTH: 2,
        TITLE_MAX_LENGTH: 100,
        CATEGORY_MIN_LENGTH: 2,
        CATEGORY_MAX_LENGTH: 100,
        ISBN_VALID_LENGTHS: [10, 13]
      };

    function listBooks(filter) {
      if (filter) {
        return filterBy(filter);
      }

      return books;
    }

    function addBook(book) {
      if (!hasValidLength(book.title, CONSTS.TITLE_MIN_LENGTH, CONSTS.TITLE_MAX_LENGTH)) {
        throw new Error('Book title name must be between ' + CONSTS.TITLE_MIN_LENGTH + ' and ' + CONSTS.TITLE_MAX_LENGTH + ' characters!');
      }

      if (!hasValidLength(book.category, CONSTS.CATEGORY_MIN_LENGTH, CONSTS.CATEGORY_MAX_LENGTH)) {
        throw new Error('Book category name must be between ' + CONSTS.CATEGORY_MIN_LENGTH + ' and ' + CONSTS.CATEGORY_MAX_LENGTH + ' characters!');
      }

      if (!validAuthor(book.author)) {
        throw new Error('Book author name cannot be empty!');
      }

      if (bookTitleExists(book.title)) {
        throw new Error(book.title + ' alredy exists!');
      }

      if (bookIsbnExists(book.isbn)) {
        throw new Error(book.isbn + ' alredy exists!');
      }

      if (!hasValidIsbnLength(book.isbn.length, CONSTS.ISBN_VALID_LENGTHS)) {
        throw new Error('Book ISBN must contain ' + CONSTS.ISBN_VALID_LENGTHS.join(' or ') + ' digits!');
      }

      if (!containOnlyDigits(book.isbn)) {
        throw new Error('Book ISBN must contain only digits!');
      }

      book.ID = books.length + 1;
      books.push(book);

      return book;
    }

    function listCategories() {
      return books.reduce(function (categories, book) {
        if (categories.indexOf(book.category) < 0) {
          categories.push(book.category);
        }

        return categories;
      }, []);
    }

    function filterBy(filterObj) {
      var key = Object.keys(filterObj)[0],
        value = filterObj[key];

      return books.filter(function (book) {
        return book[key] === value;
      });
    }

    function hasValidLength(str, min, max) {
      var len = str.length;

      return len >= min && len <= max;
    }

    function validAuthor(author) {
      return author.trim().length > 0;
    }

    function bookTitleExists(title) {
      return books.some(function (book) {
        return book.title === title;
      });
    }

    function bookIsbnExists(isbn) {
      return books.some(function (book) {
        return book.isbn === isbn;
      });
    }

    function hasValidIsbnLength(isbnLength, validLengths) {
      return validLengths.some(function (length) {
        return length === isbnLength;
      });
    }

    function containOnlyDigits(str) {
      var ch,
        len;

      for (ch = 0, len = str.length; ch < len; ch += 1) {
        if (str[ch] < '0' || str[ch] > '9') {
          return false;
        }
      }

      return true;
    }

    return {
      books: {
        list: listBooks,
        add: addBook
      },
      categories: {
        list: listCategories
      }
    };
  } ());

  return library;
}

module.exports = solve;
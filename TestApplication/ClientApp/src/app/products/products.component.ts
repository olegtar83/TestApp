import { Component, OnInit } from '@angular/core';
import { IBook } from '../models/book';
import { IDisc } from '../models/disc';
import { Observable } from 'rxjs';
import { TemplateRef, ViewChild } from '@angular/core';
import { HttpApiService } from '../services/http-api.service';


@Component({
  selector: 'products',
  templateUrl: './products.component.html',
})
export class ProductsComponent implements OnInit {

  books: IBook[]
  editedBook: IBook;
  isNewBookRecord: boolean;

  discs: IDisc[];
  editedDisc: IDisc;
  isNewDiscRecord: boolean;

  public position: 'top' | 'bottom' | 'both' = 'top';

  @ViewChild('readOnlyTemplate', { static: false }) readOnlyTemplateBook: TemplateRef<any>;
  @ViewChild('editTemplate', { static: false }) editTemplateBook: TemplateRef<any>;

  constructor(private rest: HttpApiService) {}
    ngOnInit(): void {
      this.loadBooks();
      this.loadDiscs();
  }

  AddDisc() {
    if (!this.isNewDiscRecord) {
      this.editedDisc = null;// {author: '', genre: '', year: 0, name: '',bookID: 0} as IBook;
      this.discs.unshift(this.editedDisc);
      this.isNewDiscRecord = true;
    }
  }

  editDisc(disc: IDisc) {
    this.editedDisc = disc;
  }

  loadDiscTemplate(book: IBook) {
    return (this.editedBook == book) ? this.editTemplateBook : this.readOnlyTemplateBook;
  }

  onDiscSubmit() {
       if(!this.editedBook.name)
           return;
    if (this.isNewBookRecord) {
      this.rest.post('/api/discs',  this.editedDisc).subscribe(_data => {
          this.loadDiscs();
          this.isNewDiscRecord = false;
      });
      this.isNewDiscRecord = false;
    } else {
      this.rest.put('/api/discs/', this.editedDisc).subscribe(_data => {
          this.editedBook = null;
          this.loadBooks();
      });
    }
  }

  cancelDisc() {
    if (this.isNewDiscRecord) {
      this.isNewDiscRecord = false
      this.discs.shift();
    }
      this.editedBook = null;
  }

  deleteDisc(disc: IDisc) {
    this.rest.delete('/api/discs/' + disc.id).subscribe(_data => {
      this.loadBooks();
    });
  }

  addBook() {
    if (!this.isNewBookRecord) {
      this.editedBook = null;// {author: '', genre: '', year: 0, name: '',bookID: 0} as IBook;
      this.books.unshift(this.editedBook);
      this.isNewBookRecord = true;
    }
  }

  editBook(book: IBook) {
    this.editedBook = book;
  }

  loadBookTemplate(book: IBook) {
    return (this.editedBook == book) ? this.editTemplateBook : this.readOnlyTemplateBook;
  }

  onBookSubmit() {
       if(!this.editedBook.name)
           return;
    if (this.isNewBookRecord) {
      this.rest.post('/api/books',  this.editedBook).subscribe(_data => {
          this.loadBooks();
          this.isNewBookRecord = false;
      });
      this.isNewBookRecord = false;
    } else {
      this.rest.put('/api/books/', this.editedBook).subscribe(_data => {
          this.editedBook = null;
          this.loadBooks();
      });
    }
  }

  cancel() {
    if (this.isNewBookRecord) {
      this.isNewBookRecord = false;
      this.books.shift();
    }
      this.editedBook = null;
  }

  deleteBook(book: IBook) {
    this.rest.delete('/api/books/' + book.id).subscribe(_data => {
      this.loadBooks();
    });
  }

  private loadBooks() {
    this.rest.get('/api/books').subscribe((data: IBook[]) => {
      this.books = data;
      });
    }

  private loadDiscs() {
    this.rest.get('/api/discs').subscribe((data: IDisc[]) => {
      this.discs = data;
      });
    }
  }

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Book } from '../models/list-books.model';
import { BookLibraryService } from '../services/book-library.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public books: Book[] = [];

  constructor(private bookService: BookLibraryService,
    private router: Router) {

  }
  ngOnInit(): void {
    this.bookService.GetBooksList().subscribe(books => {
      this.books = books;
    })
  }

  HandleAddBook(){
    this.router.navigate(['AddBook']);
  }
}

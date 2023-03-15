import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Book } from '../models/list-books.model';
import { BookLibraryService } from '../services/book-library.service';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {

  public book: Book = new Book();

  constructor(private bookService: BookLibraryService,
    private router: Router) { }

  ngOnInit(): void {
  }

  HandleSubmitBook(){
    this.bookService.AddNewBook(this.book).subscribe(result=>{
      debugger;
      if(result == true){
        this.router.navigate(['/']);
      }
    });
  }

}

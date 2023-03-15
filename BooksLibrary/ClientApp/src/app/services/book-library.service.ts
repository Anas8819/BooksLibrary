import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { catchError, map, Observable, of } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Endpoints } from '../constants/endpoints.constants';
import { Book } from '../models/list-books.model';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class BookLibraryService extends BaseService {

  private bookLibraryApiUrl = environment.ApiBaseUrl.Books;

  constructor(
    private httpClient: HttpClient
  ) {
    super();
  }

  public GetBooksList(): Observable<Book[]> {

    const url = `${this.bookLibraryApiUrl}/${Endpoints.GetBooksList}`;
    return this.httpClient.get<Book[]>(url).pipe(
      map(book => {
        return book;
      }),
      catchError(this.errorHandler)
    )
  }


  public AddNewBook(book: Book): Observable<boolean> {

    const url = `${this.bookLibraryApiUrl}/${Endpoints.AddNewBook}`;
    return this.httpClient.post<boolean>(url,book).pipe(
      map(book => {
        debugger;
        return true;
      }),
      catchError(this.errorHandler)
    );
  }

}

import { throwError as observableThrowError, throwError } from 'rxjs';
import { Injectable } from '@angular/core';


@Injectable()
export class BaseService {
    errorHandler(error: Response) {
        return observableThrowError(error);
    }
}

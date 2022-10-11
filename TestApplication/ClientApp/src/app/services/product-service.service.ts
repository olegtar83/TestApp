import { Injectable } from '@angular/core';
import { HttpApiService } from './http-api.service'
import { BehaviorSubject, from, Subject } from 'rxjs';
import { map } from 'rxjs/operators';
import { IBook } from '../models/book';
import { IDisc } from '../models/disc';

@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {
  constructor(private http: HttpApiService) { }

  private books$: BehaviorSubject<any[]> = new BehaviorSubject([]);
  private disc$: BehaviorSubject<any[]> = new BehaviorSubject([]);

 

}

import {  HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AppSettings {
  public  endpoint = 'https://localhost:5001/api/';
  public  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'Cache-Control':  'no-cache, no-store, must-revalidate, post-check=0, pre-check=0'
    })
  };
}
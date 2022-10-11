import { Component, OnInit } from '@angular/core';
import { HttpApiService } from '../services/http-api.service';
import { IOrder} from '../models/order';
import { from } from 'rxjs';

@Component({
  selector: 'orders',
  templateUrl: './orders.component.html'
})
export class OrdersComponent implements OnInit{
  constructor(private httpApi: HttpApiService) {}

  orders: IOrder[];

  ngOnInit(): void {
    // this.httpApi.getAllOrders().subscribe(data => {
    //   this.orders = data;
    // })
  }
}

import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public orders: Item[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Item[]>(baseUrl + 'Item').subscribe(result => {
      this.orders = result;
    }, error => console.error(error));
  }
}

interface Item {
  Item: number;
  Article: string;
  Amount: number;
}

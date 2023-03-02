import { Component } from '@angular/core';

export interface Orders {
  name: string;
  position: number;
}

const ELEMENT_DATA: Orders[] = [
  { position: 1, name: 'FirstOrder' },
  { position: 2, name: 'SecondOrder'},
];

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})

export class HomeComponent {
  displayedColumns: string[] = ['demo-position', 'demo-name'];
  dataSource = ELEMENT_DATA;
}

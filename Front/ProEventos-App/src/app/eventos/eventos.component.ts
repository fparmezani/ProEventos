import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit{

  public eventos: any = [];

  constructor(public http: HttpClient){};

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): any {
    this.http.get('https://localhost:7180/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
  }

}

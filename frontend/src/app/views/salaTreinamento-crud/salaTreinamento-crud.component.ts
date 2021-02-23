import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-salaTreinamento-crud',
  templateUrl: './salaTreinamento-crud.component.html',
  styleUrls: ['./salaTreinamento-crud.component.scss']
})
export class SalaTreinamentoCrudComponent implements OnInit {

  constructor(
    private router: Router,
    private headerService: HeaderService
  ) {
    headerService.headerData = {
      title: 'Cadastro de Salas de Treinamento',
      icon: 'school',
      routeUrl: '/salasTreinamento'
    };
  }

  ngOnInit() {
  }

  novo(): void {
    this.router.navigate(['/salasTreinamento/create']);
  }

}

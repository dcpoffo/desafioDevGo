import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-horarioCafe-crud',
  templateUrl: './horarioCafe-crud.component.html',
  styleUrls: ['./horarioCafe-crud.component.scss']
})
export class HorarioCafeCrudComponent implements OnInit {

  constructor(
    private router: Router,
    private headerService: HeaderService
  ) {
    headerService.headerData = {
      title: 'Cadastro Horário de Café',
      icon: 'schedule',
      routeUrl: '/horariosCafe'
    };
  }

  ngOnInit() {
  }

  novo(): void {
    this.router.navigate(['/horariosCafe/create']);
  }

}

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-etapa-crud',
  templateUrl: './etapa-crud.component.html',
  styleUrls: ['./etapa-crud.component.scss']
})
export class EtapaCrudComponent implements OnInit {

  constructor(
    private router: Router,
    private headerService: HeaderService
  ) {
    headerService.headerData = {
      title: 'Cadastro Horário de Aulas',
      icon: 'schedule',
      routeUrl: '/etapas'
    };
  }

  ngOnInit() {
  }

  novo(): void {
    this.router.navigate(['/etapas/create']);
  }

}

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-salaCafe-crud',
  templateUrl: './salaCafe-crud.component.html',
  styleUrls: ['./salaCafe-crud.component.scss']
})
export class SalaCafeCrudComponent implements OnInit {

  constructor(
    private router: Router,
    private headerService: HeaderService
  ) {
    headerService.headerData = {
      title: 'Cadastro de Espaços de Café',
      icon: 'local_cafe',
      routeUrl: '/salasCafe'
    };
  }

  ngOnInit() {
  }

  novo(): void {
    this.router.navigate(['/salasCafe/create']);
  }
}

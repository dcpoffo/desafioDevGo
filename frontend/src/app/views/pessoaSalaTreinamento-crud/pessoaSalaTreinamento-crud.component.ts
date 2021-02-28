import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-pessoaSalaTreinamento-crud',
  templateUrl: './pessoaSalaTreinamento-crud.component.html',
  styleUrls: ['./pessoaSalaTreinamento-crud.component.scss']
})
export class PessoaSalaTreinamentoCrudComponent implements OnInit {

  constructor(
    private router: Router,
    private headerService: HeaderService
  ) {
    headerService.headerData = {
      title: 'Cadastro de Treinamento',
      icon: 'cast_for_education',
      routeUrl: '/pessoasSalaTreinamento'
    };
  }

  ngOnInit() {
  }

  novo(): void {
    this.router.navigate(['/pessoasSalaTreinamento/create']);
  }

}

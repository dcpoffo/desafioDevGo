import { PessoaService } from './../../../services/pessoa.service';
import { Component, OnInit } from '@angular/core';
import { Pessoa } from 'src/app/models/pessoa';

@Component({
  selector: 'app-pessoa-read',
  templateUrl: './pessoa-read.component.html',
  styleUrls: ['./pessoa-read.component.css']
})
export class PessoaReadComponent implements OnInit {

  pessoas: Pessoa[];
  displayedColumns = ['id', 'nome', 'sobrenome', 'acoes'];

  constructor(
    private pessoaServico: PessoaService
  ) { }

  ngOnInit() {
    this.pessoaServico.getAll().subscribe(pessoas => {
      this.pessoas = pessoas;
      console.log(pessoas);
    });
  }

}

import { Component, OnInit } from '@angular/core';
import { PessoaSalaTreinamento } from 'src/app/models/PessoaSalaTreinamento';
import { PessoaSalaTreinamentoService } from 'src/app/services/pessoaSalaTreinamento.service';

@Component({
  selector: 'app-pessoaSalaTreinamento-read',
  templateUrl: './pessoaSalaTreinamento-read.component.html',
  styleUrls: ['./pessoaSalaTreinamento-read.component.scss']
})
export class PessoaSalaTreinamentoReadComponent implements OnInit {

  pessoasSalaTreinamento: PessoaSalaTreinamento[]
  displayedColumns = ['id', 'pessoa', 'salaTreinamento', 'etapa', 'salaCafe', 'horarioCafe', 'acoes'];
  //displayedColumns = ['id', 'pessoa', 'salaTreinamento', 'etapa', 'salaCafe', 'acoes'];


  constructor(
    private pessoaSalaTreinamentoServico: PessoaSalaTreinamentoService
  ) { }

  ngOnInit() {
    this.pessoaSalaTreinamentoServico.getAll().subscribe(pessoasSalaTreinamento => {
      this.pessoasSalaTreinamento = pessoasSalaTreinamento;
      console.log(pessoasSalaTreinamento);
    });
  }

}

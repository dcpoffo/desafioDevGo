import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Pessoa } from 'src/app/models/pessoa';
import { PessoaSalaTreinamento } from 'src/app/models/PessoaSalaTreinamento';
import { PessoaService } from 'src/app/services/pessoa.service';
import { PessoaSalaTreinamentoService } from 'src/app/services/pessoaSalaTreinamento.service';

@Component({
  selector: 'app-pessoaSalaTreinamentoPesquisa',
  templateUrl: './pessoaSalaTreinamentoPesquisa.component.html',
  styleUrls: ['./pessoaSalaTreinamentoPesquisa.component.scss']
})
export class PessoaSalaTreinamentoPesquisaComponent implements OnInit {

  pessoas: Pessoa[];

  pessoaId: number;

  pessoasSalaTreinamento: PessoaSalaTreinamento[]
  displayedColumns = ['id', 'nome', 'acoes'];

  constructor(
    private pessoaSalaTreinamentoServico: PessoaSalaTreinamentoService,
    private pessoaServico: PessoaService,
    private router: Router,
  ) { }

  ngOnInit() {
    this.pessoaServico.getAll().subscribe(pessoas => {
      this.pessoas = pessoas;
      console.log(pessoas);
    });
  }

  carregarPessoas(): void {
    this.pessoaServico.getAll().subscribe(p => {
      this.pessoas = p;
    });
  }

  pesquisar(): void {
    this.pessoaId = +this.pessoaId;
    this.pessoaSalaTreinamentoServico.getByPessoaId(this.pessoaId).subscribe(pessoasSalaTreinamento => {
      this.pessoasSalaTreinamento = this.pessoasSalaTreinamento;
    });
  }
}

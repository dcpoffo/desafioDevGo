import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PessoaSalaTreinamento } from 'src/app/models/PessoaSalaTreinamento';
import { MensagemService } from 'src/app/services/mensagem.service';
import { PessoaSalaTreinamentoService } from 'src/app/services/pessoaSalaTreinamento.service';

@Component({
  selector: 'app-pessoaSalaTreinamentoResultadoPesquisa',
  templateUrl: './pessoaSalaTreinamentoResultadoPesquisa.component.html',
  styleUrls: ['./pessoaSalaTreinamentoResultadoPesquisa.component.scss']
})
export class PessoaSalaTreinamentoResultadoPesquisaComponent implements OnInit {

  pessoasSalaTreinamento: PessoaSalaTreinamento[];

  pessoaSalaTreinamento: PessoaSalaTreinamento =
  {
    id: 0,
    salaTreinamentoId: 0,
    pessoaId: 0,
    etapaId: 0,
    salaCafeId: 0,
    horarioCafeId: 0
  };

  displayedColumns = ['id', 'pessoa', 'salaTreinamento', 'etapa', 'salaCafe', 'horarioCafe'];
  id: number;

  constructor(
    private pessoaSalaTreinamentoServico: PessoaSalaTreinamentoService,
    private mensagemServico: MensagemService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    console.log(id);
      this.pessoaSalaTreinamentoServico.getByPessoaId(id).subscribe(pessoasSalaTreinamento => {
      this.pessoasSalaTreinamento = pessoasSalaTreinamento;
    });
  }
}


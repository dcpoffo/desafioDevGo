import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PessoaSalaTreinamento } from 'src/app/models/PessoaSalaTreinamento';
import { MensagemService } from 'src/app/services/mensagem.service';
import { PessoaSalaTreinamentoService } from 'src/app/services/pessoaSalaTreinamento.service';

@Component({
  selector: 'app-pessoaSalaTreinamento-delete',
  templateUrl: './pessoaSalaTreinamento-delete.component.html',
  styleUrls: ['./pessoaSalaTreinamento-delete.component.scss']
})
export class PessoaSalaTreinamentoDeleteComponent implements OnInit {

  pessoaSalaTreinamento: PessoaSalaTreinamento = {
    //id: 0,
    salaTreinamentoId: 0,
    pessoaId: 0,
    etapaId: 0,
    salaCafeId: 0,
    horarioCafeId: 0
  };

  constructor(
    private pessoaSalaTreinamentoServico: PessoaSalaTreinamentoService,
    private router: Router,
    private route: ActivatedRoute,
    private mensagemServico: MensagemService
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.pessoaSalaTreinamentoServico.getById(id).subscribe((pessoaSalaTreinamento) => {
      this.pessoaSalaTreinamento = pessoaSalaTreinamento;
    });
  }

  apagar(): void {
    this.pessoaSalaTreinamentoServico.delete(this.pessoaSalaTreinamento.id).subscribe(() => {
      this.mensagemServico.showMessage('Treinamento excluído com sucesso!');
      this.router.navigate(['/pessoasSalaTreinamento']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/pessoasSalaTreinamento']);
  }

}

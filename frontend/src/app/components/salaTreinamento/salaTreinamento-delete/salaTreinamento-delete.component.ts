import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SalaTreinamento } from 'src/app/models/SalaTreinamento';
import { MensagemService } from 'src/app/services/mensagem.service';
import { SalaTreinamentoService } from 'src/app/services/salaTreinamento.service';

@Component({
  selector: 'app-salaTreinamento-delete',
  templateUrl: './salaTreinamento-delete.component.html',
  styleUrls: ['./salaTreinamento-delete.component.scss']
})
export class SalaTreinamentoDeleteComponent implements OnInit {

  salaTreinamento: SalaTreinamento;

  constructor(
    private salaTreinamentoServico: SalaTreinamentoService,
    private mensagemServico: MensagemService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.salaTreinamentoServico.getById(id).subscribe((salaTreinamento) => {
      this.salaTreinamento = salaTreinamento;
    });
  }

  apagar(): void {
    this.salaTreinamentoServico.delete(this.salaTreinamento.id).subscribe(() => {
      this.mensagemServico.showMessage('Sala de Treinamento excluida com sucesso!');

      this.router.navigate(['/salasTreinamento']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/salasTreinamento']);
  }
}

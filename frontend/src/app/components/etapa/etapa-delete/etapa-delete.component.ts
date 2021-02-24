import { EtapaService } from './../../../services/etapa.service';
import { Etapa } from 'src/app/models/Etapa';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-etapa-delete',
  templateUrl: './etapa-delete.component.html',
  styleUrls: ['./etapa-delete.component.scss']
})
export class EtapaDeleteComponent implements OnInit {

  etapa: Etapa;

  constructor(
    private etapaServico: EtapaService,
    private router: Router,
    private route: ActivatedRoute,
    private mensagemServico: MensagemService
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.etapaServico.getById(id).subscribe((etapa) => {
      this.etapa = etapa;
    });
  }

  apagar(): void {
    this.etapaServico.delete(this.etapa.id).subscribe(() => {
      this.mensagemServico.showMessage('Horário excluido com sucesso!');
      this.router.navigate(['/etapas']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/etapas']);
  }


}

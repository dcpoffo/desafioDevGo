import { Component, OnInit } from '@angular/core';
import { Etapa } from 'src/app/models/Etapa';
import { EtapaService } from 'src/app/services/etapa.service';

@Component({
  selector: 'app-etapa-read',
  templateUrl: './etapa-read.component.html',
  styleUrls: ['./etapa-read.component.scss']
})
export class EtapaReadComponent implements OnInit {

  etapas: Etapa[];
  displayedColumns = ['id', 'inicio', 'fim', 'acoes'];

  constructor(
    private etapaServico: EtapaService
  ) { }

  ngOnInit() {
    this.etapaServico.getAll().subscribe(etapas => {
      this.etapas = etapas;
      console.log(etapas);
    });
  }

}

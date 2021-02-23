import { Component, OnInit } from '@angular/core';
import { SalaTreinamento } from 'src/app/models/SalaTreinamento';
import { SalaTreinamentoService } from 'src/app/services/salaTreinamento.service';

@Component({
  selector: 'app-salaTreinamento-read',
  templateUrl: './salaTreinamento-read.component.html',
  styleUrls: ['./salaTreinamento-read.component.scss']
})
export class SalaTreinamentoReadComponent implements OnInit {

  salasTreinamento: SalaTreinamento[];
  displayedColumns = ['id', 'nome', 'lotacao', 'acoes'];

  constructor(
    private salaTreinamentoServico: SalaTreinamentoService

  ) { }

  ngOnInit() {
    this.salaTreinamentoServico.getAll().subscribe(salasTreinamento => {
      this.salasTreinamento = salasTreinamento;
      console.log(salasTreinamento);
    });
  }

}

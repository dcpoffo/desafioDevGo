import { Component, OnInit } from '@angular/core';
import { SalaCafe } from 'src/app/models/SalaCafe';
import { SalaCafeService } from 'src/app/services/salaCafe.service';

@Component({
  selector: 'app-salaCafe-read',
  templateUrl: './salaCafe-read.component.html',
  styleUrls: ['./salaCafe-read.component.scss']
})
export class SalaCafeReadComponent implements OnInit {

  salasCafe: SalaCafe[];
  displayedColumns = ['id', 'nome', 'acoes'];

  constructor(
    private salaCafeServico: SalaCafeService

  ) { }

  ngOnInit() {
    this.salaCafeServico.getAll().subscribe(salasCafe => {
      this.salasCafe = salasCafe;
      console.log(salasCafe);
    });
  }

}

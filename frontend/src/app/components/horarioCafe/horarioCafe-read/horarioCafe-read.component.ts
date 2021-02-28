import { HorarioCafe } from './../../../models/HorarioCafe';
import { Component, OnInit } from '@angular/core';
import { HorarioCafeService } from 'src/app/services/horarioCafe.service';

@Component({
  selector: 'app-horarioCafe-read',
  templateUrl: './horarioCafe-read.component.html',
  styleUrls: ['./horarioCafe-read.component.scss']
})
export class HorarioCafeReadComponent implements OnInit {

  horariosCafe: HorarioCafe[];
  displayedColumns = ['id', 'inicio', 'fim', 'acoes'];

  constructor(
    private horarioServico: HorarioCafeService
  ) { }

  ngOnInit() {
    this.horarioServico.getAll().subscribe(horariosCafe => {
      this.horariosCafe = horariosCafe;
    });
  }


}

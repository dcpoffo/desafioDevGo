import { HorarioCafe } from './../../../models/HorarioCafe';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MensagemService } from 'src/app/services/mensagem.service';
import { HorarioCafeService } from 'src/app/services/horarioCafe.service';

@Component({
  selector: 'app-horarioCafe-delete',
  templateUrl: './horarioCafe-delete.component.html',
  styleUrls: ['./horarioCafe-delete.component.scss']
})
export class HorarioCafeDeleteComponent implements OnInit {

  horarioCafe: HorarioCafe = {
    id: 0,
    inicio: null,
    fim: null
  }

  constructor(
    private horarioCafeServico: HorarioCafeService,
    private router: Router,
    private route: ActivatedRoute,
    private mensagemServico: MensagemService
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.horarioCafeServico.getById(id).subscribe((horarioCafe) => {
      this.horarioCafe = horarioCafe;
    });
  }

  apagar(): void {
    this.horarioCafeServico.delete(this.horarioCafe.id).subscribe(() => {
      this.mensagemServico.showMessage('Horário de Café excluido com sucesso!');
      this.router.navigate(['/horariosCafe']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/horariosCafe']);
  }

}

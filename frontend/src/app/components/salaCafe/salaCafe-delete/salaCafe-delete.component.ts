import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SalaCafe } from 'src/app/models/SalaCafe';
import { MensagemService } from 'src/app/services/mensagem.service';
import { SalaCafeService } from 'src/app/services/salaCafe.service';

@Component({
  selector: 'app-salaCafe-delete',
  templateUrl: './salaCafe-delete.component.html',
  styleUrls: ['./salaCafe-delete.component.scss']
})
export class SalaCafeDeleteComponent implements OnInit {

  salaCafe: SalaCafe = {
    nome: ''
  };

  constructor(
    private salaCafeServico: SalaCafeService,
    private mensagemServico: MensagemService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.salaCafeServico.getById(id).subscribe((salaCafe) => {
      this.salaCafe = salaCafe;
    });
  }

  apagar(): void {
    this.salaCafeServico.delete(this.salaCafe.id).subscribe(() => {
      this.mensagemServico.showMessage('Espaço para Café excluido com sucesso!');

      this.router.navigate(['/salasCafe']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/salasCafe']);
  }

}

import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { SalaCafe } from 'src/app/models/SalaCafe';
import { MensagemService } from 'src/app/services/mensagem.service';
import { SalaCafeService } from 'src/app/services/salaCafe.service';

@Component({
  selector: 'app-salaCafe-update',
  templateUrl: './salaCafe-update.component.html',
  styleUrls: ['./salaCafe-update.component.scss']
})
export class SalaCafeUpdateComponent implements OnInit {

  salaCafeForm = new FormGroup({
    nome: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(20)])
  });

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

  atualizar(): void {
    this.salaCafeServico.put(this.salaCafe).subscribe(() => {
      this.mensagemServico.showMessage('Espaço de Café atualizado com sucesso!');
      this.router.navigate(['/salasCafe']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/salasCafe']);
  }

  public temErro = (controlName: string, errorName: string) =>{
    return this.salaCafeForm.controls[controlName].hasError(errorName);
  }
}

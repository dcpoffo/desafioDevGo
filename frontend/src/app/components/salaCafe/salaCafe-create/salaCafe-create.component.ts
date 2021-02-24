import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SalaCafe } from 'src/app/models/SalaCafe';
import { MensagemService } from 'src/app/services/mensagem.service';
import { SalaCafeService } from 'src/app/services/salaCafe.service';

@Component({
  selector: 'app-salaCafe-create',
  templateUrl: './salaCafe-create.component.html',
  styleUrls: ['./salaCafe-create.component.scss']
})
export class SalaCafeCreateComponent implements OnInit {

  salaCafeForm = new FormGroup({
    nome: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(20)]),
  });

  salaCafe: SalaCafe = {
    nome: ''
  };

  constructor(
    private salaCafeServico: SalaCafeService,
    private mensagemServico: MensagemService,
    private router: Router
  ) { }

  ngOnInit() {
  }

  criar(): void {
    this.salaCafeServico.post(this.salaCafe).subscribe(() => {
      this.mensagemServico.showMessage('Espaço de Café cadastrado com sucesso!')
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

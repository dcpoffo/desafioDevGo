import { SalaTreinamento } from './../../../models/SalaTreinamento';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MensagemService } from 'src/app/services/mensagem.service';
import { SalaTreinamentoService } from 'src/app/services/salaTreinamento.service';

@Component({
  selector: 'app-salaTreinamento-create',
  templateUrl: './salaTreinamento-create.component.html',
  styleUrls: ['./salaTreinamento-create.component.scss']
})
export class SalaTreinamentoCreateComponent implements OnInit {

  salaTreinamentoForm = new FormGroup({
    nome: new FormControl('', [Validators.required, Validators.minLength(3), Validators.maxLength(20)]),
    lotacao: new FormControl('', [Validators.required, Validators.min(4)])
  });

  salaTreinamento: SalaTreinamento = {
    nome: '',
    lotacao: null
  };

  constructor(
    private salaTreinamentoServico: SalaTreinamentoService,
    private mensagemServico: MensagemService,
    private router: Router
  ) { }

  ngOnInit() {
  }

  criar(): void {
    this.salaTreinamentoServico.post(this.salaTreinamento).subscribe(() => {
      this.mensagemServico.showMessage('Sala de Treinamento cadastrada com sucesso!')
      this.router.navigate(['/salasTreinamento']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/salasTreinamento']);
  }

  public temErro = (controlName: string, errorName: string) =>{
    return this.salaTreinamentoForm.controls[controlName].hasError(errorName);
  }

}

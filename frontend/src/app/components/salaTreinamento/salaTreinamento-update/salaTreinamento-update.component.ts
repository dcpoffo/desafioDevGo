import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { SalaTreinamento } from 'src/app/models/SalaTreinamento';
import { MensagemService } from 'src/app/services/mensagem.service';
import { SalaTreinamentoService } from 'src/app/services/salaTreinamento.service';

@Component({
  selector: 'app-salaTreinamento-update',
  templateUrl: './salaTreinamento-update.component.html',
  styleUrls: ['./salaTreinamento-update.component.scss']
})
export class SalaTreinamentoUpdateComponent implements OnInit {

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
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.salaTreinamentoServico.getById(id).subscribe((salaTreinamento) => {
      this.salaTreinamento = salaTreinamento;
    });
  }

  atualizar(): void {
    this.salaTreinamentoServico.put(this.salaTreinamento).subscribe(() => {
      this.mensagemServico.showMessage('Sala de Treinamento atualizada com sucesso!');
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

import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { HorarioCafe } from 'src/app/models/HorarioCafe';
import { HorarioCafeService } from 'src/app/services/horarioCafe.service';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-horarioCafe-create',
  templateUrl: './horarioCafe-create.component.html',
  styleUrls: ['./horarioCafe-create.component.scss']
})
export class HorarioCafeCreateComponent implements OnInit {

  form = new FormGroup({
    inicio: new FormControl('', [Validators.required]),
    fim: new FormControl('', [Validators.required])
  });

  horarioCafe: HorarioCafe = {
    id: 0,
    inicio: null,
    fim: null
  };

  constructor(
    private horarioCafeServico: HorarioCafeService,
    private mensagemServico: MensagemService,
    private router: Router,

  ) { }

  ngOnInit() {
  }

  criar(): void {
    this.horarioCafeServico.post(this.horarioCafe).subscribe(() => {
      this.mensagemServico.showMessage('Horário para Café cadastrado com sucesso!')
      this.router.navigate(['/horariosCafe']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/horariosCafe']);
  }

  public temErro = (controlName: string, errorName: string) =>{
    return this.form.controls[controlName].hasError(errorName);
  }

}

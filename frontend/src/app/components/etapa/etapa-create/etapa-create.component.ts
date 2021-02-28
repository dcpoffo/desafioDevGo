import { Component, NgZone, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Etapa } from 'src/app/models/Etapa';
import { EtapaService } from 'src/app/services/etapa.service';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-etapa-create',
  templateUrl: './etapa-create.component.html',
  styleUrls: ['./etapa-create.component.scss']
})
export class EtapaCreateComponent implements OnInit {


  etapaForm = new FormGroup({
    inicio: new FormControl('', [Validators.required]),
    fim: new FormControl('', [Validators.required])
  });

  etapa: Etapa = {
    id: 0,
    inicio: null,
    fim: null
  };

  constructor(
    private etapaServico: EtapaService,
    private mensagemServico: MensagemService,
    private router: Router,

  ) { }

  ngOnInit() {
  }

  criar(): void {
    this.etapaServico.post(this.etapa).subscribe(() => {
      this.mensagemServico.showMessage('Horário cadastrado com sucesso!')
      this.router.navigate(['/etapas']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/etapas']);
  }

  public temErro = (controlName: string, errorName: string) =>{
    return this.etapaForm.controls[controlName].hasError(errorName);
  }

}

import { HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Etapa } from 'src/app/models/Etapa';
import { EtapaService } from 'src/app/services/etapa.service';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-etapa-update',
  templateUrl: './etapa-update.component.html',
  styleUrls: ['./etapa-update.component.scss']
})
export class EtapaUpdateComponent implements OnInit {

  etapaForm = new FormGroup({
    inicio: new FormControl('', [Validators.required]),
    fim: new FormControl('', [Validators.required])
  });

  etapa: Etapa = {
    id: 0,
    inicio: null,
    fim: null
  }

  constructor(
    private etapaServico: EtapaService,
    private mensagemServico: MensagemService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.etapaServico.getById(id).subscribe((etapa) => {
      this.etapa = etapa;
    });
  }

  atualizar(): void {
    this.etapaServico.put(this.etapa).subscribe(() => {
      this.mensagemServico.showMessage('Cadastro atualizado com sucesso!');
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

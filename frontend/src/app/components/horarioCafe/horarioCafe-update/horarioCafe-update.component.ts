import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { HorarioCafe } from 'src/app/models/HorarioCafe';
import { HorarioCafeService } from 'src/app/services/horarioCafe.service';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-horarioCafe-update',
  templateUrl: './horarioCafe-update.component.html',
  styleUrls: ['./horarioCafe-update.component.scss']
})
export class HorarioCafeUpdateComponent implements OnInit {

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
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.horarioCafeServico.getById(id).subscribe((horarioCafe) => {
      this.horarioCafe = horarioCafe;
    });
  }

  atualizar(): void {
    this.horarioCafeServico.put(this.horarioCafe).subscribe(() => {
      this.mensagemServico.showMessage('Cadastro atualizado com sucesso!');
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

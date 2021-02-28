import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Etapa } from 'src/app/models/Etapa';
import { HorarioCafe } from 'src/app/models/HorarioCafe';
import { Pessoa } from 'src/app/models/pessoa';
import { PessoaSalaTreinamento } from 'src/app/models/PessoaSalaTreinamento';
import { SalaCafe } from 'src/app/models/SalaCafe';
import { SalaTreinamento } from 'src/app/models/SalaTreinamento';
import { EtapaService } from 'src/app/services/etapa.service';
import { HorarioCafeService } from 'src/app/services/horarioCafe.service';
import { MensagemService } from 'src/app/services/mensagem.service';
import { PessoaService } from 'src/app/services/pessoa.service';
import { PessoaSalaTreinamentoService } from 'src/app/services/pessoaSalaTreinamento.service';
import { SalaCafeService } from 'src/app/services/salaCafe.service';
import { SalaTreinamentoService } from 'src/app/services/salaTreinamento.service';

@Component({
  selector: 'app-pessoaSalaTreinamento-update',
  templateUrl: './pessoaSalaTreinamento-update.component.html',
  styleUrls: ['./pessoaSalaTreinamento-update.component.scss']
})
export class PessoaSalaTreinamentoUpdateComponent implements OnInit {

  form = new FormGroup({
    pessoa: new FormControl('', [Validators.required]),
    salaTreinamento: new FormControl('', [Validators.required]),
    etapa: new FormControl('', [Validators.required]),
    cafe: new FormControl('', [Validators.required]),
    horarioCafe: new FormControl('', [Validators.required]),
  });

  pessoas: Pessoa[];
  salasTreinamento: SalaTreinamento[];
  etapas: Etapa[];
  salasCafe: SalaCafe[];
  horariosCafe: HorarioCafe[];

  pessoaSalaTreinamento: PessoaSalaTreinamento =
  {
    id: 0,
    salaTreinamentoId: 0,
    pessoaId: 0,
    etapaId: 0,
    salaCafeId: 0,
    horarioCafeId: 0
  };

  constructor(
    private pessoaSalaTreinamentoServico: PessoaSalaTreinamentoService,
    private salaTreinamentoServico: SalaTreinamentoService,
    private pessoaServico: PessoaService,
    private etapaServico: EtapaService,
    private salaCafeServico: SalaCafeService,
    private horarioCafeServico: HorarioCafeService,
    private router: Router,
    private mensagemServico: MensagemService,
    private route: ActivatedRoute,
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.pessoaSalaTreinamentoServico.getById(id).subscribe((pessoaSalaTreinamento) => {
      this.pessoaSalaTreinamento = pessoaSalaTreinamento;
    });

    this.carregarPessoas();
    this.carregarSalasTreinamento();
    this.carregarEtapas();
    this.carregarSalasCafe();
    this.carregarHorariosCafe();
  }

  carregarPessoas(): void {
    this.pessoaServico.getAll().subscribe(pes => {
      this.pessoas = pes;
    });
  }

  carregarSalasTreinamento(): void {
    this.salaTreinamentoServico.getAll().subscribe(salaTre => {
      this.salasTreinamento = salaTre;
    });
  }
  carregarEtapas(): void {
    this.etapaServico.getAll().subscribe(eta => {
      this.etapas = eta;
    });
  }

  carregarSalasCafe(): void {
    this.salaCafeServico.getAll().subscribe(salaCaf => {
      this.salasCafe = salaCaf;
    });
  }

  carregarHorariosCafe(): void {
    this.horarioCafeServico.getAll().subscribe(horCaf => {
      this.horariosCafe = horCaf;
    });
  }

  atualizar(): void {
        this.pessoaSalaTreinamentoServico.put(this.pessoaSalaTreinamento).subscribe(() => {
        this.mensagemServico.showMessage('Treinamento atualizado com sucesso!');
        this.router.navigate(['/pessoasSalaTreinamento']);

      });
  }

  cancelar(): void {
    this.router.navigate(['/pessoasSalaTreinamento']);
  }

  public temErro = (controlName: string, errorName: string) => {
    return this.form.controls[controlName].hasError(errorName);
  }
}

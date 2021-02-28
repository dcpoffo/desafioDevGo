import { HorarioCafeService } from './../../../services/horarioCafe.service';
import { SalaCafeService } from './../../../services/salaCafe.service';
import { Etapa } from './../../../models/Etapa';
import { SalaTreinamento } from 'src/app/models/SalaTreinamento';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Pessoa } from 'src/app/models/pessoa';
import { SalaCafe } from 'src/app/models/SalaCafe';
import { HorarioCafe } from 'src/app/models/HorarioCafe';
import { PessoaSalaTreinamento } from 'src/app/models/PessoaSalaTreinamento';
import { PessoaSalaTreinamentoService } from 'src/app/services/pessoaSalaTreinamento.service';
import { SalaTreinamentoService } from 'src/app/services/salaTreinamento.service';
import { PessoaService } from 'src/app/services/pessoa.service';
import { EtapaService } from 'src/app/services/etapa.service';
import { Router } from '@angular/router';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-pessoaSalaTreinamento-create',
  templateUrl: './pessoaSalaTreinamento-create.component.html',
  styleUrls: ['./pessoaSalaTreinamento-create.component.scss']
})
export class PessoaSalaTreinamentoCreateComponent implements OnInit {

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

  pessoaSalaTreinamento: PessoaSalaTreinamento = {
    id: 0,
    salaTreinamentoId: null,
    pessoaId: null,
    etapaId: null,
    salaCafeId: null,
    horarioCafeId: null
  };

  constructor(
    private pessoaSalaTreinamentoServico: PessoaSalaTreinamentoService,
    private salaTreinamentoServico: SalaTreinamentoService,
    private pessoaServico: PessoaService,
    private etapaServico: EtapaService,
    private salaCafeServico: SalaCafeService,
    private horarioCafeServico: HorarioCafeService,
    private router: Router,
    private mensagemServico: MensagemService
  ) { }

  ngOnInit() {
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

  criar(): void {
    if (
      this.pessoaSalaTreinamento.salaTreinamentoId === 0 ||
      this.pessoaSalaTreinamento.pessoaId === 0 ||
      this.pessoaSalaTreinamento.etapaId === 0 ||
      this.pessoaSalaTreinamento.salaCafeId === 0 ||
      this.pessoaSalaTreinamento.horarioCafeId === 0)
      {
          this.mensagemServico.showMessage('Faltou selecionar algum campo. Verifique!', true);
      }
    else {
          this.pessoaSalaTreinamentoServico.post(this.pessoaSalaTreinamento).subscribe(() => {
          this.mensagemServico.showMessage('Cadastro realizado com sucesso')
          this.router.navigate(['/pessoasSalaTreinamento']);
      });
    }
  }

  cancelar(): void {
    this.router.navigate(['/pessoasSalaTreinamento']);
  }

  public temErro = (controlName: string, errorName: string) => {
    return this.form.controls[controlName].hasError(errorName);
  }

}

/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PessoaSalaTreinamentoResultadoPesquisaSalaTreinamentoComponent } from './pessoaSalaTreinamentoResultadoPesquisa-salaTreinamento.component';

describe('PessoaSalaTreinamentoResultadoPesquisaSalaTreinamentoComponent', () => {
  let component: PessoaSalaTreinamentoResultadoPesquisaSalaTreinamentoComponent;
  let fixture: ComponentFixture<PessoaSalaTreinamentoResultadoPesquisaSalaTreinamentoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaSalaTreinamentoResultadoPesquisaSalaTreinamentoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaSalaTreinamentoResultadoPesquisaSalaTreinamentoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

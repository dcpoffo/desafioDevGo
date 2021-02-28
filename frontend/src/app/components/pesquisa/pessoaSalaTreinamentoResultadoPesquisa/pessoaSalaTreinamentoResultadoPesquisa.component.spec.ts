/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PessoaSalaTreinamentoResultadoPesquisaComponent } from './pessoaSalaTreinamentoResultadoPesquisa.component';

describe('PessoaSalaTreinamentoResultadoPesquisaComponent', () => {
  let component: PessoaSalaTreinamentoResultadoPesquisaComponent;
  let fixture: ComponentFixture<PessoaSalaTreinamentoResultadoPesquisaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaSalaTreinamentoResultadoPesquisaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaSalaTreinamentoResultadoPesquisaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

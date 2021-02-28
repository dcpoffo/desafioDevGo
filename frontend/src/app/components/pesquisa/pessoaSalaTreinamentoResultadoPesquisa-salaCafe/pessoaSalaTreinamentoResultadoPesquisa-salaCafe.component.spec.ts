/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PessoaSalaTreinamentoResultadoPesquisaSalaCafeComponent } from './pessoaSalaTreinamentoResultadoPesquisa-salaCafe.component';

describe('PessoaSalaTreinamentoResultadoPesquisaSalaCafeComponent', () => {
  let component: PessoaSalaTreinamentoResultadoPesquisaSalaCafeComponent;
  let fixture: ComponentFixture<PessoaSalaTreinamentoResultadoPesquisaSalaCafeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaSalaTreinamentoResultadoPesquisaSalaCafeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaSalaTreinamentoResultadoPesquisaSalaCafeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

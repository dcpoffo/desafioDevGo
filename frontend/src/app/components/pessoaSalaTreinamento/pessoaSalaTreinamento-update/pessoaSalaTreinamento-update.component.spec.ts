/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PessoaSalaTreinamentoUpdateComponent } from './pessoaSalaTreinamento-update.component';

describe('PessoaSalaTreinamentoUpdateComponent', () => {
  let component: PessoaSalaTreinamentoUpdateComponent;
  let fixture: ComponentFixture<PessoaSalaTreinamentoUpdateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaSalaTreinamentoUpdateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaSalaTreinamentoUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

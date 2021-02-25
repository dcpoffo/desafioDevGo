/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PessoaSalaTreinamentoDeleteComponent } from './pessoaSalaTreinamento-delete.component';

describe('PessoaSalaTreinamentoDeleteComponent', () => {
  let component: PessoaSalaTreinamentoDeleteComponent;
  let fixture: ComponentFixture<PessoaSalaTreinamentoDeleteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaSalaTreinamentoDeleteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaSalaTreinamentoDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

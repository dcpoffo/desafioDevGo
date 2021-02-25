import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EMPTY, Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { PessoaSalaTreinamento } from '../models/PessoaSalaTreinamento';
import { MensagemService } from './mensagem.service';

@Injectable({
  providedIn: 'root'
})
export class PessoaSalaTreinamentoService {

  baseURL = `${environment.mainUrlAPI}pessoaSalaTreinamento`;

  constructor(
    private http: HttpClient,
      private mensagemServico: MensagemService
  ) { }

  getAll(): Observable<PessoaSalaTreinamento[]> {
    return this.http.get<PessoaSalaTreinamento[]>(this.baseURL).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  getById(id: number): Observable<PessoaSalaTreinamento> {
    const url = `${this.baseURL}/${id}`;
    return this.http.get<PessoaSalaTreinamento>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  put(pessoaSalaTreinamento: PessoaSalaTreinamento): Observable<PessoaSalaTreinamento> {
    const url = `${this.baseURL}/${pessoaSalaTreinamento.id}`;
    return this.http.put<PessoaSalaTreinamento>(url, pessoaSalaTreinamento).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  post(pessoaSalaTreinamento: PessoaSalaTreinamento): Observable<PessoaSalaTreinamento> {
    return this.http.post<PessoaSalaTreinamento>(this.baseURL, pessoaSalaTreinamento).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  delete(id: number): Observable<PessoaSalaTreinamento> {
    const url = `${this.baseURL}/${id}`;
    return this.http.delete<PessoaSalaTreinamento>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  errorHandler(e: any): Observable<any> {
    this.mensagemServico.showMessage('Ocorreu um erro com o módulo Treinamento!', true);
    return EMPTY;
  }

}

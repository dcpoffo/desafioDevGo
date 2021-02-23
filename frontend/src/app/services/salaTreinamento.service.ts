import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EMPTY, Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { SalaTreinamento } from '../models/SalaTreinamento';
import { MensagemService } from './mensagem.service';

@Injectable({
  providedIn: 'root'
})
export class SalaTreinamentoService {

  baseURL = `${environment.mainUrlAPI}salaTreinamento`;

  constructor(
    private http: HttpClient,
      private mensagemServico: MensagemService
  ) { }

  getAll(): Observable<SalaTreinamento[]> {
    return this.http.get<SalaTreinamento[]>(this.baseURL).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  getById(id: number): Observable<SalaTreinamento> {
    const url = `${this.baseURL}/${id}`;
    return this.http.get<SalaTreinamento>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  put(salaTreinamento: SalaTreinamento): Observable<SalaTreinamento> {
    const url = `${this.baseURL}/${salaTreinamento.id}`;
    return this.http.put<SalaTreinamento>(url, salaTreinamento).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  post(salaTreinamento: SalaTreinamento): Observable<SalaTreinamento> {
    return this.http.post<SalaTreinamento>(this.baseURL, salaTreinamento).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  delete(id: number): Observable<SalaTreinamento> {
    const url = `${this.baseURL}/${id}`;
    return this.http.delete<SalaTreinamento>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  errorHandler(e: any): Observable<any> {
    this.mensagemServico.showMessage('Ocorreu um erro com o módulo Sala Treinamento!', true);
    return EMPTY;
  }
}

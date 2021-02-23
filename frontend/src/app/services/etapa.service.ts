import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EMPTY, Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Etapa } from '../models/Etapa';
import { MensagemService } from './mensagem.service';

@Injectable({
  providedIn: 'root'
})
export class EtapaService {

  baseURL = `${environment.mainUrlAPI}etapa`;

  constructor(
    private http: HttpClient,
      private mensagemServico: MensagemService
  ) { }

  getAll(): Observable<Etapa[]> {
    return this.http.get<Etapa[]>(this.baseURL).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  getById(id: number): Observable<Etapa> {
    const url = `${this.baseURL}/${id}`;
    return this.http.get<Etapa>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  put(etapa: Etapa): Observable<Etapa> {
    const url = `${this.baseURL}/${etapa.id}`;
    return this.http.put<Etapa>(url, etapa).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  post(etapa: Etapa): Observable<Etapa> {
    return this.http.post<Etapa>(this.baseURL, etapa).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  delete(id: number): Observable<Etapa> {
    const url = `${this.baseURL}/${id}`;
    return this.http.delete<Etapa>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  errorHandler(e: any): Observable<any> {
    this.mensagemServico.showMessage('Ocorreu um erro com o módulo Etapa!', true);
    return EMPTY;
  }

}

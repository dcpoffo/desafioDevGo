import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EMPTY, Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { SalaCafe } from '../models/SalaCafe';
import { MensagemService } from './mensagem.service';

@Injectable({
  providedIn: 'root'
})
export class SalaCafeService {

  baseURL = `${environment.mainUrlAPI}salaCafe`;

  constructor(
    private http: HttpClient,
    private mensagemServico: MensagemService
  ) { }

  getAll(): Observable<SalaCafe[]> {
    return this.http.get<SalaCafe[]>(this.baseURL).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  getById(id: number): Observable<SalaCafe> {
    const url = `${this.baseURL}/${id}`;
    return this.http.get<SalaCafe>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  put(salaCafe: SalaCafe): Observable<SalaCafe> {
    const url = `${this.baseURL}/${salaCafe.id}`;
    return this.http.put<SalaCafe>(url, salaCafe).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  post(salaCafe: SalaCafe): Observable<SalaCafe> {
    return this.http.post<SalaCafe>(this.baseURL, salaCafe).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  delete(id: number): Observable<SalaCafe> {
    const url = `${this.baseURL}/${id}`;
    return this.http.delete<SalaCafe>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  errorHandler(e: any): Observable<any> {
    this.mensagemServico.showMessage('Ocorreu um erro com o módulo Sala Cafe!', true);
    return EMPTY;
  }

}

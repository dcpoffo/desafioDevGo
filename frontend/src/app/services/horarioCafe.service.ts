import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EMPTY, Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { HorarioCafe } from '../models/HorarioCafe';
import { MensagemService } from './mensagem.service';

@Injectable({
  providedIn: 'root'
})
export class HorarioCafeService {

  baseURL = `${environment.mainUrlAPI}horarioCafe`;

  constructor(
    private http: HttpClient,
      private mensagemServico: MensagemService
  ) { }

  getAll(): Observable<HorarioCafe[]> {
    return this.http.get<HorarioCafe[]>(this.baseURL).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  getById(id: number): Observable<HorarioCafe> {
    const url = `${this.baseURL}/${id}`;
    return this.http.get<HorarioCafe>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  put(horarioCafe: HorarioCafe): Observable<HorarioCafe> {
    const url = `${this.baseURL}/${horarioCafe.id}`;
    return this.http.put<HorarioCafe>(url, horarioCafe).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  post(horarioCafe: HorarioCafe): Observable<HorarioCafe> {
    return this.http.post<HorarioCafe>(this.baseURL, horarioCafe).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  delete(id: number): Observable<HorarioCafe> {
    const url = `${this.baseURL}/${id}`;
    return this.http.delete<HorarioCafe>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  errorHandler(e: any): Observable<any> {
    this.mensagemServico.showMessage('Ocorreu um erro com o módulo Horario Cafe!', true);
    return EMPTY;
  }

}

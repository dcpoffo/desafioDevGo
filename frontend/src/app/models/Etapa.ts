import { Time } from "@angular/common";
import { Timestamp } from "rxjs/internal/operators/timestamp";

export class Etapa {
  id?: number;
  inicio: Date;
  fim: Date;

  constructor() {
    this.id = 0;
    this.inicio = null;
    this.fim = null;
  }
}

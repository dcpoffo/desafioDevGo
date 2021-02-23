import { Timestamp } from "rxjs/internal/operators/timestamp";

export class Etapa {
  id?: number;
  DataHoraInicio: Date;
  DataHoraFim: Date;

  constructor() {
    this.id = 0;
    this.DataHoraInicio = null;
    this.DataHoraFim = null;
  }
}

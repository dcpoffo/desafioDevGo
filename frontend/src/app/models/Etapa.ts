import { Timestamp } from "rxjs/internal/operators/timestamp";

export class Etapa {
  id?: number;
  dataHoraInicio: Date;
  dataHoraFim: Date;

  constructor() {
    this.id = 0;
    this.dataHoraInicio = null;
    this.dataHoraFim = null;
  }
}

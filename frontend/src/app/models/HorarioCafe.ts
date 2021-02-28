import { Time } from "@angular/common";

export class HorarioCafe {
  id?: number;
  inicio: Date;
  fim: Date;

  constructor() {
    this.id = 0;
    this.inicio = null;
    this.fim = null;
  }
}

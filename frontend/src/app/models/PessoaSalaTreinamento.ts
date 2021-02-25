import { SalaTreinamento } from 'src/app/models/SalaTreinamento';
export class PessoaSalaTreinamento {
  id?: number;
  salaTreinamentoId: number;
  pessoaId: number;
  etapaId: number;
  salaCafeId: number;
  horarioCafeId: number;

  constructor() {
    this.id =  0;
    this.salaTreinamentoId = 0;
    this.pessoaId = 0;
    this.etapaId = 0;
    this.salaCafeId = 0;
    this.horarioCafeId = 0;
  }
}

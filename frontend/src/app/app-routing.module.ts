import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './views/home/home.component';

//Pessoa
import { PessoaCrudComponent } from './views/pessoa-crud/pessoa-crud.component'
import { PessoaUpdateComponent } from './components/pessoa/pessoa-update/pessoa-update.component';
import { PessoaCreateComponent } from './components/pessoa/pessoa-create/pessoa-create.component';
import { PessoaDeleteComponent } from './components/pessoa/pessoa-delete/pessoa-delete.component';

//salaTreinamento
import { SalaTreinamentoCrudComponent  } from './views/salatreinamento-crud/salaTreinamento-crud.component';
import { SalaTreinamentoCreateComponent  } from './components/salaTreinamento/salaTreinamento-create/salaTreinamento-create.component';
import { SalaTreinamentoDeleteComponent  } from './components/salaTreinamento/salaTreinamento-delete/salaTreinamento-delete.component';
import { SalaTreinamentoUpdateComponent  } from './components/salaTreinamento/salaTreinamento-update/salaTreinamento-update.component';

//salaCafe
import { SalaCafeCrudComponent } from './views/salaCafe-crud/salaCafe-crud.component';
import { SalaCafeCreateComponent  } from './components/salaCafe/salaCafe-create/salaCafe-create.component';
import { SalaCafeDeleteComponent  } from './components/salaCafe/salaCafe-delete/salaCafe-delete.component';
import { SalaCafeUpdateComponent  } from './components/salaCafe/salaCafe-update/salaCafe-update.component';

//etapa
import { EtapaCrudComponent } from './views/etapa-crud/etapa-crud.component';
import { EtapaCreateComponent  } from './components/etapa/etapa-create/etapa-create.component';
import { EtapaDeleteComponent  } from './components/etapa/etapa-delete/etapa-delete.component';
import { EtapaUpdateComponent  } from './components/etapa/etapa-update/etapa-update.component';

//horarioCafe
import { HorarioCafeCrudComponent } from './views/horarioCafe-crud/horarioCafe-crud.component';
import { HorarioCafeCreateComponent  } from './components/horarioCafe/horarioCafe-create/horarioCafe-create.component';
import { HorarioCafeDeleteComponent  } from './components/horarioCafe/horarioCafe-delete/horarioCafe-delete.component';
import { HorarioCafeUpdateComponent  } from './components/horarioCafe/horarioCafe-update/horarioCafe-update.component';

//treinamento
import { PessoaSalaTreinamentoCrudComponent } from './views/pessoaSalaTreinamento-crud/pessoaSalaTreinamento-crud.component';
import { PessoaSalaTreinamentoCreateComponent } from './components/pessoaSalaTreinamento/pessoaSalaTreinamento-create/pessoaSalaTreinamento-create.component';
import { PessoaSalaTreinamentoUpdateComponent } from './components/pessoaSalaTreinamento/pessoaSalaTreinamento-update/pessoaSalaTreinamento-update.component';
import { PessoaSalaTreinamentoDeleteComponent } from './components/pessoaSalaTreinamento/pessoaSalaTreinamento-delete/pessoaSalaTreinamento-delete.component';

import { PessoaSalaTreinamentoPesquisaComponent } from './views/pesquisas/pessoaSalaTreinamentoPesquisa/pessoaSalaTreinamentoPesquisa.component';
import { PessoaSalaTreinamentoResultadoPesquisaComponent } from './components/pesquisa/pessoaSalaTreinamentoResultadoPesquisa/pessoaSalaTreinamentoResultadoPesquisa.component';
import { PessoaSalaTreinamentoResultadoPesquisaSalaTreinamentoComponent } from './components/pesquisa/pessoaSalaTreinamentoResultadoPesquisa-salaTreinamento/pessoaSalaTreinamentoResultadoPesquisa-salaTreinamento.component';
import { PessoaSalaTreinamentoResultadoPesquisaSalaCafeComponent } from './components/pesquisa/pessoaSalaTreinamentoResultadoPesquisa-salaCafe/pessoaSalaTreinamentoResultadoPesquisa-salaCafe.component';


const routes: Routes = [
  { path: '', component: HomeComponent },

  //Pessoa
  {path: 'pessoas', component: PessoaCrudComponent},
  {path: 'pessoas/create', component: PessoaCreateComponent},
  {path: 'pessoas/update/:id', component: PessoaUpdateComponent},
  {path: 'pessoas/delete/:id', component: PessoaDeleteComponent},

  //salaTreinamento
  {path: 'salasTreinamento', component: SalaTreinamentoCrudComponent},
  {path: 'salasTreinamento/create', component: SalaTreinamentoCreateComponent},
  {path: 'salasTreinamento/update/:id', component: SalaTreinamentoUpdateComponent},
  {path: 'salasTreinamento/delete/:id', component: SalaTreinamentoDeleteComponent},

  //salaCafe
  {path: 'salasCafe', component: SalaCafeCrudComponent},
  {path: 'salasCafe/create', component: SalaCafeCreateComponent},
  {path: 'salasCafe/update/:id', component: SalaCafeUpdateComponent},
  {path: 'salasCafe/delete/:id', component: SalaCafeDeleteComponent},

  //etapa
  {path: 'etapas', component: EtapaCrudComponent},
  {path: 'etapas/create', component: EtapaCreateComponent},
  {path: 'etapas/update/:id', component: EtapaUpdateComponent},
  {path: 'etapas/delete/:id', component: EtapaDeleteComponent},

  //horarioCafe
  {path: 'horariosCafe', component: HorarioCafeCrudComponent},
  {path: 'horariosCafe/create', component: HorarioCafeCreateComponent},
  {path: 'horariosCafe/update/:id', component: HorarioCafeUpdateComponent},
  {path: 'horariosCafe/delete/:id', component: HorarioCafeDeleteComponent},

  //treinamento
  {path: 'pessoasSalaTreinamento', component: PessoaSalaTreinamentoCrudComponent},
  {path: 'pessoasSalaTreinamento/create', component: PessoaSalaTreinamentoCreateComponent},
  {path: 'pessoasSalaTreinamento/update/:id', component: PessoaSalaTreinamentoUpdateComponent},
  {path: 'pessoasSalaTreinamento/delete/:id', component: PessoaSalaTreinamentoDeleteComponent},

  //pesquisas
  {path: 'pesquisaPessoas', component: PessoaSalaTreinamentoPesquisaComponent},
  {path: 'pesquisaPessoasResultado/:id', component: PessoaSalaTreinamentoResultadoPesquisaComponent},
  {path: 'pesquisaSalaTreinamentoResultado/:id', component: PessoaSalaTreinamentoResultadoPesquisaSalaTreinamentoComponent},
  {path: 'pesquisaSalaCafeResultado/:id', component: PessoaSalaTreinamentoResultadoPesquisaSalaCafeComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

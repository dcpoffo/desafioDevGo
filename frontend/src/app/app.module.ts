import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatCardModule } from '@angular/material/card';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { MatTableModule } from '@angular/material/table';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule, MAT_DATE_LOCALE } from '@angular/material/core';

import { HomeComponent } from './views/home/home.component';
import { HeaderComponent } from './components/template/header/header.component';
import { FooterComponent } from './components/template/footer/footer.component';
import { NavComponent } from './components/template/nav/nav.component';

//Pessoas
import { PessoaCrudComponent  } from './views/pessoa-crud/pessoa-crud.component';
import { PessoaReadComponent  } from './components/pessoa/pessoa-read/pessoa-read.component';
import { PessoaCreateComponent  } from './components/pessoa/pessoa-create/pessoa-create.component';
import { PessoaDeleteComponent  } from './components/pessoa/pessoa-delete/pessoa-delete.component';
import { PessoaUpdateComponent  } from './components/pessoa/pessoa-update/pessoa-update.component';

//salaTreinamento
import { SalaTreinamentoCrudComponent  } from './views/salatreinamento-crud/salaTreinamento-crud.component';
import { SalaTreinamentoReadComponent  } from './components/salaTreinamento/salaTreinamento-read/salaTreinamento-read.component';
import { SalaTreinamentoCreateComponent  } from './components/salaTreinamento/salaTreinamento-create/salaTreinamento-create.component';
import { SalaTreinamentoDeleteComponent  } from './components/salaTreinamento/salaTreinamento-delete/salaTreinamento-delete.component';
import { SalaTreinamentoUpdateComponent  } from './components/salaTreinamento/salaTreinamento-update/salaTreinamento-update.component';

//salaCafe
import { SalaCafeCrudComponent  } from './views/salaCafe-crud/salaCafe-crud.component';
import { SalaCafeReadComponent  } from './components/salaCafe/salacafe-read/salaCafe-read.component';
import { SalaCafeCreateComponent  } from './components/salaCafe/salaCafe-create/salaCafe-create.component';
import { SalaCafeDeleteComponent  } from './components/salaCafe/salaCafe-delete/salaCafe-delete.component';
import { SalaCafeUpdateComponent  } from './components/salaCafe/salaCafe-update/salaCafe-update.component';

//etapa
import { EtapaCrudComponent } from './views/etapa-crud/etapa-crud.component';
import { EtapaReadComponent } from './components/etapa/etapa-read/etapa-read.component';
import { EtapaCreateComponent  } from './components/etapa/etapa-create/etapa-create.component';
import { EtapaDeleteComponent  } from './components/etapa/etapa-delete/etapa-delete.component';
import { EtapaUpdateComponent  } from './components/etapa/etapa-update/etapa-update.component';

//horarioCafe
import { HorarioCafeCrudComponent  } from './views/horarioCafe-crud/horarioCafe-crud.component';
import { HorarioCafeReadComponent  } from './components/horarioCafe/horarioCafe-read/horarioCafe-read.component';
import { HorarioCafeCreateComponent  } from './components/horarioCafe/horarioCafe-create/horarioCafe-create.component';
import { HorarioCafeDeleteComponent  } from './components/horarioCafe/horarioCafe-delete/horarioCafe-delete.component';
import { HorarioCafeUpdateComponent  } from './components/horarioCafe/horarioCafe-update/horarioCafe-update.component';

//treinamento
import { PessoaSalaTreinamentoCrudComponent } from './views/pessoaSalaTreinamento-crud/pessoaSalaTreinamento-crud.component';
import { PessoaSalaTreinamentoCreateComponent } from './components/pessoaSalaTreinamento/pessoaSalaTreinamento-create/pessoaSalaTreinamento-create.component';
import { PessoaSalaTreinamentoReadComponent } from './components/pessoaSalaTreinamento/pessoaSalaTreinamento-read/pessoaSalaTreinamento-read.component';
import { PessoaSalaTreinamentoUpdateComponent } from './components/pessoaSalaTreinamento/pessoaSalaTreinamento-update/pessoaSalaTreinamento-update.component';
import { PessoaSalaTreinamentoDeleteComponent } from './components/pessoaSalaTreinamento/pessoaSalaTreinamento-delete/pessoaSalaTreinamento-delete.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,
    PessoaReadComponent,
    PessoaCrudComponent,
    PessoaCreateComponent,
    PessoaDeleteComponent,
    PessoaUpdateComponent,
    SalaTreinamentoCrudComponent,
    SalaTreinamentoReadComponent,
    SalaTreinamentoCreateComponent,
    SalaTreinamentoDeleteComponent,
    SalaTreinamentoUpdateComponent,
    SalaCafeCrudComponent,
    SalaCafeReadComponent,
    SalaCafeCreateComponent,
    SalaCafeDeleteComponent,
    SalaCafeUpdateComponent,
    EtapaCrudComponent,
    EtapaReadComponent,
    EtapaCreateComponent,
    EtapaDeleteComponent,
    EtapaUpdateComponent,
    HorarioCafeCrudComponent,
    HorarioCafeReadComponent,
    HorarioCafeCreateComponent,
    HorarioCafeDeleteComponent,
    HorarioCafeUpdateComponent,
    PessoaSalaTreinamentoCrudComponent,
    PessoaSalaTreinamentoCreateComponent,
    PessoaSalaTreinamentoReadComponent,
    PessoaSalaTreinamentoUpdateComponent,
    PessoaSalaTreinamentoDeleteComponent,
  ],



  imports: [

    BrowserModule,

    AppRoutingModule,
    BrowserAnimationsModule,
    MatCardModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatSnackBarModule,
    MatTableModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatSelectModule,
    MatDatepickerModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatNativeDateModule
  ],
  providers: [
    MatFormFieldModule,
    MatDatepickerModule,
    { provide: MAT_DATE_LOCALE, useValue: 'pt-BR' }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/home/login/login.component';
import { UserComponent } from './components/user/user.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AngularMaterialModule } from './material.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HeaderComponent } from './components/home/header/header.component';

@NgModule({
  declarations: [AppComponent, LoginComponent, UserComponent, HeaderComponent],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    AngularMaterialModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}

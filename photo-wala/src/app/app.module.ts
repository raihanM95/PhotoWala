import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { AppLayoutComponent } from './_layout/app-layout/app-layout.component';
import { AppHeaderComponent } from './_layout/app-header/app-header.component';
import { FooterComponent } from './_layout/footer/footer.component';
import { HomeLayoutComponent } from './_layout/home-layout/home-layout.component';
import { HomeHeaderComponent } from './_layout/home-header/home-header.component';

import { FourzerofourComponent } from './fourzerofour/fourzerofour.component';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';


@NgModule({
  declarations: [
    AppComponent,

    AppLayoutComponent,
    AppHeaderComponent,
    FooterComponent,
    HomeLayoutComponent,
    HomeHeaderComponent,
    
    FourzerofourComponent,
    
    HomeComponent,
    AboutComponent,
    ContactComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

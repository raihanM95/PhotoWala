import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { AppLayoutComponent } from './_layout/app-layout/app-layout.component';
import { AppHeaderComponent } from './_layout/app-header/app-header.component';
import { FooterComponent } from './_layout/footer/footer.component';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';

@NgModule({
  declarations: [
    AppComponent,

    AppLayoutComponent,
    AppHeaderComponent,
    FooterComponent,
    
    HomeComponent,
    AboutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FrontRoutingModule } from './front-routing.module';

import { AppLayoutComponent } from './_layout/app-layout/app-layout.component';
import { AppHeaderComponent } from './_layout/app-header/app-header.component';
import { FooterComponent } from './_layout/footer/footer.component';
import { HomeLayoutComponent } from './_layout/home-layout/home-layout.component';
import { HomeHeaderComponent } from './_layout/home-header/home-header.component';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { PhotographersComponent } from './photographers/photographers.component';
import { GalleryComponent } from './gallery/gallery.component';


@NgModule({
  declarations: [
    AppLayoutComponent, 
    AppHeaderComponent, 
    FooterComponent, 
    HomeLayoutComponent, 
    HomeHeaderComponent, 

    HomeComponent, 
    AboutComponent, 
    ContactComponent, 
    PhotographersComponent, 
    GalleryComponent, 
    
  ],

  imports: [
    CommonModule,
    FrontRoutingModule
  ]
})
export class FrontModule { }

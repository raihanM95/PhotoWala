import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AppLayoutComponent } from './_layout/app-layout/app-layout.component';
import { HomeLayoutComponent } from './_layout/home-layout/home-layout.component';

import { FourzerofourComponent } from './fourzerofour/fourzerofour.component';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { PhotographersComponent } from './photographers/photographers.component';
import { GalleryComponent } from './gallery/gallery.component';

const routes: Routes = [
  // site with layout routes
  { 
    path: '', 
    component: HomeLayoutComponent,
    children: [
      { path: '', component: HomeComponent, pathMatch: 'full'}
    ]
  },

  // site with layout routes
  { 
    path: '', 
    component: AppLayoutComponent,
    children: [
      { path: 'about', component: AboutComponent },
      { path: 'contact', component: ContactComponent },
      { path: 'photographers', component: PhotographersComponent },
      { path: 'gallery', component: GalleryComponent },
    ]
  },
  
  // otherwise redirect to home
  { path: '**', component: FourzerofourComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

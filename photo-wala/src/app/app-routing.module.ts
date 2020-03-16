import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AppLayoutComponent } from './_layout/app-layout/app-layout.component';
import { HomeLayoutComponent } from './_layout/home-layout/home-layout.component';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';

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
      
    ]
  },
  
  // otherwise redirect to home
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


import { AppLayoutComponent } from './_layout/app-layout/app-layout.component';

const routes: Routes = [
  // site with layout routes
  { 
    path: '', 
    component: AppLayoutComponent,
    children: [
      
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

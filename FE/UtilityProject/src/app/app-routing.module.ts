import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UsersListComponent } from './features/users/users-list/users-list.component';
import { AddUserComponent } from './features/users/add-user/add-user.component';

const routes: Routes = [
  {
    path : 'admin/user',
    component : UsersListComponent
  },
  {
    path:'admin/user/add',
    component : AddUserComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

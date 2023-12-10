import { Component, OnDestroy } from '@angular/core';
import { AddUserRequest } from '../models/add-user-request.model';
import { UserService } from '../services/user.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrl: './add-user.component.css'
})
export class AddUserComponent implements OnDestroy{
  
  model:AddUserRequest;
  private addUserSubscription?:Subscription

  constructor(private userService:UserService){
    this.model={
      name:'',
      email:''
    }
  }
  

  onFormSubmit(){
    this.addUserSubscription = this.userService.addUser(this.model)
    .subscribe({
      next:(response)=>{
        console.log('Successful');
      }
    })
  }

  ngOnDestroy(): void {
    this.addUserSubscription?.unsubscribe();
  }
}

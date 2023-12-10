import { Injectable } from '@angular/core';
import { AddUserRequest } from '../models/add-user-request.model';
import { Observable } from 'rxjs';
import { HttpBackend, HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http:HttpClient) { }

  addUser(model:AddUserRequest) : Observable<void>{
    return this.http.post<void>(`https://localhost:7140/api/User`,model);
  }
}

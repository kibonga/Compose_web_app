import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from './User';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Docker.Frontend_app';
  userForm: FormGroup;
  users: User[] = [];

  constructor(private http: HttpClient, private formBuilder: FormBuilder) {
    this.userForm = this.formBuilder.group({
      name: ['', Validators.required],
      job: ['', Validators.required],
      age: [null, [Validators.required, Validators.min(18)]]
    });
  }

  ngOnInit() {
    this.fetchUsers();
  }

  public fetchUsers() {
     this.http.get<User[]>("http://localhost:5000/api/Users").subscribe(data => {
      this.users = data;
    })
  }
  
  public onSubmit() {
    if (this.userForm.valid) {
      const user: User = this.userForm.value;
      this.userForm.reset();
      this.http.post<User>("http://localhost:5000/api/Users", user).subscribe(() => {
        this.fetchUsers(); 
      })
    }
  }

  public onSeed() {
    this.http.get("http://localhost:5000/api/Seed").subscribe(() => {
      this.fetchUsers();
    });
  }
}

import { Component, OnInit } from '@angular/core';
import { User } from '../Shared/user.model';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.scss']
})
export class SignUpComponent implements OnInit {
  emailPattern = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
  user: User;

  constructor() { }

  ngOnInit(): void {
  }

}

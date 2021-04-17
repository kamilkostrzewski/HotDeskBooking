import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  login = new FormGroup({
    login: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required)
  });

  register = new FormGroup({
    login: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required),
    repeatPassword: new FormControl('', Validators.required),
    firstName: new FormControl('', Validators.required),
    lastName: new FormControl('', Validators.required),
  });

  constructor() { }

  getError(errorType: string): string {
    switch (errorType) {
      case 'login':
        return 'Login is required';

      case 'password':
        return 'Password is required';

      case 'firstName':
        return 'First name is required';

      case 'lastName':
        return 'Last name is required';

      default:
        return 'ErrorType is not recognized';
    }
  }

}

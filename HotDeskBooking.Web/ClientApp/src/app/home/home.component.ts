import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  form = new FormGroup({
    login: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required)
  });

  constructor() { }

  ngOnInit(): void {
  }

  getError(errorType: string): string {
    switch (errorType) {
      case 'login':
        return 'Login is required';

      case 'password':
        return 'Password is required';

      default:
        return 'ErrorType is not recognized';
    }
  }

}

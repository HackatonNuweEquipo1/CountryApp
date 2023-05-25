import { Component, OnInit } from '@angular/core';
import Swal from 'sweetalert2/dist/sweetalert2.js';

 
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  name = 'Angular';

  ngOnInit() {
    console.log('Hey');
  }

  loginForm() {
    Swal.fire({
      title: 'Country Login Form',
      html: `<input type="text" id="login" class="swal2-input" placeholder="Username">
    <input type="password" id="password" class="swal2-input" placeholder="Password">`,
      confirmButtonText: 'Sign in',
      focusConfirm: false,
      preConfirm: () => {
        const login = Swal.getPopup().querySelector('#login').value
        const password = Swal.getPopup().querySelector('#password').value
        if (!login || !password) {
          Swal.showValidationMessage(`Please enter login and password`)
        }
        return { login: login, password: password }
      }
    }).then((result) => {
      Swal.fire(`
      Login: ${result.value.login}
      Password: ${result.value.password}
    `.trim())
    })
  }
}

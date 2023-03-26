import { Component, OnInit } from '@angular/core';
import { PrimeNGConfig } from 'primeng/api';
import { AuthService } from './shared/Services/auth.service';
import { Router } from '@angular/router';
import { LOGIN_URL } from './shared/Constants/urls.const';

@Component({
  selector: 'app-root',
  template: `
    <router-outlet></router-outlet>
  `,
})
export class AppComponent implements OnInit {
  
  constructor(private primengConfig: PrimeNGConfig, private authService: AuthService, private router: Router) {

   }

  ngOnInit() {
      this.primengConfig.ripple = true;
      if(this.authService.isAuthenticated() == false) {
        this.router.navigate([LOGIN_URL])
      }
  }
}

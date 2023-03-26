import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginRequestDto } from '../Models/login.request.dto';
import { LoginResponseDto } from '../Models/login.response.dto';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { ACCES_TOKEN, REFRESH_TOKEN } from '../Constants/keys.const';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private httpClient: HttpClient) { }

  public isAuthenticated(): boolean {
    return localStorage.getItem(ACCES_TOKEN) != null;
  }

  public logout(){
    localStorage.removeItem(ACCES_TOKEN);
    localStorage.removeItem(REFRESH_TOKEN);
  }

  public login(input: LoginRequestDto): Observable<LoginResponseDto> {
    var body = {
      username: input.username,
      password: input.password,
      client_id: environment.oAuthConfig.clientId,
      client_secret: environment.oAuthConfig.dummyClientSecret,
      grant_type: 'password',
      scope: environment.oAuthConfig.scope
    };

    const data = Object.keys(body).map((key, index) => `${key}=${encodeURIComponent(body[key])}`).join('&');
    return this.httpClient.post<LoginResponseDto>(
      environment.oAuthConfig.issuer + 'connect/token',
      data,
      { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }
    );
  }
}
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Router, RouterStateSnapshot } from "@angular/router";
import {AutentifikacijaHelper} from "../_login-help/autentifikacija-helper";

@Injectable({
  providedIn: 'root'
})
export class AutorizacijaAdminUposlenikService {

  constructor(private router: Router) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot){

    try{
      if(AutentifikacijaHelper.getLoginInfo().isAdministrator || AutentifikacijaHelper.getLoginInfo().isRadnik){
        return true;
      }

    }
    catch(e) {

    }

    this.router.navigate(['forbidden'], {queryParams:{returnUrl: state.url}});
    return false;
  }
}

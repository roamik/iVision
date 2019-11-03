import { Component, OnInit } from '@angular/core';
import { User } from '../../_models/user';
import { AuthenticationService } from '../../_services/authentication.service';


@Component({
  selector: 'app-admin-layout',
  templateUrl: './admin-layout.component.html',
  styleUrls: ['./admin-layout.component.scss']
})
export class AdminLayoutComponent implements OnInit {
    currentUser: User;
    isLoggedIn: boolean = false;

    constructor(
        private authenticationService: AuthenticationService
    ) {
        this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
    }

    ngOnInit() {
        if (this.currentUser) {
            this.isLoggedIn = true;
        }
    }
}

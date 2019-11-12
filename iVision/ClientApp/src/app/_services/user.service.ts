import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from "../../environments/environment";

import { User } from '../_models/user';

@Injectable({ providedIn: 'root' })
export class UserService {
    readonly BASEURL: string;
    constructor(private http: HttpClient) { this.BASEURL = environment.baseApi;}

    getAll() {
        return this.http.get<User[]>(`${this.BASEURL}/users`);
    }

    register(user: User) {
        return this.http.post(`${this.BASEURL}/api/account/register`, user);
    }

    delete(id: number) {
        return this.http.delete(`${this.BASEURL}/users/${id}`);
    }
}

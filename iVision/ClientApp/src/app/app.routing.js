"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var admin_layout_component_1 = require("./layouts/admin-layout/admin-layout.component");
exports.AppRoutes = [
    {
        path: '',
        redirectTo: 'dashboard',
        pathMatch: 'full',
    }, {
        path: '',
        component: admin_layout_component_1.AdminLayoutComponent,
        children: [
            {
                path: '',
                loadChildren: './layouts/admin-layout/admin-layout.module#AdminLayoutModule'
            }
        ]
    },
    {
        path: '**',
        redirectTo: 'dashboard'
    }
];
//# sourceMappingURL=app.routing.js.map
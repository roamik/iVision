"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var dashboard_component_1 = require("../../pages/dashboard/dashboard.component");
var user_component_1 = require("../../pages/user/user.component");
var table_component_1 = require("../../pages/table/table.component");
var typography_component_1 = require("../../pages/typography/typography.component");
var icons_component_1 = require("../../pages/icons/icons.component");
var maps_component_1 = require("../../pages/maps/maps.component");
var notifications_component_1 = require("../../pages/notifications/notifications.component");
var upgrade_component_1 = require("../../pages/upgrade/upgrade.component");
var login_page_component_1 = require("../../pages/login-page/login-page.component");
var auth_guard_1 = require("../../_helpers/auth.guard");
var register_page_component_1 = require("../../pages/register-page/register-page.component");
exports.AdminLayoutRoutes = [
    { path: 'dashboard', component: dashboard_component_1.DashboardComponent, canActivate: [auth_guard_1.AuthGuard] },
    { path: 'user', component: user_component_1.UserComponent, canActivate: [auth_guard_1.AuthGuard] },
    { path: 'table', component: table_component_1.TableComponent, canActivate: [auth_guard_1.AuthGuard] },
    { path: 'typography', component: typography_component_1.TypographyComponent, canActivate: [auth_guard_1.AuthGuard] },
    { path: 'icons', component: icons_component_1.IconsComponent, canActivate: [auth_guard_1.AuthGuard] },
    { path: 'maps', component: maps_component_1.MapsComponent, canActivate: [auth_guard_1.AuthGuard] },
    { path: 'notifications', component: notifications_component_1.NotificationsComponent, canActivate: [auth_guard_1.AuthGuard] },
    { path: 'upgrade', component: upgrade_component_1.UpgradeComponent, canActivate: [auth_guard_1.AuthGuard] },
    { path: 'login', component: login_page_component_1.LoginPageComponent },
    { path: 'register', component: register_page_component_1.RegisterPageComponent }
];
//# sourceMappingURL=admin-layout.routing.js.map

var app = angular.module('AngularAuthApp', ['ngRoute', 'LocalStorageModule', 'angular-loading-bar']);

app.config(function ($routeProvider) {

    $routeProvider.when("/home", {
        controller: "homeController",
        templateUrl: "/app/views/home.html"
    });

    $routeProvider.when("/login", {
        controller: "loginController",
        templateUrl: "/app/views/login.html"
    });

    $routeProvider.when("/signup", {
        controller: "signupController",
        templateUrl: "/app/views/signup.html"
    });

    $routeProvider.when("/orders", {
        controller: "ordersController",
        templateUrl: "/app/views/orders.html"
    });

    $routeProvider.when("/refresh", {
        controller: "refreshController",
        templateUrl: "/app/views/refresh.html"
    });

    $routeProvider.when("/tokens", {
        controller: "tokensManagerController",
        templateUrl: "/app/views/tokens.html"
    });

    $routeProvider.when("/associate", {
        controller: "associateController",
        templateUrl: "/app/views/associate.html"
    });

    $routeProvider.when("/slotBookingsDetail", {
        controller: "bookingDetailController",
        templateUrl: "/app/views/slotBookingsDetail.html"
    });
    $routeProvider.when("/slotBookings", {
        controller: "bookingController",
        templateUrl: "/app/views/slotBookings.html"
    });
    $routeProvider.when("/slotBookingsDetail/:bookingId", {
        controller: "bookingDetailController",
        templateUrl: "/app/views/slotBookingsDetail.html"
    });
    $routeProvider.when("/message/:bookingId", {
        controller: "messageController",
        templateUrl: "/app/views/message.html"
    });
    $routeProvider.when("/receiptDelay/:bookingId", {
        controller: "receiptDelayController",
        templateUrl: "/app/views/receiptDelay.html"
    });
    $routeProvider.otherwise({ redirectTo: "/home" });

});
//var serviceBase = 'http://ngauthenticationapi.azurewebsites.net/';
var serviceBase = 'http://localhost:26264/';

app.constant('ngAuthSettings', {
    apiServiceBaseUri: serviceBase,
    clientId: 'ngAuthApp'
});

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);





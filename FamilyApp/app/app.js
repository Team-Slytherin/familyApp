var app = angular.module("FamilyApp", ["ngRoute"]);

app.config([
    "$routeProvider", function ($routeProvider) {
        $routeProvider
            .when("/",
                {
                    templateUrl: "app/Login/Login.html",
                    controller: "LoginController"
                })
            .when("/home",
                {
                    templateUrl: "app/Home/Home.html",
                    controller: "HomeController"
                })
            .when("/signup",
                {
                    templateUrl: "app/Register/Register.html",
                    controller: "RegisterController"
                });
    }
]);
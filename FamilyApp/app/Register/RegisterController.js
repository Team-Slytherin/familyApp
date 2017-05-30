app.controller("RegisterController", ["$scope", "$http", "$location", function ($scope, $http, $location) {
        $scope.username = "";
        $scope.email = "";
        $scope.password = "";
        $scope.passwordConfirm = "";

        $scope.registerNew = function () {
            $http({
                method: 'POST',
                url: "Account/Register",
                data: {
                    "Username": $scope.username,
                    "Email": $scope.email,
                    "Password": $scope.password,
                    "ConfirmPassword": $scope.passwordConfirm
                }
                })
                .then(function (result) {
                    console.log("result", result);
                    $location.path("/home");
                });
        }
    }
]);
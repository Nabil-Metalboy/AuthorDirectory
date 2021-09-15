var app = angular.module("storageModule", [
    "ngAnimate",
    "ngSanitize",
    "ui.bootstrap",
    "ngStorage"
]);
app.controller("storageController", function (
    $scope,
    $http,
    $localStorage,
    $window
) {
    $localStorage.data = [];
});

'use strict';


angular.module('frontierApp', ['ngResource']).
  config(['$routeProvider', '$locationProvider', function($routeProvider, $locationProvider) {
    $routeProvider.when('/register', {templateUrl: '/partials/editProfile.html', controller: EditProfileController});
    $routeProvider.when('/editProfile', {templateUrl: '/partials/editProfile.html', controller: EditProfileController});
    $routeProvider.when('/viewProfile/:userName', {templateUrl: '/partials/viewProfile.html', controller: ViewProfileController});
    $routeProvider.when('/login', {templateUrl: '/partials/login.html', controller: LoginController});
    $routeProvider.otherwise({redirectTo: '/events'});
    $locationProvider.html5Mode(true);
  }]);

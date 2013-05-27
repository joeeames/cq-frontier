'use strict';


angular.module('frontierApp', ['ngResource']).
  config(['$routeProvider', '$locationProvider', function($routeProvider, $locationProvider) {
    $routeProvider.when('/', {templateUrl: '/partials/home.html', controller: 'HomeCtrl'});
    $routeProvider.when('/town/new', {templateUrl: '/partials/Town/NewTown.html', controller: 'NewTownCtrl'});
//    $routeProvider.when('/viewProfile/:userName', {templateUrl: '/partials/viewProfile.html', controller: ViewProfileController});
//    $routeProvider.when('/login', {templateUrl: '/partials/login.html', controller: LoginController});
    $routeProvider.otherwise({redirectTo: '/'});
    $locationProvider.html5Mode(true);
  }]);

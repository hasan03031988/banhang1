/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);

myApp.directive("banHangDirective", banHangDirective);

myApp.service('ValidatorService', ValidatorService);

schoolController.$inject = ['$scope', 'ValidatorService'];

function schoolController($scope, ValidatorService) {
   
    $scope.checkNumber = function () {
        $scope.message = ValidatorService.checkNumber($scope.num);
    }
    $scope.num = 1;
}
function ValidatorService($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
          return 'this is even';
        }
        else
           return 'this is oldd';
    }
}
function banHangDirective() {
    return {
        restrict: "A",
        templateUrl : "/Scripts/spa/banHangDirective.html"
    }
}
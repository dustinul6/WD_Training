var app = angular.module('myApp', []);
//  建立一個 angular module, 
app.controller('myCtrl', ['$scope', function($scope){
    $scope.name = "Tzu-Yao";
    console.log("Hello, ", $scope.name);
var d = new Date();
$scope.date1 = new Date();
$scope.date1.setFullYear($scope.date1.getFullYear() +1);
console.log($scope.date1.getFullYear());
}])

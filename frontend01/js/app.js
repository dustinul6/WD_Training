/*global angular */
'use strict';

var app = angular.module('myApp', []);
//  建立一個 angular module, 

app.controller('myCtrl', ['$scope', '$http', function ($scope, $http) {
    $scope.name = "Tzu-Yao";
    
    $scope.newProduct = {
        Name: "",
        Description : "",
        Price: 0,
        BrandId : 0
    };
    
    console.log("Hello, ", $scope.name);
    
    $http.get("http://localhost:56490/odata/Products").then(
        //如果成功，執行
        function (result) {
            console.log("result is, ", result);
            $scope.products = result.data.value;
            console.log("products is, ", $scope.products);
        },
        // 如果失敗，執行
        function (error) {
            console.log(error);
        }
    );
    
    $http.get("http://localhost:56490/odata/Brands").then(
        //如果成功，執行
        function (result) {
            $scope.brands = result.data.value;
        },
        // 如果失敗，執行
        function (error) {
            console.log(error);
        }
    );
    // $scope.products = 
}]);

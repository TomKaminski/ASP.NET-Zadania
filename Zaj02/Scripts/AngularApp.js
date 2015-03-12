var App = angular.module("App", []);

App.controller("AppCtrl", [
    '$scope', '$http', function ($scope, $http) {
        $scope.newAuthorName = "kurwa";
        $scope.init = function() {
            $http.post('/Validation.aspx/ReturnData',{}).success(function (data) {
                $scope.data = data.d;                
            }).error(function (data, status, headers, config) {
                console.log(data);
            });
        }
        $scope.plz = function(newAuthorName) {
            var asd;
        };
    }
]);
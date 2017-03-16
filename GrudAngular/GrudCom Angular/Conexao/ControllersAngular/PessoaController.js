
        var app = angular.module("myApp", [])
        .controller("myCtrl", function ($scope, $http) {
            $scope.pessoaFisicas = [];
            $http.get("http://localhost:64640/PessoaFisica").success(function (data) {
                $scope.pessoaFisicas = data;
            }).
                error(function(data, status, readers, config) {

                });

            $scope.AddPessoaFisica = function(aPessoaFisica) {
                $http({
                    traditional: true,
                    method: "Post",
                    data: JSON.stringify(aPessoaFisica),
                    dataType: "json"
                }).success(function (data) {
                    $scope.pessoaFisicas.push(angular.copy(aPessoaFisica));
                    delete $scope.aPessoaFisica;
                }).error(function (data) {

                });
            };
            

            $scope.enderecos = [];
            $http.get('@Url.Action("GetEndereco", "Endereco")').success(function (data) {
                $scope.enderecos = data;
            }).
                error(function (data, status, readers, confg) {
                });

            $scope.AddEndereco = function (aEndereco) {
                $http({
                    traditional: true,
                    url: '@Url.Action("Create", "Endereco")',
                    method: "Post",
                    data: JSON.stringify(aEndereco),
                    dataType: "json"
                }).success(function (data) {
                    $scope.enderecos.push(angular.copy(aEndereco));
                    delete $scope.aEndereco;
                }).error(function (data) {

                });
            };

        });
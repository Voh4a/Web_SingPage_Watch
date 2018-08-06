var app = angular.module('WatchesApp', []);

app.controller("SubscribeCtrl", function ($scope, $http) {
    $scope.subscribe = function (email) {

        alert("Email is " + $scope.email);
        $http.post("/api/subscribe/" + $scope.email);
       // $http.post('/api/subscribe', { params: { email: $scope.email } });
    };
});

app.controller("BodyCtrl", function ($scope, $http) {
    $scope.search = "";
    $scope.order = "";

    $scope.Watches = [];

    function fulfilled(response) {
        console.log(response);
        $scope.Watches = response.data;
    };

    function rejected(error) {
        console.log("Error");
        console.log(error);
    };

    var promice = $http.get("/api/watch");
    promice.then(fulfilled, rejected);

    $scope.FilterbyName = function (item) {
        if (item.name.toLowerCase().match($scope.search.toLowerCase()) !== null) {
            return true;
        }
        else return false;
    };

    function AscOrder(a, b) {
        if (a.price > b.price) return 1;
        if (a.price < b.price) return -1;
    }

    function DescOrder(a, b) {
        if (a.price > b.price) return -1;
        if (a.price < b.price) return 1;
    }

    function ABCOrder(a, b) {
        if (a.name > b.name) return 1;
        if (a.name < b.name) return -1;
    }

    function ASB_DescOrder(a, b) {
        if (a.name > b.name) return -1;
        if (a.name < b.name) return 1;
    }

    $scope.Order = function (order) {
        if (order === "asc") {
            $scope.Watches.sort(AscOrder);
        }
        if (order === "desc") {
            $scope.Watches.sort(DescOrder);
        }
        if (order === "ABC") {
            $scope.Watches.sort(ABCOrder);
        }
        if (order === "descABC") {
            $scope.Watches.sort(ASB_DescOrder);
        }
    };

    $scope.openModal = function (watch) {
        $('#exampleModalCenter').modal('show');
        $scope.watch = watch;
    };
});
var app = angular.module('WatchesApp', []);

app.controller("SubscribeCtrl", function ($scope) {
    $scope.subscribe = function (email,) {
        
        alert("Email is " + email);
        //Написати добавлення емейлу в базу
    }
});

app.controller("BodyCtrl", function ($scope) {
    $scope.dropdown = true;
    $scope.search = "";

    $scope.Watches = [{ image: "../Content/WatchesImage/HamiltonH76512733.jpg", name: "Hamilton H76512733", price: 16900, text: "Виробник: Швейцарія / механізм: кварцовий / стікло: сапфіровое / тип індикації: стрілковий / корпус: сталь / водонепроникність: 100 м / ремінь: шкіряний / тип: чоловічі" },
        { image: "../Content/WatchesImage/HamiltonH82305931.jpg", name: "Hamilton H82305931", price: 21850, text: "Виробник: Швейцария / механізм: механічний з автоподзаводом / стікло: сапфіровое / тип індикацхї: стрілковий / корпус: сталь / водонепроникність: 100 м / ремінь: тканинний / тип: чоловічі" },
        { image: "../Content/WatchesImage/Atlantic50744.41.21.jpg", name: "Atlantic 50744.41.21", price: 15370, text: "Виробник: Швейцарія / тип: чоловічі / механізм: механічний с автоподзаводом / стікло: сапфіровое / тип індикацхї: стрілковий / корпус: сталь / водонепроникність: 50 м / ремінь: шкіряний"}];

    $scope.ShowDropdown = function () {
        $scope.dropdown = false;
    }

    $scope.FilterbyName = function (item) {
        if (item.name.toLowerCase().match($scope.search.toLowerCase()) !== null) {
            return true;
        }
        else { return false; }
    }
});
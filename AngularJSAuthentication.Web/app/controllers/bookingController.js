'use strict';
app.controller('bookingController', ['$scope', '$location', 'bookingService', 'authService', '$filter', function ($scope, $location, bookingService, authService, $filter) {

    $scope.booking = [];
    $scope.getIframeSrc = function (bookingsId) {
        return '#/slotBookingsDetail/' + bookingsId;
    };

    //$scope.selectBooking = function () {

    $scope.username = authService.authentication.userName;
    var uname = authService.authentication.userName;
    //    $location.path('/slotBookingsDetail');

    //    },
    //     function (err) {
    //         $scope.message = err.error_description;
    //     };
   
    bookingService.getbooking().then(function (results) {
        
       // $scope.booking1 = results.data;
        $scope.booking = $filter('filter')(results.data, { userId: uname });
       // $scope.booking = $filter('filter')($scope.booking1, $scope.booking1.userId, uname)[0];
    }, function (error) {
        //alert(error.data.message);
    });

}]);
'use strict';
app.controller('messageController', ['$scope', '$location', '$routeParams', 'bookingService', function ($scope, $location, $routeParams, bookingService) {

    $scope.savedSuccessfully = false;
    $scope.message = "";
    $scope.selctedBooking;
   

  
var bookingsId = $routeParams.bookingId;

    bookingService.getbookingDetail(bookingsId).then(function (results) {

        $scope.selctedBooking = results.data;

    }, function (error) {
        //alert(error.data.message);
    });
    $scope.message1 = {
        message1: "",
        bookingsId: bookingsId
    };

    $scope.msg = function () {


        bookingService.saveMessage($scope.message1).then(function (response) {

            $scope.savedSuccessfully = true;
            $scope.message = "Message successfully send !";
            $location.path('/slotBookings');

        },
         function (response) {
             var errors = [];
             for (var key in response.data.modelState) {
                 for (var i = 0; i < response.data.modelState[key].length; i++) {
                     errors.push(response.data.modelState[key][i]);
                 }
             }
             $scope.message = "Failed to send a Receipt Delay due to:" + errors.join(' ');
         });
    };
   

   

}]);
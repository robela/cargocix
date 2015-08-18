'use strict';
app.controller('receiptDelayController', ['$scope', '$location', '$routeParams', 'bookingService', function ($scope, $location,$routeParams, bookingService) {

    $scope.savedSuccessfully = false;
    $scope.message = "";
    $scope.reason = [];

    $scope.selctedBooking;

    var bookingsId = $routeParams.bookingId;

    bookingService.getbookingDetail(bookingsId).then(function (results) {

        $scope.selctedBooking = results.data;

    }, function (error) {
        //alert(error.data.message);
    });

    bookingService.getReason().then(function (results) {
        
        $scope.reason = results.data;

    }, function (error) {
        //alert(error.data.message);
    });
        $scope.receiptDelay = {

            bookingsId: bookingsId,
            reasonId: "",
            newArrivalTime: "",
            textMsg:""
        

       
        };

    $scope.Delay = function () {

        bookingService.saveReceiptDelay($scope.receiptDelay).then(function (response) {

            $scope.savedSuccessfully = true;
            $scope.message = "Receipt Delay sent  successfully !";
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
'use strict';
app.controller('bookingDetailController', ['$scope', '$routeParams', 'bookingService', function ($scope, $routeParams, bookingService) {

    $scope.selctedBooking;
    var bookingsId = $routeParams.bookingId;

    $scope.getIframeSrcDelay = function () {
        return '#/receiptDelay/' + bookingsId;
    };
    $scope.getIframeSrcMessage = function () {
        return '#/message/' + bookingsId;
    };
    
    bookingService.getbookingDetail(bookingsId).then(function (results) {

        $scope.selctedBooking = results.data;
       
    }, function (error) {
        //alert(error.data.message);
    });

}]);
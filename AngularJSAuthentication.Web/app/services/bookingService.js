'use strict';
app.factory('bookingService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = 'http://cargoclix.somee.com/api/';

    var bookingServiceFactory = {};
 
    var _getbooking = function () {
        
        return $http.get(serviceBase + 'api/Booking').then(function (results) {
            return results;
        });
    };
    //var _getbooking = function (uname) {

    //    return $http.get(serviceBase + 'api/Booking/' +uname ).then(function (results) {
    //        return results;
    //    });
    //};
    var _getbookingDetail = function (id) {

        return $http.get(serviceBase + 'api/Booking/' +id).then(function (results) {
            return results;
        });
    };
    var _getreason = function () {

        return $http.get(serviceBase + 'api/Reason').then(function (results) {
            return results;
        });
    };
    var _saveOnMyWay = function (onMyWay) {

        

        return $http.post(serviceBase + 'api/OnMyWay/PostOnMyWay', onMyWay).then(function (response) {
            return response;
        });

    };

    var _saveReceiptDelay  = function (receiptDelay) {

        

        return $http.post(serviceBase + 'api/ReceiptDelay/PostReceiptDelay', receiptDelay).then(function (response) {
            return response;
        });

    };
    var _saveMessage = function (message) {

        

        return $http.post(serviceBase + 'api/Message/PostMessage', message).then(function (response) {
            return response;
        });

    };
    bookingServiceFactory.getbooking = _getbooking;
    bookingServiceFactory.getbookingDetail = _getbookingDetail;
    bookingServiceFactory.saveMessage = _saveMessage; 
    bookingServiceFactory.saveReceiptDelay = _saveReceiptDelay;
    bookingServiceFactory.saveOnMyWay = _saveOnMyWay;
    bookingServiceFactory.getReason = _getreason;
    return bookingServiceFactory;

}]);
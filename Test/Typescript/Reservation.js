"use strict";
exports.__esModule = true;
exports.reservation = void 0;
var reservation = /** @class */ (function () {
    function reservation(restaurants, GuestNumbers, reservationDeliveryDateTime, customer, table) {
        this.Id = ++reservation.prevId;
        this.restaurant;
        this.GuestNumbers = GuestNumbers;
        this.reservationDateTime = new Date();
        this.reservationDeliveryDateTime = reservationDeliveryDateTime;
        this.customer = customer;
        this.table = table;
    }
    reservation.prevId = 0;
    return reservation;
}());
exports.reservation = reservation;

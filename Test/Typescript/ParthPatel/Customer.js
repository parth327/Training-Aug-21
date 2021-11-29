"use strict";
exports.__esModule = true;
exports.customer = void 0;
var customer = /** @class */ (function () {
    function customer(firstName, lastName, contactNumber, city) {
        this.Id = ++customer.prevId;
        this.firstName = firstName;
        this.lastName = lastName;
        this.contactNumber = contactNumber;
        this.city = city;
    }
    customer.prevId = 0;
    return customer;
}());
exports.customer = customer;

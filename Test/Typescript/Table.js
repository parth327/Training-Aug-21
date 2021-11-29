"use strict";
exports.__esModule = true;
exports.Table = void 0;
var Table = /** @class */ (function () {
    function Table(restaurant, capacity) {
        this.Id = ++Table.prevId;
        this.restaurant = restaurant;
        this.capacity = capacity;
        this.vacant = true;
        this.reserved = false;
    }
    Table.prevId = 0;
    return Table;
}());
exports.Table = Table;

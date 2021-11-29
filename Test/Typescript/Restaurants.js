"use strict";
exports.__esModule = true;
exports.restaurantsList = exports.Restaurant = void 0;
var Data_1 = require("./Data");
var Restaurant = /** @class */ (function () {
    function Restaurant(address, city, state, name, contactNumber) {
        this.tables = [];
        this.Id = ++Restaurant.prevId;
        this.address = address;
        this.city = city;
        this.state = state;
        this.name = name;
        this.contactNumber = contactNumber;
        restaurantsList.push(this);
    }
    Restaurant.prototype.setTables = function (Table) {
        this.tables.push(Table);
    };
    Restaurant.prevId = 0;
    return Restaurant;
}());
exports.Restaurant = Restaurant;
//list of restaurant
var restaurantsList = [];
exports.restaurantsList = restaurantsList;
//dummy restaurant creation
(0, Data_1.createRestaurants)('Near VyasWadi', 'Ahmedabad', 'Gujarat', 'A-One Restaurant', 9925349250);
(0, Data_1.createRestaurants)('New Mumbai', 'Mumbai', 'Maharashtra', 'Blue Diamond Restaurant', 9425199251);
(0, Data_1.createRestaurants)('Bhat Bazar', 'New Delhi', 'Delhi', 'Al Qutub Restaurant', 9925459252);
(0, Data_1.createRestaurants)('North Panvel', 'Mumbai', 'maharashtra', 'Legend Restaurant', 9925569254);
(0, Data_1.createRestaurants)('Revdi Bazar', 'new Delhi', 'Delhi', 'Prnam Restaurant', 9825599255);

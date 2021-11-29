"use strict";
exports.__esModule = true;
exports.addTable = exports.createRestaurants = void 0;
var Restaurants_1 = require("./Restaurants");
var Table_1 = require("./Table");
//function adds table to a restaurant instances
function addTable(restaurant, capacity, tableNumber) {
    for (var i = 0; i < tableNumber; i++) {
        restaurant.setTables(new Table_1.Table(restaurant, capacity));
    }
}
exports.addTable = addTable;
//function create restaurant instance
function createRestaurants(address, city, state, name, contactNumber) {
    var newRes = new Restaurants_1.Restaurant(address, city, state, name, contactNumber);
    addTable(newRes, 4, 6);
}
exports.createRestaurants = createRestaurants;

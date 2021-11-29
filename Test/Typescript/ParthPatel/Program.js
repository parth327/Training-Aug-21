"use strict";
exports.__esModule = true;
var Customer_1 = require("./Customer");
var Reservation_1 = require("./Reservation");
var Restaurants_1 = require("./Restaurants");
// Online table reservation in the restaurant for specific date and time. This will
// Provide the list of restaurants in the country so that the user can choose accordingly.
// Provide the list of tables available for online reservation at different dining rooms in the restaurant.
// Mention the number of guests that can be accommodated on the particular table.
// Accept the booking for tables.
// Online table reservations are done 6hrs in advance for the current date.
// Table reservation can be done up to one month in advance.
// Give a token number to the customer as an acknowledgement of booking.
//Welcome 
console.log('Welcome to the Online Restaurant reservation ');
//Customer 
console.log('hello Enter Your Name and Number');
var newcustomer = new Customer_1.customer('Parth', 'Patel', 8980970882, 'Ahmedabad');
console.log("Thank you ".concat(newcustomer.firstName));
//------------------------------------------------------------
//Provide the list of restaurants in the country so that the user can choose accordingly.
console.log("Hello ".concat(newcustomer.firstName, " these are the available restaurants in your current city"));
console.log(Restaurants_1.restaurantsList);
console.log(Restaurants_1.restaurantsList.filter(function (res) { return res.city == newcustomer.city; }));
//---------------------------------------------------------------
console.log('Enter restaurant id ');
//suppose user enter reastaraunt with id 1;
var resId = 1;
var preferedRes = Restaurants_1.restaurantsList.filter(function (res) { return res.Id == resId; })[0];
console.log("You have choose Restaurent ".concat(preferedRes.name, " which in ").concat(preferedRes.address, " in ").concat(preferedRes.city));
//table available
console.log("those are the available Tables at ".concat(preferedRes.name, " ").concat(preferedRes.tables));
console.log("".concat(preferedRes.name, " can accommodate ").concat(preferedRes.tables[0].capacity, " guest on each tables"));
//booking tables
//Online table reservations are done 6hrs in advance for the current date.
// Table reservation can be done up to one month in advance.
function makeResrvation(restaurants, GuestNumbers, reservationDeliveryDateTime, customer, table) {
    var UC = new Date();
    UC.setHours(UC.getHours() + 6);
    var LC = new Date();
    LC.setMonth(LC.getMonth() - 1);
    if (reservationDeliveryDateTime < UC && reservationDeliveryDateTime > LC) {
        var newReservation = new Reservation_1.reservation(preferedRes, 4, new Date('2021-11-29 20:30:00'), newcustomer, preferedRes.tables.find(function (t) { return t.Id == 2; }));
        console.log("".concat(newcustomer.firstName, " your requested has been granted and new Reservation has been reserved with reservation Id ").concat(newReservation.Id, " in ").concat(newReservation.restaurant.name, " at time ").concat(newReservation.reservationDeliveryDateTime));
    }
    else
        console.log('sorry u either hit UC or LC of time limit');
}
makeResrvation(preferedRes, 4, new Date('2021-11-29 20:30:00'), newcustomer, preferedRes.tables.find(function (t) { return t.Id == 2; }));
//Give a token number to the customer as an acknowledgement of booking.
var reservationListTokesn = new Map();

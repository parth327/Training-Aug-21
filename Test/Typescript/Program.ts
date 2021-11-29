import { customer } from './Customer';
import { createRestaurants } from './Data';
import { reservation } from './Reservation';
import {
  IRestaurant,
  Restaurant,
  restaurantsList,
} from './Restaurants';
import { Table } from './Table';


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

let newcustomer = new customer('Parth', 'Patel', 8980970882, 'Ahmedabad');

console.log(
  `Thank you ${newcustomer.firstName}`
);

//------------------------------------------------------------
//Provide the list of restaurants in the country so that the user can choose accordingly.

console.log(
  `Hello ${newcustomer.firstName} these are the available restaurants in your current city`
);

console.log(restaurantsList);

console.log(restaurantsList.filter((res) => res.city == newcustomer.city));

//---------------------------------------------------------------
console.log('Enter restaurant id ');

//suppose user enter reastaraunt with id 1;

let resId = 1;
let preferedRes = restaurantsList.filter((res) => res.Id == resId)[0];

console.log(
  `You have choose Restaurent ${preferedRes.name} which in ${preferedRes.address} in ${preferedRes.city}`
);

//table available
console.log(
  `those are the available Tables at ${preferedRes.name} ${preferedRes.tables}`
);


console.log(
    `${preferedRes.name} can accommodate ${preferedRes.tables[0].capacity} guest on each tables`
  );
  
  //booking tables
  function makeResrvation(
    restaurants: IRestaurant,
    GuestNumbers: number,
    reservationDeliveryDateTime: Date,
    customer: customer,
    table: Table
  ) {
    var UC = new Date();
    UC.setHours(UC.getHours() + 6);
  
    var LC = new Date();
    LC.setMonth(LC.getMonth() - 1);
  
    if (reservationDeliveryDateTime < UC && reservationDeliveryDateTime > LC) {
      let newReservation = new reservation(
        preferedRes,
        4,
        new Date('2021-11-29 20:30:00'),
        newcustomer,
        preferedRes.tables.find((t) => t.Id == 2)
      );
  
      console.log(
        `${newcustomer.firstName} your requested has been granted and new Reservation has been reserved with reservation Id ${newReservation.Id} in ${newReservation.restaurant.name} at time ${newReservation.reservationDeliveryDateTime}`
      );
    } else console.log('sorry u either hit UC or LC of time limit');
  }
  
  makeResrvation(
    preferedRes,
    4,
    new Date('2021-11-29 20:30:00'),
    newcustomer,
    preferedRes.tables.find((t) => t.Id == 2)
  );
  
  //Give a token number to the customer as an acknowledgement of booking.
  var reservationListTokesn = new Map<number, string>();
  
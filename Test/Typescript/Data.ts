import { Restaurant } from './Restaurants';
import { Table } from './Table';

function addTable(
  restaurant: Restaurant,
  capacity: number,
  tableNumber: number
) {
  for (var i = 0; i < tableNumber; i++) {
    restaurant.setTables(new Table(restaurant, capacity));
  }
}
function createRestaurants(
  address: string,
  city: string,
  state: string,
  name: string,
  contactNumber: number | string
) {
  var newRes = new Restaurant(address, city, state, name, contactNumber);
  addTable(newRes, 4, 6);
}

export { createRestaurants, addTable };

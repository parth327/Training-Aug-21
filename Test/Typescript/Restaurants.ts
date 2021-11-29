import { createRestaurants } from './Data';
import { Table } from './Table';

interface IRestaurant {
  Id: number;
  address: string;
  city: string;
  state: string;
  name: string;
  contactNumber: number | string;
  tables: Array<Table>;
  setTables(Table: Table): void;
}

class Restaurant implements IRestaurant {
  static prevId: number = 0;
  Id: number;
  address: string;
  city: string;
  state: string;
  name: string;
  contactNumber: number | string;
  tables: Array<Table> = [];

  constructor(
    address: string,
    city: string,
    state: string,
    name: string,
    contactNumber: number | string
  ) {
    this.Id = ++Restaurant.prevId;
    this.address = address;
    this.city = city;
    this.state = state;
    this.name = name;
    this.contactNumber = contactNumber;

    restaurantsList.push(this);
  }

  setTables(Table) {
    this.tables.push(Table);
  }
}

//list of restaurant
var restaurantsList: Array<IRestaurant> = [];

//dummy restaurant creation

createRestaurants(
  'Near VyasWadi',
  'Ahmedabad',
  'Gujarat',
  'A-One Restaurant',
  9925349250
);

createRestaurants(
  'New Mumbai',
  'Mumbai',
  'Maharashtra',
  'Blue Diamond Restaurant',
  9425199251
);

createRestaurants(
  'Bhat Bazar',
  'New Delhi',
  'Delhi',
  'Al Qutub Restaurant',
  9925459252
);

createRestaurants(
  'North Panvel',
  'Mumbai',
  'maharashtra',
  'Legend Restaurant',
  9925569254
);

createRestaurants(
  'Revdi Bazar',
  'new Delhi',
  'Delhi',
  'Prnam Restaurant',
  9825599255
);

export {IRestaurant, Restaurant, restaurantsList };

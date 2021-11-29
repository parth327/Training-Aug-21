import { customer } from './Customer';
import { Restaurant } from './Restaurants';
import { Table } from './Table';

interface IReservation {
  Id: number;
  restaurant: Restaurant;
  GuestNumbers: number;
  reservationDateTime: Date;
  reservationDeliveryDateTime: Date;
  customer: customer;
  table: Table;
}

class reservation implements IReservation {
  static prevId = 0;
  Id: number;
  restaurant: Restaurant;
  GuestNumbers: number;
  reservationDateTime: Date;
  reservationDeliveryDateTime: Date;
  customer: customer;
  table: Table;

  constructor(
    restaurants: Restaurant,
    GuestNumbers: number,
    reservationDeliveryDateTime: Date,
    customer: customer,
    table: Table
  ) {
    this.Id = ++reservation.prevId;
    this.restaurant;
    this.GuestNumbers = GuestNumbers;
    this.reservationDateTime = new Date();
    this.reservationDeliveryDateTime = reservationDeliveryDateTime;
    this.customer = customer;
    this.table = table;
  }
}

export { reservation };

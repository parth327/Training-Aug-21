// There is a retail shop which need to manage the inventory, 
// whenever some purchase is being made product quantity should be reduced, 
// if quantity is less than 5 reorder request should be raised.
// Design an interface and classes for the same.
var RetailInventory = /** @class */ (function () {
    function RetailInventory(quantity) {
        this.Stock = quantity;
        if (this.Stock < 5) {
            this.reOrder(50);
        }
    }
    RetailInventory.prototype.buy = function (quantity) {
        if (quantity > this.Stock) {
            console.log("Sorry we can't accept your order");
            if (quantity > 100) {
                this.reOrder(quantity);
            }
            else {
                this.reOrder(100);
            }
            return;
        }
        this.Stock = this.Stock - quantity;
        console.log("buy of ".concat(quantity, " unit"));
        if (this.Stock < 5) {
            this.reOrder(100);
        }
    };
    RetailInventory.prototype.reOrder = function (quantity) {
        //process of Reordering
        console.log("reorder of  ".concat(quantity, " unit placed"));
        //after Reordering
        this.Stock += quantity; //stock is equal to or more than quantity
        console.log("Inventory = ".concat(this.Stock));
    };
    return RetailInventory;
}());
var retailShop = new RetailInventory(100);
retailShop.buy(70);

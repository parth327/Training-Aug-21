// Functions
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//Arrow Function
// var getResult = (username: string, points: number): string => {  
//     return `${ username } scored ${ points } points!`;  
//   }
// let deck = {
//     suits: ["hearts", "spades", "clubs", "diamonds"],
//     cards: Array(52),
//     createCardPicker: function () {
//       // NOTE: the line below is now an arrow function, allowing us to capture 'this' right here
//       return () => {
//         let pickedCard = Math.floor(Math.random() * 52);
//         let pickedSuit = Math.floor(pickedCard / 13);
//         return { suit: this.suits[pickedSuit], card: pickedCard % 13 };
//       };
//     },
//   };
//   let cardPicker = deck.createCardPicker();
//   let pickedCard = cardPicker();
//   alert("card: " + pickedCard.card + " of " + pickedCard.suit);
//Handling this in Arrow Function
// function Book() {
//     this.publishDate = 2016;
//     setInterval(()=>{
//         console.log(this.publishDate);
//     },1000)
// } 
//Function Types
// function PublicationMessage(year:number):string{
//     return 'Date Published' + year;
// }
// let publishFunc : (someYear:number) => string;
// publishFunc = PublicationMessage;
// let message:string = publishFunc(2016);
// let myAdd: (x: number, y: number) => number = function (
//     x: number,
//     y: number
//   ): number {
//     return x + y;
//   };
//Optional Parameter
// function buildName(firstName: string, lastName?: string) {
//     if (lastName) return firstName + " " + lastName;
//     else return firstName;
//   } 
//   let result1 = buildName("Bob"); // works correctly now
//   //let result2 = buildName("Bob", "Adams", "Sr.");//Error
//   let result3 = buildName("Bob", "Adams"); // ah, just right
// function CreateCustomer(name:string,age?:number){}
// function GetBookTitle(title:string='The C'){};
//REST Parameter
// function GetBooksReadForCust(name:string, ...bookIDs:number[]){}
// let books = GetBooksReadForCust('Leigh',2,5);
// function buildName(firstName: string, ...restOfName: string[]) {
//     return firstName + " " + restOfName.join(" ");
//   }   
//   let buildNameFun: (fname: string, ...rest: string[]) => string = buildName;
//Function Overloads
// function add(a:string, b:string): string; 
// function add(a:number, b:number): number; 
// function add(a: any, b:any): any {  
//     return a + b;  
// }  
// console.log("Addition: " +add("Hello","Typescript"));   
// console.log("Addition: "+add(30, 20));
//Interface
// interface LabeledValue {
//     label: string;
//   }
//   function printLabel(labeledObj: LabeledValue) {
//     console.log(labeledObj.label);
//   }
//   let myObj = { size: 10, label: "Size 10 Object" };
//   printLabel(myObj);
//Duck Typing
//   interface Duck{
//       walk:()=> void;
//       swim:()=>void;
//       quack:()=>void;
//   }
//Defining an Interface
// interface Book{
//     id:number;
//     title:string;
//     author:string;
//     pages?:number;
//     markDamaged:(reason:string)=>void;
// }
//Interface for Function Types
// interface SearchFunc {
//     (source: string, subString: string): boolean;
//   }
// let mySearch: SearchFunc;
// mySearch = function (src, sub) {
//   let result = src.search(sub);
//   return result > -1;
// };
//Extending Interfaces
// interface Shape {
//     color: string;
//   }
//   interface PenStroke {
//     penWidth: number;
//   }
//   interface Square extends Shape, PenStroke {
//     sideLength: number;
//   }
//   let square = {} as Square;
//   square.color = "blue";
//   square.sideLength = 10;
//   square.penWidth = 5.0;
//Class Types
//   interface ClockConstructor {
//     new (hour: number, minute: number): ClockInterface;
//   }
//   interface ClockInterface {
//     tick(): void;
//   }
//   const Clock: ClockConstructor = class Clock implements ClockInterface {
//     constructor(h: number, m: number) {}
//     tick() {
//       console.log("beep beep");
//     }
//   };
//   let clock = new Clock(12, 17);
//   clock.tick();
//   enums
//   Numeric enums
// enum UserResponse {
//     No = 0,
//     Yes = 1,
//   }
//      function respond(recipient: string, message: UserResponse): void {
//     console.log("Queen");
//   }
//    respond("Princess Caroline", UserResponse.Yes);
// String Enums
// enum Direction {
//     Up = "UP",
//     Down = "DOWN",
//     Left = "LEFT",
//     Right = "RIGHT",
//   }
//Hetrogeneous Enums
// enum BooleanLikeHeterogeneousEnum {
//     No = 0,
//     Yes = "YES",
//   }
//Enums at runtime
// enum E {
//     X,
//     Y,
//     Z,
//   }   
// function f(obj: { X: number }) {
//     return obj.X;
// }
// f(E);
//Enums at Compile Time
// enum LogLevel {
//     ERROR,
//     WARN,
//     INFO,
//     DEBUG,
//   }
//   type LogLevelStrings = keyof typeof LogLevel;
//   function printImportant(key: LogLevelStrings, message: string) {
//     const num = LogLevel[key];
//     if (num <= LogLevel.WARN) {
//       console.log("Log level key is:", key);
//       console.log("Log level value is:", num);
//       console.log("Log level message is:", message);
//     }
//   }
//   printImportant("ERROR", "This is a message");
//   Union and Intersection Types
// union with Common Fields
//   interface Bird {
//     fly(): void;
//     layEggs(): void;
//   }
//   interface Fish {
//     swim(): void;
//     layEggs(): void;
//   }
//   declare function getSmallPet(): Fish | Bird;
//   let pet = getSmallPet();
////   Only Common in both 
//pet.layEggs();
//// not in only one
//// pet.swim();
// Disciminitings Unions
// type NetworkLoadingState = {
//     state: "loading";
//   };
//   type NetworkFailedState = {
//     state: "failed";
//     code: number;
//   };
//   type NetworkSuccessState = {
//     state: "success";
//     response: {
//       title: string;
//       duration: number;
//       summary: string;
//     };
//   };
//   // Create a type which represents only one of the above types
//   // but you aren't sure which it is yet.
//   type NetworkState =
//     | NetworkLoadingState
//     | NetworkFailedState
//     | NetworkSuccessState;
//     function logger(state: NetworkState): string {
//         switch (state.state) {
//             case "loading":
//               return "Downloading...";
//             case "failed":
//               // The type must be NetworkFailedState here,
//               // so accessing the `code` field is safe
//               return `Error ${state.code} downloading`;
//             case "success":
//               return `Downloaded ${state.response.title} - ${state.response.summary}`;
//           }
//         }
// Intersections Types
// interface ErrorHandling {
//     success: boolean;
//     error?: { message: string };
//   }  
//   interface ArtworksData {
//     artworks: { title: string }[];
//   }
//   interface ArtistsData {
//     artists: { name: string }[];
//   }
//      // These interfaces are composed to have
//   // consistent error handling, and their own data.
//   type ArtworksResponse = ArtworksData & ErrorHandling;
//   type ArtistsResponse = ArtistsData & ErrorHandling; 
//   const handleArtistsResponse = (response: ArtistsResponse) => {
//     if (response.error) {
//       console.error(response.error.message);
//       return;
//     }
// }
// Classes
// class Greeter {
//     greeting: string;
//     constructor(message: string) {
//       this.greeting = message;
//     }
//     greet() {
//       return "Hello, " + this.greeting;
//     }
//   }
//   let greeter = new Greeter("world");
//Inheritance
var Animal = /** @class */ (function () {
    function Animal() {
    }
    Animal.prototype.move = function (distanceInMeters) {
        if (distanceInMeters === void 0) { distanceInMeters = 0; }
        console.log("Animal moved ".concat(distanceInMeters, "m."));
    };
    return Animal;
}());
var Dog = /** @class */ (function (_super) {
    __extends(Dog, _super);
    function Dog() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Dog.prototype.bark = function () {
        console.log("Woof! Woof!");
    };
    return Dog;
}(Animal));
var dog = new Dog();
dog.bark();
dog.move(10);
dog.bark();

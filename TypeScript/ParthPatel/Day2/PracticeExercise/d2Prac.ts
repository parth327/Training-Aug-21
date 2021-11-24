//Classes
class Greeter {
    greeting: string;
    constructor(message: string) {
      this.greeting = message;
    }
    greet() {
      return "Hello, " + this.greeting;
    }
  }
  let greeter = new Greeter("world");

//Inheritance
  class Animal {
    move(distanceInMeters: number = 0) {
      console.log(`Animal moved ${distanceInMeters}m.`);
    }
  }
  class Dog extends Animal {
    bark() {
      console.log("Woof! Woof!");
    }
  }
  const dog = new Dog();
  dog.bark();
  dog.move(20);

//Private
class Animal {
    private name: string;
    constructor(theName: string) {
      this.name = theName;
    }
  }
  class Rhino extends Animal {
    constructor() {
      super("Rhino");
    }
  }
  class Employee {
    private name: string;
    constructor(theName: string) {
      this.name = theName;
    }
  }
  let animal = new Animal("Goat");
  let rhino = new Rhino();
  let employee = new Employee("Bob");
  animal = rhino;
  //Types have separate declarations of a private property 'name'.
  //Type 'Employee' is not assignable to type 'Animal'.
  //animal = employee;

//Protected
class Person {
    protected name: string;
    protected constructor(theName: string) {
      this.name = theName;
    }
  }
  class Employee extends Person {
    private department: string; 
    constructor(name: string, department: string) {
      super(name);
      this.department = department;
    }
    public getElevatorPitch() {
      return `Hello, my name is ${this.name} and I work in ${this.department}.`;
    }
  }
  let howard = new Employee("Howard", "Sales");
  let john = new Person("John");
//Constructor of class 'Person' is protected and only accessible within the class declaration.

//Functions
//Arrow Function
var getResult = (username: string, points: number): string => {  
    return `${ username } scored ${ points } points!`;  
  }

//Handling this in Arrow Function
function Book() {
    this.publishDate = 2016;
    setInterval(()=>{
        console.log(this.publishDate);
    },1000)
} 

//Function Types
let myAdd: (x: number, y: number) => number = function (
    x: number,
    y: number
  ): number {
    return x + y;
  };

//Optional Parameter
function buildName(firstName: string, lastName?: string) {
    if (lastName) return firstName + " " + lastName;
    else return firstName;
  } 
  let result1 = buildName("Bob"); // True
  //let result2 = buildName("Bob", "Adams", "Sr.");//Error
  let result3 = buildName("Bob", "Adams"); // True
  
//REST Parameter
function GetBooksReadForCust(name:string, ...bookIDs:number[]){}
let books = GetBooksReadForCust('Leigh',2,5);

//Function Overloads
function add(a:string, b:string): string; 
function add(a:number, b:number): number; 
function add(a: any, b:any): any {  
    return a + b;  
}  
console.log("Addition: " +add("Hello","Typescript"));   
console.log("Addition: "+add(30, 20));

//Interface
interface LabeledValue {
    label: string;
  }
  function printLabel(labeledObj: LabeledValue) {
    console.log(labeledObj.label);
  }
  let myObj = { size: 10, label: "Size 10 Object" };
  printLabel(myObj);

//Duck Typing
  interface Duck{
      walk:()=> void;
      swim:()=>void;
      quack:()=>void;
  }

//Defining an Interface
interface Book{
    id:number;
    title:string;
    author:string;
    pages?:number;
    markDamaged:(reason:string)=>void;
}

//Interface for Function Types
interface SearchFunc {
    (source: string, subString: string): boolean;
  }
let mySearch: SearchFunc;
mySearch = function (src, sub) {
  let result = src.search(sub);
  return result > -1;
};

//Extending Interfaces
interface Shape {
    color: string;
  }
  interface PenStroke {
    penWidth: number;
  }
  interface Square extends Shape, PenStroke {
    sideLength: number;
  }
  let square = {} as Square;
  square.color = "blue";
  square.sideLength = 10;
  square.penWidth = 5.0;

//  Enums
//  Numeric enums
enum UserResponse {
    No = 0,
    Yes = 1,
  }
     function respond(recipient: string, message: UserResponse): void {
    console.log("Queen");
  }
   respond("Princess Caroline", UserResponse.Yes);

//String Enums
enum Direction {
    Up = "UP",
    Down = "DOWN",
    Left = "LEFT",
    Right = "RIGHT",
  }

//Hetrogeneous Enums
enum BooleanLikeHeterogeneousEnum {
    No = 0,
    Yes = "YES",
  }

//  Union and Intersection Types
//union with Common Fields
  interface Bird {
    fly(): void;
    layEggs(): void;
  }
  interface Fish {
    swim(): void;
    layEggs(): void;
  }
  declare function getSmallPet(): Fish | Bird;
  let pet = getSmallPet();
//   Only Common in both 
pet.layEggs();
// not in only one
// pet.swim();//Error

//Intersections Types
interface ErrorHandling {
    success: boolean;
    error?: { message: string };
  }  
  interface ArtworksData {
    artworks: { title: string }[];
  }
  interface ArtistsData {
    artists: { name: string }[];
  }
  type ArtworksResponse = ArtworksData & ErrorHandling;
  type ArtistsResponse = ArtistsData & ErrorHandling; 
  const handleArtistsResponse = (response: ArtistsResponse) => {
    if (response.error) {
      console.error(response.error.message);
      return;
    }
}



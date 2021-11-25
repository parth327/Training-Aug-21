// Map
let map = new Map();
map.set(1,'Ram');
map.set(1,'Rahul');
map.set(true,'bool1');
map.set(2,'Ajay');

console.log("Value1=" +map.get(1));//Get Key
console.log("Value2= " + map.get('1') );//Get values   
console.log( "Key is Present= " +map.has(3) );//check if Entry no 3 has define the key or not   
console.log( "Size= " +map.size );//Check the size of map   
console.log( "Delete value= " +map.delete(1) );//Delete the entry by key
console.log( "New Size= " +map.size );  

//set
let studentEntries = new Set();  
   
studentEntries.add("John");  
studentEntries.add("Peter");  
studentEntries.add("Gayle");  
studentEntries.add("Kohli");   
studentEntries.add("Dhawan");//Add Values in the set
  
console.log(studentEntries);//Returns the Data Available in set   
   
console.log(studentEntries.has("Kohli"));//Check kohli is in the set or not        
console.log(studentEntries.has(10));
   
console.log(studentEntries.size);//Returns size of set    

console.log(studentEntries.delete("Dhawan"));//Delete value "Dhawan" from set      
   
studentEntries.clear();//Clear Whole set   
  
console.log(studentEntries);

//Date

let date: Date = new Date(2021, 4, 4, 17, 23, 42, 11);  
date.setDate(21);//Set the Date   
date.setMonth(21);//Set Month
date.setFullYear(2021);//
date.setHours(12);  
date.setMinutes(12);  
date.setSeconds(12);  
console.log("Year = " + date.getFullYear());  
console.log("Date = " + date.getDate());  
console.log("Month = " + date.getMonth());  
console.log("Day = " + date.getDay());  
console.log("Hours = " + date.getHours());  
console.log("Minutes = " + date.getMinutes());  
console.log("Seconds = " + date.getSeconds());  

